namespace ProyectoHCL.Formularios
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            panel2 = new Panel();
            btnMin = new Button();
            btnCerrar = new Button();
            label11 = new Label();
            panel3 = new Panel();
            txtEmail2 = new TextBox();
            label7 = new Label();
            label20 = new Label();
            cbTipo = new ComboBox();
            label10 = new Label();
            label15 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtEmail1 = new TextBox();
            label16 = new Label();
            label5 = new Label();
            label22 = new Label();
            label14 = new Label();
            label12 = new Label();
            label18 = new Label();
            label13 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            gb_juridico = new GroupBox();
            txtEmpresa = new TextBox();
            txtRTN = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtNombre = new TextBox();
            txtTele2 = new TextBox();
            txtTele1 = new TextBox();
            txtID = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            errorT = new ErrorProvider(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            gb_juridico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
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
            panel2.Size = new Size(775, 67);
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
            btnMin.Location = new Point(733, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 69;
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
            btnCerrar.Location = new Point(758, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 68;
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
            label11.Location = new Point(284, 9);
            label11.Name = "label11";
            label11.Size = new Size(178, 30);
            label11.TabIndex = 28;
            label11.Text = "Registrar Cliente";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(txtEmail2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label20);
            panel3.Location = new Point(420, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 74);
            panel3.TabIndex = 70;
            panel3.Visible = false;
            panel3.Paint += panel3_Paint;
            // 
            // txtEmail2
            // 
            txtEmail2.Anchor = AnchorStyles.Top;
            txtEmail2.BackColor = Color.White;
            txtEmail2.BorderStyle = BorderStyle.FixedSingle;
            txtEmail2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail2.Location = new Point(9, 39);
            txtEmail2.MaxLength = 200;
            txtEmail2.Name = "txtEmail2";
            txtEmail2.ShortcutsEnabled = false;
            txtEmail2.Size = new Size(309, 27);
            txtEmail2.TabIndex = 54;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 42;
            label7.Text = "E-Mail 2:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(84, 6);
            label20.Name = "label20";
            label20.Size = new Size(23, 30);
            label20.TabIndex = 69;
            label20.Text = "*";
            // 
            // cbTipo
            // 
            cbTipo.BackColor = Color.White;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(48, 105);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(307, 28);
            cbTipo.TabIndex = 56;
            cbTipo.SelectedValueChanged += cbTipo_SelectedValueChanged;
            cbTipo.Leave += cbTipo_Leave;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(48, 79);
            label10.Name = "label10";
            label10.Size = new Size(45, 19);
            label10.TabIndex = 55;
            label10.Text = "Tipo:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(89, 68);
            label15.Name = "label15";
            label15.Size = new Size(23, 30);
            label15.TabIndex = 63;
            label15.Text = "*";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 147);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 29;
            label2.Text = "Nombres:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(txtEmail1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(gb_juridico);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTele2);
            panel1.Controls.Add(txtTele1);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 407);
            panel1.TabIndex = 21;
            // 
            // txtEmail1
            // 
            txtEmail1.Anchor = AnchorStyles.Top;
            txtEmail1.BackColor = Color.White;
            txtEmail1.BorderStyle = BorderStyle.FixedSingle;
            txtEmail1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail1.Location = new Point(429, 177);
            txtEmail1.MaxLength = 200;
            txtEmail1.Name = "txtEmail1";
            txtEmail1.ShortcutsEnabled = false;
            txtEmail1.Size = new Size(309, 27);
            txtEmail1.TabIndex = 53;
            txtEmail1.Click += txtEmail1_Click;
            txtEmail1.TextChanged += txtEmail1_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(499, 136);
            label16.Name = "label16";
            label16.Size = new Size(23, 30);
            label16.TabIndex = 64;
            label16.Text = "*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(429, 144);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 41;
            label5.Text = "E-Mail 1:";
            label5.Click += label5_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(517, 3);
            label22.Name = "label22";
            label22.Size = new Size(23, 30);
            label22.TabIndex = 71;
            label22.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(131, 208);
            label14.Name = "label14";
            label14.Size = new Size(23, 30);
            label14.TabIndex = 70;
            label14.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(171, 3);
            label12.Name = "label12";
            label12.Size = new Size(23, 30);
            label12.TabIndex = 68;
            label12.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(517, 68);
            label18.Name = "label18";
            label18.Size = new Size(23, 30);
            label18.TabIndex = 66;
            label18.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(131, 136);
            label13.Name = "label13";
            label13.Size = new Size(23, 30);
            label13.TabIndex = 61;
            label13.Text = "*";
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
            btnCancelar.Location = new Point(442, 363);
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
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(230, 363);
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
            gb_juridico.Location = new Point(32, 283);
            gb_juridico.Name = "gb_juridico";
            gb_juridico.Size = new Size(720, 74);
            gb_juridico.TabIndex = 57;
            gb_juridico.TabStop = false;
            gb_juridico.Visible = false;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Anchor = AnchorStyles.Top;
            txtEmpresa.BackColor = Color.White;
            txtEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtEmpresa.CharacterCasing = CharacterCasing.Upper;
            txtEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmpresa.Location = new Point(397, 31);
            txtEmpresa.MaxLength = 200;
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.ShortcutsEnabled = false;
            txtEmpresa.Size = new Size(309, 27);
            txtEmpresa.TabIndex = 59;
            txtEmpresa.KeyPress += txtEmpresa_KeyPress;
            txtEmpresa.Leave += txtEmpresa_Leave;
            // 
            // txtRTN
            // 
            txtRTN.Anchor = AnchorStyles.Top;
            txtRTN.BackColor = Color.White;
            txtRTN.BorderStyle = BorderStyle.FixedSingle;
            txtRTN.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRTN.Location = new Point(22, 31);
            txtRTN.MaxLength = 14;
            txtRTN.Name = "txtRTN";
            txtRTN.ShortcutsEnabled = false;
            txtRTN.Size = new Size(301, 27);
            txtRTN.TabIndex = 58;
            txtRTN.KeyPress += txtRTN_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 9);
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
            label9.Location = new Point(397, 9);
            label9.Name = "label9";
            label9.Size = new Size(84, 19);
            label9.TabIndex = 47;
            label9.Text = "Empresa: ";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(52, 177);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(303, 27);
            txtNombre.TabIndex = 48;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtTele2
            // 
            txtTele2.Anchor = AnchorStyles.Top;
            txtTele2.BackColor = Color.White;
            txtTele2.BorderStyle = BorderStyle.FixedSingle;
            txtTele2.CharacterCasing = CharacterCasing.Upper;
            txtTele2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTele2.Location = new Point(429, 106);
            txtTele2.MaxLength = 20;
            txtTele2.Name = "txtTele2";
            txtTele2.ShortcutsEnabled = false;
            txtTele2.Size = new Size(309, 27);
            txtTele2.TabIndex = 52;
            txtTele2.KeyPress += txtTele2_KeyPress;
            txtTele2.Leave += txtTele2_Leave;
            // 
            // txtTele1
            // 
            txtTele1.Anchor = AnchorStyles.Top;
            txtTele1.BackColor = Color.White;
            txtTele1.BorderStyle = BorderStyle.FixedSingle;
            txtTele1.CharacterCasing = CharacterCasing.Upper;
            txtTele1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTele1.Location = new Point(429, 38);
            txtTele1.MaxLength = 20;
            txtTele1.Name = "txtTele1";
            txtTele1.ShortcutsEnabled = false;
            txtTele1.Size = new Size(309, 27);
            txtTele1.TabIndex = 51;
            txtTele1.KeyPress += txtTele1_KeyPress;
            txtTele1.Leave += txtTele1_Leave;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.BackColor = Color.White;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(46, 38);
            txtID.MaxLength = 20;
            txtID.MinimumSize = new Size(13, 0);
            txtID.Name = "txtID";
            txtID.ShortcutsEnabled = false;
            txtID.Size = new Size(309, 27);
            txtID.TabIndex = 50;
            txtID.KeyPress += txtID_KeyPress;
            txtID.Leave += txtID_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.BackColor = Color.White;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(54, 249);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.ShortcutsEnabled = false;
            txtApellido.Size = new Size(301, 27);
            txtApellido.TabIndex = 49;
            txtApellido.KeyPress += txtApellido_KeyPress;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(429, 79);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 40;
            label6.Text = "Teléfono 2:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(429, 14);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 36;
            label4.Text = "Teléfono 1:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 16);
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
            label1.Location = new Point(52, 219);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 32;
            label1.Text = "Apellidos:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // AgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 474);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarCliente";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            Load += AgregarCliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label8;
        private Label label9;
        public TextBox txtNombre;
        public TextBox txtApellido;
        private ComboBox cbTipo;
        private Label label10;
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
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label13;
        private Button btnCerrar;
        private Button btnMin;
        private Label label12;
        public TextBox txtEmail2;
        private Label label7;
        private Label label20;
        private Label label14;
        private Label label22;
        private Panel panel3;
    }
}