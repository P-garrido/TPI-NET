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
            txtHorasSemanales = new TextBox();
            frmHorasSemanales = new Label();
            txtHorasTotales = new TextBox();
            lblHorasTotales = new Label();
            txtPlan = new TextBox();
            lblPlan = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
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
            // txtHorasSemanales
            // 
            txtHorasSemanales.Location = new Point(102, 223);
            txtHorasSemanales.Name = "txtHorasSemanales";
            txtHorasSemanales.Size = new Size(100, 23);
            txtHorasSemanales.TabIndex = 4;
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
            // txtHorasTotales
            // 
            txtHorasTotales.Location = new Point(102, 262);
            txtHorasTotales.Name = "txtHorasTotales";
            txtHorasTotales.Size = new Size(100, 23);
            txtHorasTotales.TabIndex = 6;
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
            // txtPlan
            // 
            txtPlan.Location = new Point(102, 302);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(100, 23);
            txtPlan.TabIndex = 8;
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
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 371);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtPlan);
            Controls.Add(lblPlan);
            Controls.Add(txtHorasTotales);
            Controls.Add(lblHorasTotales);
            Controls.Add(txtHorasSemanales);
            Controls.Add(frmHorasSemanales);
            Controls.Add(txtDescripcionMateria);
            Controls.Add(lblDescripcionMateria);
            Controls.Add(dgvMaterias);
            Name = "frmMaterias";
            Text = "Menú Materias";
            Load += frmMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaterias;
        private Label lblDescripcionMateria;
        private TextBox txtDescripcionMateria;
        private TextBox txtHorasSemanales;
        private Label frmHorasSemanales;
        private TextBox txtHorasTotales;
        private Label lblHorasTotales;
        private TextBox txtPlan;
        private Label lblPlan;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}