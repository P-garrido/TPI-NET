namespace UI_Escritorio
{
    partial class frmLogin
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
            lblNomUsuario = new Label();
            txtNomUsuario = new TextBox();
            txtPass = new TextBox();
            lblPass = new Label();
            lklCrearUsu = new LinkLabel();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Location = new Point(148, 94);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(110, 15);
            lblNomUsuario.TabIndex = 0;
            lblNomUsuario.Text = "Nombre de Usuario";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(294, 99);
            txtNomUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(110, 23);
            txtNomUsuario.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(294, 157);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(110, 23);
            txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(148, 152);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña";
            // 
            // lklCrearUsu
            // 
            lklCrearUsu.AutoSize = true;
            lklCrearUsu.Location = new Point(151, 239);
            lklCrearUsu.Name = "lklCrearUsu";
            lklCrearUsu.Size = new Size(78, 15);
            lklCrearUsu.TabIndex = 4;
            lklCrearUsu.TabStop = true;
            lklCrearUsu.Text = "Crear Usuario";
            lklCrearUsu.LinkClicked += lklCrearUsu_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(309, 236);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 332);
            Controls.Add(btnAceptar);
            Controls.Add(lklCrearUsu);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtNomUsuario);
            Controls.Add(lblNomUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomUsuario;
        private TextBox txtNomUsuario;
        private TextBox txtPass;
        private Label lblPass;
        private LinkLabel lklCrearUsu;
        private Button btnAceptar;
    }
}