namespace UI_Escritorio
{
    partial class frmInscripcionComisiones
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
            lblComision = new Label();
            cmbComisiones = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(159, 132);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(74, 20);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comision:";
            // 
            // cmbComisiones
            // 
            cmbComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(334, 129);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(151, 28);
            cmbComisiones.TabIndex = 1;
            cmbComisiones.SelectedIndexChanged += cmbComisiones_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(391, 277);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(159, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmInscripcionComisiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 461);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbComisiones);
            Controls.Add(lblComision);
            Name = "frmInscripcionComisiones";
            Text = "Inscripcion a comisiones";
            Load += frmInscripcionComisiones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblComision;
        private ComboBox cmbComisiones;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}