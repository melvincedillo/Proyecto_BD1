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
    public partial class fmrHistorial : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        int id_dev = 0;
        public fmrHistorial()
        {
            InitializeComponent();
        }

        private void fmrHistorial_Load(object sender, EventArgs e)
        {
            mostrarHistorial();
        }


        private void mostrarHistorial()
        {
            oracle.Open();
            OracleCommand disponibles = new OracleCommand("rentadora.select_historial", oracle);
            disponibles.CommandType = System.Data.CommandType.StoredProcedure;
            disponibles.Parameters.Add("historial", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador1 = new OracleDataAdapter();
            adaptador1.SelectCommand = disponibles;
            DataTable table = new DataTable();
            adaptador1.Fill(table);
            dgvHistorial.DataSource = table;
            oracle.Close();
            //dgvAutos.Columns[4].Visible = false;
            dgvHistorial.Columns[0].Visible = false;
            dgvHistorial.Columns[5].Visible = false;
            dgvHistorial.Columns[7].Visible = false;
            dgvHistorial.Columns[8].Visible = false;
            dgvHistorial.Columns[9].Visible = false;
        }


        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_dev = Convert.ToInt32(dgvHistorial.SelectedRows[0].Cells[0].Value);
        }

        private void Detalles_Click(object sender, EventArgs e)
        {

                if (id_dev != 0)
                {
                    Variable.id_dev = id_dev;
                    fmrDetalleHistorial abrir = new fmrDetalleHistorial();
                    abrir.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione una devolucion");
                }
        }
    }
}
