﻿namespace UI_Escritorio
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
            lblComision.Location = new Point(139, 99);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(61, 15);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comision:";
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(292, 97);
            cmbComisiones.Margin = new Padding(3, 2, 3, 2);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(133, 23);
            cmbComisiones.TabIndex = 1;
            cmbComisiones.SelectedIndexChanged += cmbComisiones_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(342, 208);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(139, 208);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmInscripcionComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 346);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbComisiones);
            Controls.Add(lblComision);
            Margin = new Padding(3, 2, 3, 2);
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