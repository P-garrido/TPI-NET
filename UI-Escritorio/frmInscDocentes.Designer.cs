namespace UI_Escritorio
{
    partial class frmInscDocentes
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
            lblComision = new Label();
            cmbComisiones = new ComboBox();
            lblCargo = new Label();
            cmbCargos = new ComboBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(337, 109);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(121, 23);
            cmbMaterias.TabIndex = 0;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(188, 112);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(188, 161);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(58, 15);
            lblComision.TabIndex = 3;
            lblComision.Text = "Comisión";
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(337, 158);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(121, 23);
            cmbComisiones.TabIndex = 2;
            cmbComisiones.SelectedIndexChanged += cmbComisiones_SelectedIndexChanged;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(188, 222);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 5;
            lblCargo.Text = "Cargo";
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Location = new Point(337, 219);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(121, 23);
            cmbCargos.TabIndex = 4;
            cmbCargos.SelectedIndexChanged += cmbCargos_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(383, 312);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmInscDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(lblCargo);
            Controls.Add(cmbCargos);
            Controls.Add(lblComision);
            Controls.Add(cmbComisiones);
            Controls.Add(lblMateria);
            Controls.Add(cmbMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInscDocentes";
            Text = "frmInscDocentes";
            Load += frmInscDocentes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterias;
        private Label lblMateria;
        private Label lblComision;
        private ComboBox cmbComisiones;
        private Label lblCargo;
        private ComboBox cmbCargos;
        private Button btnAceptar;
    }
}