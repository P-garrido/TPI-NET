﻿using System;
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
            cargarOpcionesPlan();
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
            txtDescripcionMateria.Text = "";
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
                        txtDescripcionMateria.Text = "";
                        numHorasTotales.Value = 0;
                        numHorasSemanales.Value = 0;
                        descPla = "";
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
    }
}