namespace UI_Escritorio
{
    partial class frmRegistroNotas
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
            cmbComision = new ComboBox();
            cmbMateria = new ComboBox();
            lblComision = new Label();
            lblMateria = new Label();
            cmbAlumno = new ComboBox();
            lblAlumnos = new Label();
            numNota = new NumericUpDown();
            label1 = new Label();
            btnRegistrarNota = new Button();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            SuspendLayout();
            // 
            // cmbComision
            // 
            cmbComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComision.FormattingEnabled = true;
            cmbComision.Location = new Point(188, 95);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(121, 23);
            cmbComision.TabIndex = 0;
            cmbComision.SelectedIndexChanged += cmbComision_SelectedIndexChanged;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.Enabled = false;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(188, 139);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 1;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(52, 98);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(108, 15);
            lblComision.TabIndex = 2;
            lblComision.Text = "Elija una Comisión:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(63, 142);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(97, 15);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "Elija una Materia:";
            // 
            // cmbAlumno
            // 
            cmbAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlumno.Enabled = false;
            cmbAlumno.FormattingEnabled = true;
            cmbAlumno.Location = new Point(188, 181);
            cmbAlumno.Name = "cmbAlumno";
            cmbAlumno.Size = new Size(121, 23);
            cmbAlumno.TabIndex = 4;
            cmbAlumno.SelectedIndexChanged += cmbAlumno_SelectedIndexChanged;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Location = new Point(63, 184);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(91, 15);
            lblAlumnos.TabIndex = 5;
            lblAlumnos.Text = "Elija un Alumno";
            // 
            // numNota
            // 
            numNota.Location = new Point(189, 216);
            numNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numNota.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNota.Name = "numNota";
            numNota.Size = new Size(120, 23);
            numNota.TabIndex = 6;
            numNota.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 218);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Nota:";
            // 
            // btnRegistrarNota
            // 
            btnRegistrarNota.Location = new Point(234, 270);
            btnRegistrarNota.Name = "btnRegistrarNota";
            btnRegistrarNota.Size = new Size(75, 23);
            btnRegistrarNota.TabIndex = 8;
            btnRegistrarNota.Text = "Registrar Nota";
            btnRegistrarNota.UseVisualStyleBackColor = true;
            btnRegistrarNota.Click += btnRegistrarNota_Click;
            // 
            // frmRegistroNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 327);
            Controls.Add(btnRegistrarNota);
            Controls.Add(label1);
            Controls.Add(numNota);
            Controls.Add(lblAlumnos);
            Controls.Add(cmbAlumno);
            Controls.Add(lblMateria);
            Controls.Add(lblComision);
            Controls.Add(cmbMateria);
            Controls.Add(cmbComision);
            Name = "frmRegistroNotas";
            Text = "Registro de Notas Alumnos";
            Load += frmRegistroNotas_Load;
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbComision;
        private ComboBox cmbMateria;
        private Label lblComision;
        private Label lblMateria;
        private ComboBox cmbAlumno;
        private Label lblAlumnos;
        private NumericUpDown numNota;
        private Label label1;
        private Button btnRegistrarNota;
    }
}