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
    public partial class SelectAuto : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);

        public SelectAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void mostrarAutos()
        {
            oracle.Open();
            OracleCommand comando = new OracleCommand("rentadora.elegir_vehiculos", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("vehiculo", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvAutosSelect.DataSource = table;
            oracle.Close();
            //dgvAutos.Columns[4].Visible = false;
        }

        private void SelectAuto_Load(object sender, EventArgs e)
        {
            mostrarAutos();
        }
    }
}
