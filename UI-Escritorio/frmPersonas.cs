using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Datos;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmPersonas : Form
    {
        CN_Persona CNPersona = new CN_Persona();
        CN_Plan CNPlan = new CN_Plan();
        CN_Usuario CNUsuario = new CN_Usuario();

        string descPla = "";
        string nomPersona = "";
        int idPla = 0;
        string nomPer = "";
        DateTime fechaNac;
        int anio;
        int mes;
        int dia;
        string stringFecha = "";
        int tipoPer;
        Usuario usuario = null;
        int idPer;

        public frmPersonas()
        {
            InitializeComponent();
        }

        public frmPersonas(Usuario usu)
        {
            InitializeComponent();
            this.usuario = usu;
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            mostrarPersonas();
            cargarOpcionesPlan();
            cargarOpcionesTipoPersona();

            if (usuario == null)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                dgvPersonas.Visible = false;
                cmbTipoPersona.Enabled = false;
                cmbTipoPersona.SelectedItem = "Alumno";

                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }


        }

        public void cargarOpcionesPlan()
        {
            DataTable planes = CNPlan.mostrarPlanes();
            for (int i = 0; i < planes.Rows.Count; i++)
            {
                cmbPlanes.Items.Add(planes.Rows[i]["desc_plan"].ToString());
            }
        }

        public void cargarOpcionesTipoPersona()
        {
            cmbTipoPersona.Items.Add("Docente");
            cmbTipoPersona.Items.Add("Alumno");
        }

        public void mostrarPersonas()
        {
            dgvPersonas.DataSource = CNPersona.mostrarPersonasCompleto();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable plan = CNPlan.mostrarPlan(descPla);
            int idPlan = (int)plan.Rows[0]["id_plan"];
            CNPersona.agregarPersona(txtApellido.Text, txtDireccion.Text, txtEmail.Text, DateTime.Parse(stringFecha), idPlan, int.Parse(txtLegajo.Text), txtNombre.Text, txtTelefono.Text, tipoPer);
            
            if (usuario == null)
            {
                Usuario usu = new Usuario(null, null, txtNombre.Text, txtApellido.Text, txtEmail.Text, -1);
                frmUsuarios formUsuarios = new frmUsuarios(usu);
                formUsuarios.Show();
                this.Dispose();
            }
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtDireccion.ResetText();
            txtEmail.ResetText();
            txtTelefono.ResetText();
            dtpFechaNac.Value = DateTime.Now;
            cmbTipoPersona.SelectedIndex = -1;
            txtLegajo.ResetText();
            cmbPlanes.SelectedIndex = -1;
            mostrarPersonas();
        }

        private void frmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedCells.Count>0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro? Tambien se borrarán todos los usuarios e inscripciones vinculados a esta persona"
                    , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        nomPersona = (string)dgvPersonas.CurrentRow.Cells["Nombre"].Value;
                        CNUsuario.eliminarUsuariosDePersona((int)dgvPersonas.CurrentRow.Cells["ID Persona"].Value);
                        CNPersona.eliminarInscripcionesDePersona((int)dgvPersonas.CurrentRow.Cells["ID Persona"].Value, (int)dgvPersonas.CurrentRow.Cells["Tipo de Persona"].Value);
                        CNPersona.eliminarPersona((int)dgvPersonas.CurrentRow.Cells["ID Persona"].Value);
                        MessageBox.Show("Persona eliminada");
                        mostrarPersonas();
                        txtNombre.ResetText();
                        txtApellido.ResetText();
                        txtDireccion.ResetText();
                        txtEmail.ResetText();
                        txtTelefono.ResetText();
                        dtpFechaNac.Value = DateTime.Now;
                        cmbTipoPersona.SelectedIndex = -1;
                        txtLegajo.ResetText();
                        cmbPlanes.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar la persona por " + ex);
                    }


                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        //SIN TERMINAR: en el segundo if siempre sale por descPla == "", no encuetro porque, y aun al sacar esa condicion salta error
        // no item at position 0. Empezar devuelta?
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedCells.Count > 0)
            {
                try
                {
                    if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtEmail.Text == "" ||
                        txtTelefono.Text == "" || cmbTipoPersona.SelectedIndex == -1 || txtLegajo.Text == ""
                        || descPla == "")
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    else
                    {
                        DataTable pla = CNPlan.mostrarPlan(descPla);
                        idPla = (int)pla.Rows[0]["id_plan"];
                        idPer = (int)dgvPersonas.CurrentRow.Cells["ID Persona"].Value;
                        Persona per = new Persona(txtApellido.Text, txtDireccion.Text, txtEmail.Text, DateTime.Parse(stringFecha), idPla,
                            int.Parse(txtLegajo.Text), txtNombre.Text, txtTelefono.Text, cmbTipoPersona.SelectedItem.ToString() == "Docente"? 0 : 1);
                        CNPersona.actualizarPersona(idPer, per);
                        mostrarPersonas();
                        txtNombre.ResetText();
                        txtApellido.ResetText();
                        txtDireccion.ResetText();
                        txtEmail.ResetText();
                        txtTelefono.ResetText();
                        dtpFechaNac.Value = DateTime.Now;
                        cmbTipoPersona.SelectedIndex = -1;
                        txtLegajo.ResetText();
                        cmbPlanes.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar la persona por " + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }


        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            descPla = (string)cmbPlanes.SelectedItem;
        }

        private void cmbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbTipoPersona.SelectedItem == "Alumno")
            {
                tipoPer = 1;
            }
            else
            {
                tipoPer = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaNac = dtpFechaNac.Value;
            anio = fechaNac.Year;
            mes = fechaNac.Month;
            dia = fechaNac.Day;
            stringFecha = anio.ToString() + '/' + mes.ToString() + '/' + dia.ToString();
        }

        private void dgvPersonas_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvPersonas.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDireccion.Text = dgvPersonas.CurrentRow.Cells["Dirección"].Value.ToString();
            txtEmail.Text = dgvPersonas.CurrentRow.Cells["Email"].Value.ToString();
            txtLegajo.Text = dgvPersonas.CurrentRow.Cells["Legajo"].Value.ToString();
            txtTelefono.Text = dgvPersonas.CurrentRow.Cells["Teléfono"].Value.ToString();
            cmbPlanes.SelectedItem = dgvPersonas.CurrentRow.Cells["Plan"].Value;
            dtpFechaNac.Value = Convert.ToDateTime(dgvPersonas.CurrentRow.Cells["Fecha de Nacimiento"].Value);
            if ((int)dgvPersonas.CurrentRow.Cells["Tipo de Persona"].Value == 0)
            {
                cmbTipoPersona.SelectedItem = "Docente";
            }
            else
            {
                cmbTipoPersona.SelectedItem = "Alumno";
            }
        }
    }
}
