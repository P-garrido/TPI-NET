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
            txtdescEsp = new TextBox();
            lblNomEsp = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // dgvPlanes
            // 
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(12, 12);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.RowTemplate.Height = 29;
            dgvPlanes.Size = new Size(776, 188);
            dgvPlanes.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 226);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del Plan";
            // 
            // txtDescPlan
            // 
            txtDescPlan.Location = new Point(221, 226);
            txtDescPlan.Name = "txtDescPlan";
            txtDescPlan.Size = new Size(125, 27);
            txtDescPlan.TabIndex = 2;
            // 
            // txtdescEsp
            // 
            txtdescEsp.Location = new Point(221, 276);
            txtdescEsp.Name = "txtdescEsp";
            txtdescEsp.Size = new Size(125, 27);
            txtdescEsp.TabIndex = 4;
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
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(141, 349);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
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
            // frmPlanes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtdescEsp);
            Controls.Add(lblNomEsp);
            Controls.Add(txtDescPlan);
            Controls.Add(lblNombre);
            Controls.Add(dgvPlanes);
            Name = "frmPlanes";
            Text = "Planes";
            Load += frmPlanes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlanes;
        private Label lblNombre;
        private TextBox txtDescPlan;
        private TextBox txtdescEsp;
        private Label lblNomEsp;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}