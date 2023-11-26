namespace ProyectoHCL
{
    partial class FORMULARIO
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMULARIO));
            Usuariolabel1 = new Label();
            Contraseñalabel2 = new Label();
            UsuarioBox1 = new TextBox();
            ContraseñaBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Ingresarbutton1 = new Button();
            label6 = new Label();
            label7 = new Label();
            MostrarBox3 = new PictureBox();
            OcultarBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnExit = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)MostrarBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Usuariolabel1
            // 
            Usuariolabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Usuariolabel1.AutoSize = true;
            Usuariolabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Usuariolabel1.ForeColor = SystemColors.Control;
            Usuariolabel1.Location = new Point(314, 449);
            Usuariolabel1.Name = "Usuariolabel1";
            Usuariolabel1.Size = new Size(102, 32);
            Usuariolabel1.TabIndex = 0;
            Usuariolabel1.Text = "Usuario";
            // 
            // Contraseñalabel2
            // 
            Contraseñalabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Contraseñalabel2.AutoSize = true;
            Contraseñalabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Contraseñalabel2.ForeColor = SystemColors.Control;
            Contraseñalabel2.Location = new Point(300, 568);
            Contraseñalabel2.Name = "Contraseñalabel2";
            Contraseñalabel2.Size = new Size(143, 32);
            Contraseñalabel2.TabIndex = 1;
            Contraseñalabel2.Text = "Contraseña";
            // 
            // UsuarioBox1
            // 
            UsuarioBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UsuarioBox1.BackColor = Color.DeepSkyBlue;
            UsuarioBox1.CharacterCasing = CharacterCasing.Upper;
            UsuarioBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsuarioBox1.Location = new Point(221, 513);
            UsuarioBox1.MaxLength = 8;
            UsuarioBox1.Name = "UsuarioBox1";
            UsuarioBox1.Size = new Size(318, 37);
            UsuarioBox1.TabIndex = 2;
            UsuarioBox1.TextChanged += UsuarioBox1_TextChanged;
            UsuarioBox1.KeyPress += UsuarioBox1_KeyPress;
            // 
            // ContraseñaBox2
            // 
            ContraseñaBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ContraseñaBox2.BackColor = Color.DeepSkyBlue;
            ContraseñaBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContraseñaBox2.Location = new Point(218, 613);
            ContraseñaBox2.MaxLength = 8;
            ContraseñaBox2.Name = "ContraseñaBox2";
            ContraseñaBox2.PasswordChar = '*';
            ContraseñaBox2.Size = new Size(323, 39);
            ContraseñaBox2.TabIndex = 3;
            ContraseñaBox2.TextChanged += ContraseñaBox2_TextChanged;
            ContraseñaBox2.DoubleClick += UsuarioBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(162, 883);
            label3.Name = "label3";
            label3.Size = new Size(445, 32);
            label3.TabIndex = 4;
            label3.Text = "¿Olvidaste tu usuario y/o contraseña?";
            label3.Click += label3_Click;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 22);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(726, 17);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 6;
            label5.Click += label5_Click;
            // 
            // Ingresarbutton1
            // 
            Ingresarbutton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Ingresarbutton1.BackColor = SystemColors.ButtonFace;
            Ingresarbutton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ingresarbutton1.ForeColor = SystemColors.ActiveCaptionText;
            Ingresarbutton1.Location = new Point(218, 721);
            Ingresarbutton1.Name = "Ingresarbutton1";
            Ingresarbutton1.Size = new Size(321, 55);
            Ingresarbutton1.TabIndex = 7;
            Ingresarbutton1.Text = "Ingresar";
            Ingresarbutton1.UseVisualStyleBackColor = false;
            Ingresarbutton1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(267, 247);
            label6.Name = "label6";
            label6.Size = new Size(284, 41);
            label6.TabIndex = 8;
            label6.Text = "BIENVENIDOS ";
            label6.Click += label6_Click_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(157, 322);
            label7.Name = "label7";
            label7.Size = new Size(440, 41);
            label7.TabIndex = 11;
            label7.Text = "A HOTEL CASA LOMAS";
            // 
            // MostrarBox3
            // 
            MostrarBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MostrarBox3.BackColor = Color.DeepSkyBlue;
            MostrarBox3.Image = (Image)resources.GetObject("MostrarBox3.Image");
            MostrarBox3.Location = new Point(495, 617);
            MostrarBox3.Name = "MostrarBox3";
            MostrarBox3.Size = new Size(44, 32);
            MostrarBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarBox3.TabIndex = 12;
            MostrarBox3.TabStop = false;
            MostrarBox3.Click += MostrarBox3_Click;
            // 
            // OcultarBox4
            // 
            OcultarBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OcultarBox4.BackColor = Color.DeepSkyBlue;
            OcultarBox4.Image = (Image)resources.GetObject("OcultarBox4.Image");
            OcultarBox4.Location = new Point(495, 615);
            OcultarBox4.Name = "OcultarBox4";
            OcultarBox4.Size = new Size(44, 32);
            OcultarBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            OcultarBox4.TabIndex = 13;
            OcultarBox4.TabStop = false;
            OcultarBox4.Click += OcultarBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(286, 40);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(632, 7);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(669, 5);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 30);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(Ingresarbutton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(MostrarBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(OcultarBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Usuariolabel1);
            panel1.Controls.Add(UsuarioBox1);
            panel1.Controls.Add(ContraseñaBox2);
            panel1.Controls.Add(Contraseñalabel2);
            errorProvider1.SetIconAlignment(panel1, ErrorIconAlignment.TopLeft);
            panel1.Location = new Point(622, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 969);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // FORMULARIO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1323, 968);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FORMULARIO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOTEL CASA LOMAS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MostrarBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuariolabel1;
        private Label Contraseñalabel2;
        private TextBox UsuarioBox1;
        private TextBox ContraseñaBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Ingresarbutton1;
        private Label label6;
        private Label label7;
        private PictureBox MostrarBox3;
        private PictureBox OcultarBox4;
        private PictureBox pictureBox2;
        private PictureBox btnExit;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ErrorProvider errorProvider1;
        private Panel panel1;
    }
}