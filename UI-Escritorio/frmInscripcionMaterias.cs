using System;
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
    public partial class frmInscripcionMaterias : Form
    {

        Usuario usuario;
        CN_Materia CNMaterias = new CN_Materia();
        string descMat = "";

        public frmInscripcionMaterias()
        {
            InitializeComponent();
        }
        public frmInscripcionMaterias(Usuario usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmInscripcionMaterias_Load(object sender, EventArgs e)
        {
            cargarOpcionesMaterias();
        }

        public void cargarOpcionesMaterias()
        {
            try
            {
                DataTable materias = CNMaterias.mostrarMaterias();
                for (int i = 0; i < materias.Rows.Count; i++)
                {
                    cmbMaterias.Items.Add(materias.Rows[i]["desc_materia"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable mat = CNMaterias.mostrarMateria(descMat);
                int idMat = (int)mat.Rows[0]["id_materia"];
                frmInscripcionComisiones formInscripcionComisiones = new frmInscripcionComisiones(idMat, usuario);
                formInscripcionComisiones.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede inscribir a la materia por " + ex.Message);
            }
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            descMat = (string)cmbMaterias.SelectedItem;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
