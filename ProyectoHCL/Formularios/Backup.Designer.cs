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
            btnMin = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(421, 29);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(398, 55);
            label11.TabIndex = 19;
            label11.Text = "Copia de Seguridad";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(329, 247);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(630, 48);
            label6.TabIndex = 5;
            label6.Text = "Generar la base de datos del sistema";
            // 
            // Generar_Backup
            // 
            Generar_Backup.BackColor = Color.Green;
            Generar_Backup.BackgroundImageLayout = ImageLayout.Center;
            Generar_Backup.FlatAppearance.BorderSize = 0;
            Generar_Backup.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Generar_Backup.FlatStyle = FlatStyle.Flat;
            Generar_Backup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Generar_Backup.ForeColor = Color.White;
            Generar_Backup.ImageAlign = ContentAlignment.BottomCenter;
            Generar_Backup.Location = new Point(421, 322);
            Generar_Backup.Margin = new Padding(4, 5, 4, 5);
            Generar_Backup.Name = "Generar_Backup";
            Generar_Backup.Size = new Size(377, 78);
            Generar_Backup.TabIndex = 21;
            Generar_Backup.Text = "Generar Backup";
            Generar_Backup.UseVisualStyleBackColor = false;
            Generar_Backup.Click += Generar_Backup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 122);
            panel1.TabIndex = 23;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1229, 20);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 28);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(1179, 17);
            btnMin.Margin = new Padding(4, 5, 4, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(27, 33);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Generar_Backup);
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1266, 696);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1265, 815);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Button btnMin;
    }
}