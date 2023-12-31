﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmUsuarios : Form
    {
        CN_Usuario CNusuario = new CN_Usuario();
        CN_Persona CNPersona = new CN_Persona();

        string nomUsu = "";
        int idPer;
        Usuario usuario = null;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public frmUsuarios(Usuario usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
            if (usuario==null)
            {

                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                dgvUsuarios.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else if (usuario.IdPersona == -1)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                dgvUsuarios.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtEmail.Text = usuario.Email;
                //txtLegajo.Text = usuario.
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtEmail.Enabled = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }

        }

        public void mostrarUsuarios()
        {
            dgvUsuarios.DataSource = CNusuario.mostrarUsuariosCompleto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable per = CNPersona.mostrarPersona(int.Parse(txtLegajo.Text));
                int idPersona = (int)per.Rows[0]["id_persona"];
                CNusuario.agregarUsuario(txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, idPersona);
                txtNombre.ResetText();
                txtApellido.ResetText();
                txtEmail.ResetText();
                txtLegajo.ResetText();
                txtClave.ResetText();
                txtNombreUsuario.ResetText();
                mostrarUsuarios();
                if(usuario==null || usuario.IdPersona == -1)
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?"
                    , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        nomUsu = (string)dgvUsuarios.CurrentRow.Cells["Nombre de Usuario"].Value;
                        CNusuario.eliminarUsuario(nomUsu);
                        MessageBox.Show("Usuario eliminada");
                        mostrarUsuarios();
                        txtNombre.ResetText();
                        txtApellido.ResetText();
                        txtEmail.ResetText();
                        txtLegajo.ResetText();
                        txtClave.ResetText();
                        txtNombreUsuario.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar el usuario por " + ex);
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
            if (dgvUsuarios.SelectedCells.Count > 0)
            {
                try
                {
                    if (txtNombreUsuario.Text == "" || txtApellido.Text == "" || txtNombre.Text == "" || txtEmail.Text == "" ||
                        txtClave.Text == "" || txtLegajo.Text == "")
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    else
                    {

                        nomUsu = (string)dgvUsuarios.CurrentRow.Cells["Nombre de Usuario"].Value;
                        idPer = (int)dgvUsuarios.CurrentRow.Cells["ID Persona"].Value;
                        Usuario usu = new Usuario(txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, idPer);
                        CNusuario.actualizarUsuario(nomUsu, usu);
                        mostrarUsuarios();
                        txtNombre.ResetText();
                        txtApellido.ResetText();
                        txtEmail.ResetText();
                        txtLegajo.ResetText();
                        txtClave.ResetText();
                        txtNombreUsuario.ResetText();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar el usuario por " + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtClave.Text = dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells["Nombre de Usuario"].Value.ToString();
            txtLegajo.Text = CNPersona.buscarPerPorId((int)dgvUsuarios.CurrentRow.Cells["ID Persona"].Value).Rows[0]["Legajo"].ToString();
        }
    }
}
