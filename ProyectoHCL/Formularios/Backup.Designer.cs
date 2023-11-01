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
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnMin = new Button();
            panel3 = new Panel();
            Generar_Backup = new Button();
            label6 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnMin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 73);
            panel2.TabIndex = 24;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(2364, 5);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 28);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(467, 18);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(398, 55);
            label11.TabIndex = 19;
            label11.Text = "Copia de Seguridad";
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(2329, 2);
            btnMin.Margin = new Padding(4, 5, 4, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(27, 33);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(Generar_Backup);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 461);
            panel3.TabIndex = 38;
            // 
            // Generar_Backup
            // 
            Generar_Backup.BackColor = Color.Green;
            Generar_Backup.FlatAppearance.BorderSize = 0;
            Generar_Backup.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            Generar_Backup.FlatStyle = FlatStyle.Flat;
            Generar_Backup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Generar_Backup.ForeColor = Color.White;
            Generar_Backup.Location = new Point(488, 309);
            Generar_Backup.Margin = new Padding(4, 5, 4, 5);
            Generar_Backup.Name = "Generar_Backup";
            Generar_Backup.Size = new Size(377, 78);
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
            label6.Location = new Point(354, 228);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(630, 48);
            label6.TabIndex = 5;
            label6.Text = "Generar la base de datos del sistema";
            label6.Click += label6_Click;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1112, 534);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Enabled = false;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private Label label11;
        private Button btnMin;
        public Button Generar_Backup;
        private Label label6;
        private SaveFileDialog saveFileDialog1;
        private Panel panel3;
    }
}