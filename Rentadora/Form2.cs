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
    public partial class Form2 : Form
    {
        OracleConnection ora = new OracleConnection(Variable.conexion);
        public Form2()
        {
            InitializeComponent();
            userTxt.Text = Variable.usuario;

            ora.Open();
            OracleCommand comando = new OracleCommand("system.solicitudes", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("prueba", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            solicitudes.DataSource = tabla;
            ora.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Variable.conexion = "";
            Variable.Login.Show();
            this.Close();
        }
    }
}
