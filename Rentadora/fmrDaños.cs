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
    public partial class fmrDaños : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        private int idDaño = 0;

        public fmrDaños()
        {
            InitializeComponent();
        }

        private void fmrDaños_Load(object sender, EventArgs e)
        {
            mostrarDaños();
        }

        private void mostrarDaños()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.select_daño", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idD", OracleType.Int32).Value = Variable.idsolicitud;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dgvDaños.DataSource = table;
                oracle.Close();
                dgvDaños.Columns[0].Visible = false;
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("Error al cargar");
            }
        }

        private void dgvDaños_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idDaño = Convert.ToInt32(dgvDaños.SelectedRows[0].Cells[0].Value);
        }

        private void delete_cliente_Click(object sender, EventArgs e)
        {
            if (idDaño != 0) {
                try
                {
                    oracle.Open();
                    OracleCommand comando = new OracleCommand("rentadora.delete_danios", oracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("idD", OracleType.Int32).Value = Variable.idsolicitud;
                    comando.Parameters.Add("idDa", OracleType.Int32).Value = idDaño;
                    comando.ExecuteNonQuery();
                    oracle.Close();
                    mostrarDaños();
                }
                catch
                {
                    oracle.Close();
                    MessageBox.Show("Error al borrar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un daño");
            }
        }

        private void disponible_Click(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_danios", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idD", OracleType.Int32).Value = Variable.idsolicitud;
                comando.Parameters.Add("precio", OracleType.Float).Value = Convert.ToDouble(costo.Text);
                comando.Parameters.Add("daño", OracleType.VarChar).Value = descrpcion.Text;
                comando.Parameters.Add("idDa", OracleType.Int32).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();
                oracle.Close();
                descrpcion.Text = "";
                costo.Text = "";
                mostrarDaños();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("Error al insertar");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
