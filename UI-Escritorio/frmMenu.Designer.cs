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
            materiasToolStripMenuItem = new ToolStripMenuItem();
            tsmUsuarios = new ToolStripMenuItem();
            tsmAdministrar = new ToolStripMenuItem();
            tsmComisiones = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmCuenta, tsmUsuarios, tsmComisiones });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCuenta
            // 
            tsmCuenta.DropDownItems.AddRange(new ToolStripItem[] { tsmLogin, tsmLogout, materiasToolStripMenuItem });
            tsmCuenta.Name = "tsmCuenta";
            tsmCuenta.Size = new Size(57, 20);
            tsmCuenta.Text = "Cuenta";
            // 
            // tsmLogin
            // 
            tsmLogin.Name = "tsmLogin";
            tsmLogin.Size = new Size(119, 22);
            tsmLogin.Text = "Login";
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(119, 22);
            tsmLogout.Text = "Logout";
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(119, 22);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // tsmUsuarios
            // 
            tsmUsuarios.DropDownItems.AddRange(new ToolStripItem[] { tsmAdministrar });
            tsmUsuarios.Name = "tsmUsuarios";
            tsmUsuarios.Size = new Size(64, 20);
            tsmUsuarios.Text = "Usuarios";
            // 
            // tsmAdministrar
            // 
            tsmAdministrar.Name = "tsmAdministrar";
            tsmAdministrar.Size = new Size(136, 22);
            tsmAdministrar.Text = "Administrar";
            tsmAdministrar.Click += tsmAdministrar_Click;
            // 
            // tsmComisiones
            // 
            tsmComisiones.Name = "tsmComisiones";
            tsmComisiones.Size = new Size(81, 20);
            tsmComisiones.Text = "Comisiones";
            tsmComisiones.Click += comisionesToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem tsmComisiones;
    }
}