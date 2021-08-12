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
                    comando.Parameters.Add("expi", OracleType.VarChar).Value = "";
                    comando.Parameters.Add("cod", OracleType.Int32).Value = 0;
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
                    comando.Parameters.Add("expi", OracleType.VarChar).Value = exp.Text;
                    comando.Parameters.Add("cod", OracleType.Int32).Value = Convert.ToInt32(cod.Text);
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

        private void fmrPago_Load(object sender, EventArgs e)
        {
            Total.Text = "Total a pagar L. " + Variable.total;
        }

        private void exp_KeyDown(object sender, KeyEventArgs e)
        {
            if (exp.Text.ToString().Length == 2 && e.KeyValue != 8)
            {
                exp.Text = exp.Text + "/";
                exp.Select(exp.Text.Length, 0);
            }
        }

        private void tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            PanelTarjeta.Visible = true;
        }

        private void efectivo_CheckedChanged(object sender, EventArgs e)
        {
            PanelTarjeta.Visible = false;
        }

        private void tarj_KeyDown(object sender, KeyEventArgs e)
        {
            if ((tarj.Text.ToString().Length == 4 || tarj.Text.ToString().Length == 9 || tarj.Text.ToString().Length == 14) && e.KeyValue != 8)
            {
                tarj.Text = tarj.Text + " ";
                tarj.Select(tarj.Text.Length, 0);
            }
        }
    }
}
