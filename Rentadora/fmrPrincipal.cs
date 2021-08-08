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
    public partial class fmrPrincipal : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);

        public fmrPrincipal()
        {
            InitializeComponent();
            textNameUser.Text = Variable.usuario;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Variable.conexion = "";
            Variable.Login.Show();
            this.Close();
        }

        public void seleccionarBoton(Button sender) {
            solicitud.ForeColor = Color.White;
            cliente.ForeColor = Color.White;
            contrato.ForeColor = Color.White;
            historial.ForeColor = Color.White;
            empleados.ForeColor = Color.White;
            auto.ForeColor = Color.White;
            finalizar.ForeColor = Color.White;
            sender.Capture = true;

            if (sender.Capture) {
                sender.ForeColor = Color.FromArgb(0, 192, 0);
                flecha.Visible = true;
                flecha.Top = sender.Top;
            }
        }

        private void solicitud_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrSolicitudes());
        }

        private void contrato_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrContratos());
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrClientes());
        }

        private void historial_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrHistorial());
        }

        private void empleados_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrEmpleados());
        }

        private void auto_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrAutos());
        }

        private Form formActivado = null;

        private void abrirFormEnPanel(Form formHijo) {
            if (formActivado != null) {
                formActivado.Close();
            }
            formActivado = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            Pfmrs.Controls.Add(formHijo);
            Pfmrs.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            solicitud.ForeColor = Color.White;
            cliente.ForeColor = Color.White;
            contrato.ForeColor = Color.White;
            historial.ForeColor = Color.White;
            empleados.ForeColor = Color.White;
            auto.ForeColor = Color.White;
            finalizar.ForeColor = Color.White;
            flecha.Visible = false;
            if (formActivado != null) {
                formActivado.Close();
            }
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
           
            oracle.Open();
            OracleCommand comando = new OracleCommand("select role from role_sys_privs", oracle);
            OracleDataReader registro =  comando.ExecuteReader();
            registro.Read();
            string rol = registro["role"].ToString();
            oracle.Close();
            if(rol == "LECTURA")
            {
                Variable.controltotal = false;
            }
            else
            {
                Variable.controltotal = true;
            }
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Button)sender);
            abrirFormEnPanel(new fmrFinalizar());
        }

        
    }
}
