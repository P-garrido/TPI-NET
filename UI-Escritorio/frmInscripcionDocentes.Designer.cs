namespace UI_Escritorio
{
    partial class frmInscripcionDocentes
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
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(450, 273);
            cmbMaterias.Margin = new Padding(3, 4, 3, 4);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(138, 28);
            cmbMaterias.TabIndex = 0;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(257, 273);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(60, 20);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(257, 416);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(503, 416);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmInscripcionDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMateria);
            Controls.Add(cmbMaterias);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInscripcionDocentes";
            Text = "frmInscripcionDocentes";
            Load += frmInscripcionDocentes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}