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
    }
}