using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Datos;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmEspeciaidades : Form
    {

        CN_Especialidad CNEspecialidad = new CN_Especialidad();

        bool editar;
        string descEsp;
        public frmEspeciaidades()
        {
            InitializeComponent();
        }

        private void frmEspeciaidades_Load(object sender, EventArgs e)
        {
            mostrarEspecialidades();
        }

        public void mostrarEspecialidades()
        {
            dgvEspecialidades.DataSource = CNEspecialidad.mostrarEspecialidadesCompleto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!editar)
            {
                try
                {
                    CNEspecialidad.agregarEspecialidad(txtDescEspecialidad.Text);
                    mostrarEspecialidades();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede insertar la especialidad por " + ex);
                }
            }
            else
            {
                try
                {
                    CNEspecialidad.actualizarEspecialidad(descEsp, txtDescEspecialidad.Text);
                    mostrarEspecialidades();
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


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                descEsp = dgvEspecialidades.CurrentRow.Cells["desc_especialidad"].Value.ToString();
                txtDescEspecialidad.Text = descEsp;
                editar = true;
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        descEsp = (string)dgvEspecialidades.CurrentRow.Cells["desc_especialidad"].Value;
                        CNEspecialidad.eliminarEspecialidad(descEsp);
                        MessageBox.Show("Especialidad eliminada");
                        mostrarEspecialidades();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar la especialidad por " + ex);
                    }


                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void frmEspeciaidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
