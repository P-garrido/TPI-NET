namespace UI_Escritorio
{
    partial class frmComisiones
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
            dgvComisiones = new DataGridView();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblAnioEspecialidad = new Label();
            lblPlan = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtAnioEsp = new TextBox();
            cmbPlanes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // dgvComisiones
            // 
            dgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Location = new Point(12, 12);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.RowTemplate.Height = 25;
            dgvComisiones.Size = new Size(846, 150);
            dgvComisiones.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(281, 194);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(415, 194);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(120, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // lblAnioEspecialidad
            // 
            lblAnioEspecialidad.AutoSize = true;
            lblAnioEspecialidad.Location = new Point(281, 251);
            lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            lblAnioEspecialidad.Size = new Size(128, 15);
            lblAnioEspecialidad.TabIndex = 3;
            lblAnioEspecialidad.Text = "Anio de la especialidad";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(281, 314);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 5;
            lblPlan.Text = "Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(260, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(381, 386);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(500, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtAnioEsp
            // 
            txtAnioEsp.Location = new Point(415, 251);
            txtAnioEsp.Name = "txtAnioEsp";
            txtAnioEsp.Size = new Size(120, 23);
            txtAnioEsp.TabIndex = 12;
            // 
            // cmbPlanes
            // 
            cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(414, 311);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(121, 23);
            cmbPlanes.TabIndex = 14;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            // 
            // frmComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 480);
            Controls.Add(cmbPlanes);
            Controls.Add(txtAnioEsp);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblPlan);
            Controls.Add(lblAnioEspecialidad);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(dgvComisiones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmComisiones";
            Text = "Comisiones";
            FormClosing += frmComisiones_FormClosing;
            Load += frmComisiones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvComisiones;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblAnioEspecialidad;
        private Label lblPlan;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtAnioEsp;
        private ComboBox cmbPlanes;
    }
}