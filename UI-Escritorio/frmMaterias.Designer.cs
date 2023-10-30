namespace UI_Escritorio
{
    partial class frmMaterias
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
            dgvMaterias = new DataGridView();
            lblDescripcionMateria = new Label();
            txtDescripcionMateria = new TextBox();
            frmHorasSemanales = new Label();
            lblHorasTotales = new Label();
            lblPlan = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            numHorasSemanales = new NumericUpDown();
            numHorasTotales = new NumericUpDown();
            cmbPlan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasSemanales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTotales).BeginInit();
            SuspendLayout();
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(12, 12);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(399, 151);
            dgvMaterias.TabIndex = 0;
            // 
            // lblDescripcionMateria
            // 
            lblDescripcionMateria.AutoSize = true;
            lblDescripcionMateria.Location = new Point(12, 187);
            lblDescripcionMateria.Name = "lblDescripcionMateria";
            lblDescripcionMateria.Size = new Size(51, 15);
            lblDescripcionMateria.TabIndex = 1;
            lblDescripcionMateria.Text = "Nombre";
            // 
            // txtDescripcionMateria
            // 
            txtDescripcionMateria.Location = new Point(102, 184);
            txtDescripcionMateria.Name = "txtDescripcionMateria";
            txtDescripcionMateria.Size = new Size(100, 23);
            txtDescripcionMateria.TabIndex = 2;
            // 
            // frmHorasSemanales
            // 
            frmHorasSemanales.AutoSize = true;
            frmHorasSemanales.Location = new Point(12, 226);
            frmHorasSemanales.Name = "frmHorasSemanales";
            frmHorasSemanales.Size = new Size(83, 15);
            frmHorasSemanales.TabIndex = 3;
            frmHorasSemanales.Text = "Hs. Semanales";
            // 
            // lblHorasTotales
            // 
            lblHorasTotales.AutoSize = true;
            lblHorasTotales.Location = new Point(12, 265);
            lblHorasTotales.Name = "lblHorasTotales";
            lblHorasTotales.Size = new Size(63, 15);
            lblHorasTotales.TabIndex = 5;
            lblHorasTotales.Text = "Hs. Totales";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(12, 305);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 7;
            lblPlan.Text = "Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(20, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(118, 336);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(217, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numHorasSemanales
            // 
            numHorasSemanales.Location = new Point(101, 224);
            numHorasSemanales.Name = "numHorasSemanales";
            numHorasSemanales.Size = new Size(101, 23);
            numHorasSemanales.TabIndex = 12;
            // 
            // numHorasTotales
            // 
            numHorasTotales.Location = new Point(101, 263);
            numHorasTotales.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numHorasTotales.Name = "numHorasTotales";
            numHorasTotales.Size = new Size(101, 23);
            numHorasTotales.TabIndex = 13;
            // 
            // cmbPlan
            // 
            cmbPlan.AccessibleRole = AccessibleRole.None;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(101, 305);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(139, 23);
            cmbPlan.TabIndex = 14;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 371);
            Controls.Add(cmbPlan);
            Controls.Add(numHorasTotales);
            Controls.Add(numHorasSemanales);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblPlan);
            Controls.Add(lblHorasTotales);
            Controls.Add(frmHorasSemanales);
            Controls.Add(txtDescripcionMateria);
            Controls.Add(lblDescripcionMateria);
            Controls.Add(dgvMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMaterias";
            Text = "Menú Materias";
            FormClosing += frmMaterias_FormClosing;
            Load += frmMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasSemanales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHorasTotales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaterias;
        private Label lblDescripcionMateria;
        private TextBox txtDescripcionMateria;
        private Label frmHorasSemanales;
        private Label lblHorasTotales;
        private Label lblPlan;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private NumericUpDown numHorasSemanales;
        private NumericUpDown numHorasTotales;
        private ComboBox cmbPlan;
    }
}