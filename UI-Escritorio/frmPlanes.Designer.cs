namespace UI_Escritorio
{
    partial class frmPlanes
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
            dgvPlanes = new DataGridView();
            lblNombre = new Label();
            txtDescPlan = new TextBox();
            lblNomEsp = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            cmbEspecialidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // dgvPlanes
            // 
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(10, 9);
            dgvPlanes.Margin = new Padding(3, 2, 3, 2);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.RowTemplate.Height = 29;
            dgvPlanes.Size = new Size(679, 141);
            dgvPlanes.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 170);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(96, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del Plan";
            // 
            // txtDescPlan
            // 
            txtDescPlan.Location = new Point(193, 170);
            txtDescPlan.Margin = new Padding(3, 2, 3, 2);
            txtDescPlan.Name = "txtDescPlan";
            txtDescPlan.Size = new Size(137, 23);
            txtDescPlan.TabIndex = 2;
            // 
            // lblNomEsp
            // 
            lblNomEsp.AutoSize = true;
            lblNomEsp.Location = new Point(16, 207);
            lblNomEsp.Name = "lblNomEsp";
            lblNomEsp.Size = new Size(147, 15);
            lblNomEsp.TabIndex = 3;
            lblNomEsp.Text = "Nombre de la Especialidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(16, 262);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(123, 262);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(237, 262);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(193, 207);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(137, 23);
            cmbEspecialidad.TabIndex = 8;
            cmbEspecialidad.Text = "Elija una especialidad";
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // frmPlanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(cmbEspecialidad);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblNomEsp);
            Controls.Add(txtDescPlan);
            Controls.Add(lblNombre);
            Controls.Add(dgvPlanes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPlanes";
            Text = "Planes";
            FormClosing += frmPlanes_FormClosing;
            Load += frmPlanes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlanes;
        private Label lblNombre;
        private TextBox txtDescPlan;
        private Label lblNomEsp;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private ComboBox cmbEspecialidad;
    }
}