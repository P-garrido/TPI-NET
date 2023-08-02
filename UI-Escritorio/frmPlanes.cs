using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmPlanes : Form
    {

        CN_Plan CNPlan = new CN_Plan();
        public frmPlanes()
        {
            InitializeComponent();
        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {
            mostrarPlanes();
        }

        public void mostrarPlanes()
        {
            dgvPlanes.DataSource = CNPlan.mostrarPlanes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEsp = 0;
            CNPlan.agregarPlan(txtDescPlan.Text, idEsp);
            mostrarPlanes();
        }
    }
}
