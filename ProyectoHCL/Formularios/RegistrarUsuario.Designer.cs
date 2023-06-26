namespace ProyectoHCL.Formularios
{
    partial class RegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txtFechaV = new TextBox();
            txtFechaC = new TextBox();
            cmbEstado = new ComboBox();
            cmbRol = new ComboBox();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            button2 = new Button();
            btnCancelar = new Button();
            errorT = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 523);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 70);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(362, 36);
            label1.TabIndex = 16;
            label1.Text = "HOTEL CASA LOMAS";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtFechaV);
            panel3.Controls.Add(txtFechaC);
            panel3.Controls.Add(cmbEstado);
            panel3.Controls.Add(cmbRol);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtContraseña);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(175, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(583, 334);
            panel3.TabIndex = 2;
            // 
            // txtFechaV
            // 
            txtFechaV.BackColor = SystemColors.MenuHighlight;
            txtFechaV.BorderStyle = BorderStyle.FixedSingle;
            txtFechaV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaV.Location = new Point(215, 241);
            txtFechaV.MaxLength = 50;
            txtFechaV.Name = "txtFechaV";
            txtFechaV.ReadOnly = true;
            txtFechaV.ShortcutsEnabled = false;
            txtFechaV.Size = new Size(333, 27);
            txtFechaV.TabIndex = 18;
            // 
            // txtFechaC
            // 
            txtFechaC.BackColor = SystemColors.MenuHighlight;
            txtFechaC.BorderStyle = BorderStyle.FixedSingle;
            txtFechaC.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaC.Location = new Point(215, 207);
            txtFechaC.MaxLength = 50;
            txtFechaC.Name = "txtFechaC";
            txtFechaC.ReadOnly = true;
            txtFechaC.ShortcutsEnabled = false;
            txtFechaC.Size = new Size(333, 27);
            txtFechaC.TabIndex = 17;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = SystemColors.MenuHighlight;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Bloqueado", "Activo", "Inactivo", "Nuevo" });
            cmbEstado.Location = new Point(215, 277);
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
            cmbRol.Items.AddRange(new object[] { "Administrador", "Colaborador" });
            cmbRol.Location = new Point(215, 136);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(333, 28);
            cmbRol.TabIndex = 15;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.MenuHighlight;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(215, 173);
            txtCorreo.MaxLength = 50;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.ShortcutsEnabled = false;
            txtCorreo.Size = new Size(333, 27);
            txtCorreo.TabIndex = 12;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.MenuHighlight;
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(215, 100);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.ShortcutsEnabled = false;
            txtContraseña.Size = new Size(333, 27);
            txtContraseña.TabIndex = 11;
            txtContraseña.KeyPress += txtContraseña_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.MenuHighlight;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(215, 64);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(333, 27);
            txtNombre.TabIndex = 10;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.MenuHighlight;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(215, 27);
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
            label9.Location = new Point(31, 277);
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
            label8.Location = new Point(31, 207);
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
            label7.Location = new Point(31, 241);
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
            label6.Location = new Point(31, 173);
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
            label5.Location = new Point(31, 136);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 4;
            label5.Text = "Rol usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 100);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 64);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 27);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(373, 82);
            label11.Name = "label11";
            label11.Size = new Size(208, 32);
            label11.TabIndex = 9;
            label11.Text = "Registrar usuarios";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(302, 470);
            button2.Name = "button2";
            button2.Size = new Size(82, 32);
            button2.TabIndex = 10;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(517, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(876, 523);
            Controls.Add(btnCancelar);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionUsuario";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUsuario;
        private Label label11;
        private ComboBox cmbEstado;
        private ComboBox cmbRol;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private Button button2;
        private Button btnCancelar;
        private TextBox txtFechaC;
        private Label label8;
        private TextBox txtFechaV;
        private ErrorProvider errorT;
    }
}