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
    public partial class fmrDetalleHistorial : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        int idSolicitud = 0;
        int idContrato = 0;
        int idDevolucion = 0;
        int idCliente = 0;
        int idDireccion = 0;
        int idVehiculo = 0;
        int idEmpleado = 0;
        int idSucursal = 0;
        bool seguro = true;
        public fmrDetalleHistorial()
        {
            InitializeComponent();
        }


        private void DetalleHistorial_Load(object sender, EventArgs e)
        {
            try
            {
                oracle.Open();
                OracleCommand comandd = new OracleCommand("select d.devolucionid,d.fecha,d.contratoid,da.grado,da.costo_aproximado from rentadora.devolucion d inner join danio da on da.danioid=d.danioid where devolucionid =" + Variable.id_dev, oracle);
                OracleDataReader registroo = comandd.ExecuteReader();
                registroo.Read();
                nDev.Text = registroo["devolucionid"].ToString();
                dFecha.Text = registroo["fecha"].ToString();
                danios.Text = registroo["grado"].ToString();
                cdanio.Text = registroo["costo_aproximado"].ToString();
                idContrato = Convert.ToInt32(registroo["contratoid"].ToString());


                OracleCommand comand = new OracleCommand("select * from rentadora.contrato where contratoid =" + idContrato, oracle);
                OracleDataReader registro0 = comand.ExecuteReader();
                registro0.Read();
                sSubtotal.Text = registro0["subtotal"].ToString();
                sTotal.Text = registro0["total"].ToString();
                sIVA.Text = registro0["iva"].ToString();
                idSolicitud = Convert.ToInt32(registro0["solicitudid"].ToString());

                OracleCommand comando = new OracleCommand("select * from rentadora.solicitud where solicitudid =" + idSolicitud, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                sNumero.Text = registro["solicitudid"].ToString();
                sFecha.Text = registro["fecha_solicitud"].ToString();
                sInicio.Text = registro["fecharinicio"].ToString();
                sFin.Text = registro["fechafin"].ToString();
                seguroEstado.Text = registro["seguro"].ToString();

                if (seguroEstado.Text == "NO") { seguro = false; }

                idEmpleado = Convert.ToInt32(registro["empleadoid"].ToString());
                idSucursal = Convert.ToInt32(registro["sucursalid"].ToString());
                idVehiculo = Convert.ToInt32(registro["vehiculoid"].ToString());
                idCliente = Convert.ToInt32(registro["clienteid"].ToString());

                OracleCommand comando2 = new OracleCommand("select tp.tipo_pago as tipo from rentadora.pago p inner join rentadora.tipo_pago tp on tp.tipo_pagoid = p.tipo_pagoid where contratoid =" + idContrato, oracle);
                OracleDataReader registro1 = comando2.ExecuteReader();
                registro1.Read();
                tipo_pago.Text = registro1["tipo"].ToString();

                oracle.Close();

                cargarSucursal();
                cargarEmpleado();
                cargarAuto();
                cargarCliente();
                extrasPago();
            }
            catch
            {
                MessageBox.Show("No existe el contrato buscado");
                oracle.Close();
            }
        }

        private void cargarContrato()
        {
            try
            {
                oracle.Open();
                OracleCommand comand = new OracleCommand("select * from rentadora.contrato where contratoid =" + idContrato, oracle);
                OracleDataReader registro0 = comand.ExecuteReader();
                registro0.Read();
                sSubtotal.Text = registro0["subtotal"].ToString();
                sTotal.Text = registro0["total"].ToString();
                sIVA.Text = registro0["iva"].ToString();
                idSolicitud = Convert.ToInt32(registro0["solicitudid"].ToString());

                OracleCommand comando = new OracleCommand("select * from rentadora.solicitud where solicitudid =" + idSolicitud, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                sNumero.Text = registro["solicitudid"].ToString();
                sFecha.Text = registro["fecha_solicitud"].ToString();
                sInicio.Text = registro["fecharinicio"].ToString();
                sFin.Text = registro["fechafin"].ToString();
                seguroEstado.Text = registro["seguro"].ToString();

                if (seguroEstado.Text == "NO") { seguro = false; }

                idEmpleado = Convert.ToInt32(registro["empleadoid"].ToString());
                idSucursal = Convert.ToInt32(registro["sucursalid"].ToString());
                idVehiculo = Convert.ToInt32(registro["vehiculoid"].ToString());
                idCliente = Convert.ToInt32(registro["clienteid"].ToString());

                OracleCommand comando2 = new OracleCommand("select tp.tipo_pago as tipo from rentadora.pago p inner join rentadora.tipo_pago tp on tp.tipo_pagoid = p.tipo_pagoid where contratoid =" + idContrato, oracle);
                OracleDataReader registro1 = comando2.ExecuteReader();
                registro1.Read();
                tipo_pago.Text = registro1["tipo"].ToString();

                oracle.Close();

                cargarSucursal();
                cargarEmpleado();
                cargarAuto();
                cargarCliente();
                extrasPago();
            }
            catch
            {
                MessageBox.Show("No existe el contrato buscado");
                oracle.Close();
            }
        }

        private void extrasPago()
        {
            double subtotal = Convert.ToDouble(sSubtotal.Text);
            double renta = Convert.ToDouble(vCosto.Text);
            double seguro = Convert.ToDouble(vSeguro.Text);
            int dias;
            if (seguroEstado.Text == "SI")
            {
                double aux = renta + seguro;
                dias = Convert.ToInt32(subtotal / aux);

                tVehiculo.Text = (dias * renta).ToString();
                tSeguro.Text = (dias * seguro).ToString();
            }
            else
            {
                dias = Convert.ToInt32(subtotal / renta);

                tVehiculo.Text = (dias * renta).ToString();
                tSeguro.Text = "0";
            }
        }

        private void cargarEmpleado()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.empleado where empleadoid =" + idEmpleado, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                empleado.Text = registro["nombre"].ToString();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar empleado");
                oracle.Close();
            }
        }

        private void cargarSucursal()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.sucursal where sucursalid =" + idSucursal, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                sucursal.Text = registro["sucursal"].ToString();
                oracle.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar sucursal");
                oracle.Close();
            }
        }


        private void cargarAuto()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand(
                    "Select v.costo_renta, v.placa, comb.combustible, modelo.modelo, marca.marca, color.color, vers.version, tp.tipo_vehiculo, v.seguro " +
                    "from rentadora.vehiculo v INNER JOIN rentadora.combustible comb ON comb.combustibleid = v.combustibleid " +
                    "INNER JOIN rentadora.modelo modelo ON modelo.modeloid = v.modeloid " +
                    "INNER JOIN rentadora.marca marca ON marca.marcaid = v.marcaid " +
                    "INNER JOIN rentadora.color color ON color.colorid = v.colorid " +
                    "INNER JOIN rentadora.version vers ON vers.versionid = v.versionid " +
                    "INNER JOIN rentadora.tipo_vehiculo tp ON tp.tipo_vehiculoid = v.tipo_vehiculoid " +
                    "where v.vehiculoid =" + idVehiculo,
                    oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                vPlaca.Text = registro["placa"].ToString();
                vCombustible.Text = registro["combustible"].ToString();
                vModelo.Text = registro["modelo"].ToString();
                vMarca.Text = registro["marca"].ToString();
                vColor.Text = registro["color"].ToString();
                vVersion.Text = registro["version"].ToString();
                vCosto.Text = registro["costo_renta"].ToString();
                vTipo.Text = registro["tipo_vehiculo"].ToString();
                vSeguro.Text = registro["seguro"].ToString();
                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("No se puede cargar auto");
            }
        }

        private void cargarCliente()
        {
            try
            {
                oracle.Open();
                OracleCommand comando = new OracleCommand("select * from rentadora.cliente where clienteid =" + idCliente, oracle);
                OracleDataReader registro = comando.ExecuteReader();
                registro.Read();
                string nombre = registro["p_nombre"].ToString() + " " + registro["s_nombre"].ToString() + " " + registro["p_apellido"].ToString() + " " + registro["s_apellido"].ToString();
                cNombre.Text = nombre;
                cSexo.Text = registro["sexo"].ToString();
                cRTN.Text = registro["rtn"].ToString();
                cID.Text = registro["identidad"].ToString();
                idDireccion = Convert.ToInt32(registro["direccionid"].ToString());


                OracleCommand comando2 = new OracleCommand(
                    "select * from rentadora.direccion dir " +
                    "inner join rentadora.municipio m on m.municipioid = dir.municipioid " +
                    "inner join rentadora.departamento d on d.departamentoid = m.municipioid " +
                    "where dir.direccionid =" + idDireccion,
                    oracle);
                OracleDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();
                string direccion = registro2["municipio"].ToString() + ", " +
                    registro2["departamento"].ToString() + " |  Colonia/Aldea " +
                    registro2["col_aldea"].ToString() + ", Calle " +
                    registro2["calle"].ToString() + ", Casa " +
                    registro2["casa"].ToString();
                cDireccion.Text = direccion;


                OracleCommand comando3 = new OracleCommand("select * from rentadora.telefonoxcliente where clienteid = " + idCliente + "order by pos", oracle);
                OracleDataReader registro3 = comando3.ExecuteReader();
                string telefonos = "";
                while (registro3.Read())
                {
                    telefonos = telefonos + registro3["telefono"].ToString() + "   ";
                }
                cTelefonos.Text = telefonos;

                oracle.Close();
            }
            catch
            {
                oracle.Close();
                MessageBox.Show("No se puede cargar cliente");
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Variable.idsolicitud = 0;
            DialogResult = DialogResult.OK;
        }
    }
}
