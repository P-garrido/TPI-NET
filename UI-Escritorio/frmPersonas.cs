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
    public partial class frmPersonas : Form
    {
        CN_Persona CNPersona = new CN_Persona();
        CN_Plan CNPlan = new CN_Plan();
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            mostrarPersonas();

        }

        public void mostrarPersonas()
        {
            dgvPersonas.DataSource = CNPersona.mostrarPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable plan = CNPlan.mostrarPlan(txtPlan.Text);
            int idPlan = (int)plan.Rows[0]["id_plan"];
            CNPersona.agregarPersona(txtApellido.Text, txtDireccion.Text, txtEmail.Text, DateTime.Parse(txtFechaNac.Text), idPlan,int.Parse(txtLegajo.Text), txtNombre.Text, txtTelefono.Text, int.Parse(txtTipoPersona.Text));
            txtLegajo.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtFechaNac.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtTipoPersona.Text = "";
            txtPlan.Text = "";
            mostrarPersonas();
        }
    }
}
