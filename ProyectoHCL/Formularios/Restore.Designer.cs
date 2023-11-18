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
            label11 = new Label();
            txtRuta = new TextBox();
            btnRestaurar = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            panel3 = new Panel();
            btnCerrar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.White;
            label11.Name = "label11";
            // 
            // txtRuta
            // 
            resources.ApplyResources(txtRuta, "txtRuta");
            txtRuta.Name = "txtRuta";
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(btnRestaurar, "btnRestaurar");
            btnRestaurar.BackColor = Color.Green;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.UseVisualStyleBackColor = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(label11);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // btnCerrar
            // 
            resources.ApplyResources(btnCerrar, "btnCerrar");
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRuta);
            panel1.Controls.Add(btnRestaurar);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // Restore
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Restore";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label11;
        private TextBox txtRuta;
        public Button btnRestaurar;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private Button btnCerrar;
        private PictureBox pictureBox1;
    }
}