namespace UI_Escritorio
{
    partial class frmCursos
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
            lblNomMateria = new Label();
            dgvCursos = new DataGridView();
            lblComision = new Label();
            lblAnioCalendario = new Label();
            lblCupo = new Label();
            numAnioCal = new NumericUpDown();
            numCupo = new NumericUpDown();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            cmbMateria = new ComboBox();
            cmbComision = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnioCal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCupo).BeginInit();
            SuspendLayout();
            // 
            // lblNomMateria
            // 
            lblNomMateria.AutoSize = true;
            lblNomMateria.Location = new Point(12, 186);
            lblNomMateria.Name = "lblNomMateria";
            lblNomMateria.Size = new Size(47, 15);
            lblNomMateria.TabIndex = 0;
            lblNomMateria.Text = "Materia";
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(12, 12);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new Size(638, 160);
            dgvCursos.TabIndex = 2;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(12, 222);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(58, 15);
            lblComision.TabIndex = 3;
            lblComision.Text = "Comision";
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Location = new Point(12, 260);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(89, 15);
            lblAnioCalendario.TabIndex = 5;
            lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(12, 298);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(36, 15);
            lblCupo.TabIndex = 7;
            lblCupo.Text = "Cupo";
            // 
            // numAnioCal
            // 
            numAnioCal.Location = new Point(102, 260);
            numAnioCal.Name = "numAnioCal";
            numAnioCal.Size = new Size(120, 23);
            numAnioCal.TabIndex = 11;
            // 
            // numCupo
            // 
            numCupo.Location = new Point(103, 298);
            numCupo.Name = "numCupo";
            numCupo.Size = new Size(120, 23);
            numCupo.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 338);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(113, 338);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(213, 338);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(101, 186);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(121, 23);
            cmbMateria.TabIndex = 16;
            cmbMateria.Text = "Elija una materia";
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // cmbComision
            // 
            cmbComision.FormattingEnabled = true;
            cmbComision.Location = new Point(102, 222);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(121, 23);
            cmbComision.TabIndex = 17;
            cmbComision.Text = "Elija una comisión";
            cmbComision.SelectedIndexChanged += cmbComision_SelectedIndexChanged;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 373);
            Controls.Add(cmbComision);
            Controls.Add(cmbMateria);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(numCupo);
            Controls.Add(numAnioCal);
            Controls.Add(lblCupo);
            Controls.Add(lblAnioCalendario);
            Controls.Add(lblComision);
            Controls.Add(dgvCursos);
            Controls.Add(lblNomMateria);
            Name = "frmCursos";
            Text = "Menú Cursos";
            FormClosing += frmCursos_FormClosing;
            Load += frmCursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnioCal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCupo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomMateria;
        private TextBox txtNomMateria;
        private DataGridView dgvCursos;
        private TextBox txtComision;
        private Label lblComision;
        private TextBox txtAnioCal;
        private Label lblAnioCalendario;
        private TextBox txtCupo;
        private Label lblCupo;
        private NumericUpDown numAnioCal;
        private NumericUpDown numCupo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private ComboBox cmbMateria;
        private ComboBox cmbComision;
    }
}