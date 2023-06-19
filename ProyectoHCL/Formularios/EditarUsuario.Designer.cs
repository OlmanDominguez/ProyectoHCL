namespace ProyectoHCL.Formularios
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            panel2 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            label11 = new Label();
            panel3 = new Panel();
            dtpVencimiento = new DateTimePicker();
            dtpCreacion = new DateTimePicker();
            cmbEstado = new ComboBox();
            cmbRol = new ComboBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 70);
            panel2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(106, 20);
            label3.Name = "label3";
            label3.Size = new Size(362, 36);
            label3.TabIndex = 16;
            label3.Text = "HOTEL CASA LOMAS";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 504);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(5, 20);
            button1.Name = "button1";
            button1.Size = new Size(49, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(351, 84);
            label11.Name = "label11";
            label11.Size = new Size(174, 32);
            label11.TabIndex = 19;
            label11.Text = "Editar usuarios";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dtpVencimiento);
            panel3.Controls.Add(dtpCreacion);
            panel3.Controls.Add(cmbEstado);
            panel3.Controls.Add(cmbRol);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(166, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(583, 292);
            panel3.TabIndex = 20;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Anchor = AnchorStyles.Top;
            dtpVencimiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(222, 202);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(333, 27);
            dtpVencimiento.TabIndex = 18;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Anchor = AnchorStyles.Top;
            dtpCreacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(222, 168);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(333, 27);
            dtpCreacion.TabIndex = 17;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = SystemColors.MenuHighlight;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Bloqueado", "Activo", "Inactivo", "Nuevo" });
            cmbEstado.Location = new Point(222, 238);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(333, 28);
            cmbEstado.TabIndex = 16;
            // 
            // cmbRol
            // 
            cmbRol.BackColor = SystemColors.MenuHighlight;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cmbRol.Location = new Point(222, 97);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(333, 28);
            cmbRol.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.MenuHighlight;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(222, 133);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ShortcutsEnabled = false;
            txtCorreo.Size = new Size(333, 27);
            txtCorreo.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.MenuHighlight;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(222, 61);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(333, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.MenuHighlight;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(222, 24);
            txtUsuario.MaxLength = 15;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ShortcutsEnabled = false;
            txtUsuario.Size = new Size(333, 27);
            txtUsuario.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(38, 238);
            label9.Name = "label9";
            label9.Size = new Size(142, 25);
            label9.TabIndex = 8;
            label9.Text = "Estado usuario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(38, 168);
            label8.Name = "label8";
            label8.Size = new Size(144, 25);
            label8.TabIndex = 7;
            label8.Text = "Fecha creación:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(38, 202);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 6;
            label7.Text = "Fecha vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 133);
            label6.Name = "label6";
            label6.Size = new Size(175, 25);
            label6.TabIndex = 5;
            label6.Text = "Correo electrónico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 97);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 4;
            label5.Text = "Rol usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 24);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(514, 435);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(299, 435);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 504);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panel3);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EditarUsuario";
            Text = "EditarUsuario";
            Load += EditarUsuario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button button1;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        public Panel panel3;
        public Button btnCancelar;
        public Button btnGuardar;
        public ComboBox cmbEstado;
        public ComboBox cmbRol;
        public TextBox txtCorreo;
        public TextBox txtNombre;
        public TextBox txtUsuario;
        public DateTimePicker dtpVencimiento;
        public DateTimePicker dtpCreacion;
    }
}