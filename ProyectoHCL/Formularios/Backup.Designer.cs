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
            label11 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            label6 = new Label();
            Generar_Backup = new Button();
            panel1 = new Panel();
            btnCerrar = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(424, 15);
            label11.Name = "label11";
            label11.Size = new Size(237, 32);
            label11.TabIndex = 19;
            label11.Text = "Copia de Seguridad";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(343, 45);
            label6.Name = "label6";
            label6.Size = new Size(393, 30);
            label6.TabIndex = 5;
            label6.Text = "Generar la base de datos del sistema";
            // 
            // Generar_Backup
            // 
            Generar_Backup.Anchor = AnchorStyles.Top;
            Generar_Backup.BackColor = Color.Green;
            Generar_Backup.BackgroundImageLayout = ImageLayout.Center;
            Generar_Backup.FlatAppearance.BorderSize = 0;
            Generar_Backup.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Generar_Backup.FlatStyle = FlatStyle.Flat;
            Generar_Backup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Generar_Backup.ForeColor = Color.White;
            Generar_Backup.ImageAlign = ContentAlignment.BottomCenter;
            Generar_Backup.Location = new Point(424, 93);
            Generar_Backup.Name = "Generar_Backup";
            Generar_Backup.Size = new Size(237, 36);
            Generar_Backup.TabIndex = 21;
            Generar_Backup.Text = "Generar Backup";
            Generar_Backup.UseVisualStyleBackColor = false;
            Generar_Backup.Click += Generar_Backup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 67);
            panel1.TabIndex = 23;
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
            btnCerrar.Location = new Point(1058, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Generar_Backup);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 67);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 494);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1084, 561);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Backup";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label11;
        private SaveFileDialog saveFileDialog1;
        private Label label6;
        public Button Generar_Backup;
        private Panel panel1;
        private Panel panel2;
        private Button btnCerrar;
        private PictureBox pictureBox1;
    }
}