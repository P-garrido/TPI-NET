namespace UI_Escritorio
{
    partial class frmReporteCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rpvCursos = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rpvCursos
            // 
            rpvCursos.Location = new Point(0, 0);
            rpvCursos.Name = "ReportViewer";
            rpvCursos.ServerReport.BearerToken = null;
            rpvCursos.Size = new Size(595, 842);
            rpvCursos.TabIndex = 0;
            // 
            // frmReporteCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 749);
            Controls.Add(rpvCursos);
            Name = "frmReporteCursos";
            Text = "Reporte Cursos";
            Load += frmReporteCursos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCursos;
    }
}