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
    public partial class fmrHistorial : Form
    {
        private OracleConnection oracle = new OracleConnection(Variable.conexion);
        int idSolicitud = 0;
        public fmrHistorial()
        {
            InitializeComponent();
        }

        private void fmrHistorial_Load(object sender, EventArgs e)
        {

        }

        private void Detalles_Click(object sender, EventArgs e)
        {
            if (idSolicitud != 0)
            {
                Variable.idsolicitud = idSolicitud;
                fmrDetalleHistorial abrir = new fmrDetalleHistorial();
                abrir.ShowDialog();
            }
        }
    }
}
