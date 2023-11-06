namespace UI_Escritorio
{
    partial class frmInscAlumnos
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
            lblMateria = new Label();
            cmbMaterias = new ComboBox();
            cmbComisiones = new ComboBox();
            lblComision = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(119, 161);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(60, 20);
            lblMateria.TabIndex = 0;
            lblMateria.Text = "Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(323, 160);
            cmbMaterias.Margin = new Padding(3, 4, 3, 4);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(138, 28);
            cmbMaterias.TabIndex = 1;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(323, 268);
            cmbComisiones.Margin = new Padding(3, 4, 3, 4);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(138, 28);
            cmbComisiones.TabIndex = 3;
            cmbComisiones.SelectedIndexChanged += cmbComisiones_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(119, 269);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(71, 20);
            lblComision.TabIndex = 2;
            lblComision.Text = "Comision";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(376, 379);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmInscAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAceptar);
            Controls.Add(cmbComisiones);
            Controls.Add(lblComision);
            Controls.Add(cmbMaterias);
            Controls.Add(lblMateria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInscAlumnos";
            Text = "frmInscAlumnos";
            Load += frmInscAlumnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMateria;
        private ComboBox cmbMaterias;
        private ComboBox cmbComisiones;
        private Label lblComision;
        private Button btnAceptar;
    }
}