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
        private List<int> idSucursales = new List<int>();
        private int idempleado;
        private int idSucursal;

        

        public fmrEmpleados()
        {
            InitializeComponent();
        }

        private void fmrEmpleados_Load(object sender, EventArgs e)
        {
            mostrarEmpleados();
            cargarSucursales();
            aceptar.Visible = false;
            cancelar.Visible = false;
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
            dgvEmpleados.Columns[4].Visible = false;
        }

        private void cargarSucursales()
        {
            oracle.Open();
            OracleCommand sucursales = new OracleCommand("select sucursalid, sucursal from rentadora.sucursal", oracle);
            OracleDataReader empleado = sucursales.ExecuteReader();
            while (empleado.Read())
            {
                cbSucursal.Items.Add(empleado["sucursal"].ToString());
                idSucursales.Add(Int32.Parse(empleado["sucursalid"].ToString()));
                //idSucursal =Int32.Parse(empleado["sucursalid"].ToString());
            }
            oracle.Close();
        }

        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSucursal = idSucursales[cbSucursal.SelectedIndex];
            idSucur.Text = idSucursal.ToString();
        }

        private void add_empleado_Click(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                try
                {
                    crearEmpleado();
                    mostrarEmpleados();
                    limpiarForm();
                }
                catch
                {
                    MessageBox.Show("NO SE PUEDE CREARRRRRR UGH.");
                }
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void limpiarForm()
        {
            cNombreEmpleado.Text = "";
            cP_Nombre.Text = "";
            cS_Nombre.Text = "";
            cP_Apellido.Text = "";
            cS_Apellido.Text = "";
            cIdentidad.Text = "";
            cbSexo.Text = "";
            cSueldo.Text = "";
            cH_Extras.Text = "";
            dpFecha_ingreso.Text = "";
            cbSucursal.Text = "";
        }

        private void crearEmpleado()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_empleado", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nb", OracleType.VarChar).Value = cNombreEmpleado.Text;
                comando.Parameters.Add("pn", OracleType.VarChar).Value = cP_Nombre.Text;
                comando.Parameters.Add("sn", OracleType.VarChar).Value = cS_Nombre.Text;
                comando.Parameters.Add("pa", OracleType.VarChar).Value = cP_Apellido.Text;
                comando.Parameters.Add("sa", OracleType.VarChar).Value = cS_Apellido.Text;
                comando.Parameters.Add("tid", OracleType.VarChar).Value = cIdentidad.Text;
                comando.Parameters.Add("sld", OracleType.Float).Value = cSueldo.Text;
                comando.Parameters.Add("he", OracleType.Float).Value = cH_Extras.Text;
                comando.Parameters.Add("fi", OracleType.DateTime).Value = dpFecha_ingreso.Text;
                comando.Parameters.Add("sex", OracleType.VarChar).Value = cbSexo.Text;
                comando.Parameters.Add("sc", OracleType.Int32).Value = idSucursal;
                //comando.Parameters.Add("sc", OracleType.Number).Value = ComboboxItem.Indice(CbSucursal.SelectedItem as ComboboxItem);
                //comando.Parameters.Add("sc", OracleType.Int32).Value = cbSucursal.Text;
                comando.ExecuteNonQuery();
                oracle.Close();


            }
            catch { MessageBox.Show("Error al Crear Empleado"); }
            
        }


        private void aceptar_Click(object sender, EventArgs e)
        {
            updateEmpleado();
            limpiarForm();
            mostrarEmpleados();
            add_empleado.Visible = true;
            delete_empleado.Visible = true;
            editar_empleado.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }


        private void deleteEmpleado()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.delete_empleado", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idE", OracleType.Int32).Value = idempleado;
                comando.ExecuteNonQuery();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("No se puede eliminar");
            }
        }

        private void updateEmpleado()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.update_empleado", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idE", OracleType.Int32).Value = idempleado;
                comando.Parameters.Add("nb", OracleType.VarChar).Value = cNombreEmpleado.Text;
                comando.Parameters.Add("pn", OracleType.VarChar).Value = cP_Nombre.Text;
                comando.Parameters.Add("sn", OracleType.VarChar).Value = cS_Nombre.Text;
                comando.Parameters.Add("pa", OracleType.VarChar).Value = cP_Apellido.Text;
                comando.Parameters.Add("sa", OracleType.VarChar).Value = cS_Apellido.Text;
                comando.Parameters.Add("tid", OracleType.VarChar).Value = cIdentidad.Text;
                comando.Parameters.Add("sld", OracleType.Float).Value = cSueldo.Text;
                comando.Parameters.Add("he", OracleType.Float).Value = cH_Extras.Text;
                comando.Parameters.Add("fi", OracleType.DateTime).Value = dpFecha_ingreso.Text;
                comando.Parameters.Add("sex", OracleType.VarChar).Value = cbSexo.Text;
                comando.Parameters.Add("sc", OracleType.Int32).Value = idSucursal;
                comando.ExecuteNonQuery();
                

            }
            catch
            {
                MessageBox.Show("Error al actualizar Empleado");
            }
            oracle.Close();
        }

        private void editar_empleado_Click(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                add_empleado.Visible = false;
                delete_empleado.Visible = false;
                editar_empleado.Visible = false;
                aceptar.Visible = true;
                cancelar.Visible = true;
                cargarEmpleadoEditar();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void cargarEmpleadoEditar()
        {
            oracle.Open();
            OracleCommand comando = new OracleCommand("Select e.empleadoID,e.nombre,e.p_nombre,e.s_nombre,e.p_apellido,e.s_apellido, e.identidad, e.sueldo, e.horasextras, e.fecha_ingreso,e.sexo, s.sucursal from rentadora.empleado e INNER JOIN rentadora.sucursal s ON s.sucursalid = e.sucursalid where empleadoid = " + idempleado, oracle);
            OracleDataReader registro = comando.ExecuteReader();
            registro.Read();
            cNombreEmpleado.Text = registro["nombre"].ToString();
            cIdentidad.Text = registro["identidad"].ToString();
            cSueldo.Text = registro["sueldo"].ToString();
            cH_Extras.Text = registro["horasextras"].ToString();
            dpFecha_ingreso.Text = registro["fecha_ingreso"].ToString();
            cP_Nombre.Text = registro["p_nombre"].ToString();
            cS_Nombre.Text = registro["s_nombre"].ToString();
            cP_Apellido.Text = registro["p_apellido"].ToString();
            cS_Apellido.Text = registro["s_apellido"].ToString();
            cbSexo.Text = registro["sexo"].ToString();
            cbSucursal.Text = registro["sucursal"].ToString();

            oracle.Close();
        }

        private void delete_empleado_Click_1(object sender, EventArgs e)
        {
            if (Variable.controltotal == true)
            {
                deleteEmpleado();
                idempleado = 0;
                mostrarEmpleados();
            }
            else
            {
                MessageBox.Show("PRIVILEGIOS INSUFICIENTES");
            }
        }

        private void cancelar_Click_1(object sender, EventArgs e)
        {
            add_empleado.Visible = true;
            delete_empleado.Visible = true;
            editar_empleado.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
            limpiarForm();
        }

        private void dgvEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idempleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value);

            //Label para verificar que se seleccione el empleado con el id correcto
            idEmp.Text = idempleado.ToString();
        }
    }
}
