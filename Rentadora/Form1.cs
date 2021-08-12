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
                //Captura los datos del login y crea una conexion
                Variable.conexion = "DATA SOURCE = xe; PASSWORD =" + passwordTxt.Text + "; USER ID =" + usuarioTxt.Text + ";";
                OracleConnection oracle = new OracleConnection(Variable.conexion);

                //Abre la conexion
                oracle.Open();
                    Variable.usuario = usuarioTxt.Text;

                    //Comprueba el tipo de usuario
                    OracleCommand comando = new OracleCommand("select role from role_sys_privs", oracle);
                    OracleDataReader registro = comando.ExecuteReader();
                    registro.Read();
                    //Guarda el tipo de usuario
                    string rol = registro["role"].ToString();
                oracle.Close();

                //Asigna el tipo de usuario al sistema
                    if (rol == "LECTURA")
                    {
                        Variable.controltotal = false;
                    }
                    else
                    {
                        Variable.controltotal = true;
                    }
                //Abre el formulario principal
                fmrPrincipal entrar = new fmrPrincipal();
                entrar.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Credenciales Invalidas");
            }
            usuarioTxt.Text = null;
            passwordTxt.Text = null;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
