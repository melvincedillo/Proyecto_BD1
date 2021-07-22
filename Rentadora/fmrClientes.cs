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

        public fmrClientes()
        {
            InitializeComponent();
        }


        private void fmrClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            cargarDepartamentos();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
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
            OracleCommand departamentos = new OracleCommand("select municipio from municipio where departamentoid =" + id, oracle);
            OracleDataReader registro = departamentos.ExecuteReader();
            while (registro.Read())
            {
                cbMunicipio.Items.Add(registro["municipio"].ToString());
            }
            oracle.Close();
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMunicipio.Items.Clear();
            cbMunicipio.Text = "";
            int dep = cbDepartamento.SelectedIndex;
            cargarMunicipios(dep + 1);
        }
    }
}
