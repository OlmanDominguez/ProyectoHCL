namespace ProyectoHCL.Formularios
{
    partial class ShowCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCliente));
            panel2 = new Panel();
            btnMin = new Button();
            btnCerrar = new Button();
            label11 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lb_Empresa = new Label();
            label9 = new Label();
            lb_RTN = new Label();
            label8 = new Label();
            lb_email2 = new Label();
            lb_email1 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            lb_Tele2 = new Label();
            lb_Tele1 = new Label();
            lb_ID = new Label();
            label4 = new Label();
            label3 = new Label();
            lb_apellidos = new Label();
            lb_nombres = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 73);
            panel2.TabIndex = 20;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(695, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 70;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(720, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 69;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(255, 19);
            label11.Name = "label11";
            label11.Size = new Size(247, 30);
            label11.TabIndex = 28;
            label11.Text = "Información del Cliente";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 157);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 29;
            label2.Text = "Nombres:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lb_Empresa);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lb_RTN);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lb_email2);
            panel1.Controls.Add(lb_email1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lb_Tele2);
            panel1.Controls.Add(lb_Tele1);
            panel1.Controls.Add(lb_ID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lb_apellidos);
            panel1.Controls.Add(lb_nombres);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 335);
            panel1.TabIndex = 21;
            // 
            // lb_Empresa
            // 
            lb_Empresa.Anchor = AnchorStyles.Top;
            lb_Empresa.AutoSize = true;
            lb_Empresa.BackColor = Color.Transparent;
            lb_Empresa.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Empresa.ForeColor = Color.Black;
            lb_Empresa.Location = new Point(130, 271);
            lb_Empresa.Name = "lb_Empresa";
            lb_Empresa.Size = new Size(0, 21);
            lb_Empresa.TabIndex = 48;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(40, 271);
            label9.Name = "label9";
            label9.Size = new Size(90, 19);
            label9.TabIndex = 47;
            label9.Text = "Empresa: ";
            // 
            // lb_RTN
            // 
            lb_RTN.Anchor = AnchorStyles.Top;
            lb_RTN.AutoSize = true;
            lb_RTN.BackColor = Color.Transparent;
            lb_RTN.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_RTN.ForeColor = Color.Black;
            lb_RTN.Location = new Point(85, 101);
            lb_RTN.Name = "lb_RTN";
            lb_RTN.Size = new Size(0, 21);
            lb_RTN.TabIndex = 46;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(41, 101);
            label8.Name = "label8";
            label8.Size = new Size(44, 19);
            label8.TabIndex = 45;
            label8.Text = "RTN:";
            // 
            // lb_email2
            // 
            lb_email2.Anchor = AnchorStyles.Top;
            lb_email2.AutoSize = true;
            lb_email2.BackColor = Color.Transparent;
            lb_email2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_email2.ForeColor = Color.Black;
            lb_email2.Location = new Point(469, 214);
            lb_email2.Name = "lb_email2";
            lb_email2.Size = new Size(0, 21);
            lb_email2.TabIndex = 44;
            // 
            // lb_email1
            // 
            lb_email1.Anchor = AnchorStyles.Top;
            lb_email1.AutoSize = true;
            lb_email1.BackColor = Color.Transparent;
            lb_email1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_email1.ForeColor = Color.Black;
            lb_email1.Location = new Point(469, 157);
            lb_email1.Name = "lb_email1";
            lb_email1.Size = new Size(0, 21);
            lb_email1.TabIndex = 43;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(390, 214);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 42;
            label7.Text = "E-Mail 2:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(390, 157);
            label5.Name = "label5";
            label5.Size = new Size(79, 19);
            label5.TabIndex = 41;
            label5.Text = "E-Mail 1:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(390, 101);
            label6.Name = "label6";
            label6.Size = new Size(99, 19);
            label6.TabIndex = 40;
            label6.Text = "Telefono 2:";
            // 
            // lb_Tele2
            // 
            lb_Tele2.Anchor = AnchorStyles.Top;
            lb_Tele2.AutoSize = true;
            lb_Tele2.BackColor = Color.Transparent;
            lb_Tele2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Tele2.ForeColor = Color.Black;
            lb_Tele2.Location = new Point(489, 101);
            lb_Tele2.Name = "lb_Tele2";
            lb_Tele2.Size = new Size(0, 21);
            lb_Tele2.TabIndex = 39;
            // 
            // lb_Tele1
            // 
            lb_Tele1.Anchor = AnchorStyles.Top;
            lb_Tele1.AutoSize = true;
            lb_Tele1.BackColor = Color.Transparent;
            lb_Tele1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Tele1.ForeColor = Color.Black;
            lb_Tele1.Location = new Point(489, 43);
            lb_Tele1.Name = "lb_Tele1";
            lb_Tele1.Size = new Size(0, 21);
            lb_Tele1.TabIndex = 38;
            // 
            // lb_ID
            // 
            lb_ID.Anchor = AnchorStyles.Top;
            lb_ID.AutoSize = true;
            lb_ID.BackColor = Color.Transparent;
            lb_ID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ID.ForeColor = Color.Black;
            lb_ID.Location = new Point(167, 43);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(0, 21);
            lb_ID.TabIndex = 37;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(390, 43);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 36;
            label4.Text = "Telefono 1:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 43);
            label3.Name = "label3";
            label3.Size = new Size(126, 19);
            label3.TabIndex = 35;
            label3.Text = "Identificación:";
            label3.Click += label3_Click;
            // 
            // lb_apellidos
            // 
            lb_apellidos.Anchor = AnchorStyles.Top;
            lb_apellidos.AutoSize = true;
            lb_apellidos.BackColor = Color.Transparent;
            lb_apellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_apellidos.ForeColor = Color.Black;
            lb_apellidos.Location = new Point(132, 214);
            lb_apellidos.Name = "lb_apellidos";
            lb_apellidos.Size = new Size(0, 21);
            lb_apellidos.TabIndex = 34;
            // 
            // lb_nombres
            // 
            lb_nombres.Anchor = AnchorStyles.Top;
            lb_nombres.AutoSize = true;
            lb_nombres.BackColor = Color.Transparent;
            lb_nombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nombres.ForeColor = Color.Black;
            lb_nombres.Location = new Point(132, 157);
            lb_nombres.Name = "lb_nombres";
            lb_nombres.Size = new Size(0, 21);
            lb_nombres.TabIndex = 33;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 214);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 32;
            label1.Text = "Apellidos:";
            // 
            // ShowCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 408);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowCliente";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            Load += ShowCliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label11;
        public TextBox txtDescripcion;
        public ComboBox cmbEstado;
        private Panel panel1;
        private Label label3;
        private Label lb_apellidos;
        private Label lb_nombres;
        private Label label1;
        private Label lb_email2;
        private Label lb_email1;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label lb_Tele2;
        private Label lb_Tele1;
        private Label lb_ID;
        private Label label4;
        private Label lb_RTN;
        private Label label8;
        private Label lb_Empresa;
        private Label label9;
        private Button btnCerrar;
        private Button btnMin;
    }
}