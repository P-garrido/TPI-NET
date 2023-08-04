namespace UI_Escritorio
{
    partial class frmCursos
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
            lblNomMateria = new Label();
            txtNomMateria = new TextBox();
            dataGridView1 = new DataGridView();
            txtComision = new TextBox();
            lblComision = new Label();
            txtAnioCal = new TextBox();
            lblAnioCalendario = new Label();
            txtCupo = new TextBox();
            lblCupo = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNomMateria
            // 
            lblNomMateria.AutoSize = true;
            lblNomMateria.Location = new Point(12, 186);
            lblNomMateria.Name = "lblNomMateria";
            lblNomMateria.Size = new Size(47, 15);
            lblNomMateria.TabIndex = 0;
            lblNomMateria.Text = "Materia";
            // 
            // txtNomMateria
            // 
            txtNomMateria.Location = new Point(94, 183);
            txtNomMateria.Name = "txtNomMateria";
            txtNomMateria.Size = new Size(100, 23);
            txtNomMateria.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(638, 160);
            dataGridView1.TabIndex = 2;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(94, 219);
            txtComision.Name = "txtComision";
            txtComision.Size = new Size(100, 23);
            txtComision.TabIndex = 4;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(12, 222);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(58, 15);
            lblComision.TabIndex = 3;
            lblComision.Text = "Comision";
            // 
            // txtAnioCal
            // 
            txtAnioCal.Location = new Point(94, 257);
            txtAnioCal.Name = "txtAnioCal";
            txtAnioCal.Size = new Size(100, 23);
            txtAnioCal.TabIndex = 6;
            // 
            // lblAnioCalendario
            // 
            lblAnioCalendario.AutoSize = true;
            lblAnioCalendario.Location = new Point(12, 260);
            lblAnioCalendario.Name = "lblAnioCalendario";
            lblAnioCalendario.Size = new Size(89, 15);
            lblAnioCalendario.TabIndex = 5;
            lblAnioCalendario.Text = "Año Calendario";
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(94, 295);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(100, 23);
            txtCupo.TabIndex = 8;
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(12, 298);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(36, 15);
            lblCupo.TabIndex = 7;
            lblCupo.Text = "Cupo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 330);
            Controls.Add(comboBox1);
            Controls.Add(txtCupo);
            Controls.Add(lblCupo);
            Controls.Add(txtAnioCal);
            Controls.Add(lblAnioCalendario);
            Controls.Add(txtComision);
            Controls.Add(lblComision);
            Controls.Add(dataGridView1);
            Controls.Add(txtNomMateria);
            Controls.Add(lblNomMateria);
            Name = "frmCursos";
            Text = "Menú Cursos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomMateria;
        private TextBox txtNomMateria;
        private DataGridView dataGridView1;
        private TextBox txtComision;
        private Label lblComision;
        private TextBox txtAnioCal;
        private Label lblAnioCalendario;
        private TextBox txtCupo;
        private Label lblCupo;
        private ComboBox comboBox1;
    }
}