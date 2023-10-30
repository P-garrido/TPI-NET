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
            lblNomMateria.Location = new Point(14, 248);
            lblNomMateria.Name = "lblNomMateria";
            lblNomMateria.Size = new Size(60, 20);
            lblNomMateria.TabIndex = 0;
            lblNomMateria.Text = "Materia";
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(14, 16);
            dgvCursos.Margin = new Padding(3, 4, 3, 4);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new Size(961, 213);
            dgvCursos.TabIndex = 2;
            dgvCursos.Click += dgvCursos_Click;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(14, 296);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(71, 20);
            lblComision.TabIndex = 3;
            lblComision.Text = "Comision";
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Location = new Point(14, 347);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(112, 20);
            lblAnioCalendario.TabIndex = 5;
            lblAnioCalendario.Text = "Año Calendario";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(14, 397);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(44, 20);
            lblCupo.TabIndex = 7;
            lblCupo.Text = "Cupo";
            // 
            // numAnioCal
            // 
            numAnioCal.Location = new Point(117, 347);
            numAnioCal.Margin = new Padding(3, 4, 3, 4);
            numAnioCal.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numAnioCal.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numAnioCal.Name = "numAnioCal";
            numAnioCal.Size = new Size(137, 27);
            numAnioCal.TabIndex = 11;
            numAnioCal.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // numCupo
            // 
            numCupo.Location = new Point(118, 397);
            numCupo.Margin = new Padding(3, 4, 3, 4);
            numCupo.Name = "numCupo";
            numCupo.Size = new Size(137, 27);
            numCupo.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(14, 451);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(129, 451);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(243, 451);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(115, 248);
            cmbMateria.Margin = new Padding(3, 4, 3, 4);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(138, 28);
            cmbMateria.TabIndex = 16;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedIndexChanged;
            // 
            // cmbComision
            // 
            cmbComision.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComision.FormattingEnabled = true;
            cmbComision.Location = new Point(117, 296);
            cmbComision.Margin = new Padding(3, 4, 3, 4);
            cmbComision.Name = "cmbComision";
            cmbComision.Size = new Size(138, 28);
            cmbComision.TabIndex = 17;
            cmbComision.SelectedIndexChanged += cmbComision_SelectedIndexChanged;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 497);
            ControlBox = false;
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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