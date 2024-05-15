namespace Mateo
{
    partial class Form1
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
            btnAtender = new Button();
            btnSalir = new Button();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            rtbinfoMedico = new RichTextBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(632, 12);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(156, 92);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(632, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 79);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 31);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(297, 229);
            lstMedicos.TabIndex = 2;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(334, 31);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(273, 229);
            lstPacientes.TabIndex = 3;
            // 
            // rtbinfoMedico
            // 
            rtbinfoMedico.Location = new Point(12, 278);
            rtbinfoMedico.Name = "rtbinfoMedico";
            rtbinfoMedico.Size = new Size(595, 160);
            rtbinfoMedico.TabIndex = 4;
            rtbinfoMedico.Text = "";
            rtbinfoMedico.TextChanged += rtbinfoMedico_TextChanged;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 12);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(334, 13);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(rtbinfoMedico);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing_1;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox rtbinfoMedico;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}
