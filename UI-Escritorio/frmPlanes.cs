using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmPlanes : Form
    {

        CN_Plan CNPlan = new CN_Plan();
        CN_Especialidad CNEspecialidad = new CN_Especialidad();
        string descEsp = "";

        int idEsp;
        int idPlan;
        int idPlaViejo;

        public frmPlanes()
        {
            InitializeComponent();
        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {
            mostrarPlanes();
            cargarOpcionesEspecialidades();
        }

        public void cargarOpcionesEspecialidades()
        {
            DataTable especialidades = CNEspecialidad.mostrarEspecialidades();
            for (int i = 0; i < especialidades.Rows.Count; i++)
            {
                cmbEspecialidad.Items.Add(especialidades.Rows[i]["desc_especialidad"].ToString());
            }
        }

        public void mostrarPlanes()
        {
            dgvPlanes.DataSource = CNPlan.mostrarPlanesCompleto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                try
                {
                    DataTable esp = CNEspecialidad.mostrarEspecialidad(descEsp);
                    idEsp = (int)esp.Rows[0]["id_especialidad"];
                    CNPlan.agregarPlan(txtDescPlan.Text, idEsp);
                    mostrarPlanes();
                    txtDescPlan.ResetText();
                    cmbEspecialidad.SelectedIndex = -1;
                    cmbEspecialidad.Text = "Elija una especialidad";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede insertar el usuario por " + ex);
                }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        idPlan = (int)dgvPlanes.CurrentRow.Cells["ID Plan"].Value;
                        CNPlan.eliminarPlan(idPlan);
                        MessageBox.Show("Plan eliminado");
                        mostrarPlanes();
                        txtDescPlan.ResetText();
                        cmbEspecialidad.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ADVERTENCIA: no se puede eliminar este plan es este momento porque" +
                            "existen personas, comisiones y/o materias asociados a el. Eliminelos e intente de nuevo.");
                    }


                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            descEsp = (string)cmbEspecialidad.SelectedItem;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedCells.Count > 0)
            {
                try
                {
                    DataTable esp = CNEspecialidad.mostrarEspecialidad(cmbEspecialidad.SelectedItem.ToString());
                    CNPlan.actualizarPlan(idPlaViejo, txtDescPlan.Text, (int)esp.Rows[0]["id_especialidad"]);
                    mostrarPlanes();
                    txtDescPlan.ResetText();
                    cmbEspecialidad.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede actualizar el plan por " + ex);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void frmPlanes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dgvPlanes_Click(object sender, EventArgs e)
        {
            idPlaViejo = (int)dgvPlanes.CurrentRow.Cells["ID Plan"].Value;
            txtDescPlan.Text = dgvPlanes.CurrentRow.Cells["Descripción"].Value.ToString();
            cmbEspecialidad.SelectedItem = dgvPlanes.CurrentRow.Cells["Especialidad"].Value;
        }
    }
}
