namespace ProyectoHCL.Formularios
{
    partial class CalendarioReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioReservas));
            panel1 = new Panel();
            btnC = new Button();
            btnCerrar = new Button();
            label11 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            cmbHabitacion = new ComboBox();
            panel46 = new Panel();
            LBLMES = new Label();
            panel38 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSig = new Button();
            btnAnt = new Button();
            ContenedorDias = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel46.SuspendLayout();
            panel38.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnC);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 62);
            panel1.TabIndex = 3;
            // 
            // btnC
            // 
            btnC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnC.BackColor = Color.Transparent;
            btnC.BackgroundImage = (Image)resources.GetObject("btnC.BackgroundImage");
            btnC.BackgroundImageLayout = ImageLayout.Stretch;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Location = new Point(871, 12);
            btnC.Name = "btnC";
            btnC.Size = new Size(14, 17);
            btnC.TabIndex = 34;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1755, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 44;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(24, 16);
            label11.Name = "label11";
            label11.Size = new Size(318, 32);
            label11.TabIndex = 31;
            label11.Text = "Reservaciones programadas";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbHabitacion);
            panel2.Controls.Add(panel46);
            panel2.Controls.Add(panel38);
            panel2.Controls.Add(btnSig);
            panel2.Controls.Add(btnAnt);
            panel2.Controls.Add(ContenedorDias);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(897, 654);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(88, 29);
            label8.Name = "label8";
            label8.Size = new Size(185, 20);
            label8.TabIndex = 6;
            label8.Text = "Seleccione una habitación:";
            // 
            // cmbHabitacion
            // 
            cmbHabitacion.FormattingEnabled = true;
            cmbHabitacion.Location = new Point(279, 29);
            cmbHabitacion.Name = "cmbHabitacion";
            cmbHabitacion.Size = new Size(121, 23);
            cmbHabitacion.TabIndex = 5;
            cmbHabitacion.SelectedIndexChanged += cmbHabitacion_SelectedIndexChanged;
            // 
            // panel46
            // 
            panel46.Controls.Add(LBLMES);
            panel46.Location = new Point(88, 77);
            panel46.Name = "panel46";
            panel46.Size = new Size(715, 37);
            panel46.TabIndex = 4;
            // 
            // LBLMES
            // 
            LBLMES.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBLMES.ForeColor = SystemColors.ActiveCaptionText;
            LBLMES.Location = new Point(193, 8);
            LBLMES.Name = "LBLMES";
            LBLMES.Size = new Size(332, 21);
            LBLMES.TabIndex = 7;
            LBLMES.Text = "MES";
            LBLMES.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel38
            // 
            panel38.BackColor = Color.DarkOrange;
            panel38.Controls.Add(label7);
            panel38.Controls.Add(label6);
            panel38.Controls.Add(label5);
            panel38.Controls.Add(label4);
            panel38.Controls.Add(label3);
            panel38.Controls.Add(label2);
            panel38.Controls.Add(label1);
            panel38.Location = new Point(88, 116);
            panel38.Name = "panel38";
            panel38.Size = new Size(715, 35);
            panel38.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(631, 8);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 6;
            label7.Text = "Sábado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(529, 8);
            label6.Name = "label6";
            label6.Size = new Size(63, 18);
            label6.TabIndex = 5;
            label6.Text = "Viernes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(429, 8);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 4;
            label5.Text = "Jueves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(319, 8);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 3;
            label4.Text = "Miércoles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(228, 10);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Martes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(130, 10);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 1;
            label2.Text = "Lunes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 0;
            label1.Text = "Domingo";
            // 
            // btnSig
            // 
            btnSig.BackColor = Color.Transparent;
            btnSig.BackgroundImage = (Image)resources.GetObject("btnSig.BackgroundImage");
            btnSig.BackgroundImageLayout = ImageLayout.Zoom;
            btnSig.FlatAppearance.BorderSize = 0;
            btnSig.FlatStyle = FlatStyle.Flat;
            btnSig.Location = new Point(760, 596);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(43, 34);
            btnSig.TabIndex = 2;
            btnSig.UseVisualStyleBackColor = false;
            btnSig.Click += btnSig_Click;
            // 
            // btnAnt
            // 
            btnAnt.BackColor = Color.Transparent;
            btnAnt.BackgroundImage = (Image)resources.GetObject("btnAnt.BackgroundImage");
            btnAnt.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnt.FlatAppearance.BorderSize = 0;
            btnAnt.FlatStyle = FlatStyle.Flat;
            btnAnt.Location = new Point(703, 596);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(43, 34);
            btnAnt.TabIndex = 1;
            btnAnt.UseVisualStyleBackColor = false;
            btnAnt.Click += btnAnt_Click;
            // 
            // ContenedorDias
            // 
            ContenedorDias.BackColor = Color.LightGray;
            ContenedorDias.Location = new Point(88, 157);
            ContenedorDias.Name = "ContenedorDias";
            ContenedorDias.Size = new Size(715, 423);
            ContenedorDias.TabIndex = 0;
            // 
            // CalendarioReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(897, 716);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalendarioReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += CalendarioReservas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel46.ResumeLayout(false);
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnCerrar;
        private Label label11;
        private Button btnC;
        private Panel panel2;
        private FlowLayoutPanel ContenedorDias;
        private Panel panel38;
        private Label label1;
        private Button btnSig;
        private Button btnAnt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel46;
        private Label LBLMES;
        private Label label8;
        private ComboBox cmbHabitacion;
    }
}