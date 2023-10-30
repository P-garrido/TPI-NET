using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmInscripcionComisiones : Form
    {

        Usuario usuario;
        int idMateria;
        string descComision = "";
        CN_Comisiones CNComisiones = new CN_Comisiones();
        CN_Cursos CNCursos = new CN_Cursos();
        CN_Persona CNPersonas = new CN_Persona();



        public frmInscripcionComisiones()
        {
            InitializeComponent();
        }
        public frmInscripcionComisiones(int idMat, Usuario usu)
        {
            InitializeComponent();
            idMateria = idMat;
            usuario = usu;
        }

        private void frmInscripcionComisiones_Load(object sender, EventArgs e)
        {
            cargarOpcionesComisiones();

        }

        public void cargarOpcionesComisiones()
        {
            try
            {
                DataTable comisiones = CNCursos.mostrarCursosConCupos(idMateria, usuario.IdPersona);
                for (int i = 0; i < comisiones.Rows.Count; i++)
                {
                    cmbComisiones.Items.Add(comisiones.Rows[i]["desc_comision"].ToString());
                }
                if (cmbComisiones.Items.Count == 0)
                {
                    cmbComisiones.Items.Add("Sin cupos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmbComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            descComision = (string)cmbComisiones.SelectedItem;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable com = CNComisiones.mostrarComisionPorDescripcion(descComision);
                List<TPI_Entidades.Curso> cur = CNCursos.buscarCurso(idMateria, (int)com.Rows[0]["id_comision"]);
                CNPersonas.inscribirACurso(usuario.IdPersona, (int)cur[0].IdCurso);
                MessageBox.Show("Inscripcion Realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
