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

namespace UI_Escritorio
{
    public partial class frmRegistroNotas : Form
    {
        Usuario usuario;
        CN_Comisiones CNComision = new CN_Comisiones();
        CN_Materia CNMateria = new CN_Materia();
        CN_Persona CNPersona = new CN_Persona();
        CN_Cursos CNCurso = new CN_Cursos();
        int idComSeleccionada;
        int idMatSeleccionada;
        Persona alumno;
        public frmRegistroNotas()
        {
            InitializeComponent();
        }
        public frmRegistroNotas(Usuario usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void frmRegistroNotas_Load(object sender, EventArgs e)
        {
            cargarOpcionesComisiones();
        }

        public void cargarOpcionesComisiones()
        {
            List<Comision> comisiones = CNComision.buscarComisionesPorDocente(usuario);
            foreach (var comision in comisiones)
            {
                cmbComision.Items.Add(comision.Descripcion);
            }
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbAlumno.Enabled)
            {
                cmbAlumno.Enabled = true;
            }
            if (cmbAlumno.Items.Count != 0)
            {
                cmbAlumno.Items.Clear();
            }
            Materia materia = CNMateria.buscarMateriaPorDescripcion(cmbMateria.SelectedItem.ToString());
            idMatSeleccionada = materia.IdMateria;
            cargarOpcionesAlumnos(idComSeleccionada, idMatSeleccionada);
        }

        public void cargarOpcionesAlumnos(int idCom, int idMat)
        {
            List<Persona> alumnos = CNPersona.buscarAlumnosCursando(idCom, idMat);
            foreach (var alumno in alumnos)
            {
                cmbAlumno.Items.Add(alumno.Nombre + ' ' + alumno.Apellido);
            }
        }

        public void cargarOpcionesMaterias(int idCom)
        {
            List<Materia> materias = CNMateria.buscarMateriasPorComision(idCom);
            foreach (var materia in materias)
            {
                cmbMateria.Items.Add(materia.Descripcion);
            }
        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbMateria.Enabled)
            {
                cmbMateria.Enabled = true;
            }
            if (cmbMateria.Items.Count != 0)
            {
                cmbMateria.Items.Clear();
            }
            Comision comision = CNComision.buscarComisionPorDescripcion(cmbComision.SelectedItem.ToString());
            idComSeleccionada = comision.IdComision;
            cargarOpcionesMaterias(comision.IdComision);
        }

        private void cmbAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            alumno = CNPersona.buscarAlumnoNombreApellido(cmbAlumno.SelectedItem.ToString());
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            AlumnoInscripcion inscripcion = CNCurso.buscarInscripcion(alumno, idComSeleccionada, idMatSeleccionada);
            CNPersona.actualizarNota(inscripcion, (int)numNota.Value);
            MessageBox.Show("Nota Registrada Exitosamente");
            numNota.Value = numNota.Minimum;
            // CAMBIAR LAS PROXIMAS LINEAS TAL QUE VUELVAN AL INDEX -1
            cmbAlumno.SelectedIndex = 0;
            cmbComision.SelectedIndex = 0;
            cmbMateria.SelectedIndex = 0;
        }
    }
}
