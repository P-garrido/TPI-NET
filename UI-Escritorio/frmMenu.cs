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

        frmIdentificacion formIdentificacion = new frmIdentificacion();

        CN_Persona CNPersona = new CN_Persona();

        private void tsmAdministrar_Click(object sender, EventArgs e)
        {

            if (formIdentificacion.ShowDialog() == DialogResult.OK)
            {
                abrirFormularioHijo(new frmUsuarios());

            }
            else
            {
                abrirFormularioHijo(new frmPersonas());
            }




        }




        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmMaterias());
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmComisiones());
        }

        private void tsmCursos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmCursos());
        }

        public void obtenerUsuario(Usuario usu)
        {
            usuario = usu;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (CNPersona.buscarPersonaPorId(usuario.IdPersona) == 1)
            {
                tsmEspecialidades.Visible = false;
                tsmCursos.Visible = false;
                tsmInscDocentes.Visible = false;
                tsmComisiones.Visible = false;
                tsmPlanes.Visible = false;
                subirNotasToolStripMenuItem.Visible = false;
                personasToolStripMenuItem.Visible = false;
                tsmUsuarios.Visible = false;
            }
            else
            {
                tsmInscMaterias.Visible = false;
            }

        }

        private void tsmInscMaterias_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmInscAlumnos(usuario));
        }

        public void abrirFormularioHijo(object formHijo)
        {
            if (this.panMenu.Controls.Count > 0)
            {
                this.panMenu.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panMenu.Controls.Add(fh);
            panMenu.Tag = fh;
            fh.Show();
        }

        private void tsmInscDocentes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmInscDocentes(usuario));
        }


        private void subirNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmRegistroNotas(usuario));
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnReporteCursos_Click(object sender, EventArgs e)
        {
            frmReporteCursos formReporteCursos = new frmReporteCursos();
            formReporteCursos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportePlanes formReportePlanes = new frmReportePlanes();
            formReportePlanes.Show();
        }

        private void tsmUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmUsuarios(usuario));
        }

        private void tsmPlanes_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPlanes());
        }

        private void tsmEspecialidades_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmEspeciaidades());
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new frmPersonas(usuario));
        }
    }
}