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
    public partial class frmInscAlumnos : Form
    {
        public frmInscAlumnos()
        {
            InitializeComponent();
        }

        public frmInscAlumnos(Usuario usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }

        Usuario usuario;
        CN_Materia CNMaterias = new CN_Materia();
        string descMat = "";
        int idMateria;
        string descComision = "";
        CN_Comisiones CNComisiones = new CN_Comisiones();
        CN_Cursos CNCursos = new CN_Cursos();
        CN_Persona CNPersonas = new CN_Persona();

        private void frmInscAlumnos_Load(object sender, EventArgs e)
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

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            descMat = (string)cmbMaterias.SelectedItem;
            try
            {
                DataTable mat = CNMaterias.mostrarMateria(descMat);
                idMateria = (int)mat.Rows[0]["id_materia"];
                cmbComisiones.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede inscribir a la materia por " + ex.Message);
            }

            cargarOpcionesComisiones();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable com = CNComisiones.mostrarComisionPorDescripcion(descComision);
                List<TPI_Entidades.Curso> cur = CNCursos.buscarCurso(idMateria, (int)com.Rows[0]["id_comision"]);
                CNPersonas.inscribirACurso(usuario.IdPersona, (int)cur[0].IdCurso);
                cmbComisiones.SelectedIndex = -1;
                cmbMaterias.SelectedIndex= -1;
                MessageBox.Show("Inscripcion Realizada");
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
    }
}
