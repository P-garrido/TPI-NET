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
        CN_Especialidad CNEspecialidad = new CN_Especialidad();

        int idEsp;
        int idPlan;

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
            DataTable esp = CNEspecialidad.mostrarEspecialidad(txtdescEsp.Text);
            idEsp = (int)esp.Rows[0]["id_especialidad"];
            CNPlan.agregarPlan(txtDescPlan.Text, idEsp);
            mostrarPlanes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        idPlan = (int)dgvPlanes.CurrentRow.Cells["id_plan"].Value;
                        CNPlan.eliminarPlan(idPlan);
                        MessageBox.Show("Plan eliminado");
                        mostrarPlanes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar el usuario por " + ex);
                    }


                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }
    }
}
