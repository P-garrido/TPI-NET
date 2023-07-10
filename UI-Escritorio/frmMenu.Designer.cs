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
            toolStrip1 = new ToolStrip();
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            todosToolStripMenuItem = new ToolStripMenuItem();
            porNombreDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            nombreDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            claveToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem = new ToolStripMenuItem();
            apellidoToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            cambiarEstadoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, editarToolStripMenuItem, eliminarToolStripMenuItem, mostrarToolStripMenuItem, cambiarEstadoToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(59, 20);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(157, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreDeUsuarioToolStripMenuItem, claveToolStripMenuItem, nombreToolStripMenuItem, apellidoToolStripMenuItem, emailToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(157, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(157, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosToolStripMenuItem, porNombreDeUsuarioToolStripMenuItem });
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(157, 22);
            mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // todosToolStripMenuItem
            // 
            todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            todosToolStripMenuItem.Size = new Size(195, 22);
            todosToolStripMenuItem.Text = "Todos";
            // 
            // porNombreDeUsuarioToolStripMenuItem
            // 
            porNombreDeUsuarioToolStripMenuItem.Name = "porNombreDeUsuarioToolStripMenuItem";
            porNombreDeUsuarioToolStripMenuItem.Size = new Size(195, 22);
            porNombreDeUsuarioToolStripMenuItem.Text = "Por nombre de usuario";
            // 
            // nombreDeUsuarioToolStripMenuItem
            // 
            nombreDeUsuarioToolStripMenuItem.Name = "nombreDeUsuarioToolStripMenuItem";
            nombreDeUsuarioToolStripMenuItem.Size = new Size(180, 22);
            nombreDeUsuarioToolStripMenuItem.Text = "Nombre de usuario";
            // 
            // claveToolStripMenuItem
            // 
            claveToolStripMenuItem.Name = "claveToolStripMenuItem";
            claveToolStripMenuItem.Size = new Size(180, 22);
            claveToolStripMenuItem.Text = "Clave";
            // 
            // nombreToolStripMenuItem
            // 
            nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            nombreToolStripMenuItem.Size = new Size(180, 22);
            nombreToolStripMenuItem.Text = "Nombre";
            // 
            // apellidoToolStripMenuItem
            // 
            apellidoToolStripMenuItem.Name = "apellidoToolStripMenuItem";
            apellidoToolStripMenuItem.Size = new Size(180, 22);
            apellidoToolStripMenuItem.Text = "Apellido";
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(180, 22);
            emailToolStripMenuItem.Text = "Email";
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            cambiarEstadoToolStripMenuItem.Size = new Size(157, 22);
            cambiarEstadoToolStripMenuItem.Text = "Cambiar estado";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem nombreDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem claveToolStripMenuItem;
        private ToolStripMenuItem nombreToolStripMenuItem;
        private ToolStripMenuItem apellidoToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem todosToolStripMenuItem;
        private ToolStripMenuItem porNombreDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem cambiarEstadoToolStripMenuItem;
    }
}