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
    public partial class frmComisiones : Form
    {
        CN_Comisiones CN_Comisiones = new CN_Comisiones();
        CN_Plan CN_Plan = new CN_Plan();
        public frmComisiones()
        {
            InitializeComponent();
        }

        private void frmComisiones_Load(object sender, EventArgs e)
        {
            mostrarComisiones();
        }
        public void mostrarComisiones()
        {
            dgvComisiones.DataSource = CN_Comisiones.mostrarComisiones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable pl = CN_Plan.mostrarPlan(txtPlan.Text);
            int planId = (int)pl.Rows[0]["id_plan"];
            CN_Comisiones.agregarComision(txtDescripcion.Text, DateOnly.Parse(txtAnioEsp.Text),planId);
            txtDescripcion.Text = "";
            txtAnioEsp.Text = "";
            txtPlan.Text = "";

        }
    }
}
