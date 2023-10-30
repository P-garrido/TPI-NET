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
using TPI_Entidades;
using TPI_Negocios;

namespace UI_Escritorio
{
    public partial class frmReportePlanes : Form
    {
        CN_Plan plan = new CN_Plan();
        public frmReportePlanes()
        {
            InitializeComponent();
        }

        private void frmReportePlanes_Load(object sender, EventArgs e)
        {
            rpvPlanes.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("PlanesDataSet3", plan.cargarReportePlanes());
            rpvPlanes.LocalReport.ReportPath = @"..\\..\\..\\reportePlanes.rdlc";
            rpvPlanes.LocalReport.DataSources.Add(source);
            rpvPlanes.RefreshReport();
        }
    }
}
