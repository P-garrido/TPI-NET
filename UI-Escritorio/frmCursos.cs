using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Datos;
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmCursos : Form
    {
        CN_Cursos CNCurso = new CN_Cursos();
        CN_Comisiones CNComision = new CN_Comisiones();
        CN_Materia CNMateria = new CN_Materia();

        int idCurso = 0;
        string descCom = "";
        string nomMat = "";
        string nomCom = "";
        int idMat = 0;
        int idCom = 0;
        int idPla = 0;
        int anio = 0;
        int cupo = 0;
        string descMat = "";
        DataTable materias;
        DataTable comisiones;
        DataTable mat;
        DataTable com;

        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            cargarOpcionesMaterias();
            cargarOpcionesComisiones();
            mostrarCursos();
        }

        public void cargarOpcionesMaterias()
        {
            materias = CNMateria.mostrarMaterias();
            for (int i = 0; i < materias.Rows.Count; i++)
            {
                cmbMateria.Items.Add(materias.Rows[i]["desc_materia"]);
            }
        }

        public void cargarOpcionesComisiones()
        {
            comisiones = CNComision.mostrarComisiones();
            for (int i = 0; i < comisiones.Rows.Count; i++)
            {
                cmbComision.Items.Add(comisiones.Rows[i]["desc_comision"]);
            }
        }

        public void mostrarCursos()
        {
            dgvCursos.DataSource = CNCurso.mostrarCursos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estas seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        idCurso = (int)dgvCursos.CurrentRow.Cells["id_curso"].Value;
                        CNCurso.eliminarCurso(idCurso);
                        MessageBox.Show("Materia eliminada");
                        mostrarCursos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar el curso por " + ex);
                    }


                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable mat = CNMateria.mostrarMateria(descMat);
            idMat = (int)mat.Rows[0]["id_materia"];
            DataTable com = CNComision.mostrarComisionPorDescripcion(descCom);
            idCom = (int)com.Rows[0]["id_comision"];
            CNCurso.agregarCurso(idMat, idCom, Decimal.ToInt32(numAnioCal.Value), Decimal.ToInt32(numCupo.Value));
            mostrarCursos();
            numAnioCal.Value = 0;
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            descMat = (string)cmbMateria.SelectedItem;
        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            descCom = (string)cmbComision.SelectedItem;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                try
                {
                    if (cmbMateria.SelectedIndex == -1 || cmbMateria.SelectedIndex == -1 || numAnioCal.Value == 0 || numCupo.Value == 0)
                    {
                        MessageBox.Show("Complete todos los campos");
                    }
                    else
                    {
                        DataTable mat = CNMateria.mostrarMateria(cmbMateria.SelectedItem.ToString());
                        idMat = (int)mat.Rows[0]["id_materia"];
                        DataTable com = CNComision.mostrarComisionPorDescripcion(cmbComision.SelectedItem.ToString());
                        idCom = (int)com.Rows[0]["id_comision"];
                        anio = Decimal.ToInt32(numAnioCal.Value);
                        cupo = Decimal.ToInt32(numCupo.Value);
                        Curso cur = new Curso(idMat, idCom, anio, cupo);
                        CNCurso.actualizarCurso(cur, (int)dgvCursos.CurrentRow.Cells["id_curso"].Value);
                        mostrarCursos();
                        cmbMateria.SelectedIndex = -1;
                        cmbComision.SelectedIndex = -1;
                        numAnioCal.Value = 0;
                        numCupo.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar la materia por " + ex);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void frmCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
