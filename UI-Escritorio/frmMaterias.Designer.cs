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
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(12, 13);
            dgvMaterias.Margin = new Padding(3, 4, 3, 4);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(910, 201);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.Click += dgvMaterias_Click;
            // 
            // lblDescripcionMateria
            // 
            lblDescripcionMateria.AutoSize = true;
            lblDescripcionMateria.Location = new Point(14, 249);
            lblDescripcionMateria.Name = "lblDescripcionMateria";
            lblDescripcionMateria.Size = new Size(64, 20);
            lblDescripcionMateria.TabIndex = 1;
            lblDescripcionMateria.Text = "Nombre";
            // 
            // txtDescripcionMateria
            // 
            txtDescripcionMateria.Location = new Point(117, 245);
            txtDescripcionMateria.Margin = new Padding(3, 4, 3, 4);
            txtDescripcionMateria.Name = "txtDescripcionMateria";
            txtDescripcionMateria.Size = new Size(114, 27);
            txtDescripcionMateria.TabIndex = 2;
            // 
            // frmHorasSemanales
            // 
            frmHorasSemanales.AutoSize = true;
            frmHorasSemanales.Location = new Point(14, 301);
            frmHorasSemanales.Name = "frmHorasSemanales";
            frmHorasSemanales.Size = new Size(104, 20);
            frmHorasSemanales.TabIndex = 3;
            frmHorasSemanales.Text = "Hs. Semanales";
            // 
            // lblHorasTotales
            // 
            lblHorasTotales.AutoSize = true;
            lblHorasTotales.Location = new Point(14, 353);
            lblHorasTotales.Name = "lblHorasTotales";
            lblHorasTotales.Size = new Size(80, 20);
            lblHorasTotales.TabIndex = 5;
            lblHorasTotales.Text = "Hs. Totales";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(14, 407);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 7;
            lblPlan.Text = "Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 448);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(135, 448);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(248, 448);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numHorasSemanales
            // 
            numHorasSemanales.Location = new Point(115, 299);
            numHorasSemanales.Margin = new Padding(3, 4, 3, 4);
            numHorasSemanales.Name = "numHorasSemanales";
            numHorasSemanales.Size = new Size(115, 27);
            numHorasSemanales.TabIndex = 12;
            // 
            // numHorasTotales
            // 
            numHorasTotales.Location = new Point(115, 351);
            numHorasTotales.Margin = new Padding(3, 4, 3, 4);
            numHorasTotales.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numHorasTotales.Name = "numHorasTotales";
            numHorasTotales.Size = new Size(115, 27);
            numHorasTotales.TabIndex = 13;
            // 
            // cmbPlan
            // 
            cmbPlan.AccessibleRole = AccessibleRole.None;
            cmbPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(115, 407);
            cmbPlan.Margin = new Padding(3, 4, 3, 4);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(158, 28);
            cmbPlan.TabIndex = 14;
            cmbPlan.SelectedIndexChanged += cmbPlan_SelectedIndexChanged;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 495);
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
            Margin = new Padding(3, 4, 3, 4);
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