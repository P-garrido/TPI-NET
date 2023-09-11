﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Negocios;
using TPI_Entidades;

namespace UI_Escritorio
{
    public partial class frmLogin : Form
    {
        CN_Usuario CNUsuario = new CN_Usuario();
        Usuario usuarioLogueado = null;
        frmIdentificacion formIdentificacion = new frmIdentificacion();
        frmMenu formMenu = new frmMenu();
        frmUsuarios formUsuarios = new frmUsuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lklCrearUsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formIdentificacion.ShowDialog();
            //if (formIdentificacion.ShowDialog() == DialogResult.OK)
            //{
            //    formUsuarios.Show();

            //}
            //else
            //{
            //    formIdentificacion.Hide();
            //}
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioLogueado = CNUsuario.validarUsuario(txtNomUsuario.Text, txtPass.Text);
                if (usuarioLogueado == null)
                {
                    throw new Exception("Usuario inexistente");
                }
                else
                {
                    this.Hide();
                    formMenu.obtenerUsuario(usuarioLogueado);
                    formMenu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
