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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Variable.Login = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Variable.conexion = "DATA SOURCE = xe; PASSWORD =" + passwordTxt.Text + "; USER ID =" + usuarioTxt.Text + ";";
                OracleConnection oracle = new OracleConnection(Variable.conexion);
                oracle.Open();
                Variable.usuario = usuarioTxt.Text;
                oracle.Close();
                fmrPrincipal entrar = new fmrPrincipal();
                entrar.Show();
                this.Hide();
            }catch
            {
                MessageBox.Show("Credenciales Invalidas");
            }
            usuarioTxt.Text = null;
            passwordTxt.Text = null;
        }

    }
}
