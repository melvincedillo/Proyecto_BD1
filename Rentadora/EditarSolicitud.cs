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
    public partial class EditarSolicitud : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        private float costo_renta = 0;
        private float seguro = 0;
        private float subtotal = 0;
        private int opcionSeguro;
        private int idcliente;
        DateTime fecha_i;
        DateTime fecha_f;


        public EditarSolicitud()
        {
            InitializeComponent();
        }

        private void EditarSolicitud_Load(object sender, EventArgs e)
        {
            try 
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.solicitud where solicitudid = " + Variable.idsolicitud, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                Variable.idSelectAuto = Convert.ToInt32(registro["vehiculoid"].ToString());
                idcliente = Convert.ToInt32(registro["clienteid"].ToString());
                fecha_i = Convert.ToDateTime(registro["fecharinicio"].ToString());
                fecha_f = Convert.ToDateTime(registro["fechafin"].ToString());
                subtotal = float.Parse(registro["subtotal"].ToString());
                sSubtotal.Text = subtotal.ToString();
                sID.Text = registro["solicitudid"].ToString();
                sFecha.Text = registro["fecha_solicitud"].ToString();
                cbSeguro.Text = registro["seguro"].ToString();
                oracle.Close();

                cargarAuto();
                ifoCliente();
                sInicio.Value = fecha_i;
                sFin.Value = fecha_f;
            } 
            catch
            {
                oracle.Close();
                MessageBox.Show("Error");
            }
        }

        private void ifoCliente()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.cliente where clienteid = " + idcliente, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                cSexo.Text = registro["sexo"].ToString();
                cRTN.Text = registro["rtn"].ToString();
                cID.Text = registro["identidad"].ToString();
                string nombre = registro["p_nombre"].ToString() + " " + registro["s_nombre"].ToString() + " " + registro["p_apellido"].ToString() + " " + registro["s_apellido"].ToString();
                cNombre.Text = nombre;

                OracleCommand comando2 = new OracleCommand("select * from rentadora.telefonoxcliente where pos = 1 and clienteid = " + idcliente, oracle);
                OracleDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();
                cTel.Text = registro2["telefono"].ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            oracle.Close();
        }

        private void cargarAuto()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("Select v.costo_renta, v.placa, comb.combustible, modelo.modelo, marca.marca, color.color,vers.version, v.seguro from rentadora.vehiculo v INNER JOIN rentadora.combustible comb ON comb.combustibleid = v.combustibleid INNER JOIN rentadora.modelo modelo ON modelo.modeloid = v.modeloid INNER JOIN rentadora.marca marca ON marca.marcaid = v.marcaid INNER JOIN rentadora.color color ON color.colorid = v.colorid INNER JOIN rentadora.version vers ON vers.versionid = v.versionid where v.vehiculoid =" + Variable.idSelectAuto, oracle);
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
                vSeguro.Text = registro["seguro"].ToString();
                seguro = float.Parse(registro["seguro"].ToString());
            }
            catch
            {
                MessageBox.Show("No se puede seleccionar el auto");
            }
            oracle.Close();
        }

        private void sVehiculo_Click(object sender, EventArgs e)
        {
            SelectAuto auto = new SelectAuto();
            if (auto.ShowDialog() == DialogResult.OK) { 
                cargarAuto();
                totalDias();
                sSubtotal.Text = subtotal.ToString();
            }
        }

        private void cbSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcionSeguro = cbSeguro.SelectedIndex;
        }

        private void totalDias()
        {
            TimeSpan dif = fecha_f - fecha_i;
            int dias = dif.Days;
            if (opcionSeguro == 0) { subtotal = seguro + (costo_renta * dias); }
            else { subtotal = costo_renta * dias; }

        }

        private void sFin_ValueChanged(object sender, EventArgs e)
        {
            fecha_f = sFin.Value.Date;
            totalDias();
            sSubtotal.Text = subtotal.ToString();
        }

        private void sInicio_ValueChanged(object sender, EventArgs e)
        {
            fecha_i = sInicio.Value.Date;
            totalDias();
            sSubtotal.Text = subtotal.ToString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void actualizar()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.update_solicitud", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idS", OracleType.Int32).Value = Variable.idsolicitud;
                comando.Parameters.Add("vehiculo", OracleType.Int32).Value = Variable.idSelectAuto;
                comando.Parameters.Add("fechai", OracleType.DateTime).Value = sInicio.Value;
                comando.Parameters.Add("fechaf", OracleType.DateTime).Value = sFin.Value;
                comando.Parameters.Add("seguro", OracleType.VarChar).Value = cbSeguro;
                comando.Parameters.Add("subt", OracleType.Float).Value = subtotal;
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Imposible actualizar");
            }
            oracle.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            actualizar();
            DialogResult = DialogResult.OK;
        }

       
    }
}
