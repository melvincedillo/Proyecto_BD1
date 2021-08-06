using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Rentadora
{
    public partial class fmrClientes : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        private List<int> idmunicipios = new List<int>();
        private int idmunicipio;
        private int iddireccion;
        private int idcliente;

        public fmrClientes()
        {
            InitializeComponent();
        }


        private void fmrClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            cargarDepartamentos();
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void mostrarClientes() {
            oracle.Open();

            OracleCommand comando = new OracleCommand("rentadora.select_clientes", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvClientes.DataSource = table;
            oracle.Close();
            dgvClientes.Columns[5].Visible = false;
        }

        private void cargarDepartamentos() {
            try
            {
                oracle.Open();
                OracleCommand departamentos = new OracleCommand("select departamento from rentadora.departamento", oracle);
                OracleDataReader registro = departamentos.ExecuteReader();
                while (registro.Read())
                {
                    cbDepartamento.Items.Add(registro["departamento"].ToString());
                }
            }
            catch {
                MessageBox.Show("Error al cargar departamentos");
            }
            oracle.Close();
        }

        private void cargarMunicipios(int id) {
            try
            {
                oracle.Open();
                OracleCommand departamentos = new OracleCommand("select municipioid, municipio from rentadora.municipio where departamentoid =" + id, oracle);
                OracleDataReader registro = departamentos.ExecuteReader();
                while (registro.Read())
                {
                    cbMunicipio.Items.Add(registro["municipio"].ToString());
                    idmunicipios.Add(Int32.Parse(registro["municipioid"].ToString()));
                }
            }
            catch {
                MessageBox.Show("Error al cargar municipios");
            }
            oracle.Close();
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMunicipio.Items.Clear();
            cbMunicipio.Text = "";
            idmunicipios.Clear();
            int dep = cbDepartamento.SelectedIndex;
            cargarMunicipios(dep + 1);
        }

        private void add_cliente_Click(object sender, EventArgs e)
        {
            if(Variable.controltotal == true)
            {
                crearDireccion();
                mostrarClientes();
                limpiarForm();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFUCIENTES");
            }
        }

        private void limpiarForm()
        {
            cP_nombre.Text = "";
            cS_nombre.Text = "";
            cP_apellido.Text = "";
            cS_apellido.Text = "";
            cIdentidad.Text = "";
            cRtn.Text = "";
            cSexo.Text = "";
            tel1.Text = "";
            tel2.Text = "";
            tel3.Text = "";
            cbDepartamento.Text = "";
            cbMunicipio.Text = "";
            col_aldea.Text = "";
            casa.Text = "";
            calle.Text = "";
        }


        private void crearDireccion() {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_direccion", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idM", OracleType.Int32).Value = idmunicipio;
                comando.Parameters.Add("colonia", OracleType.VarChar).Value = col_aldea.Text;
                comando.Parameters.Add("callea", OracleType.VarChar).Value = calle.Text;
                comando.Parameters.Add("casaa", OracleType.Int32).Value = Convert.ToInt32(casa.Text);
                comando.Parameters.Add("iddir", OracleType.Int32).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                iddireccion = Convert.ToInt32(comando.Parameters["iddir"].Value);
                oracle.Close();

                crearCliente();
            } catch {
                oracle.Close();
                MessageBox.Show("Imposible crear cliente");
            }
        }

        private void crearCliente() {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("pn", OracleType.VarChar).Value = cP_nombre.Text;
                comando.Parameters.Add("sn", OracleType.VarChar).Value = cS_nombre.Text;
                comando.Parameters.Add("pa", OracleType.VarChar).Value = cP_apellido.Text;
                comando.Parameters.Add("sa", OracleType.VarChar).Value = cS_apellido.Text;
                comando.Parameters.Add("tid", OracleType.VarChar).Value = cIdentidad.Text;
                comando.Parameters.Add("rtn", OracleType.VarChar).Value = cRtn.Text;
                comando.Parameters.Add("sex", OracleType.VarChar).Value = cSexo.Text;
                comando.Parameters.Add("dir", OracleType.Int32).Value = iddireccion;
                comando.Parameters.Add("idC", OracleType.Int32).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                idcliente = Convert.ToInt32(comando.Parameters["idC"].Value);
                oracle.Close();

                insertarTelefono(tel1.Text, 1);
                insertarTelefono(tel2.Text, 2);
                insertarTelefono(tel3.Text, 3);
            } catch { 
                oracle.Close();
                MessageBox.Show("Imposible crear cliente");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
            iddireccion = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[5].Value);

            clid.Text = idcliente.ToString();
            drid.Text = iddireccion.ToString();
        }

        private void delete_cliente_Click(object sender, EventArgs e)
        {
            if(Variable.controltotal == true)
            {
                deleteCliente();
                idcliente = 0;
                iddireccion = 0;
                mostrarClientes();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void deleteCliente() {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.delete_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idC", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("idDir", OracleType.Int32).Value = iddireccion;
                comando.ExecuteNonQuery();
                oracle.Close();
            }
            catch {
                MessageBox.Show("Imposible eliminar");
            }
        }

        private void editar_cliente_Click(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                add_cliente.Visible = false;
                delete_cliente.Visible = false;
                editar_cliente.Visible = false;
                aceptar.Visible = true;
                cancelar.Visible = true;
                cargarClienteEditar();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            add_cliente.Visible = true;
            delete_cliente.Visible = true;
            editar_cliente.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
            limpiarForm();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            updateCliente();
            update_tel_cliente(tel1.Text, 1);
            update_tel_cliente(tel2.Text, 2);
            update_tel_cliente(tel3.Text, 3);
            limpiarForm();
            mostrarClientes();
            add_cliente.Visible = true;
            delete_cliente.Visible = true;
            editar_cliente.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void cargarClienteEditar() {
            oracle.Open();
            OracleCommand comando = new OracleCommand("Select * from rentadora.cliente where clienteid =" + idcliente, oracle);
            OracleDataReader registro = comando.ExecuteReader();
            registro.Read();
            cIdentidad.Text = registro["identidad"].ToString();
            cP_nombre.Text = registro["p_nombre"].ToString();
            cS_nombre.Text = registro["s_nombre"].ToString();
            cP_apellido.Text = registro["p_apellido"].ToString();
            cS_apellido.Text = registro["s_apellido"].ToString();
            cRtn.Text = registro["rtn"].ToString();
            cSexo.Text = registro["sexo"].ToString();

            OracleCommand comando2 = new OracleCommand("select dp.departamento, m.municipio, d.col_aldea, d.calle, d.casa from rentadora.direccion d join rentadora.municipio m on m.municipioid = d.municipioid join rentadora.departamento dp on dp.departamentoid = m.departamentoid where d.direccionid = " + iddireccion, oracle);
            OracleDataReader registro2 = comando2.ExecuteReader();
            registro2.Read();
            col_aldea.Text = registro2["col_aldea"].ToString();
            calle.Text = registro2["calle"].ToString();
            casa.Text = registro2["casa"].ToString();
            string dep = registro2["departamento"].ToString(); ;
            string muni = registro2["municipio"].ToString();

            OracleCommand comandoT1 = new OracleCommand("select * from rentadora.telefonoxcliente where pos = 1 and clienteid = " + idcliente, oracle);
            OracleDataReader registroT1 = comandoT1.ExecuteReader();
            registroT1.Read();
            tel1.Text = registroT1["telefono"].ToString();

            OracleCommand comandoT2 = new OracleCommand("select * from rentadora.telefonoxcliente where pos = 2 and clienteid = " + idcliente, oracle);
            OracleDataReader registroT2 = comandoT2.ExecuteReader();
            registroT2.Read();
            tel2.Text = registroT2["telefono"].ToString();

            OracleCommand comandoT3 = new OracleCommand("select * from rentadora.telefonoxcliente where pos = 3 and clienteid = " + idcliente, oracle);
            OracleDataReader registroT3 = comandoT3.ExecuteReader();
            registroT3.Read();
            tel3.Text = registroT3["telefono"].ToString();

            oracle.Close();
            cbDepartamento.Text = dep;
            cbMunicipio.Text = muni;
        }

        private void updateCliente() {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.update_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idC", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("pn", OracleType.VarChar).Value = cP_nombre.Text;
                comando.Parameters.Add("sn", OracleType.VarChar).Value = cS_nombre.Text;
                comando.Parameters.Add("pa", OracleType.VarChar).Value = cP_apellido.Text;
                comando.Parameters.Add("sa", OracleType.VarChar).Value = cS_apellido.Text;
                comando.Parameters.Add("tid", OracleType.VarChar).Value = cIdentidad.Text;
                comando.Parameters.Add("rtnC", OracleType.VarChar).Value = cRtn.Text;
                comando.Parameters.Add("sex", OracleType.VarChar).Value = cSexo.Text;
                comando.ExecuteNonQuery();


                OracleCommand direccion = new OracleCommand("rentadora.update_direccion", oracle);
                direccion.CommandType = System.Data.CommandType.StoredProcedure;
                direccion.Parameters.Add("idDir", OracleType.Int32).Value = iddireccion;
                direccion.Parameters.Add("idM", OracleType.Int32).Value = idmunicipio;
                direccion.Parameters.Add("colonia", OracleType.VarChar).Value = col_aldea.Text;
                direccion.Parameters.Add("cal", OracleType.VarChar).Value = calle.Text;
                direccion.Parameters.Add("cas", OracleType.Int32).Value = Convert.ToInt32(casa.Text);
                direccion.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Error al actualizar");
            }
            oracle.Close();
        }

        private void update_tel_cliente(string tel, int posT) {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.update_tel_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idC", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("tel", OracleType.VarChar).Value = tel;
                comando.Parameters.Add("posT", OracleType.VarChar).Value = posT;
                comando.ExecuteNonQuery();
            } catch {
                MessageBox.Show("Telefono ya existente");
            }
            oracle.Close();
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            idmunicipio = idmunicipios[cbMunicipio.SelectedIndex];
            mnid.Text = idmunicipio.ToString();
        }

        private void insertarTelefono(string telA, int pos)
        {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_tel_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idC", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("posT", OracleType.Int32).Value = pos;
                comando.Parameters.Add("tel", OracleType.VarChar).Value = telA;
                comando.ExecuteNonQuery();
            } 
            catch {
                MessageBox.Show("Fallo insertar telefono");
            }
            oracle.Close();
        }
    }
}
