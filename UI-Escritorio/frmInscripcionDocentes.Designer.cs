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
            cmbMaterias.Location = new Point(394, 205);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(121, 23);
            cmbMaterias.TabIndex = 0;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(225, 205);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(225, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(440, 312);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmInscripcionDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMateria);
            Controls.Add(cmbMaterias);
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