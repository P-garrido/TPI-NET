namespace UI_Escritorio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        frmUsuarios formUsuarios = new frmUsuarios();
        frmIdentificacion formIdentificacion = new frmIdentificacion();

        frmPlanes formPlanes = new frmPlanes();
        frmEspeciaidades formEspecialidades = new frmEspeciaidades();


        frmMaterias formMaterias = new frmMaterias();
        frmComisiones formComisiones = new frmComisiones();
        frmCursos formCursos = new frmCursos();

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
    }
}