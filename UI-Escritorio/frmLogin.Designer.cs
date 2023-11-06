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
            cbxClave = new CheckBox();
            SuspendLayout();
            // 
            // lblNomUsuario
            // 
            lblNomUsuario.AutoSize = true;
            lblNomUsuario.Location = new Point(169, 125);
            lblNomUsuario.Name = "lblNomUsuario";
            lblNomUsuario.Size = new Size(139, 20);
            lblNomUsuario.TabIndex = 0;
            lblNomUsuario.Text = "Nombre de Usuario";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(336, 132);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(125, 27);
            txtNomUsuario.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(336, 209);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(169, 203);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 20);
            lblPass.TabIndex = 2;
            lblPass.Text = "Contraseña";
            // 
            // lklCrearUsu
            // 
            lklCrearUsu.AutoSize = true;
            lklCrearUsu.Location = new Point(173, 319);
            lklCrearUsu.Name = "lklCrearUsu";
            lklCrearUsu.Size = new Size(98, 20);
            lklCrearUsu.TabIndex = 4;
            lklCrearUsu.TabStop = true;
            lklCrearUsu.Text = "Crear Usuario";
            lklCrearUsu.LinkClicked += lklCrearUsu_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(353, 315);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cbxClave
            // 
            cbxClave.AutoSize = true;
            cbxClave.Location = new Point(485, 213);
            cbxClave.Name = "cbxClave";
            cbxClave.Size = new Size(120, 24);
            cbxClave.TabIndex = 6;
            cbxClave.Text = "Mostrar clave";
            cbxClave.UseVisualStyleBackColor = true;
            cbxClave.CheckedChanged += cbxClave_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 443);
            Controls.Add(cbxClave);
            Controls.Add(btnAceptar);
            Controls.Add(lklCrearUsu);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtNomUsuario);
            Controls.Add(lblNomUsuario);
            Name = "frmLogin";
            Text = "Iniciar Sesion";
            FormClosing += frmLogin_FormClosing;
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
        private CheckBox cbxClave;
    }
}