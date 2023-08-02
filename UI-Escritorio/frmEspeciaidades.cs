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
    public partial class frmEspeciaidades : Form
    {

        CN_Especialidad CNEspecialidad = new CN_Especialidad();
        public frmEspeciaidades()
        {
            InitializeComponent();
        }

        private void frmEspeciaidades_Load(object sender, EventArgs e)
        {
            mostrarEspecialidades();
        }

        public void mostrarEspecialidades()
        {
            dgvEspecialidades.DataSource = CNEspecialidad.mostrarEspecialidades();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CNEspecialidad.agregarEspecialidad(txtDescEspecialidad.Text);
            mostrarEspecialidades();
        }
    }
}
