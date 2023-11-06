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
    public partial class frmComisiones : Form
    {
        CN_Comisiones CN_Comisiones = new CN_Comisiones();
        CN_Plan CNPlan = new CN_Plan();


        string descPla = "";
        public frmComisiones()
        {
            InitializeComponent();
        }

        private void frmComisiones_Load(object sender, EventArgs e)
        {
            mostrarComisiones();
            cargarOpcionesPlanes();
        }
        public void mostrarComisiones()
        {
            dgvComisiones.DataSource = CN_Comisiones.mostrarComisionesCompleto();
        }

        public void cargarOpcionesPlanes()
        {
            DataTable planes = CNPlan.mostrarPlanes();
            for (int i = 0; i < planes.Rows.Count; i++)
            {
                cmbPlanes.Items.Add(planes.Rows[i]["desc_plan"].ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable pl = CNPlan.mostrarPlan(descPla);
            int planId = (int)pl.Rows[0]["id_plan"];
            CN_Comisiones.agregarComision(txtDescripcion.Text, int.Parse(txtAnioEsp.Text), planId);
            txtDescripcion.Text = "";
            txtAnioEsp.Text = "";
            cmbPlanes.SelectedIndex = -1;
            mostrarComisiones();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        int idCom = (int)dgvComisiones.CurrentRow.Cells["ID Comision"].Value;
                        CN_Comisiones.eliminarComision(idCom);
                        MessageBox.Show("Comision eliminada");
                        mostrarComisiones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ADVERTENCIA: esta comisión no puede ser eliminada en este momento porque" +
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
            if (dgvComisiones.SelectedCells.Count > 0)
            {
                if (txtDescripcion.Text == "" || txtDescripcion.Text == "" || descPla == "")
                {
                    MessageBox.Show("Complete todos los campos");
                }
                else
                {
                    int idCom = (int)dgvComisiones.CurrentRow.Cells["ID Comision"].Value;
                    int idPlan = (int)CNPlan.mostrarPlan(cmbPlanes.SelectedItem.ToString()).Rows[0]["id_plan"];
                    Comision comision = new Comision(txtDescripcion.Text, int.Parse(txtAnioEsp.Text), idPlan);
                    CN_Comisiones.actualizarComision(idCom, comision);
                    mostrarComisiones();
                    txtDescripcion.ResetText();
                    txtAnioEsp.ResetText();
                    cmbPlanes.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void frmComisiones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            descPla = (string)cmbPlanes.SelectedItem;
        }

        private void dgvComisiones_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = dgvComisiones.CurrentRow.Cells["Descripción"].Value.ToString();
            txtAnioEsp.Text = dgvComisiones.CurrentRow.Cells["Año Especialidad"].Value.ToString();
            cmbPlanes.SelectedItem = dgvComisiones.CurrentRow.Cells["Plan de Estudios"].Value;
        }
    }
}
