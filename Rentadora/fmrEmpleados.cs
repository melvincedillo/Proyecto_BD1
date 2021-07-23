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
    public partial class fmrEmpleados : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);

        public fmrEmpleados()
        {
            InitializeComponent();
        }

        private void fmrEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
            cargarSucursales();
        }

        private void mostrarEmpleados()
        {
            oracle.Open();
            OracleCommand comando = new OracleCommand("rentadora.select_empleados", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("empleado", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvEmpleados.DataSource = table;
            oracle.Close();
        }

        private void cargarSucursales()
        {
            oracle.Open();
            OracleCommand sucursales = new OracleCommand("select sucursal from rentadora.sucursal", oracle);
            OracleDataReader empleado = sucursales.ExecuteReader();
            while (empleado.Read())
            {
                cbSucursal.Items.Add(empleado["sucursal"].ToString());
            }
            oracle.Close();
        }


        /*
        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSucursal.Items.Clear();
            cbSucursal.Text = "";
            int sucursal = cbSucursal.SelectedIndex;
            cargarSucursales(sucursal + 1);
        }
        */


    }
}
