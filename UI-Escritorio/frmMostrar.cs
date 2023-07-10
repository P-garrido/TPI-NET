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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }
        CN_Usuario CNUsuario = new CN_Usuario();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = CNUsuario.mostrarUsuarios();
        }
    }
}
