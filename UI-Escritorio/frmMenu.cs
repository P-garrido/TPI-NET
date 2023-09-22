using System.Data;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        Usuario usuario = null;


        frmUsuarios formUsuarios = new frmUsuarios();
        frmIdentificacion formIdentificacion = new frmIdentificacion();

        frmPlanes formPlanes = new frmPlanes();
        frmEspeciaidades formEspecialidades = new frmEspeciaidades();


        frmMaterias formMaterias = new frmMaterias();
        frmComisiones formComisiones = new frmComisiones();
        frmCursos formCursos = new frmCursos();




        CN_Persona CNPersona = new CN_Persona();

        private void tsmAdministrar_Click(object sender, EventArgs e)
        {

            if (formIdentificacion.ShowDialog() == DialogResult.OK)
            {
                formUsuarios.Show();

            }
            else
            {
                formIdentificacion.Hide();
            }




        }


        private void tsmAdminPlanes_Click(object sender, EventArgs e)
        {
            formPlanes.Show();
        }

        private void tsmAdminEsp_Click(object sender, EventArgs e)
        {
            formEspecialidades.Show();

        }
        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMaterias.Show();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formComisiones.Show();
        }

        private void tsmCursos_Click(object sender, EventArgs e)
        {
            formCursos.Show();

        }

        public void obtenerUsuario(Usuario usu)
        {
            usuario = usu;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (CNPersona.buscarPersonaPorId(usuario.IdPersona) == 1)
            {
                //Aca hacemos invisibles/inaccesibles las cosas que el alumno no deba tocar
            }

        }

        private void tsmInscMaterias_Click(object sender, EventArgs e)
        {
            frmInscripcionMaterias formInscripcionMaterias = new frmInscripcionMaterias(usuario);
            formInscripcionMaterias.Show();
        }

        private void tsmInscDocentes_Click(object sender, EventArgs e)
        {
            frmInscripcionDocentes formInscripcionDocentes = new frmInscripcionDocentes(usuario);
            formInscripcionDocentes.Show();
        }

        private void subirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroNotas formRegistroNotas = new frmRegistroNotas(usuario);
            formRegistroNotas.Show();

        }
    }
}