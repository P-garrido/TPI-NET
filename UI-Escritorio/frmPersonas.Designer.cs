namespace UI_Escritorio
{
    partial class frmPersonas
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
            dgvPersonas = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtFechaNac = new TextBox();
            lblFecha_nac = new Label();
            txtTipoPersona = new TextBox();
            lblTipoPersona = new Label();
            txtLegajo = new TextBox();
            lblLegajo = new Label();
            txtPlan = new TextBox();
            lblPlan = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(10, 9);
            dgvPersonas.Margin = new Padding(3, 2, 3, 2);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 29;
            dgvPersonas.Size = new Size(679, 141);
            dgvPersonas.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 169);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 170);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(128, 198);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(110, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 197);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(128, 223);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(110, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(17, 222);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 248);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(128, 273);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(17, 272);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // txtFechaNac
            // 
            txtFechaNac.Location = new Point(128, 298);
            txtFechaNac.Margin = new Padding(3, 2, 3, 2);
            txtFechaNac.Name = "txtFechaNac";
            txtFechaNac.Size = new Size(110, 23);
            txtFechaNac.TabIndex = 12;
            // 
            // lblFecha_nac
            // 
            lblFecha_nac.AutoSize = true;
            lblFecha_nac.Location = new Point(10, 297);
            lblFecha_nac.Name = "lblFecha_nac";
            lblFecha_nac.Size = new Size(103, 15);
            lblFecha_nac.TabIndex = 11;
            lblFecha_nac.Text = "Fecha Nacimiento";
            // 
            // txtTipoPersona
            // 
            txtTipoPersona.Location = new Point(128, 322);
            txtTipoPersona.Margin = new Padding(3, 2, 3, 2);
            txtTipoPersona.Name = "txtTipoPersona";
            txtTipoPersona.Size = new Size(110, 23);
            txtTipoPersona.TabIndex = 14;
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(10, 322);
            lblTipoPersona.Name = "lblTipoPersona";
            lblTipoPersona.Size = new Size(75, 15);
            lblTipoPersona.TabIndex = 13;
            lblTipoPersona.Text = "Tipo Persona";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(128, 358);
            txtLegajo.Margin = new Padding(3, 2, 3, 2);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(110, 23);
            txtLegajo.TabIndex = 16;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(10, 357);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 15;
            lblLegajo.Text = "Legajo";
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(128, 394);
            txtPlan.Margin = new Padding(3, 2, 3, 2);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(110, 23);
            txtPlan.TabIndex = 18;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(17, 394);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 17;
            lblPlan.Text = "Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(10, 459);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(108, 459);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(207, 459);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 514);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(txtPlan);
            Controls.Add(lblPlan);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(txtTipoPersona);
            Controls.Add(lblTipoPersona);
            Controls.Add(txtFechaNac);
            Controls.Add(lblFecha_nac);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(dgvPersonas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPersonas";
            Text = "Personas";
            FormClosing += frmPersonas_FormClosing;
            Load += frmPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonas;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtFechaNac;
        private Label lblFecha_nac;
        private TextBox txtTipoPersona;
        private Label lblTipoPersona;
        private TextBox txtLegajo;
        private Label lblLegajo;
        private TextBox txtPlan;
        private Label lblPlan;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}