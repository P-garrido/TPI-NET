﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Escritorio
{
    public partial class frmIdentificacion : Form
    {

        frmPersonas formPersonas = new frmPersonas();
        frmUsuarios formUsuarios = new frmUsuarios();  
        public frmIdentificacion()
        {
            InitializeComponent();
        }

        private void btnNoRegistrado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            formPersonas.Show();
        }

        private void btnRegistrado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            formUsuarios.Show();
        }

        private void frmIdentificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
