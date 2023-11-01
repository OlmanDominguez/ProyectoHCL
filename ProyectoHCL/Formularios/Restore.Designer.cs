namespace ProyectoHCL.Formularios
{
    partial class Restore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restore));
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnMin = new Button();
            label6 = new Label();
            txtRuta = new TextBox();
            btnRestaurar = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            panel2.SuspendLayout();
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
            panel2.Size = new Size(915, 64);
            panel2.TabIndex = 25;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1500, 5);
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
            label11.Location = new Point(416, 9);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(169, 55);
            label11.TabIndex = 19;
            label11.Text = "Restore";
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(1464, 0);
            btnMin.Margin = new Padding(4, 5, 4, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(27, 33);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(560, -90);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(446, 43);
            label6.TabIndex = 26;
            label6.Text = "Restaurar base de datos";
            // 
            // txtRuta
            // 
            txtRuta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRuta.Location = new Point(267, 196);
            txtRuta.Margin = new Padding(4, 5, 4, 5);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(524, 39);
            txtRuta.TabIndex = 27;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnRestaurar.BackColor = Color.Green;
            btnRestaurar.BackgroundImageLayout = ImageLayout.Center;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Location = new Point(1164, 273);
            btnRestaurar.Margin = new Padding(4, 5, 4, 5);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(0, 68);
            btnRestaurar.TabIndex = 28;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(368, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 29;
            label1.Text = "Seleccionar archivo:";
            // 
            // Restore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(915, 466);
            Controls.Add(label1);
            Controls.Add(btnRestaurar);
            Controls.Add(txtRuta);
            Controls.Add(label6);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Restore";
            Text = "Restore";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private Label label11;
        private Button btnMin;
        private Label label6;
        private TextBox txtRuta;
        public Button btnRestaurar;
        private OpenFileDialog openFileDialog1;
        private Label label1;
    }
}