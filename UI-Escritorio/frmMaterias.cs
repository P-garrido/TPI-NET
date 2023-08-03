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
using TPI_Negocios;
using TPI_Entidades;

namespace UI_Escritorio
{
    public partial class frmMaterias : Form
    {
        CN_Materia CNMateria = new CN_Materia();
        CN_Plan CNPlan = new CN_Plan();

        int idPla = 0;
        int idMateria = 0;
        string descPla = "";
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            mostrarMaterias();
        }

        public void mostrarMaterias()
        {
            dgvMaterias.DataSource = CNMateria.mostrarMaterias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable pla = CNPlan.mostrarPlan(txtPlan.Text);
            idPla = (int)pla.Rows[0]["id_plan"];
            CNMateria.agregarMateria(txtDescripcionMateria.Text, txtHorasSemanales.Text, txtHorasTotales.Text, idPla);
            mostrarMaterias();
            txtDescripcionMateria.Text = "";
            txtHorasTotales.Text = "";
            txtHorasSemanales.Text = "";
            txtPlan.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        idMateria = (int)dgvMaterias.CurrentRow.Cells["id_materia"].Value;
                        CNMateria.eliminarMateria(idMateria);
                        MessageBox.Show("Materia eliminada");
                        mostrarMaterias();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar la materia por " + ex);
                    }


                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                    try
                    {
                        if (txtDescripcionMateria.Text == "" || txtHorasSemanales.Text == "" || txtHorasTotales.Text == "" || txtPlan.Text == "")
                        {
                            MessageBox.Show("Complete todos los campos");
                        }
                        else
                        {
                            DataTable pla = CNPlan.mostrarPlan(txtPlan.Text);
                            idPla = (int)pla.Rows[0]["id_plan"];
                            string descMat = (string) dgvMaterias.CurrentRow.Cells["desc_materia"].Value;
                            Materia mat = new Materia(txtDescripcionMateria.Text, int.Parse(txtHorasSemanales.Text), int.Parse(txtHorasTotales.Text), idPla);
                            CNMateria.actualizarMateria(mat, descMat);
                            mostrarMaterias();
                            txtDescripcionMateria.Text = "";
                            txtHorasTotales.Text = "";
                            txtHorasSemanales.Text = "";
                            txtPlan.Text = "";
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede editar la materia por " + ex);
                    }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
