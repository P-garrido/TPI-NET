namespace UI_Escritorio
{
    partial class frmIdentificacion
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
            label1 = new Label();
            btnRegistrado = new Button();
            btnNoRegistrado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 69);
            label1.Name = "label1";
            label1.Size = new Size(220, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Se encuentra registrado como Persona?";
            // 
            // btnRegistrado
            // 
            btnRegistrado.Location = new Point(203, 112);
            btnRegistrado.Margin = new Padding(3, 2, 3, 2);
            btnRegistrado.Name = "btnRegistrado";
            btnRegistrado.Size = new Size(82, 22);
            btnRegistrado.TabIndex = 1;
            btnRegistrado.Text = "Si";
            btnRegistrado.UseVisualStyleBackColor = true;
            btnRegistrado.Click += btnRegistrado_Click;
            // 
            // btnNoRegistrado
            // 
            btnNoRegistrado.Location = new Point(67, 112);
            btnNoRegistrado.Margin = new Padding(3, 2, 3, 2);
            btnNoRegistrado.Name = "btnNoRegistrado";
            btnNoRegistrado.Size = new Size(82, 22);
            btnNoRegistrado.TabIndex = 2;
            btnNoRegistrado.Text = "No";
            btnNoRegistrado.UseVisualStyleBackColor = true;
            btnNoRegistrado.Click += btnNoRegistrado_Click;
            // 
            // frmIdentificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 209);
            Controls.Add(btnNoRegistrado);
            Controls.Add(btnRegistrado);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmIdentificacion";
            Text = "Identificación";
            FormClosing += frmIdentificacion_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrado;
        private Button btnNoRegistrado;
    }
}