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

            if (txtDescEspecialidad.Text != "")
                try
                {
                    CNEspecialidad.agregarEspecialidad(txtDescEspecialidad.Text);
                    mostrarEspecialidades();
                    txtDescEspecialidad.ResetText();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede insertar la especialidad por " + ex);
                }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows.Count > 0)
            {
                if (txtDescEspecialidad.Text == "")
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    try
                    {
                        descEsp = (string)dgvEspecialidades.CurrentRow.Cells["Descripción"].Value;
                        CNEspecialidad.actualizarEspecialidad(descEsp, txtDescEspecialidad.Text);
                        mostrarEspecialidades();
                        txtDescEspecialidad.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede actualizar el plan por " + ex);
                    }
                }
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
                        descEsp = (string)dgvEspecialidades.CurrentRow.Cells["Descripción"].Value;
                        CNEspecialidad.eliminarEspecialidad(descEsp);
                        MessageBox.Show("Especialidad eliminada");
                        mostrarEspecialidades();
                        txtDescEspecialidad.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ADVERTENCIA: esta especialidad no puede ser eliminada en este momento porque " +
                            "existen planes asociados a ella. Eliminelos e intente de nuevo. ");
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

        private void dgvEspecialidades_Click(object sender, EventArgs e)
        {
            txtDescEspecialidad.Text = dgvEspecialidades.CurrentRow.Cells["Descripción"].Value.ToString();
        }
    }
}
