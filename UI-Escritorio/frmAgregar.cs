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
    public partial class frmAgregar : Form
    {
        public CN_Usuario CNUsuario { get; }

        public frmAgregar(CN_Usuario CNUsuario)
        {
            InitializeComponent();
            this.CNUsuario = CNUsuario;
        }


        private void frmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CNUsuario.agregarUsuario(txtNombreUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text);
        }
    }
}
