using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmMenu : Form
    {
        CN_Usuario CNUsuario = new CN_Usuario();

        public frmMenu()
        {
            InitializeComponent();
            CNUsuario.inicializar();
        }
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsiAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}