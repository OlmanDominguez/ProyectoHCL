namespace ProyectoHCL.Formularios
{
    partial class R_E_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_E_Roles));
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            panel2 = new Panel();
            btnMin = new Button();
            cerrar = new Button();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtRol = new TextBox();
            cmbEstado = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNumero = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            error1 = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(372, 51);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 29;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(740, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 32;
            label1.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.DarkGray;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(458, 47);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(259, 27);
            txtNombre.TabIndex = 48;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.BackColor = Color.DarkGray;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(831, 47);
            txtApellido.MaxLength = 15;
            txtApellido.Name = "txtApellido";
            txtApellido.ShortcutsEnabled = false;
            txtApellido.Size = new Size(230, 27);
            txtApellido.TabIndex = 49;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(cerrar);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 73);
            panel2.TabIndex = 60;
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
            btnMin.Location = new Point(747, 6);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 64;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click_1;
            // 
            // cerrar
            // 
            cerrar.BackColor = Color.Transparent;
            cerrar.BackgroundImage = (Image)resources.GetObject("cerrar.BackgroundImage");
            cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Location = new Point(781, 8);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(14, 17);
            cerrar.TabIndex = 63;
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += cerrar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 61;
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
            btnCerrar.Location = new Point(1185, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 31;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(340, 24);
            label11.Name = "label11";
            label11.Size = new Size(46, 30);
            label11.TabIndex = 28;
            label11.Text = "lbR";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 395);
            panel1.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtRol);
            panel3.Controls.Add(cmbEstado);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(txtNumero);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(809, 322);
            panel3.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(517, 36);
            label8.Name = "label8";
            label8.Size = new Size(23, 30);
            label8.TabIndex = 32;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(129, 118);
            label7.Name = "label7";
            label7.Size = new Size(23, 30);
            label7.TabIndex = 31;
            label7.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(100, 36);
            label5.Name = "label5";
            label5.Size = new Size(23, 30);
            label5.TabIndex = 30;
            label5.Text = "*";
            // 
            // txtRol
            // 
            txtRol.BackColor = Color.White;
            txtRol.BorderStyle = BorderStyle.FixedSingle;
            txtRol.CharacterCasing = CharacterCasing.Upper;
            txtRol.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRol.Location = new Point(69, 75);
            txtRol.MaxLength = 50;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(316, 27);
            txtRol.TabIndex = 24;
            txtRol.Leave += txtRol_Leave;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbEstado.Location = new Point(69, 157);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(316, 28);
            cmbEstado.TabIndex = 23;
            cmbEstado.Leave += cmbEstado_Leave;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(468, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(258, 231);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.White;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(418, 75);
            txtNumero.Margin = new Padding(2);
            txtNumero.MaxLength = 500;
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(316, 110);
            txtNumero.TabIndex = 25;
            txtNumero.KeyPress += txtNumero_KeyPress;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(418, 44);
            label6.Name = "label6";
            label6.Size = new Size(104, 19);
            label6.TabIndex = 5;
            label6.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(69, 126);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 2;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 44);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 1;
            label4.Text = "Rol:";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // R_E_Roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 395);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "R_E_Roles";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarRoles";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        public TextBox txtNombre;
        public TextBox txtApellido;
        private Panel panel2;
        private Button btnCerrar;
        private Panel panel1;
        private PictureBox pictureBox5;
        public Panel panel3;
        public ComboBox cmbEstado;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox txtNumero;
        private Button cerrar;
        public Label label11;
        public Label label6;
        public Label label3;
        public Label label4;
        private ErrorProvider error1;
        public TextBox txtRol;
        private Button btnMin;
        private Label label7;
        private Label label5;
        private Label label8;
    }
}