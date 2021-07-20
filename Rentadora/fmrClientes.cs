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
            mostrarClientes();
        }

        private void mostrarClientes() {
            oracle.Open();
            OracleCommand comando = new OracleCommand("rentadora.clientes", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvClientes.DataSource = table;

            oracle.Close();
        }
    }
}
