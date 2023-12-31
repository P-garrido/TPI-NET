﻿namespace UI_Escritorio
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
            lblFecha_nac = new Label();
            lblTipoPersona = new Label();
            txtLegajo = new TextBox();
            lblLegajo = new Label();
            lblPlan = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            cmbPlanes = new ComboBox();
            cmbTipoPersona = new ComboBox();
            dtpFechaNac = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(11, 12);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 29;
            dgvPersonas.Size = new Size(776, 188);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.Click += dgvPersonas_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 225);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 227);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(146, 264);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(19, 263);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(146, 297);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(19, 296);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(11, 333);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(146, 364);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(19, 363);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblFecha_nac
            // 
            lblFecha_nac.AutoSize = true;
            lblFecha_nac.Location = new Point(11, 396);
            lblFecha_nac.Name = "lblFecha_nac";
            lblFecha_nac.Size = new Size(128, 20);
            lblFecha_nac.TabIndex = 11;
            lblFecha_nac.Text = "Fecha Nacimiento\r\n";
            // 
            // lblTipoPersona
            // 
            lblTipoPersona.AutoSize = true;
            lblTipoPersona.Location = new Point(11, 429);
            lblTipoPersona.Name = "lblTipoPersona";
            lblTipoPersona.Size = new Size(94, 20);
            lblTipoPersona.TabIndex = 13;
            lblTipoPersona.Text = "Tipo Persona";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(146, 477);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(125, 27);
            txtLegajo.TabIndex = 16;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(11, 476);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(54, 20);
            lblLegajo.TabIndex = 15;
            lblLegajo.Text = "Legajo";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(19, 525);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(37, 20);
            lblPlan.TabIndex = 17;
            lblPlan.Text = "Plan";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(11, 612);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(123, 612);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(237, 612);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbPlanes
            // 
            cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(146, 525);
            cmbPlanes.Margin = new Padding(3, 4, 3, 4);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(138, 28);
            cmbPlanes.TabIndex = 22;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            // 
            // cmbTipoPersona
            // 
            cmbTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPersona.FormattingEnabled = true;
            cmbTipoPersona.Location = new Point(146, 429);
            cmbTipoPersona.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPersona.Name = "cmbTipoPersona";
            cmbTipoPersona.Size = new Size(138, 28);
            cmbTipoPersona.TabIndex = 26;
            cmbTipoPersona.SelectedIndexChanged += cmbTipoPersona_SelectedIndexChanged;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(146, 396);
            dtpFechaNac.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(125, 27);
            dtpFechaNac.TabIndex = 27;
            dtpFechaNac.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // frmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 685);
            Controls.Add(dtpFechaNac);
            Controls.Add(cmbTipoPersona);
            Controls.Add(cmbPlanes);
            Controls.Add(btnGuardar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(lblPlan);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(lblTipoPersona);
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
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblFecha_nac;
        private Label lblTipoPersona;
        private TextBox txtLegajo;
        private Label lblLegajo;
        private Label lblPlan;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private ComboBox cmbPlanes;
        private ComboBox cmbTipoPersona;
        private DateTimePicker dtpFechaNac;
    }
}