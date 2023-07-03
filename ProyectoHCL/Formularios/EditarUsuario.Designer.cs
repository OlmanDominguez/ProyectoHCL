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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            btnMin = new Button();
            label11 = new Label();
            panel3 = new Panel();
            btnCancelar = new Button();
            txtFechaC = new TextBox();
            btnGuardar = new Button();
            dtpVencimiento = new DateTimePicker();
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
            errorT = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 73);
            panel2.TabIndex = 18;
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
            pictureBox5.TabIndex = 34;
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
            btnCerrar.Location = new Point(837, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
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
            btnMin.Location = new Point(802, 10);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(336, 20);
            label11.Name = "label11";
            label11.Size = new Size(158, 30);
            label11.TabIndex = 19;
            label11.Text = "Editar usuarios";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 42, 65);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(txtFechaC);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(dtpVencimiento);
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(863, 451);
            panel3.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(498, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtFechaC
            // 
            txtFechaC.BackColor = Color.DarkGray;
            txtFechaC.BorderStyle = BorderStyle.FixedSingle;
            txtFechaC.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaC.Location = new Point(454, 144);
            txtFechaC.MaxLength = 50;
            txtFechaC.Name = "txtFechaC";
            txtFechaC.ReadOnly = true;
            txtFechaC.ShortcutsEnabled = false;
            txtFechaC.Size = new Size(316, 27);
            txtFechaC.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(288, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Anchor = AnchorStyles.Top;
            dtpVencimiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(454, 221);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(316, 27);
            dtpVencimiento.TabIndex = 18;
            dtpVencimiento.ValueChanged += dtpVencimiento_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.DarkGray;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Bloqueado", "Activo", "Inactivo", "Nuevo" });
            cmbEstado.Location = new Point(91, 295);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(316, 28);
            cmbEstado.TabIndex = 16;
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.DarkGray;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "ADMINISTRADOR", "COLABORADOR" });
            cmbRol.Location = new Point(91, 220);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(316, 28);
            cmbRol.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.DarkGray;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(454, 69);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ShortcutsEnabled = false;
            txtCorreo.Size = new Size(316, 27);
            txtCorreo.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.DarkGray;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(91, 144);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(316, 27);
            txtNombre.TabIndex = 10;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.DarkGray;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(91, 69);
            txtUsuario.MaxLength = 15;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ShortcutsEnabled = false;
            txtUsuario.Size = new Size(316, 27);
            txtUsuario.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(91, 268);
            label9.Name = "label9";
            label9.Size = new Size(123, 19);
            label9.TabIndex = 8;
            label9.Text = "Estado usuario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(454, 116);
            label8.Name = "label8";
            label8.Size = new Size(136, 19);
            label8.TabIndex = 7;
            label8.Text = "Fecha creación:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(454, 193);
            label7.Name = "label7";
            label7.Size = new Size(163, 19);
            label7.TabIndex = 6;
            label7.Text = "Fecha vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(454, 41);
            label6.Name = "label6";
            label6.Size = new Size(156, 19);
            label6.TabIndex = 5;
            label6.Text = "Correo electrónico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(91, 193);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 4;
            label5.Text = "Rol usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 116);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 41);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 524);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarUsuario";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarUsuario";
            Load += EditarUsuario_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
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
        public TextBox txtFechaC;
        private ErrorProvider errorT;
        private Button btnCerrar;
        private Button btnMin;
        private PictureBox pictureBox5;
    }
}