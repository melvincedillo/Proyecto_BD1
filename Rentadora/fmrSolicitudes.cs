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
        private int idmunicipio;
        private int iddireccion;
        private int idcliente = 0;
        bool cargarC = true;

        public fmrSolicitudes()
        {
            InitializeComponent();
        }

        private void fmrSolicitudes_Load(object sender, EventArgs e)
        {
            cargarDepartamentos();
            idcprueba.Text = idcliente.ToString();
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

        private void cargarClienteEditar()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("Select * from rentadora.cliente where identidad =" + cIdentidad.Text, oracle);
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
            cargarClienteEditar();
            bloquearCliente();
            idcprueba.Text = idcliente.ToString();
            cerrarCliente.Visible = true;
            cargarCliente.Visible = false;
        }

        private void cerrarCliente_Click(object sender, EventArgs e)
        {
            bloquearCliente();
            limpiarForm();
            idcliente = 0;
            idcprueba.Text = idcliente.ToString();
            cerrarCliente.Visible = false;
            cargarCliente.Visible = true;
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
    }
}
