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
            tsmLogout = new ToolStripMenuItem();
            tsmUsuarios = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            tsmComisiones = new ToolStripMenuItem();
            tsmCursos = new ToolStripMenuItem();
            tsmPlanes = new ToolStripMenuItem();
            tsmEspecialidades = new ToolStripMenuItem();
            tsmInscripciones = new ToolStripMenuItem();
            tsmInscMaterias = new ToolStripMenuItem();
            tsmInscDocentes = new ToolStripMenuItem();
            subirNotasToolStripMenuItem = new ToolStripMenuItem();
            btnReporteCursos = new Button();
            button1 = new Button();
            panMenu = new Panel();
            tsmMaterias = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmCuenta, tsmUsuarios, personasToolStripMenuItem, tsmComisiones, tsmCursos, tsmPlanes, tsmEspecialidades, tsmInscripciones, subirNotasToolStripMenuItem, tsmMaterias });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1171, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmCuenta
            // 
            tsmCuenta.DropDownItems.AddRange(new ToolStripItem[] { tsmLogout });
            tsmCuenta.Name = "tsmCuenta";
            tsmCuenta.Size = new Size(69, 24);
            tsmCuenta.Text = "Cuenta";
            // 
            // tsmLogout
            // 
            tsmLogout.Name = "tsmLogout";
            tsmLogout.Size = new Size(139, 26);
            tsmLogout.Text = "Logout";
            tsmLogout.Click += tsmLogout_Click;
            // 
            // tsmUsuarios
            // 
            tsmUsuarios.Name = "tsmUsuarios";
            tsmUsuarios.Size = new Size(79, 24);
            tsmUsuarios.Text = "Usuarios";
            tsmUsuarios.Click += tsmUsuarios_Click;
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(80, 24);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // tsmComisiones
            // 
            tsmComisiones.Name = "tsmComisiones";
            tsmComisiones.Size = new Size(99, 24);
            tsmComisiones.Text = "Comisiones";
            tsmComisiones.Click += comisionesToolStripMenuItem_Click;
            // 
            // tsmCursos
            // 
            tsmCursos.Name = "tsmCursos";
            tsmCursos.Size = new Size(66, 24);
            tsmCursos.Text = "Cursos";
            tsmCursos.Click += tsmCursos_Click;
            // 
            // tsmPlanes
            // 
            tsmPlanes.Name = "tsmPlanes";
            tsmPlanes.Size = new Size(65, 24);
            tsmPlanes.Text = "Planes";
            tsmPlanes.Click += tsmPlanes_Click;
            // 
            // tsmEspecialidades
            // 
            tsmEspecialidades.Name = "tsmEspecialidades";
            tsmEspecialidades.Size = new Size(121, 24);
            tsmEspecialidades.Text = "Especialidades";
            tsmEspecialidades.Click += tsmEspecialidades_Click;
            // 
            // tsmInscripciones
            // 
            tsmInscripciones.DropDownItems.AddRange(new ToolStripItem[] { tsmInscMaterias, tsmInscDocentes });
            tsmInscripciones.Name = "tsmInscripciones";
            tsmInscripciones.Size = new Size(108, 24);
            tsmInscripciones.Text = "Inscripciones";
            // 
            // tsmInscMaterias
            // 
            tsmInscMaterias.Name = "tsmInscMaterias";
            tsmInscMaterias.Size = new Size(224, 26);
            tsmInscMaterias.Text = "Alumno";
            tsmInscMaterias.Click += tsmInscMaterias_Click;
            // 
            // tsmInscDocentes
            // 
            tsmInscDocentes.Name = "tsmInscDocentes";
            tsmInscDocentes.Size = new Size(224, 26);
            tsmInscDocentes.Text = "Docente";
            tsmInscDocentes.Click += tsmInscDocentes_Click;
            // 
            // subirNotasToolStripMenuItem
            // 
            subirNotasToolStripMenuItem.Name = "subirNotasToolStripMenuItem";
            subirNotasToolStripMenuItem.Size = new Size(100, 24);
            subirNotasToolStripMenuItem.Text = "Subir Notas";
            subirNotasToolStripMenuItem.Click += subirNotasToolStripMenuItem_Click;
            // 
            // btnReporteCursos
            // 
            btnReporteCursos.Location = new Point(14, 37);
            btnReporteCursos.Margin = new Padding(3, 4, 3, 4);
            btnReporteCursos.Name = "btnReporteCursos";
            btnReporteCursos.Size = new Size(150, 31);
            btnReporteCursos.TabIndex = 1;
            btnReporteCursos.Text = "Reporte Cursos";
            btnReporteCursos.UseVisualStyleBackColor = true;
            btnReporteCursos.Click += btnReporteCursos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 76);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(150, 31);
            button1.TabIndex = 2;
            button1.Text = "Reporte Planes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panMenu
            // 
            panMenu.Location = new Point(182, 37);
            panMenu.Margin = new Padding(3, 4, 3, 4);
            panMenu.Name = "panMenu";
            panMenu.Size = new Size(976, 687);
            panMenu.TabIndex = 3;
            // 
            // tsmMaterias
            // 
            tsmMaterias.Name = "tsmMaterias";
            tsmMaterias.Size = new Size(80, 24);
            tsmMaterias.Text = "Materias";
            tsmMaterias.Click += tsmMaterias_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 740);
            Controls.Add(panMenu);
            Controls.Add(button1);
            Controls.Add(btnReporteCursos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu";
            FormClosing += frmMenu_FormClosing;
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmCuenta;
        private ToolStripMenuItem tsmLogout;
        private ToolStripMenuItem tsmUsuarios;

        private ToolStripMenuItem tsmPlanes;
        private ToolStripMenuItem tsmEspecialidades;
        private ToolStripMenuItem tsmComisiones;
        private ToolStripMenuItem tsmCursos;
        private ToolStripMenuItem tsmInscripciones;
        private ToolStripMenuItem tsmInscMaterias;
        private ToolStripMenuItem tsmInscDocentes;
        private ToolStripMenuItem subirNotasToolStripMenuItem;
        private Button btnReporteCursos;
        private Button button1;
        private Panel panMenu;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem tsmMaterias;
    }
}