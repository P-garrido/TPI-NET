using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmUsuarios : Form
    {
        CN_Usuario CNusuario = new CN_Usuario();
        CN_Persona CNPersona = new CN_Persona();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        public void mostrarUsuarios()
        {
            dgvUsuarios.DataSource = CNusuario.mostrarUsuarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable per = CNPersona.mostrarPersona(int.Parse(txtLegajo.Text));
            int idPersona = (int)per.Rows[0]["id_persona"];
            CNusuario.agregarUsuario(txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, idPersona);
            txtLegajo.Text = "";
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtClave.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            mostrarUsuarios();
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
