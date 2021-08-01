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
    public partial class fmrAutos : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        private int idvehiculo;
        private List<int> idCombustibles = new List<int>();
        private List<int> idModelos = new List<int>();
        private List<int> idMarcas = new List<int>();
        private List<int> idColores = new List<int>();
        private List<int> idTipo_Vehiculos = new List<int>();
        private List<int> idVersiones = new List<int>();
        private List<int> idEstados = new List<int>();
        private int idCombustible;
        private int idModelo;
        private int idMarca;
        private int idColor;
        private int idTipo_Vehiculo;
        private int idVersion;
        private int idEstado;
        public fmrAutos()
        {
            InitializeComponent();
        }

        private void fmrAutos_Load(object sender, EventArgs e)
        {
            mostrarAutos();
            cargarCombustibles();
            cargarModelos();
            cargarMarcas();
            cargarColores();
            cargarTipo_Vehiculos();
            cargarVersiones();
            cargarEstados();
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void mostrarAutos()
        {
            oracle.Open();
            OracleCommand comando = new OracleCommand("rentadora.select_vehiculos", oracle);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("vehiculo", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable table = new DataTable();
            adaptador.Fill(table);
            dgvAutos.DataSource = table;
            oracle.Close();
            //dgvAutos.Columns[4].Visible = false;
            dgvAutos.Columns[0].Visible = false;
            dgvAutos.Columns[5].Visible = false;
            dgvAutos.Columns[7].Visible = false;
            dgvAutos.Columns[8].Visible = false;
            dgvAutos.Columns[9].Visible = false;
        }

        private void cargarCombustibles()
        {
            oracle.Open();
            OracleCommand combustible = new OracleCommand("select combustibleid, combustible from rentadora.combustible", oracle);
            OracleDataReader vehiculo = combustible.ExecuteReader();
            while (vehiculo.Read())
            {
                cbCombustible.Items.Add(vehiculo["combustible"].ToString());
                idCombustibles.Add(Int32.Parse(vehiculo["combustibleid"].ToString()));
            }
            oracle.Close();
        }

        private void cbCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCombustible = idCombustibles[cbCombustible.SelectedIndex];
        }

        private void cargarModelos()
        {
            oracle.Open();
            OracleCommand modelo = new OracleCommand("select modeloid, modelo from rentadora.modelo", oracle);
            OracleDataReader vehiculo = modelo.ExecuteReader();
            while (vehiculo.Read())
            {
                cbModelo.Items.Add(vehiculo["modelo"].ToString());
                idModelos.Add(Int32.Parse(vehiculo["modeloid"].ToString()));
            }
            oracle.Close();
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idModelo = idModelos[cbModelo.SelectedIndex];
        }

        private void cargarMarcas()
        {
            oracle.Open();
            OracleCommand marca = new OracleCommand("select marcaid, marca from rentadora.marca", oracle);
            OracleDataReader vehiculo = marca.ExecuteReader();
            while (vehiculo.Read())
            {
                cbMarca.Items.Add(vehiculo["marca"].ToString());
                idMarcas.Add(Int32.Parse(vehiculo["marcaid"].ToString()));
            }
            oracle.Close();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMarca = idMarcas[cbMarca.SelectedIndex];
        }

        private void cargarTipo_Vehiculos()
        {
            oracle.Open();
            OracleCommand tipo_vehiculo = new OracleCommand("select tipo_vehiculoid, tipo_vehiculo from rentadora.tipo_vehiculo", oracle);
            OracleDataReader vehiculo = tipo_vehiculo.ExecuteReader();
            while (vehiculo.Read())
            {
                cbTipo_Vehiculo.Items.Add(vehiculo["tipo_vehiculo"].ToString());
                idTipo_Vehiculos.Add(Int32.Parse(vehiculo["tipo_vehiculoid"].ToString()));
            }
            oracle.Close();
        }

        private void cbTipo_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTipo_Vehiculo = idTipo_Vehiculos[cbTipo_Vehiculo.SelectedIndex];
        }

        private void cargarColores()
        {
            oracle.Open();
            OracleCommand color = new OracleCommand("select colorid, color from rentadora.color", oracle);
            OracleDataReader vehiculo = color.ExecuteReader();
            while (vehiculo.Read())
            {
                cbColor.Items.Add(vehiculo["color"].ToString());
                idColores.Add(Int32.Parse(vehiculo["colorid"].ToString()));
            }
            oracle.Close();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            idColor = idColores[cbColor.SelectedIndex];
        }

        private void cargarVersiones()
        {
            oracle.Open();
            OracleCommand version = new OracleCommand("select versionid, version from rentadora.version", oracle);
            OracleDataReader vehiculo = version.ExecuteReader();
            while (vehiculo.Read())
            {
                cb_Version.Items.Add(vehiculo["version"].ToString());
                idVersiones.Add(Int32.Parse(vehiculo["versionid"].ToString()));
            }
            oracle.Close();
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVersion = idVersiones[cb_Version.SelectedIndex];
        }

        private void cargarEstados()
        {
            oracle.Open();
            OracleCommand estado = new OracleCommand("select estadoid, estado from rentadora.estado", oracle);
            OracleDataReader vehiculo = estado.ExecuteReader();
            while (vehiculo.Read())
            {
                cbEstado.Items.Add(vehiculo["estado"].ToString());
                idEstados.Add(Int32.Parse(vehiculo["estadoid"].ToString()));
            }
            oracle.Close();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEstado = idEstados[cbEstado.SelectedIndex];
        }



        private void add_auto_Click(object sender, EventArgs e)
        {
            try
            {
                crearAuto();
                mostrarAutos();
                limpiarForm();
            }
            catch
            {
                MessageBox.Show("NO SE PUEDE CREARRRRRR UGH.");
            }
        }

        private void limpiarForm()
        {
            cPlaca.Text = "";
            dpFecha_Adq.Text = "";
            cCosto_Vehiculo.Text = "";
            cbCombustible.Text = "";
            cbModelo.Text = "";
            cbMarca.Text = "";
            cbColor.Text = "";
            cbTipo_Vehiculo.Text = "";
            cb_Version.Text = "";
            cbEstado.Text = "";
            cSeguro.Text = "";
            vCosto_renta.Text = "";
        }

        private void crearAuto()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.insert_vehiculos", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("plac", OracleType.VarChar).Value = cPlaca.Text;
                comando.Parameters.Add("fecha", OracleType.DateTime).Value = dpFecha_Adq.Text;
                comando.Parameters.Add("costo_a", OracleType.Float).Value = Convert.ToDouble(cCosto_Vehiculo.Text);
                comando.Parameters.Add("costo_r", OracleType.Float).Value = float.Parse(vCosto_renta.Text);
                comando.Parameters.Add("cb", OracleType.Int32).Value = idCombustible;
                comando.Parameters.Add("modelo", OracleType.Int32).Value = idModelo;
                comando.Parameters.Add("mar", OracleType.Int32).Value = idMarca;
                comando.Parameters.Add("color", OracleType.Int32).Value = idColor;
                comando.Parameters.Add("tv", OracleType.Int32).Value = idTipo_Vehiculo;
                comando.Parameters.Add("vers", OracleType.Int32).Value = idVersion;
                comando.Parameters.Add("est", OracleType.Int32).Value = idEstado;
                comando.Parameters.Add("segur", OracleType.Float).Value = Convert.ToDouble(cSeguro.Text);
                comando.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Error al Crear Auto"); }
            oracle.Close();
        }


        private void aceptar_Click(object sender, EventArgs e)
        {
            updateAuto();
            limpiarForm();
            mostrarAutos();
            add_auto.Visible = true;
            delete_auto.Visible = true;
            editar_auto.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
        }


        private void updateAuto()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.update_vehiculo", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("placa", OracleType.VarChar).Value = cPlaca.Text;
                comando.Parameters.Add("fecha", OracleType.DateTime).Value = dpFecha_Adq.Text;
                comando.Parameters.Add("costo_a", OracleType.Float).Value = Convert.ToDouble(cCosto_Vehiculo.Text);
                comando.Parameters.Add("costo_r", OracleType.Float).Value = Convert.ToDouble(vCosto_renta.Text);
                comando.Parameters.Add("cb", OracleType.Int32).Value = idCombustible;
                comando.Parameters.Add("modelo", OracleType.Int32).Value = idModelo;
                comando.Parameters.Add("mar", OracleType.Int32).Value = idMarca;
                comando.Parameters.Add("color", OracleType.Int32).Value = idColor;
                comando.Parameters.Add("tv", OracleType.Int32).Value = idTipo_Vehiculo;
                comando.Parameters.Add("vers", OracleType.Int32).Value = idVersion;
                comando.Parameters.Add("est", OracleType.Int32).Value = idEstado;
                comando.Parameters.Add("seguro", OracleType.Float).Value = Convert.ToDouble(cSeguro.Text);
                comando.Parameters.Add("idV", OracleType.Int32).Value = idvehiculo;
                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al actualizar Empleado");
            }
            oracle.Close();
        }

        private void deleteVehiculo()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("rentadora.delete_vehiculo", oracle);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idV", OracleType.Int32).Value = idvehiculo;
                comando.ExecuteNonQuery();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("No se puede eliminar");
            }
        }

        private void delete_auto_Click(object sender, EventArgs e)
        {
            deleteVehiculo();
            idvehiculo = 0;
            mostrarAutos();
        }

        private void editar_auto_Click(object sender, EventArgs e)
        {
            add_auto.Visible = false;
            delete_auto.Visible = false;
            editar_auto.Visible = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
            cargarAutoEditar();
        }

        //HACER TODOS LOS INNER JOIN
        private void cargarAutoEditar()
        {
            oracle.Open();
            OracleCommand comando = new OracleCommand("Select v.vehiculoID, v.costo_renta, v.placa, v.fecha_adquisicion, v.costo_vehiculo, comb.combustible, modelo.modelo,marca.marca,color.color,tv.tipo_vehiculo,vers.version,est.estado,v.seguro from rentadora.vehiculo v INNER JOIN rentadora.combustible comb ON comb.combustibleid = v.combustibleid INNER JOIN rentadora.modelo modelo ON modelo.modeloid = v.modeloid INNER JOIN rentadora.marca marca ON marca.marcaid = v.marcaid INNER JOIN rentadora.color color ON color.colorid = v.colorid INNER JOIN rentadora.tipo_vehiculo tv ON tv.tipo_vehiculoid = v.tipo_vehiculoid INNER JOIN rentadora.version vers ON vers.versionid = v.versionid INNER JOIN rentadora.estado est ON est.estadoid = v.estadoid where v.vehiculoid =" + idvehiculo, oracle);
            OracleDataReader registro = comando.ExecuteReader();
            registro.Read();
            cPlaca.Text = registro["placa"].ToString();
            dpFecha_Adq.Text = registro["fecha_adquisicion"].ToString();
            cCosto_Vehiculo.Text = registro["costo_vehiculo"].ToString();
            cbCombustible.Text = registro["combustible"].ToString();
            cbModelo.Text = registro["modelo"].ToString();
            cbMarca.Text = registro["marca"].ToString();
            cbColor.Text = registro["color"].ToString();
            cbTipo_Vehiculo.Text = registro["tipo_vehiculo"].ToString();
            cb_Version.Text = registro["version"].ToString();
            cbEstado.Text = registro["estado"].ToString();
            cSeguro.Text = registro["seguro"].ToString();
            vCosto_renta.Text = registro["costo_renta"].ToString();

            oracle.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            add_auto.Visible = true;
            delete_auto.Visible = true;
            editar_auto.Visible = true;
            aceptar.Visible = false;
            cancelar.Visible = false;
            limpiarForm();
        }

        private void dgvAutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idvehiculo = Convert.ToInt32(dgvAutos.SelectedRows[0].Cells[0].Value);

            //Label para verificar que se seleccione el empleado con el id correcto
            idAuto.Text = idvehiculo.ToString();
        }
    }
}
