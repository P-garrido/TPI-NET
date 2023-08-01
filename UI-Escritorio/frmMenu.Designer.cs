namespace UI_Escritorio
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmCuenta = new ToolStripMenuItem();
            tsmLogin = new ToolStripMenuItem();
            tsmLogout = new ToolStripMenuItem();
            tsmUsuarios = new ToolStripMenuItem();
            tsmAdministrar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmCuenta, tsmUsuarios });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCuenta
            // 
            tsmCuenta.DropDownItems.AddRange(new ToolStripItem[] { tsmLogin, tsmLogout });
            tsmCuenta.Name = "tsmCuenta";
            tsmCuenta.Size = new Size(69, 24);
            tsmCuenta.Text = "Cuenta";
            // 
            // tsmLogin
            // 
            tsmLogin.Name = "tsmLogin";
            tsmLogin.Size = new Size(224, 26);
            tsmLogin.Text = "Login";
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(224, 26);
            tsmLogout.Text = "Logout";
            // 
            // tsmUsuarios
            // 
            tsmUsuarios.DropDownItems.AddRange(new ToolStripItem[] { tsmAdministrar });
            tsmUsuarios.Name = "tsmUsuarios";
            tsmUsuarios.Size = new Size(79, 24);
            tsmUsuarios.Text = "Usuarios";
            // 
            // tsmAdministrar
            // 
            tsmAdministrar.Name = "tsmAdministrar";
            tsmAdministrar.Size = new Size(224, 26);
            tsmAdministrar.Text = "Administrar";
            tsmAdministrar.Click += tsmAdministrar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmCuenta;
        private ToolStripMenuItem tsmLogin;
        private ToolStripMenuItem tsmLogout;
        private ToolStripMenuItem tsmUsuarios;
        private ToolStripMenuItem tsmAdministrar;
    }
}