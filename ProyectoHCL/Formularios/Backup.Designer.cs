namespace ProyectoHCL.Formularios
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            panel2 = new Panel();
            btnCerrar = new Button();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            btnMin = new Button();
            panel3 = new Panel();
            Generar_Backup = new Button();
            label6 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnMin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1672, 73);
            panel2.TabIndex = 24;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1655, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(73, 69);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(774, 21);
            label11.Name = "label11";
            label11.Size = new Size(268, 37);
            label11.TabIndex = 19;
            label11.Text = "Copia de Seguridad";
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(1630, 1);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(Generar_Backup);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1672, 595);
            panel3.TabIndex = 26;
            // 
            // Generar_Backup
            // 
            Generar_Backup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Generar_Backup.BackColor = Color.Green;
            Generar_Backup.BackgroundImageLayout = ImageLayout.Center;
            Generar_Backup.FlatAppearance.BorderSize = 0;
            Generar_Backup.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Generar_Backup.FlatStyle = FlatStyle.Flat;
            Generar_Backup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Generar_Backup.ForeColor = Color.White;
            Generar_Backup.Location = new Point(789, 242);
            Generar_Backup.Name = "Generar_Backup";
            Generar_Backup.Size = new Size(203, 47);
            Generar_Backup.TabIndex = 21;
            Generar_Backup.Text = "Generar Backup";
            Generar_Backup.UseVisualStyleBackColor = false;
            Generar_Backup.Click += Generar_Backup_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(673, 187);
            label6.Name = "label6";
            label6.Size = new Size(431, 32);
            label6.TabIndex = 5;
            label6.Text = "Generar la base de datos del sistema";
            label6.Click += label6_Click;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1672, 668);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Backup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup";
            Load += Backup_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private PictureBox pictureBox5;
        private Label label11;
        private Button btnMin;
        public Panel panel3;
        public Button Generar_Backup;
        private Label label6;
        private SaveFileDialog saveFileDialog1;
    }
}