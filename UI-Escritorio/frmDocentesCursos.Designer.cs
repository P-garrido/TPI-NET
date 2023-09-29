namespace UI_Escritorio
{
    partial class frmDocentesCursos
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
            cmbComisiones = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblComisiones = new Label();
            cmbCargo = new ComboBox();
            lblCargo = new Label();
            SuspendLayout();
            // 
            // cmbComisiones
            // 
            cmbComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(479, 239);
            cmbComisiones.Margin = new Padding(3, 4, 3, 4);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(138, 28);
            cmbComisiones.TabIndex = 0;
            cmbComisiones.SelectedIndexChanged += cmbComisiones_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(282, 367);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(531, 367);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblComisiones
            // 
            lblComisiones.AutoSize = true;
            lblComisiones.Location = new Point(325, 239);
            lblComisiones.Name = "lblComisiones";
            lblComisiones.Size = new Size(71, 20);
            lblComisiones.TabIndex = 3;
            lblComisiones.Text = "Comision";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(479, 296);
            cmbCargo.Margin = new Padding(3, 4, 3, 4);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(138, 28);
            cmbCargo.TabIndex = 4;
            cmbCargo.SelectedIndexChanged += cmbCargo_SelectedIndexChanged;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(328, 308);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 20);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo:";
            // 
            // frmDocentesCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblCargo);
            Controls.Add(cmbCargo);
            Controls.Add(lblComisiones);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(cmbComisiones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDocentesCursos";
            Text = "frmDocentesCursos";
            Load += frmDocentesCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbComisiones;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblComisiones;
        private ComboBox cmbCargo;
        private Label lblCargo;
    }
}