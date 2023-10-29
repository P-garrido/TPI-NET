using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmReporteCursos : Form
    {
        CN_Cursos curso = new CN_Cursos();
        public frmReporteCursos()
        {
            InitializeComponent();
        }

        private void frmReporteCursos_Load(object sender, EventArgs e)
        {
            rpvCursos.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("CursosDataSet", curso.cargarReporteCursos());
            rpvCursos.LocalReport.ReportPath = @"C:\\Users\\Usuario\\source\\repos\\TPI-NET\\UI-Escritorio\\reporteCursos.rdlc";
            rpvCursos.LocalReport.DataSources.Add(source);
            rpvCursos.RefreshReport();
        }
    }
}
