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
    public partial class fmrPago : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);

        public fmrPago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (efectivo.Checked)
            {
                try
                {
                    oracle.Open();
                    OracleCommand comando = new OracleCommand("rentadora.pagar", oracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("idC", OracleType.Int32).Value = Variable.idsolicitud;
                    comando.Parameters.Add("total", OracleType.Int32).Value = Variable.total;
                    comando.Parameters.Add("tipo", OracleType.Int32).Value = 1;
                    comando.Parameters.Add("tarjeta", OracleType.VarChar).Value = "";
                    comando.ExecuteNonQuery();
                    oracle.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else if (tarjeta.Checked)
            {
                try
                {
                    oracle.Open();
                    OracleCommand comando = new OracleCommand("rentadora.pagar", oracle);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("idC", OracleType.Int32).Value = Variable.idsolicitud;
                    comando.Parameters.Add("total", OracleType.Int32).Value = Variable.total;
                    comando.Parameters.Add("tipo", OracleType.Int32).Value = 2;
                    comando.Parameters.Add("tarjeta", OracleType.VarChar).Value = tarj.Text;
                    comando.ExecuteNonQuery();
                    oracle.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            DialogResult = DialogResult.OK;
        }
    }
}
