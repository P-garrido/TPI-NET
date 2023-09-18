using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Entidades;
using TPI_Negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI_Escritorio
{
    public partial class frmDocentesCursos : Form
    {
        Usuario usuario;
        CN_Comisiones CNComisiones = new CN_Comisiones();
        int idMateria;
        string descComision;
        CN_Cursos CNCursos = new CN_Cursos();
        CN_Persona CNPersonas = new CN_Persona();
        int cargo;
        public frmDocentesCursos()
        {
            InitializeComponent();
        }

        public frmDocentesCursos(Usuario usu, int idMat)
        {
            InitializeComponent();
            usuario = usu;
            idMateria = idMat;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable com = CNComisiones.mostrarComisionPorDescripcion(descComision);
                List<TPI_Entidades.Curso> cur = CNCursos.buscarCurso(idMateria, (int)com.Rows[0]["id_comision"]);
                CNPersonas.inscribirDocenteACurso(usuario.IdPersona, (int)cur[0].IdCurso, cargo);
                MessageBox.Show("Inscripcion Realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            descComision =(string) cmbComisiones.SelectedItem;
        }

        private void frmDocentesCursos_Load(object sender, EventArgs e)
        {
            try
            {
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

            cmbCargo.Items.Add("Docente teoría");
            cmbCargo.Items.Add("Docente práctica");
            cmbCargo.Items.Add("Ayudante de cátedra");


        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCargo.SelectedItem)
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
