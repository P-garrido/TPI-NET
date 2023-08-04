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
                formIdentificacion.Dispose();
            }




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