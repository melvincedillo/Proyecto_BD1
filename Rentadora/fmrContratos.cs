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
    public partial class fmrContratos : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        int idSolicitud = 0;
        int idCliente = 0;
        int idDireccion = 0;
        int idVehiculo = 0;
        int idEmpleado = 0;
        int idSucursal = 0;
        float subTotal = 0;
        double iva = 0;
        double total = 0;

        public fmrContratos()
        {
            InitializeComponent();
        }

        private void fmrContratos_Load(object sender, EventArgs e)
        {
            cargarContratos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                idSolicitud = Convert.ToInt32(idSoliciudGenerar.Text);
                cargarSolicitud();
                idSoliciudGenerar.Enabled = false;
                buscarSolicitud.Visible = false;
                cancelarContrato.Visible = true;
                Detalles.Visible = false;
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void cargarSolicitud()
        {
            try {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.solicitud where solicitudid =" + idSolicitud, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                sNumero.Text = registro["solicitudid"].ToString();
                sFecha.Text = registro["fecha_solicitud"].ToString();
                sSubtotal.Text = registro["subtotal"].ToString();
                sInicio.Text = registro["fecharinicio"].ToString();
                sFin.Text = registro["fechafin"].ToString();

                subTotal = Convert.ToInt32(registro["subtotal"].ToString());
                idEmpleado = Convert.ToInt32(registro["empleadoid"].ToString());
                idSucursal = Convert.ToInt32(registro["sucursalid"].ToString());
                idVehiculo = Convert.ToInt32(registro["vehiculoid"].ToString());
                idCliente = Convert.ToInt32(registro["clienteid"].ToString());
                oracle.Close();

                cargarSucursal();
                cargarEmpleado();
                cargarAuto();
                cargarCliente();
                calculoTotal();
            } 
            catch {
                MessageBox.Show("No existe la solicitud");
                oracle.Close();
            }
        }

        private void cargarSucursal()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.sucursal where sucursalid =" + idSucursal, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                sucursal.Text = registro["sucursal"].ToString();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar sucursal");
                oracle.Close();
            }
        }

        private void cargarEmpleado()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.empleado where empleadoid =" + idEmpleado, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                empleado.Text = registro["nombre"].ToString();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar empleado");
                oracle.Close();
            }
        }

        private void cargarAuto() {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand(
                    "Select v.costo_renta, v.placa, comb.combustible, modelo.modelo, marca.marca, color.color, vers.version, tp.tipo_vehiculo " +
                    "from rentadora.vehiculo v INNER JOIN rentadora.combustible comb ON comb.combustibleid = v.combustibleid " +
                    "INNER JOIN rentadora.modelo modelo ON modelo.modeloid = v.modeloid " +
                    "INNER JOIN rentadora.marca marca ON marca.marcaid = v.marcaid " +
                    "INNER JOIN rentadora.color color ON color.colorid = v.colorid " +
                    "INNER JOIN rentadora.version vers ON vers.versionid = v.versionid " +
                    "INNER JOIN rentadora.tipo_vehiculo tp ON tp.tipo_vehiculoid = v.tipo_vehiculoid " +
                    "where v.vehiculoid =" + idVehiculo, 
                    oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                vPlaca.Text = registro["placa"].ToString();
                vCombustible.Text = registro["combustible"].ToString();
                vModelo.Text = registro["modelo"].ToString();
                vMarca.Text = registro["marca"].ToString();
                vColor.Text = registro["color"].ToString();
                vVersion.Text = registro["version"].ToString();
                vCosto.Text = registro["costo_renta"].ToString();
                vTipo.Text = registro["tipo_vehiculo"].ToString();
                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("No se puede cargar auto");
            }
        }

        private void cargarCliente()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.cliente where clienteid =" + idCliente, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                string nombre = registro["p_nombre"].ToString() + " " + registro["s_nombre"].ToString() + " " + registro["p_apellido"].ToString() + " " + registro["s_apellido"].ToString();
                cNombre.Text = nombre;
                cSexo.Text = registro["sexo"].ToString();
                cRTN.Text = registro["rtn"].ToString();
                cID.Text = registro["identidad"].ToString();
                idDireccion = Convert.ToInt32(registro["direccionid"].ToString());


                OracleCommand comando2 = new OracleCommand(
                    "select * from rentadora.direccion dir " +
                    "inner join rentadora.municipio m on m.municipioid = dir.municipioid " +
                    "inner join rentadora.departamento d on d.departamentoid = m.municipioid " +
                    "where dir.direccionid =" + idDireccion, 
                    oracle);
                OracleDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();
                string direccion = registro2["municipio"].ToString() + ", " +
                    registro2["departamento"].ToString() + " |  Colonia/Aldea " +
                    registro2["col_aldea"].ToString() + ", Calle " +
                    registro2["calle"].ToString() + ", Casa " +
                    registro2["casa"].ToString();
                cDireccion.Text = direccion;


                OracleCommand comando3 = new OracleCommand("select * from rentadora.telefonoxcliente where clienteid = " + idCliente + "order by pos", oracle);
                OracleDataReader registro3 = comando3.ExecuteReader();
                string telefonos = "";
                while (registro3.Read())
                {
                    telefonos = telefonos + registro3["telefono"].ToString() + "   ";
                }
                cTelefonos.Text = telefonos;

                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("No se puede cargar cliente");
            }
        }

        private void calculoTotal()
        {
            iva = subTotal * 0.15;
            total = subTotal + iva;

            sIVA.Text = iva.ToString();
            sTotal.Text = total.ToString();
        }

        private void crearContrato()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_contrato", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idCo", OracleType.Int32).Value = idSolicitud;
                comando.Parameters.Add("idS", OracleType.Int32).Value = idSolicitud;
                comando.Parameters.Add("fech", OracleType.DateTime).Value = cfecha.Text;
                comando.Parameters.Add("subt", OracleType.Float).Value = subTotal;
                comando.Parameters.Add("ivac", OracleType.Float).Value = iva;
                comando.Parameters.Add("totalc", OracleType.Float).Value = total;
                comando.ExecuteNonQuery();

                OracleCommand estado = new OracleCommand("UPDATE VEHICULO SET ESTADOID=2 WHERE vehiculoid=(SELECT s.vehiculoid FROM contrato c INNER JOIN solicitud s on s.solicitudid=c.solicitudid WHERE contratoid= " + idSolicitud + ")", oracle);
                estado.ExecuteNonQuery();
                
                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("ERROR AL CREAR CONTRATO");
            }
        }

        private void addContrato_Click(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                crearContrato();
                limpiarform();
                idSoliciudGenerar.Enabled = true;
                buscarSolicitud.Visible = true;
                cancelarContrato.Visible = false;
                Detalles.Visible = true;
                cargarContratos();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void limpiarform()
        {
            idSolicitud = 0; idCliente = 0; idDireccion = 0; idVehiculo = 0; idEmpleado = 0; idSucursal = 0; subTotal = 0; iva = 0; total = 0;
            idSoliciudGenerar.Text = "";
            sNumero.Text = "----"; sFecha.Text = "----"; empleado.Text = "----"; sucursal.Text = "----";
            cNombre.Text = "----"; cSexo.Text = "----"; cID.Text = "----"; cDireccion.Text = "----"; cRTN.Text = "----"; cTelefonos.Text = "----";
            vPlaca.Text = "----"; vMarca.Text = "----"; vModelo.Text = "----"; vVersion.Text = "----";
            vTipo.Text = "----"; vColor.Text = "----"; vCombustible.Text = "----"; vCosto.Text = "----";
            sInicio.Text = "----"; sFin.Text = "----";
            sSubtotal.Text = "----"; sIVA.Text = "----"; sTotal.Text = "----";
        }

        private void cancelarContrato_Click(object sender, EventArgs e)
        {
            limpiarform();
            idSoliciudGenerar.Enabled = true;
            buscarSolicitud.Visible = true;
            cancelarContrato.Visible = false;
            Detalles.Visible = true;
        }

        private void dgvContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSolicitud = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells[0].Value);
        }

        private void Detalles_Click(object sender, EventArgs e)
        {
            cargarSolicitud();
            idSoliciudGenerar.Enabled = false;
            buscarSolicitud.Visible = false;
            addContrato.Visible = false;
            cancelarDeatlles.Visible = true;
            Detalles.Visible = false;
        }

        private void cargarContratos()
        {
            oracle.Open();

            OracleCommand comando = new OracleCommand("rentadora.select_contrato", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvContratos.DataSource = table;
            oracle.Close();
        }

        private void cancelarDeatlles_Click(object sender, EventArgs e)
        {
            limpiarform();
            idSoliciudGenerar.Enabled = true;
            buscarSolicitud.Visible = true;
            addContrato.Visible = true;
            cancelarDeatlles.Visible = false;
            Detalles.Visible = true;
        }
    }
}
