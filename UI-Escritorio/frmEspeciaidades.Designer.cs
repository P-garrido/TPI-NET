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
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(10, 9);
            dgvEspecialidades.Margin = new Padding(3, 2, 3, 2);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.RowTemplate.Height = 29;
            dgvEspecialidades.Size = new Size(679, 141);
            dgvEspecialidades.TabIndex = 0;
            // 
            // lblDescEspecialidad
            // 
            lblDescEspecialidad.AutoSize = true;
            lblDescEspecialidad.Location = new Point(23, 167);
            lblDescEspecialidad.Name = "lblDescEspecialidad";
            lblDescEspecialidad.Size = new Size(135, 15);
            lblDescEspecialidad.TabIndex = 1;
            lblDescEspecialidad.Text = "Nombre de Especialidad";
            // 
            // txtDescEspecialidad
            // 
            txtDescEspecialidad.Location = new Point(193, 165);
            txtDescEspecialidad.Margin = new Padding(3, 2, 3, 2);
            txtDescEspecialidad.Name = "txtDescEspecialidad";
            txtDescEspecialidad.Size = new Size(110, 23);
            txtDescEspecialidad.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 212);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(122, 212);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(220, 212);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmEspeciaidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtDescEspecialidad);
            Controls.Add(lblDescEspecialidad);
            Controls.Add(dgvEspecialidades);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEspeciaidades";
            Text = "Especiaidades";
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