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
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmPersonas : Form
    {
        CN_Persona CNPersona = new CN_Persona();
        CN_Plan CNPlan = new CN_Plan();
        CN_Usuario CNUsuario = new CN_Usuario();

        string descPla = "";
        string nomPersona = "";
        int idPla = 0;
        string nomPer = "";
        DateTime fechaNac;
        int anio;
        int mes;
        int dia;
        string stringFecha = "";
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            mostrarPersonas();
            cargarOpcionesPlan();

        }

        public void cargarOpcionesPlan()
        {
            DataTable planes = CNPlan.mostrarPlanes();
            for (int i = 0; i < planes.Rows.Count; i++)
            {
                cmbPlanes.Items.Add(planes.Rows[i]["desc_plan"].ToString());
            }
        }

        public void mostrarPersonas()
        {
            dgvPersonas.DataSource = CNPersona.mostrarPersonasCompleto();
        }


        //Preguntar a Porta: No funciona el datetime.parse. me quiero suicidar. ultimo aviso no joke
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable plan = CNPlan.mostrarPlan(descPla);
            int idPlan = (int)plan.Rows[0]["id_plan"];
            CNPersona.agregarPersona(txtApellido.Text, txtDireccion.Text, txtEmail.Text, DateTime.Parse(numAño.Value.ToString() +
                 '-' + numMes.Value.ToString() + '-' + numDia.Value.ToString()), idPlan, int.Parse(txtLegajo.Text), txtNombre.Text, txtTelefono.Text, int.Parse(txtTipoPersona.Text));
            txtLegajo.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            stringFecha = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtTipoPersona.Text = "";
            mostrarPersonas();
        }

        private void frmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro? Tambien se borrarán todos los usuarios vinculados a esta persona"
                    , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        nomPersona = (string)dgvPersonas.CurrentRow.Cells["Nombre"].Value;
                        CNUsuario.eliminarUsuariosDePersona((int)dgvPersonas.CurrentRow.Cells["ID Persona"].Value);
                        CNPersona.eliminarPersona(nomPersona);
                        MessageBox.Show("Persona eliminada");
                        mostrarPersonas();
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

        //SIN TERMINAR: en el segundo if siempre sale por descPla == "", no encuetro porque, y aun al sacar esa condicion salta error
        // no item at position 0. Empezar devuelta?
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (dgvPersonas.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtEmail.Text == "" || 
            //            txtTelefono.Text == "" || txtFechaNac.Text == "" || txtTipoPersona.Text == "" || txtLegajo.Text == "" 
            //            || descPla == "")
            //        {
            //            MessageBox.Show("Complete todos los campos");
            //        }
            //        else
            //        {
            //            DataTable pla = CNPlan.mostrarPlan(descPla);
            //            idPla = (int)pla.Rows[0]["id_plan"];
            //            nomPer = (string)dgvPersonas.CurrentRow.Cells["Nombre"].Value;
            //            Persona per = new Persona(txtApellido.Text, txtDireccion.Text,txtEmail.Text, DateTime.Parse(txtFechaNac.Text), idPla,
            //                int.Parse(txtLegajo.Text), txtNombre.Text, txtTelefono.Text, (int) dgvPersonas.CurrentRow.Cells["Tipo de Persona"].Value);
            //            CNPersona.actualizarPersona(nomPer, per);
            //            mostrarPersonas();
            //            txtNombre.Text = "";
            //            txtApellido.Text = "";
            //            txtDireccion.Text = "";
            //            txtEmail.Text = "";
            //            txtTelefono.Text = "";
            //            txtFechaNac.Text = "";
            //            txtTipoPersona.Text = "";
            //            txtLegajo.Text = "";
            //            cmbPlanes.SelectedIndex = -1;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("No se puede editar la materia por " + ex);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila");
            //}
        }


        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            descPla = (string)cmbPlanes.SelectedItem;
        }
    }
}
