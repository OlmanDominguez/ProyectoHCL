namespace ProyectoHCL.Formularios
{
    partial class R_E_Objeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_E_Objeto));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            lblTitulo = new Label();
            btnCerrar = new Button();
            btnMin = new Button();
            panel3 = new Panel();
            rTxtDesc = new TextBox();
            txtObj = new TextBox();
            cmbEstado = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            errorT = new ErrorProvider(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            panel2.Paint += panel2_Paint;
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
            lblTitulo.Location = new Point(314, 21);
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
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(rTxtDesc);
            panel3.Controls.Add(txtObj);
            panel3.Controls.Add(cmbEstado);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 328);
            panel3.TabIndex = 25;
            // 
            // rTxtDesc
            // 
            rTxtDesc.BackColor = Color.White;
            rTxtDesc.BorderStyle = BorderStyle.FixedSingle;
            rTxtDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rTxtDesc.Location = new Point(418, 75);
            rTxtDesc.Margin = new Padding(2);
            rTxtDesc.MaxLength = 500;
            rTxtDesc.Multiline = true;
            rTxtDesc.Name = "rTxtDesc";
            rTxtDesc.Size = new Size(316, 110);
            rTxtDesc.TabIndex = 25;
            rTxtDesc.KeyPress += rTxtDesc_KeyPress_1;
            rTxtDesc.Leave += rTxtDesc_Leave_1;
            // 
            // txtObj
            // 
            txtObj.BackColor = Color.White;
            txtObj.BorderStyle = BorderStyle.FixedSingle;
            txtObj.CharacterCasing = CharacterCasing.Upper;
            txtObj.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtObj.Location = new Point(69, 75);
            txtObj.Margin = new Padding(2);
            txtObj.MaxLength = 50;
            txtObj.Name = "txtObj";
            txtObj.ShortcutsEnabled = false;
            txtObj.Size = new Size(316, 27);
            txtObj.TabIndex = 24;
            txtObj.TextChanged += txtObj_TextChanged;
            txtObj.Leave += txtObj_Leave;
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
            btnCancelar.Location = new Point(467, 230);
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
            btnGuardar.Location = new Point(257, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            label6.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 126);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 2;
            label1.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(69, 44);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(142, 36);
            label3.Name = "label3";
            label3.Size = new Size(23, 30);
            label3.TabIndex = 29;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(127, 118);
            label4.Name = "label4";
            label4.Size = new Size(23, 30);
            label4.TabIndex = 30;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(517, 36);
            label5.Name = "label5";
            label5.Size = new Size(23, 30);
            label5.TabIndex = 31;
            label5.Text = "*";
            // 
            // R_E_Objeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "R_E_Objeto";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "R_E_Objeto";
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
        public ComboBox cmbEstado;
        public TextBox txtObj;
        private ErrorProvider errorT;
        public Label label6;
        public Label label2;
        public Label label1;
        public TextBox rTxtDesc;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}