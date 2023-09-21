using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmInscripcionDocentes : Form
    {
        Usuario usuario;
        CN_Materia CNMateria = new CN_Materia();
        string descMat = "";
        public frmInscripcionDocentes()
        {
            InitializeComponent();
        }
        public frmInscripcionDocentes(Usuario usu)
        {
            InitializeComponent();
            usuario = usu;
        }


        private void frmInscripcionDocentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            descMat = (string)cmbMaterias.SelectedItem;
        }

        private void frmInscripcionDocentes_Load(object sender, EventArgs e)
        {
            cargarOpcionesMaterias();
        }

        public void cargarOpcionesMaterias()
        {
            try
            {
                DataTable materias = CNMateria.mostrarMaterias();
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
            DataTable mat = CNMateria.mostrarMateria(descMat);
            int idMat = (int)mat.Rows[0]["id_materia"];
            frmDocentesCursos formDocentesCursos = new frmDocentesCursos(usuario, idMat);
            formDocentesCursos.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
