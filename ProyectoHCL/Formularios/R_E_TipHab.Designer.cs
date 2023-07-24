namespace ProyectoHCL.Formularios
{
    partial class R_E_TipHab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_E_TipHab));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            lblTitulo = new Label();
            btnCerrar = new Button();
            btnMin = new Button();
            panel3 = new Panel();
            txtPrecio = new TextBox();
            label1 = new Label();
            txtCapacidad = new TextBox();
            label6 = new Label();
            txtTipo = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
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
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lblTitulo);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 73);
            panel2.TabIndex = 23;
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
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(254, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.RightToLeft = RightToLeft.No;
            lblTitulo.Size = new Size(38, 30);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "lbl";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(774, 12);
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
            btnMin.Location = new Point(739, 10);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(txtPrecio);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtCapacidad);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtTipo);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 377);
            panel3.TabIndex = 25;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.CharacterCasing = CharacterCasing.Upper;
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(243, 221);
            txtPrecio.MaxLength = 100;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ShortcutsEnabled = false;
            txtPrecio.Size = new Size(316, 27);
            txtPrecio.TabIndex = 28;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 193);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 27;
            label1.Text = "Precio:";
            // 
            // txtCapacidad
            // 
            txtCapacidad.BackColor = Color.White;
            txtCapacidad.BorderStyle = BorderStyle.FixedSingle;
            txtCapacidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidad.Location = new Point(243, 142);
            txtCapacidad.MaxLength = 50;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.ShortcutsEnabled = false;
            txtCapacidad.Size = new Size(316, 27);
            txtCapacidad.TabIndex = 26;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            txtCapacidad.Leave += txtCapacidad_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(243, 114);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 25;
            label6.Text = "Capacidad:";
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.White;
            txtTipo.BorderStyle = BorderStyle.FixedSingle;
            txtTipo.CharacterCasing = CharacterCasing.Upper;
            txtTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipo.Location = new Point(243, 64);
            txtTipo.MaxLength = 15;
            txtTipo.Name = "txtTipo";
            txtTipo.ShortcutsEnabled = false;
            txtTipo.Size = new Size(316, 27);
            txtTipo.TabIndex = 24;
            txtTipo.Leave += txtTipo_Leave;
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
            btnCancelar.Location = new Point(467, 280);
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
            btnGuardar.Location = new Point(257, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(243, 32);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 1;
            label2.Text = "Tipo:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // R_E_TipHab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "R_E_TipHab";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "R_E_TipHab";
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
        private PictureBox pictureBox5;
        public Label lblTitulo;
        private Button btnCerrar;
        private Button btnMin;
        public Panel panel3;
        public Button btnCancelar;
        public Button btnGuardar;
        private Label label2;
        public TextBox txtTipo;
        public TextBox txtCapacidad;
        private Label label6;
        public TextBox txtPrecio;
        private Label label1;
        private ErrorProvider errorT;
    }
}