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
            tsiUsuario = new ToolStripMenuItem();
            tsiAgregar = new ToolStripMenuItem();
            tsiMostrar = new ToolStripMenuItem();
            tsiMostrarTodos = new ToolStripMenuItem();
            tsiPorNombreDeUsuario = new ToolStripMenuItem();
            tsiEditar = new ToolStripMenuItem();
            tsiEditarNombreDeUsuario = new ToolStripMenuItem();
            tsiEditarClave = new ToolStripMenuItem();
            tsiEditarNombre = new ToolStripMenuItem();
            tsiEditarApellido = new ToolStripMenuItem();
            tsiEditarEmail = new ToolStripMenuItem();
            tsiCambiarEstado = new ToolStripMenuItem();
            tsiEliminar = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsiUsuario });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tsiUsuario
            // 
            tsiUsuario.DropDownItems.AddRange(new ToolStripItem[] { tsiAgregar, tsiMostrar, tsiEditar, tsiCambiarEstado, tsiEliminar });
            tsiUsuario.Name = "tsiUsuario";
            tsiUsuario.Size = new Size(73, 24);
            tsiUsuario.Text = "Usuario";
            // 
            // tsiAgregar
            // 
            tsiAgregar.Name = "tsiAgregar";
            tsiAgregar.Size = new Size(197, 26);
            tsiAgregar.Text = "Agregar";
            tsiAgregar.Click += tsiAgregar_Click;
            // 
            // tsiMostrar
            // 
            tsiMostrar.DropDownItems.AddRange(new ToolStripItem[] { tsiMostrarTodos, tsiPorNombreDeUsuario });
            tsiMostrar.Name = "tsiMostrar";
            tsiMostrar.Size = new Size(197, 26);
            tsiMostrar.Text = "Mostrar";
            // 
            // tsiMostrarTodos
            // 
            tsiMostrarTodos.Name = "tsiMostrarTodos";
            tsiMostrarTodos.Size = new Size(242, 26);
            tsiMostrarTodos.Text = "Todos";
            tsiMostrarTodos.Click += tsiMostrarTodos_Click;
            // 
            // tsiPorNombreDeUsuario
            // 
            tsiPorNombreDeUsuario.Name = "tsiPorNombreDeUsuario";
            tsiPorNombreDeUsuario.Size = new Size(242, 26);
            tsiPorNombreDeUsuario.Text = "Por nombre de usuario";
            tsiPorNombreDeUsuario.Click += tsiPorNombreDeUsuario_Click;
            // 
            // tsiEditar
            // 
            tsiEditar.DropDownItems.AddRange(new ToolStripItem[] { tsiEditarNombreDeUsuario, tsiEditarClave, tsiEditarNombre, tsiEditarApellido, tsiEditarEmail });
            tsiEditar.Name = "tsiEditar";
            tsiEditar.Size = new Size(197, 26);
            tsiEditar.Text = "Editar";
            tsiEditar.Click += tsiEditar_Click;
            // 
            // tsiEditarNombreDeUsuario
            // 
            tsiEditarNombreDeUsuario.Name = "tsiEditarNombreDeUsuario";
            tsiEditarNombreDeUsuario.Size = new Size(220, 26);
            tsiEditarNombreDeUsuario.Text = "Nombre de usuario";
            // 
            // tsiEditarClave
            // 
            tsiEditarClave.Name = "tsiEditarClave";
            tsiEditarClave.Size = new Size(220, 26);
            tsiEditarClave.Text = "Clave";
            // 
            // tsiEditarNombre
            // 
            tsiEditarNombre.Name = "tsiEditarNombre";
            tsiEditarNombre.Size = new Size(220, 26);
            tsiEditarNombre.Text = "Nombre";
            // 
            // tsiEditarApellido
            // 
            tsiEditarApellido.Name = "tsiEditarApellido";
            tsiEditarApellido.Size = new Size(220, 26);
            tsiEditarApellido.Text = "Apellido";
            // 
            // tsiEditarEmail
            // 
            tsiEditarEmail.Name = "tsiEditarEmail";
            tsiEditarEmail.Size = new Size(220, 26);
            tsiEditarEmail.Text = "Email";
            // 
            // tsiCambiarEstado
            // 
            tsiCambiarEstado.Name = "tsiCambiarEstado";
            tsiCambiarEstado.Size = new Size(197, 26);
            tsiCambiarEstado.Text = "Cambiar Estado";
            // 
            // tsiEliminar
            // 
            tsiEliminar.Name = "tsiEliminar";
            tsiEliminar.Size = new Size(197, 26);
            tsiEliminar.Text = "Eliminar";
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
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsiUsuario;
        private ToolStripMenuItem tsiAgregar;
        private ToolStripMenuItem tsiMostrar;
        private ToolStripMenuItem tsiMostrarTodos;
        private ToolStripMenuItem tsiPorNombreDeUsuario;
        private ToolStripMenuItem tsiEditar;
        private ToolStripMenuItem tsiEditarNombreDeUsuario;
        private ToolStripMenuItem tsiEditarClave;
        private ToolStripMenuItem tsiEditarNombre;
        private ToolStripMenuItem tsiEditarApellido;
        private ToolStripMenuItem tsiEditarEmail;
        private ToolStripMenuItem tsiCambiarEstado;
        private ToolStripMenuItem tsiEliminar;
    }
}