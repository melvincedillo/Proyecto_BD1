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
    public partial class fmrSolicitudes : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        private List<int> idmunicipios = new List<int>();
        private List<int> idSucursales = new List<int>();
        private List<int> idEmpleados = new List<int>();
        private int idempleado;
        private int idSucursal;
        private int idmunicipio;
        private int iddireccion;
        private int idcliente = 0;
        private float subtotal = 0;
        private float costo_renta = 0;
        private int idsolicitud = 0;
        bool cargarC = true;

        public fmrSolicitudes()
        {
            InitializeComponent();
        }

        private void fmrSolicitudes_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
            cargarSucursales();
            cargarEmpleados();
            mostrarSolicitudes();
            sSubtotal.Text = subtotal.ToString();
        }

        private void cargarDepartamentos()
        {
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
            catch
            {
                MessageBox.Show("Error al cargar departamentos");
            }
            oracle.Close();
        }

        private void cargarMunicipios(int id)
        {
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
            catch
            {
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

        private void cargarClienteEditar(string id)
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("Select * from rentadora.cliente where identidad =" + id, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                cIdentidad.Text = registro["identidad"].ToString();
                cP_nombre.Text = registro["p_nombre"].ToString();
                cS_nombre.Text = registro["s_nombre"].ToString();
                cP_apellido.Text = registro["p_apellido"].ToString();
                cS_apellido.Text = registro["s_apellido"].ToString();
                cRtn.Text = registro["rtn"].ToString();
                cSexo.Text = registro["sexo"].ToString();

                idcliente = Convert.ToInt32(registro["clienteid"]);
                iddireccion = Convert.ToInt32(registro["direccionid"]);

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
                bloquearCliente();
                cerrarCliente.Visible = true;
                cargarCliente.Visible = false;
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("Cliente no existente");
            }
        }

        private void bloquearCliente() {
            if (cargarC == false) { cargarC = true; }
            else { cargarC = false; }

            cP_nombre.Enabled = cargarC;
            cS_nombre.Enabled = cargarC;
            cP_apellido.Enabled = cargarC;
            cS_apellido.Enabled = cargarC;
            cIdentidad.Enabled = cargarC;
            cSexo.Enabled = cargarC;
            cRtn.Enabled = cargarC;
            tel1.Enabled = cargarC;
            tel2.Enabled = cargarC;
            tel3.Enabled = cargarC;
            cbDepartamento.Enabled = cargarC;
            cbMunicipio.Enabled = cargarC;
            col_aldea.Enabled = cargarC;
            calle.Enabled = cargarC;
            casa.Enabled = cargarC;
        }

        private void cargarCliente_Click(object sender, EventArgs e)
        {
            cargarClienteEditar(cIdentidad.Text);
        }

        private void cerrarCliente_Click(object sender, EventArgs e)
        {
            bloquearCliente();
            limpiarForm();
            idcliente = 0;
            cerrarCliente.Visible = false;
            cargarCliente.Visible = true;
        }

        private void limpiarForm()
        {
            cP_nombre.Text = ""; cS_nombre.Text = ""; cP_apellido.Text = ""; cS_apellido.Text = ""; cIdentidad.Text = "";
            cRtn.Text = ""; cSexo.Text = ""; tel1.Text = ""; tel2.Text = ""; tel3.Text = "";  cbDepartamento.Text = ""; 
            cbMunicipio.Text = ""; col_aldea.Text = ""; casa.Text = ""; calle.Text = "";
        }

        private void limpiarForm2()
        {
            limpiarForm();
            if (cargarC == false) { bloquearCliente(); }
            if (cerrarCliente.Visible == true) {
                cerrarCliente.Visible = false;
                cargarCliente.Visible = true;
            }
            if (cerrarCliente.Visible == false && cargarCliente.Visible == false) { cargarCliente.Visible = true; }
            vPlaca.Text = ""; vVersion.Text = ""; vColor.Text = ""; vCombustible.Text = ""; vCosto.Text = ""; vMarca.Text = ""; vModelo.Text = "";
            sInicio.Value = DateTime.Now; sFin.Value = DateTime.Now;
            sSubtotal.Text = "0"; cbSucursal.Text = ""; sEmpleado.Text = "";
            idcliente = 0; costo_renta = 0; subtotal = 0; Variable.idSelectAuto = 0;
        }

        private void crearDireccion()
        {
            try
            {
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
            }
            catch
            {
                MessageBox.Show("Imposible crear direccion");
            }
            oracle.Close();
        }

        private void crearCliente()
        {
            try
            {
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
            }
            catch { oracle.Close(); }
        }

        private void insertarTelefono(string telA, int pos)
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_tel_cliente", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idC", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("posT", OracleType.Int32).Value = pos;
                comando.Parameters.Add("tel", OracleType.VarChar).Value = telA;
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Fallo insertar telefono");
            }
            oracle.Close();
        }

        private void add_soli_Click(object sender, EventArgs e)
        {
            if (idcliente == 0) {
                crearDireccion();
                crearCliente();
            }
            crearSolicitud();
            mostrarSolicitudes();
            limpiarForm2();
        }

        private void cargarSucursales()
        {
            oracle.Open();
            OracleCommand sucursales = new OracleCommand("select sucursalid, sucursal from rentadora.sucursal", oracle);
            OracleDataReader sucursal = sucursales.ExecuteReader();
            while (sucursal.Read())
            {
                cbSucursal.Items.Add(sucursal["sucursal"].ToString());
                idSucursales.Add(Int32.Parse(sucursal["sucursalid"].ToString()));
            }
            oracle.Close();
        }

        private void cargarEmpleados() {
            oracle.Open();
            OracleCommand sucursales = new OracleCommand("select empleadoid, nombre from rentadora.empleado", oracle);
            OracleDataReader empleado = sucursales.ExecuteReader();
            while (empleado.Read())
            {
                sEmpleado.Items.Add(empleado["nombre"].ToString());
                idEmpleados.Add(Int32.Parse(empleado["empleadoid"].ToString()));
            }
            oracle.Close();
        }

        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSucursal = idSucursales[cbSucursal.SelectedIndex];
        }

        private void sVehiculo_Click(object sender, EventArgs e)
        {
            SelectAuto auto = new SelectAuto();
            if (auto.ShowDialog() == DialogResult.OK) { cargarAuto(); }
        }

        private void cargarAuto()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("Select v.costo_renta, v.placa, comb.combustible, modelo.modelo, marca.marca, color.color,vers.version from rentadora.vehiculo v INNER JOIN rentadora.combustible comb ON comb.combustibleid = v.combustibleid INNER JOIN rentadora.modelo modelo ON modelo.modeloid = v.modeloid INNER JOIN rentadora.marca marca ON marca.marcaid = v.marcaid INNER JOIN rentadora.color color ON color.colorid = v.colorid INNER JOIN rentadora.version vers ON vers.versionid = v.versionid where v.vehiculoid =" + Variable.idSelectAuto, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                vPlaca.Text = registro["placa"].ToString();
                vCombustible.Text = registro["combustible"].ToString();
                vModelo.Text = registro["modelo"].ToString();
                vMarca.Text = registro["marca"].ToString();
                vColor.Text = registro["color"].ToString();
                vVersion.Text = registro["version"].ToString();
                vCosto.Text = registro["costo_renta"].ToString();
                costo_renta = float.Parse(registro["costo_renta"].ToString());
            }
            catch
            {
                MessageBox.Show("No se puede seleccionar el auto");
            }
            oracle.Close();
        }

        private void sEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idempleado = idEmpleados[sEmpleado.SelectedIndex];
        }

        private void crearSolicitud()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insertar_solicitud", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("fechas", OracleType.DateTime).Value = sfecha.Text;
                comando.Parameters.Add("fechai", OracleType.DateTime).Value = sInicio.Text;
                comando.Parameters.Add("fechaf", OracleType.DateTime).Value = sFin.Text;
                comando.Parameters.Add("cliente", OracleType.Int32).Value = idcliente;
                comando.Parameters.Add("empleado", OracleType.Int32).Value = idempleado;
                comando.Parameters.Add("sucursal", OracleType.Int32).Value = idSucursal;
                comando.Parameters.Add("vehiculo", OracleType.Int32).Value = Variable.idSelectAuto;
                comando.Parameters.Add("subt", OracleType.Float).Value = subtotal;
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Imposible crear solicitud");
            }
            oracle.Close();
        }

        private void totalDias() {
            DateTime fecha_i = sInicio.Value.Date;
            DateTime fecha_f = sFin.Value.Date;
            TimeSpan dif = fecha_f - fecha_i;
            int dias = dif.Days;
            subtotal = costo_renta * dias;
        }

        private void sFin_ValueChanged(object sender, EventArgs e)
        {
            totalDias();
            sSubtotal.Text = subtotal.ToString();
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            idmunicipio = idmunicipios[cbMunicipio.SelectedIndex];
        }

        private void mostrarSolicitudes()
        {
            oracle.Open();

            OracleCommand comando = new OracleCommand("rentadora.select_solicitud", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvSolicitudes.DataSource = table;
            oracle.Close();
            dgvSolicitudes.Columns[3].Visible = false; //idcliente
            dgvSolicitudes.Columns[7].Visible = false; //idvehiculo
            dgvSolicitudes.Columns[8].Visible = false; //inicio
            dgvSolicitudes.Columns[9].Visible = false; //fin
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsolicitud = Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells[0].Value);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (idsolicitud != 0)
            {
                try {
                    oracle.Open();
                    OracleCommand comando = new OracleCommand("rentadora.delete_solicitud", oracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("idS", OracleType.Int32).Value = idsolicitud;
                    comando.ExecuteNonQuery();
                } catch 
                {
                    MessageBox.Show("Imposible borrar");
                }
                oracle.Close();
                mostrarSolicitudes();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            Variable.idsolicitud = idsolicitud;
            EditarSolicitud nuevo = new EditarSolicitud();
            nuevo.ShowDialog();
            mostrarSolicitudes();
        }
    }
}
