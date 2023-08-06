namespace ProyectoHCL.Formularios
{
    partial class CtrlParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlParametros));
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btnAgregarParametro = new Button();
            label11 = new Label();
            panel3 = new Panel();
            button10 = new Button();
            button11 = new Button();
            txtBuscarP = new TextBox();
            label4 = new Label();
            dgvParametro = new DataGridView();
            panel4 = new Panel();
            txtPart = new TextBox();
            label13 = new Label();
            label14 = new Label();
            cmbPart = new ComboBox();
            label1 = new Label();
            pmtMostrar = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParametro).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 935);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(7, 33);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(70, 60);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnAgregarParametro);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(86, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1463, 208);
            panel2.TabIndex = 20;
            // 
            // btnAgregarParametro
            // 
            btnAgregarParametro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarParametro.BackColor = Color.RoyalBlue;
            btnAgregarParametro.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarParametro.FlatAppearance.BorderSize = 0;
            btnAgregarParametro.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnAgregarParametro.FlatStyle = FlatStyle.Flat;
            btnAgregarParametro.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarParametro.ForeColor = SystemColors.ButtonFace;
            btnAgregarParametro.Image = (Image)resources.GetObject("btnAgregarParametro.Image");
            btnAgregarParametro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarParametro.Location = new Point(40, 108);
            btnAgregarParametro.Margin = new Padding(4, 5, 4, 5);
            btnAgregarParametro.Name = "btnAgregarParametro";
            btnAgregarParametro.Size = new Size(143, 65);
            btnAgregarParametro.TabIndex = 42;
            btnAgregarParametro.Text = "Agregar";
            btnAgregarParametro.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarParametro.UseVisualStyleBackColor = false;
            btnAgregarParametro.Click += btnAgregarParametro_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(27, 28);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(408, 48);
            label11.TabIndex = 43;
            label11.Text = "Parametros Registrados";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(txtBuscarP);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(86, 208);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1463, 142);
            panel3.TabIndex = 37;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.Red;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(1213, 47);
            button10.Name = "button10";
            button10.Size = new Size(111, 42);
            button10.TabIndex = 59;
            button10.Text = "PDF";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button11.BackColor = Color.FromArgb(0, 192, 0);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(1083, 47);
            button11.Name = "button11";
            button11.Size = new Size(111, 42);
            button11.TabIndex = 58;
            button11.Text = "Excel ";
            button11.UseVisualStyleBackColor = false;
            // 
            // txtBuscarP
            // 
            txtBuscarP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscarP.BackColor = SystemColors.Info;
            txtBuscarP.Location = new Point(126, 47);
            txtBuscarP.Name = "txtBuscarP";
            txtBuscarP.Size = new Size(358, 31);
            txtBuscarP.TabIndex = 46;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(40, 50);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 47;
            label4.Text = "Buscar:";
            // 
            // dgvParametro
            // 
            dgvParametro.BackgroundColor = Color.WhiteSmoke;
            dgvParametro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParametro.Dock = DockStyle.Top;
            dgvParametro.Location = new Point(86, 350);
            dgvParametro.Name = "dgvParametro";
            dgvParametro.RowHeadersWidth = 62;
            dgvParametro.RowTemplate.Height = 33;
            dgvParametro.Size = new Size(1463, 459);
            dgvParametro.TabIndex = 4;
            dgvParametro.CellClick += dgvParametro_CellClick;
            dgvParametro.CellPainting += dgvParametro_CellPainting;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 66, 91);
            panel4.Controls.Add(txtPart);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(cmbPart);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pmtMostrar);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(86, 809);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1463, 127);
            panel4.TabIndex = 39;
            // 
            // txtPart
            // 
            txtPart.Anchor = AnchorStyles.Right;
            txtPart.Location = new Point(1234, 32);
            txtPart.Margin = new Padding(4, 5, 4, 5);
            txtPart.Name = "txtPart";
            txtPart.ReadOnly = true;
            txtPart.Size = new Size(88, 31);
            txtPart.TabIndex = 68;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(1195, 37);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(36, 28);
            label13.TabIndex = 67;
            label13.Text = "De";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(1013, 37);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 28);
            label14.TabIndex = 66;
            label14.Text = "Página";
            // 
            // cmbPart
            // 
            cmbPart.Anchor = AnchorStyles.Right;
            cmbPart.BackColor = SystemColors.Info;
            cmbPart.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPart.FormattingEnabled = true;
            cmbPart.Location = new Point(1081, 32);
            cmbPart.Name = "cmbPart";
            cmbPart.Size = new Size(91, 33);
            cmbPart.TabIndex = 65;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 50;
            label1.Text = "Mostrar";
            // 
            // pmtMostrar
            // 
            pmtMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pmtMostrar.BackColor = SystemColors.Info;
            pmtMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            pmtMostrar.FormattingEnabled = true;
            pmtMostrar.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            pmtMostrar.Location = new Point(126, 28);
            pmtMostrar.Name = "pmtMostrar";
            pmtMostrar.Size = new Size(108, 33);
            pmtMostrar.TabIndex = 49;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(241, 33);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 51;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CtrlParametros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1549, 935);
            Controls.Add(panel4);
            Controls.Add(dgvParametro);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CtrlParametros";
            Text = "CtrlParametros";
            WindowState = FormWindowState.Maximized;
            Load += CtrlParametros_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParametro).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvParametro;
        private Panel panel4;
        private Button btnAgregarParametro;
        private Label label11;
        private TextBox txtBuscarP;
        private Label label4;
        private Button button10;
        private Button button11;
        private Label label1;
        private ComboBox pmtMostrar;
        private Label label3;
        private TextBox txtPart;
        private Label label13;
        private Label label14;
        private ComboBox cmbPart;
    }
}