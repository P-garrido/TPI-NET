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
    public partial class frmInscDocentes : Form
    {
        public frmInscDocentes()
        {
            InitializeComponent();
        }


        public frmInscDocentes(Usuario usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        Usuario usuario;
        CN_Materia CNMateria = new CN_Materia();
        string descMat = "";
        int idMateria;
        string descComision;
        CN_Cursos CNCursos = new CN_Cursos();
        CN_Persona CNPersonas = new CN_Persona();
        CN_Comisiones CNComisiones = new CN_Comisiones();
        int cargo;


        private void frmInscDocentes_Load(object sender, EventArgs e)
        {
            cargarOpcionesMaterias();
            cmbCargos.Items.Add("Docente teoría");
            cmbCargos.Items.Add("Docente práctica");
            cmbCargos.Items.Add("Ayudante de cátedra");
            cmbCargos.Enabled = false;
            cmbComisiones.Enabled = false;
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

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedItem != null)
            {
                descMat = (string)cmbMaterias.SelectedItem;
                cmbComisiones.Enabled = true;
                try
                {
                    DataTable mat = CNMateria.mostrarMateria(descMat);
                    idMateria = (int)mat.Rows[0]["id_materia"];
                    DataTable comisiones = CNCursos.mostrarCursosSinDocentes(idMateria);
                    for (int i = 0; i < comisiones.Rows.Count; i++)
                    {
                        cmbComisiones.Items.Add(comisiones.Rows[i]["desc_comision"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable com = CNComisiones.mostrarComisionPorDescripcion(descComision);
                List<TPI_Entidades.Curso> cur = CNCursos.buscarCurso(idMateria, (int)com.Rows[0]["id_comision"]);
                CNPersonas.inscribirDocenteACurso(usuario.IdPersona, (int)cur[0].IdCurso, cargo);
                MessageBox.Show("Inscripcion Realizada");
                cmbComisiones.SelectedIndex = -1;
                cmbCargos.SelectedIndex = -1;
                cmbMaterias.SelectedIndex = -1;
                cmbComisiones.Enabled = false;
                cmbCargos.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void cmbComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComisiones.SelectedItem != null)
            {
                cmbCargos.Enabled = true;
                descComision = (string)cmbComisiones.SelectedItem;
            }
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCargos.SelectedItem != null)
            {
                switch (cmbCargos.SelectedItem)
                {
                    case "Docente teoría":
                        cargo = 0;
                        break;
                    case "Docente práctica":
                        cargo = 1;
                        break;
                    case "Ayudante de cátedra":
                        cargo = 2;
                        break;

                }
            }
        }
    }
}
