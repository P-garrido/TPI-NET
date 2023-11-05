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
            dgvPlanes.AllowUserToAddRows = false;
            dgvPlanes.AllowUserToDeleteRows = false;
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(11, 12);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.RowTemplate.Height = 29;
            dgvPlanes.Size = new Size(776, 188);
            dgvPlanes.TabIndex = 0;
            dgvPlanes.Click += dgvPlanes_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 227);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del Plan";
            // 
            // txtDescPlan
            // 
            txtDescPlan.Location = new Point(221, 227);
            txtDescPlan.Name = "txtDescPlan";
            txtDescPlan.Size = new Size(156, 27);
            txtDescPlan.TabIndex = 2;
            // 
            // lblNomEsp
            // 
            lblNomEsp.AutoSize = true;
            lblNomEsp.Location = new Point(18, 276);
            lblNomEsp.Name = "lblNomEsp";
            lblNomEsp.Size = new Size(189, 20);
            lblNomEsp.TabIndex = 3;
            lblNomEsp.Text = "Nombre de la Especialidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(18, 349);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(141, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(221, 276);
            cmbEspecialidad.Margin = new Padding(3, 4, 3, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(156, 28);
            cmbEspecialidad.TabIndex = 8;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // frmPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(cmbEspecialidad);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblNomEsp);
            Controls.Add(txtDescPlan);
            Controls.Add(lblNombre);
            Controls.Add(dgvPlanes);
            FormBorderStyle = FormBorderStyle.None;
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