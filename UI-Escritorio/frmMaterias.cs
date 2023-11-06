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
        CN_Persona CNPersona = new CN_Persona();

        int idPla = 0;
        int idMateria = 0;
        string descPla = "";
        Usuario usuario = null;
        public frmMaterias()
        {
            InitializeComponent();
        }
        public frmMaterias(Usuario usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            mostrarMaterias();
            cargarOpcionesPlan();

            if (CNPersona.buscarPersonaPorId(usuario.IdPersona) == 1)
            {
                txtDescripcionMateria.Visible = false;
                lblDescripcionMateria.Visible=false;
                numHorasSemanales.Visible = false;
                numHorasTotales.Visible = false;
                cmbPlan.Visible = false;
                lblDescripcionMateria.Visible = false;
                lblHorasTotales.Visible=false;
                lblPlan.Visible = false;
                frmHorasSemanales.Visible=false;
                btnEditar.Visible=false;
                btnEliminar.Visible=false;
                btnGuardar.Visible=false;
            }
            else
            {
            }
        }

        public void mostrarMaterias()
        {
            dgvMaterias.DataSource = CNMateria.mostrarMateriasCompleto();
        }

        public void cargarOpcionesPlan()
        {
            DataTable planes = CNPlan.mostrarPlanes();
            for (int i = 0; i < planes.Rows.Count; i++)
            {
                cmbPlan.Items.Add(planes.Rows[i]["desc_plan"].ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable pla = CNPlan.mostrarPlan(descPla);
            idPla = (int)pla.Rows[0]["id_plan"];
            CNMateria.agregarMateria(txtDescripcionMateria.Text, Decimal.ToInt32(numHorasSemanales.Value), Decimal.ToInt32(numHorasTotales.Value), idPla);
            mostrarMaterias();
            txtDescripcionMateria.ResetText();
            numHorasTotales.Value = 0;
            numHorasSemanales.Value = 0;
            descPla = "";
            cmbPlan.SelectedIndex = -1;
            cmbPlan.Text = "Elija un plan";
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
                        idMateria = (int)dgvMaterias.CurrentRow.Cells["ID Materia"].Value;
                        CNMateria.eliminarMateria(idMateria);
                        MessageBox.Show("Materia eliminada");
                        mostrarMaterias();
                        txtDescripcionMateria.ResetText();
                        numHorasTotales.Value = 0;
                        numHorasSemanales.Value = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ADVERTENCIA: esta materia no puede ser eliminada en este momento porque" +
                            "existen cursos asociados a ella. Eliminelos e intente de nuevo.");
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
                    if (txtDescripcionMateria.Text == "" || numHorasSemanales.Value == 0 || numHorasTotales.Value == 0 || descPla == "")
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    else
                    {
                        DataTable pla = CNPlan.mostrarPlan(descPla);
                        idPla = (int)pla.Rows[0]["id_plan"];
                        string descMat = (string)dgvMaterias.CurrentRow.Cells["Nombre"].Value;
                        Materia mat = new Materia(txtDescripcionMateria.Text, Decimal.ToInt32(numHorasSemanales.Value), Decimal.ToInt32(numHorasTotales.Value), idPla);
                        CNMateria.actualizarMateria(mat, descMat);
                        mostrarMaterias();
                        txtDescripcionMateria.ResetText();
                        numHorasTotales.Value = 0;
                        numHorasSemanales.Value = 0;
                        descPla = "";
                        cmbPlan.SelectedIndex = -1;
                        cmbPlan.Text = "Elija un plan";
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

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            descPla = (string)cmbPlan.SelectedItem;
        }

        private void frmMaterias_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void dgvMaterias_Click(object sender, EventArgs e)
        {
            txtDescripcionMateria.Text = dgvMaterias.CurrentRow.Cells["Nombre"].Value.ToString();
            numHorasSemanales.Value = Convert.ToDecimal(dgvMaterias.CurrentRow.Cells["Horas Semanales"].Value);
            numHorasTotales.Value = Convert.ToDecimal(dgvMaterias.CurrentRow.Cells["Horas Totales"].Value);
            cmbPlan.SelectedItem = dgvMaterias.CurrentRow.Cells["Plan de Estudios"].Value;
        }

        private void btnBuscarXDesc_Click(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = CNMateria.buscarMateriaPorDescripcionEntidad(txtBuscaXNombre.Text);
            dgvMaterias.Columns["IdMateria"].HeaderText = "ID Materia";
            dgvMaterias.Columns["Descripcion"].HeaderText = "Nombre";
            dgvMaterias.Columns["HorasSemanales"].HeaderText = "Horas Semanales";
            dgvMaterias.Columns["HorasTotales"].HeaderText = "Horas Totales";
            dgvMaterias.Columns["Plan"].HeaderText = "Plan de Estudios";
        }

        private void btnBuscarTodas_Click(object sender, EventArgs e)
        {
            mostrarMaterias();
        }
    }
}
