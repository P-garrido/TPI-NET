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


        private void tsmAdministrar_Click(object sender, EventArgs e)
        {
            DialogResult registrado = formIdentificacion.ShowDialog();

            if (registrado == DialogResult.OK)
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
    }
}