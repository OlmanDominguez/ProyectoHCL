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
            label6 = new Label();
            txtRuta = new TextBox();
            btnRestaurar = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.BackColor = Color.Transparent;
            label11.ForeColor = Color.White;
            label11.Name = "label11";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Black;
            label6.Name = "label6";
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
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtRuta);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(label11);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // Restore
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label6);
            Name = "Restore";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Label label6;
        private TextBox txtRuta;
        public Button btnRestaurar;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
    }
}