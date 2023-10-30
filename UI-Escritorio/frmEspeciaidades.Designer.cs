namespace UI_Escritorio
{
    partial class frmEspeciaidades
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
            dgvEspecialidades = new DataGridView();
            lblDescEspecialidad = new Label();
            txtDescEspecialidad = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(11, 12);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.RowTemplate.Height = 29;
            dgvEspecialidades.Size = new Size(776, 188);
            dgvEspecialidades.TabIndex = 0;
            dgvEspecialidades.Click += dgvEspecialidades_Click;
            // 
            // lblDescEspecialidad
            // 
            lblDescEspecialidad.AutoSize = true;
            lblDescEspecialidad.Location = new Point(26, 223);
            lblDescEspecialidad.Name = "lblDescEspecialidad";
            lblDescEspecialidad.Size = new Size(173, 20);
            lblDescEspecialidad.TabIndex = 1;
            lblDescEspecialidad.Text = "Nombre de Especialidad";
            // 
            // txtDescEspecialidad
            // 
            txtDescEspecialidad.Location = new Point(221, 220);
            txtDescEspecialidad.Name = "txtDescEspecialidad";
            txtDescEspecialidad.Size = new Size(125, 27);
            txtDescEspecialidad.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(139, 283);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(251, 283);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEspeciaidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtDescEspecialidad);
            Controls.Add(lblDescEspecialidad);
            Controls.Add(dgvEspecialidades);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEspeciaidades";
            Text = "Especiaidades";
            FormClosing += frmEspeciaidades_FormClosing;
            Load += frmEspeciaidades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEspecialidades;
        private Label lblDescEspecialidad;
        private TextBox txtDescEspecialidad;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}