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
            oracle.Open();
            OracleCommand departamentos = new OracleCommand("select departamento from departamento", oracle);
            OracleDataReader registro = departamentos.ExecuteReader();
            while (registro.Read()) {
                cbDepartamento.Items.Add(registro["departamento"].ToString());
            }
            oracle.Close();
        }

        private void cargarMunicipios(int id) {
            oracle.Open();
            OracleCommand departamentos = new OracleCommand("select municipioid, municipio from municipio where departamentoid =" + id, oracle);
            OracleDataReader registro = departamentos.ExecuteReader();
            while (registro.Read())
            {
                cbMunicipio.Items.Add(registro["municipio"].ToString());
                idmunicipios.Add(Int32.Parse(registro["municipioid"].ToString()));
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
            try
            {
                crearDireccion();
                crearCliente();
                mostrarClientes();
                limpiarForm();
            }
            catch { MessageBox.Show("Imposible crear cliente"); }
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
            cDireccion.Text = "";
            cbDepartamento.Text = "";
            cbMunicipio.Text = "";
        }


        private void crearDireccion() {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_direccion", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idM", OracleType.Int32).Value = idmunicipio;
                comando.Parameters.Add("dir", OracleType.VarChar).Value = cDireccion.Text;
                comando.Parameters.Add("iddir", OracleType.Int32).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                iddireccion = Convert.ToInt32(comando.Parameters["iddir"].Value);
                oracle.Close();
            } catch { }
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
                comando.ExecuteNonQuery();
                oracle.Close();

            } catch {}
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
            deleteCliente();
            idcliente = 0;
            iddireccion = 0;
            mostrarClientes();
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
            add_cliente.Visible = false;
            delete_cliente.Visible = false;
            editar_cliente.Visible = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
            cargarClienteEditar();
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

            OracleCommand comando2 = new OracleCommand("select dp.departamento, m.municipio, d.direccion from rentadora.direccion d join rentadora.municipio m on m.municipioid = d.municipioid join rentadora.departamento dp on dp.departamentoid = m.departamentoid where d.direccionid = " + iddireccion, oracle);
            OracleDataReader registro2 = comando2.ExecuteReader();
            registro2.Read();
            cDireccion.Text = registro2["direccion"].ToString();
            String temp1 = registro2["departamento"].ToString();
            String temp2 = registro2["municipio"].ToString();
            oracle.Close();

            cbDepartamento.Text = temp1;
            cbMunicipio.Text = temp2;
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
                direccion.Parameters.Add("dir", OracleType.VarChar).Value = cDireccion.Text;
                direccion.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Error al actualizar");
            }
            oracle.Close();
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            idmunicipio = idmunicipios[cbMunicipio.SelectedIndex];
            mnid.Text = idmunicipio.ToString();
        }

        private void mnid_Click(object sender, EventArgs e)
        {

        }
    }
}
