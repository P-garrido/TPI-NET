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
        string descPlan;
        bool editar;

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
            dgvPlanes.DataSource = CNPlan.mostrarPlanes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!editar)
            {
                try
                {
                    DataTable esp = CNEspecialidad.mostrarEspecialidad(descEsp);
                    idEsp = (int)esp.Rows[0]["id_especialidad"];
                    CNPlan.agregarPlan(txtDescPlan.Text, idEsp);
                    mostrarPlanes();
                    txtDescPlan.Text = "";
                    cmbEspecialidad.SelectedIndex = -1;
                    cmbEspecialidad.Text = "Elija una especialidad";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede insertar el usuario por " + ex);
                }
            }
            else
            {
                try
                {
                    DataTable esp = CNEspecialidad.mostrarEspecialidad(cmbEspecialidad.SelectedItem.ToString());
                    CNPlan.actualizarPlan(descPlan, txtDescPlan.Text, (int)esp.Rows[0]["id_especialidad"]);
                    mostrarPlanes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede actualizar el plan por " + ex);
                }
                finally
                {
                    editar = false;
                }
            }
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

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            descEsp = (string)cmbEspecialidad.SelectedItem;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows.Count > 0)
            {
                txtDescPlan.Text = dgvPlanes.CurrentRow.Cells["desc_plan"].Value.ToString();

                cmbEspecialidad.SelectedIndex = -1;
                descPlan = (string)dgvPlanes.CurrentRow.Cells["desc_plan"].Value;
                editar = true;
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
    }
}
