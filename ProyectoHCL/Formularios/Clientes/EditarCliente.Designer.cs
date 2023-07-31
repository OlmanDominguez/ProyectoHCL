namespace ProyectoHCL.Formularios
{
    partial class EditarCliente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCliente));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            label11 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            gb_juridico = new GroupBox();
            txtEmpresa = new TextBox();
            txtRTN = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            txtEmail2 = new TextBox();
            txtEmail1 = new TextBox();
            txtTele2 = new TextBox();
            txtTele1 = new TextBox();
            txtID = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            errorT = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            gb_juridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 73);
            panel2.TabIndex = 20;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 60;
            pictureBox5.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(749, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 31;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(273, 21);
            label11.Name = "label11";
            label11.Size = new Size(210, 30);
            label11.TabIndex = 28;
            label11.Text = "Información Cliente";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 51);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 29;
            label2.Text = "Nombres:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(gb_juridico);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtEmail2);
            panel1.Controls.Add(txtEmail1);
            panel1.Controls.Add(txtTele2);
            panel1.Controls.Add(txtTele1);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 401);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(442, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(230, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 58;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gb_juridico
            // 
            gb_juridico.Controls.Add(txtEmpresa);
            gb_juridico.Controls.Add(txtRTN);
            gb_juridico.Controls.Add(label8);
            gb_juridico.Controls.Add(label9);
            gb_juridico.Location = new Point(25, 223);
            gb_juridico.Name = "gb_juridico";
            gb_juridico.Size = new Size(720, 74);
            gb_juridico.TabIndex = 57;
            gb_juridico.TabStop = false;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Anchor = AnchorStyles.Top;
            txtEmpresa.BackColor = Color.DarkGray;
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.CharacterCasing = CharacterCasing.Upper;
            txtEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(462, 26);
            txtEmpresa.MaxLength = 15;
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ShortcutsEnabled = false;
            txtEmpresa.Size = new Size(238, 27);
            txtEmpresa.TabIndex = 59;
            // 
            // txtRTN
            // 
            txtRTN.Anchor = AnchorStyles.Top;
            txtRTN.BackColor = Color.DarkGray;
            txtRTN.BorderStyle = BorderStyle.FixedSingle;
            txtRTN.CharacterCasing = CharacterCasing.Upper;
            txtRTN.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRTN.Location = new Point(60, 26);
            txtRTN.MaxLength = 15;
            txtRTN.Name = "txtRTN";
            txtRTN.ShortcutsEnabled = false;
            txtRTN.Size = new Size(298, 27);
            txtRTN.TabIndex = 58;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 31);
            label8.Name = "label8";
            label8.Size = new Size(41, 19);
            label8.TabIndex = 45;
            label8.Text = "RTN:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(381, 31);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 47;
            label9.Text = "Empresa: ";
            // 
            // cbTipo
            // 
            cbTipo.BackColor = Color.DarkGray;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(457, 168);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(268, 28);
            cbTipo.TabIndex = 56;
            cbTipo.SelectedValueChanged += cbTipo_SelectedValueChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(406, 172);
            label10.Name = "label10";
            label10.Size = new Size(45, 19);
            label10.TabIndex = 55;
            label10.Text = "Tipo:";
            // 
            // txtEmail2
            // 
            txtEmail2.Anchor = AnchorStyles.Top;
            txtEmail2.BackColor = Color.DarkGray;
            txtEmail2.BorderStyle = BorderStyle.FixedSingle;
            txtEmail2.CharacterCasing = CharacterCasing.Upper;
            txtEmail2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail2.Location = new Point(124, 170);
            txtEmail2.MaxLength = 15;
            txtEmail2.Name = "txtEmail2";
            txtEmail2.ShortcutsEnabled = false;
            txtEmail2.Size = new Size(259, 27);
            txtEmail2.TabIndex = 54;
            // 
            // txtEmail1
            // 
            txtEmail1.Anchor = AnchorStyles.Top;
            txtEmail1.BackColor = Color.DarkGray;
            txtEmail1.BorderStyle = BorderStyle.FixedSingle;
            txtEmail1.CharacterCasing = CharacterCasing.Upper;
            txtEmail1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail1.Location = new Point(124, 128);
            txtEmail1.MaxLength = 15;
            txtEmail1.Name = "txtEmail1";
            txtEmail1.ShortcutsEnabled = false;
            txtEmail1.Size = new Size(259, 27);
            txtEmail1.TabIndex = 53;
            // 
            // txtTele2
            // 
            txtTele2.Anchor = AnchorStyles.Top;
            txtTele2.BackColor = Color.DarkGray;
            txtTele2.BorderStyle = BorderStyle.FixedSingle;
            txtTele2.CharacterCasing = CharacterCasing.Upper;
            txtTele2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTele2.Location = new Point(497, 128);
            txtTele2.MaxLength = 15;
            txtTele2.Name = "txtTele2";
            txtTele2.ShortcutsEnabled = false;
            txtTele2.Size = new Size(230, 27);
            txtTele2.TabIndex = 52;
            // 
            // txtTele1
            // 
            txtTele1.Anchor = AnchorStyles.Top;
            txtTele1.BackColor = Color.DarkGray;
            txtTele1.BorderStyle = BorderStyle.FixedSingle;
            txtTele1.CharacterCasing = CharacterCasing.Upper;
            txtTele1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTele1.Location = new Point(497, 89);
            txtTele1.MaxLength = 15;
            txtTele1.Name = "txtTele1";
            txtTele1.ShortcutsEnabled = false;
            txtTele1.Size = new Size(230, 27);
            txtTele1.TabIndex = 51;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BackColor = Color.DarkGray;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.CharacterCasing = CharacterCasing.Upper;
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(163, 89);
            txtID.MaxLength = 15;
            txtID.Name = "txtID";
            txtID.ShortcutsEnabled = false;
            txtID.Size = new Size(220, 27);
            txtID.TabIndex = 50;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.BackColor = Color.DarkGray;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(497, 47);
            txtApellido.MaxLength = 15;
            txtApellido.Name = "txtApellido";
            txtApellido.ShortcutsEnabled = false;
            txtApellido.Size = new Size(230, 27);
            txtApellido.TabIndex = 49;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.DarkGray;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(124, 47);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(259, 27);
            txtNombre.TabIndex = 48;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(38, 175);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 42;
            label7.Text = "E-Mail 2:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(38, 130);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 41;
            label5.Text = "E-Mail 1:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(406, 130);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 40;
            label6.Text = "Telefono 2:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(406, 91);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 36;
            label4.Text = "Telefono 1:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 91);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 35;
            label3.Text = "Identificación:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(406, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 32;
            label1.Text = "Apellidos:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // EditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 474);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarCliente";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            Load += EditarCliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gb_juridico.ResumeLayout(false);
            gb_juridico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label11;
        public TextBox txtDescripcion;
        public ComboBox cmbEstado;
        private Panel panel1;
        private Button btnCerrar;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label9;
        public TextBox txtNombre;
        public TextBox txtApellido;
        private ComboBox cbTipo;
        private Label label10;
        public TextBox txtEmail2;
        public TextBox txtEmail1;
        public TextBox txtTele2;
        public TextBox txtTele1;
        public TextBox txtID;
        private GroupBox gb_juridico;
        public TextBox txtEmpresa;
        public TextBox txtRTN;
        private Button btnCancelar;
        private Button btnGuardar;
        private ErrorProvider errorT;
        private PictureBox pictureBox5;
    }
}