using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        CN_Usuario CNUsuario = new CN_Usuario();


        private void tsiPorNombreDeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tsiEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsiAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregarUsuario = new frmAgregar();
            frmAgregarUsuario.ShowDialog();
        }

        private void tsiMostrarTodos_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrarTodos = new frmMostrar(); 
            frmMostrarTodos.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}