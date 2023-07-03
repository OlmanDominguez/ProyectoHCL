namespace ProyectoHCL.Formularios
{
    partial class EditarObjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarObjeto));
            panel2 = new Panel();
            btnCerrar = new Button();
            btnMin = new Button();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtObjeto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbEstado = new ComboBox();
            panel1 = new Panel();
            errorT = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 73);
            panel2.TabIndex = 20;
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
            btnCerrar.Location = new Point(711, 12);
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
            btnMin.Location = new Point(676, 10);
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
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(287, 21);
            label11.Name = "label11";
            label11.Size = new Size(150, 30);
            label11.TabIndex = 28;
            label11.Text = "Editar objetos";
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
            btnCancelar.Location = new Point(424, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 34;
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
            btnGuardar.Location = new Point(212, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top;
            txtDescripcion.BackColor = Color.DarkGray;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(111, 156);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ShortcutsEnabled = false;
            txtDescripcion.Size = new Size(342, 27);
            txtDescripcion.TabIndex = 32;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // txtObjeto
            // 
            txtObjeto.Anchor = AnchorStyles.Top;
            txtObjeto.BackColor = Color.DarkGray;
            txtObjeto.BorderStyle = BorderStyle.FixedSingle;
            txtObjeto.CharacterCasing = CharacterCasing.Upper;
            txtObjeto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtObjeto.Location = new Point(111, 60);
            txtObjeto.MaxLength = 15;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.ShortcutsEnabled = false;
            txtObjeto.Size = new Size(230, 27);
            txtObjeto.TabIndex = 31;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 128);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 30;
            label1.Text = "Descripción del objeto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(111, 32);
            label2.Name = "label2";
            label2.Size = new Size(159, 19);
            label2.TabIndex = 29;
            label2.Text = "Nombre del objeto:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(446, 32);
            label4.Name = "label4";
            label4.Size = new Size(145, 19);
            label4.TabIndex = 35;
            label4.Text = "Estado del objeto:";
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.DarkGray;
            cmbEstado.FlatStyle = FlatStyle.Flat;
            cmbEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cmbEstado.Location = new Point(438, 59);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(165, 28);
            cmbEstado.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtObjeto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 335);
            panel1.TabIndex = 21;
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // EditarObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 408);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarObjeto";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label11;
        private Label label4;
        public TextBox txtDescripcion;
        public TextBox txtObjeto;
        public ComboBox cmbEstado;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Button btnCerrar;
        private Button btnMin;
        private ErrorProvider errorT;
    }
}