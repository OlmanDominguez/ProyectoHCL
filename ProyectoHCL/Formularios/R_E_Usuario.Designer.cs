namespace ProyectoHCL.Formularios
{
    partial class R_E_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_E_Usuario));
            panel2 = new Panel();
            btnCerrar = new Button();
            btnMin = new Button();
            pictureBox5 = new PictureBox();
            lblTitulo = new Label();
            panel3 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            errorT = new ErrorProvider(components);
            label6 = new Label();
            label8 = new Label();
            txtFechaC = new TextBox();
            txtCorreo = new TextBox();
            lblContraseña = new Label();
            label5 = new Label();
            label7 = new Label();
            lblEstado = new Label();
            txtContraseña = new TextBox();
            cmbRol = new ComboBox();
            dtpVencimiento = new DateTimePicker();
            txtFechaV = new TextBox();
            lblEstado2 = new Label();
            cmbEstado2 = new ComboBox();
            cmbEstado = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 73);
            panel2.TabIndex = 2;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(860, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 31;
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
            btnMin.Location = new Point(825, 10);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 30;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(345, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 30);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "lbl";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(dtpVencimiento);
            panel3.Controls.Add(cmbEstado2);
            panel3.Controls.Add(lblEstado2);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(txtFechaV);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(txtFechaC);
            panel3.Controls.Add(cmbEstado);
            panel3.Controls.Add(cmbRol);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtContraseña);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(lblEstado);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblContraseña);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 418);
            panel3.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(506, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(286, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(98, 134);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(316, 27);
            txtNombre.TabIndex = 10;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(98, 62);
            txtUsuario.MaxLength = 15;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ShortcutsEnabled = false;
            txtUsuario.Size = new Size(316, 27);
            txtUsuario.TabIndex = 9;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(98, 106);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 34);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(463, 34);
            label6.Name = "label6";
            label6.Size = new Size(156, 19);
            label6.TabIndex = 5;
            label6.Text = "Correo electrónico:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(463, 106);
            label8.Name = "label8";
            label8.Size = new Size(136, 19);
            label8.TabIndex = 7;
            label8.Text = "Fecha creación:";
            // 
            // txtFechaC
            // 
            txtFechaC.BackColor = Color.White;
            txtFechaC.BorderStyle = BorderStyle.FixedSingle;
            txtFechaC.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaC.Location = new Point(463, 134);
            txtFechaC.MaxLength = 50;
            txtFechaC.Name = "txtFechaC";
            txtFechaC.ReadOnly = true;
            txtFechaC.ShortcutsEnabled = false;
            txtFechaC.Size = new Size(316, 27);
            txtFechaC.TabIndex = 17;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.White;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(463, 62);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ShortcutsEnabled = false;
            txtCorreo.Size = new Size(316, 27);
            txtCorreo.TabIndex = 12;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = Color.Black;
            lblContraseña.Location = new Point(98, 177);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(102, 19);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña:";
            lblContraseña.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(98, 250);
            label5.Name = "label5";
            label5.Size = new Size(96, 19);
            label5.TabIndex = 4;
            label5.Text = "Rol usuario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(463, 177);
            label7.Name = "label7";
            label7.Size = new Size(163, 19);
            label7.TabIndex = 6;
            label7.Text = "Fecha vencimiento:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.Black;
            lblEstado.Location = new Point(463, 250);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(123, 19);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado usuario:";
            lblEstado.Visible = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(98, 205);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ShortcutsEnabled = false;
            txtContraseña.Size = new Size(316, 27);
            txtContraseña.TabIndex = 11;
            txtContraseña.Visible = false;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.White;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "ADMINISTRADOR", "COLABORADOR" });
            cmbRol.Location = new Point(98, 277);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(316, 28);
            cmbRol.TabIndex = 15;
            cmbRol.Leave += cmbRol_Leave;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Anchor = AnchorStyles.Top;
            dtpVencimiento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpVencimiento.Format = DateTimePickerFormat.Short;
            dtpVencimiento.Location = new Point(463, 205);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(316, 27);
            dtpVencimiento.TabIndex = 21;
            dtpVencimiento.Visible = false;
            // 
            // txtFechaV
            // 
            txtFechaV.BackColor = Color.White;
            txtFechaV.BorderStyle = BorderStyle.FixedSingle;
            txtFechaV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaV.Location = new Point(463, 205);
            txtFechaV.MaxLength = 50;
            txtFechaV.Name = "txtFechaV";
            txtFechaV.ReadOnly = true;
            txtFechaV.ShortcutsEnabled = false;
            txtFechaV.Size = new Size(316, 27);
            txtFechaV.TabIndex = 18;
            txtFechaV.Visible = false;
            // 
            // lblEstado2
            // 
            lblEstado2.AutoSize = true;
            lblEstado2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado2.ForeColor = Color.Black;
            lblEstado2.Location = new Point(98, 177);
            lblEstado2.Name = "lblEstado2";
            lblEstado2.Size = new Size(123, 19);
            lblEstado2.TabIndex = 19;
            lblEstado2.Text = "Estado usuario:";
            lblEstado2.Visible = false;
            // 
            // cmbEstado2
            // 
            cmbEstado2.BackColor = Color.White;
            cmbEstado2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado2.FormattingEnabled = true;
            cmbEstado2.Items.AddRange(new object[] { "BLOQUEADO", "ACTIVO", "INACTIVO", "NUEVO" });
            cmbEstado2.Location = new Point(98, 205);
            cmbEstado2.Name = "cmbEstado2";
            cmbEstado2.Size = new Size(316, 28);
            cmbEstado2.TabIndex = 20;
            cmbEstado2.Visible = false;
            cmbEstado2.Leave += cmbEstado2_Leave;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "BLOQUEADO", "ACTIVO", "INACTIVO", "NUEVO" });
            cmbEstado.Location = new Point(463, 277);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(316, 28);
            cmbEstado.TabIndex = 16;
            cmbEstado.Visible = false;
            cmbEstado.Leave += cmbEstado_Leave;
            // 
            // R_E_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 491);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "R_E_Usuario";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "R_E_Usuario";
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
        private Button btnCerrar;
        private Button btnMin;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label3;
        private Label label2;
        private ErrorProvider errorT;
        public Label lblTitulo;
        public TextBox txtNombre;
        public TextBox txtUsuario;
        public DateTimePicker dtpVencimiento;
        public ComboBox cmbEstado2;
        public Label lblEstado2;
        public TextBox txtFechaV;
        public TextBox txtFechaC;
        public ComboBox cmbEstado;
        public ComboBox cmbRol;
        public TextBox txtCorreo;
        public TextBox txtContraseña;
        public Label lblEstado;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        public Label lblContraseña;
    }
}