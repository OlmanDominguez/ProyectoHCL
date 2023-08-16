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
            panel2 = new Panel();
            btCerrar = new Button();
            btnnuevoP = new Button();
            label11 = new Label();
            panel3 = new Panel();
            button10 = new Button();
            button11 = new Button();
            txtBuscarP = new TextBox();
            label4 = new Label();
            dgvParametro = new DataGridView();
            panel4 = new Panel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            txtPagP = new TextBox();
            label13 = new Label();
            label14 = new Label();
            cmbPagP = new ComboBox();
            label1 = new Label();
            pmtMostrar = new ComboBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParametro).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btCerrar);
            panel2.Controls.Add(btnnuevoP);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1549, 208);
            panel2.TabIndex = 20;
            // 
            // btCerrar
            // 
            btCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btCerrar.BackColor = Color.Transparent;
            btCerrar.BackgroundImage = (Image)resources.GetObject("btCerrar.BackgroundImage");
            btCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btCerrar.FlatAppearance.BorderSize = 0;
            btCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btCerrar.FlatStyle = FlatStyle.Flat;
            btCerrar.Location = new Point(1516, 20);
            btCerrar.Margin = new Padding(4, 5, 4, 5);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(20, 28);
            btCerrar.TabIndex = 44;
            btCerrar.UseVisualStyleBackColor = false;
            btCerrar.Click += btCerrar_Click;
            // 
            // btnnuevoP
            // 
            btnnuevoP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnnuevoP.BackColor = Color.RoyalBlue;
            btnnuevoP.BackgroundImageLayout = ImageLayout.Stretch;
            btnnuevoP.FlatAppearance.BorderSize = 0;
            btnnuevoP.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnnuevoP.FlatStyle = FlatStyle.Flat;
            btnnuevoP.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnnuevoP.ForeColor = SystemColors.ButtonFace;
            btnnuevoP.Image = (Image)resources.GetObject("btnnuevoP.Image");
            btnnuevoP.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevoP.Location = new Point(40, 108);
            btnnuevoP.Margin = new Padding(4, 5, 4, 5);
            btnnuevoP.Name = "btnnuevoP";
            btnnuevoP.Size = new Size(143, 65);
            btnnuevoP.TabIndex = 42;
            btnnuevoP.Text = "Agregar";
            btnnuevoP.TextAlign = ContentAlignment.MiddleRight;
            btnnuevoP.UseVisualStyleBackColor = false;
            btnnuevoP.EnabledChanged += btnnuevoP_EnabledChanged;
            btnnuevoP.Click += btnnuevoP_Click;
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
            panel3.Location = new Point(0, 208);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1549, 142);
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
            button10.Location = new Point(1299, 47);
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
            button11.Location = new Point(1169, 47);
            button11.Name = "button11";
            button11.Size = new Size(111, 42);
            button11.TabIndex = 58;
            button11.Text = "Excel ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // txtBuscarP
            // 
            txtBuscarP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscarP.BackColor = SystemColors.Info;
            txtBuscarP.Location = new Point(126, 47);
            txtBuscarP.Name = "txtBuscarP";
            txtBuscarP.Size = new Size(358, 31);
            txtBuscarP.TabIndex = 46;
            txtBuscarP.TextChanged += txtBuscarP_TextChanged;
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
            dgvParametro.Location = new Point(0, 350);
            dgvParametro.Name = "dgvParametro";
            dgvParametro.RowHeadersWidth = 62;
            dgvParametro.RowTemplate.Height = 33;
            dgvParametro.Size = new Size(1549, 459);
            dgvParametro.TabIndex = 4;
            dgvParametro.CellClick += dgvParametro_CellClick;
            dgvParametro.CellPainting += dgvParametro_CellPainting;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 66, 91);
            panel4.Controls.Add(btnSiguiente);
            panel4.Controls.Add(btnAnterior);
            panel4.Controls.Add(txtPagP);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(cmbPagP);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pmtMostrar);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 809);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1549, 127);
            panel4.TabIndex = 39;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.Transparent;
            btnSiguiente.BackgroundImage = (Image)resources.GetObject("btnSiguiente.BackgroundImage");
            btnSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Location = new Point(1036, 28);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(43, 52);
            btnSiguiente.TabIndex = 70;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.BackgroundImage = (Image)resources.GetObject("btnAnterior.BackgroundImage");
            btnAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(985, 28);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(43, 52);
            btnAnterior.TabIndex = 69;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtPagP
            // 
            txtPagP.Anchor = AnchorStyles.Right;
            txtPagP.Location = new Point(1320, 32);
            txtPagP.Margin = new Padding(4, 5, 4, 5);
            txtPagP.Name = "txtPagP";
            txtPagP.ReadOnly = true;
            txtPagP.Size = new Size(88, 31);
            txtPagP.TabIndex = 68;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(1281, 37);
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
            label14.Location = new Point(1099, 37);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 28);
            label14.TabIndex = 66;
            label14.Text = "Página";
            // 
            // cmbPagP
            // 
            cmbPagP.Anchor = AnchorStyles.Right;
            cmbPagP.BackColor = SystemColors.Info;
            cmbPagP.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagP.FormattingEnabled = true;
            cmbPagP.Location = new Point(1167, 32);
            cmbPagP.Name = "cmbPagP";
            cmbPagP.Size = new Size(91, 33);
            cmbPagP.TabIndex = 65;
            cmbPagP.SelectedIndexChanged += cmbPagP_SelectedIndexChanged_1;
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
            pmtMostrar.SelectedIndexChanged += pmtMostrar_SelectedIndexChanged_1;
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
            Name = "CtrlParametros";
            Text = "CtrlParametros";
            WindowState = FormWindowState.Maximized;
            Load += CtrlParametros_Load;
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
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvParametro;
        private Panel panel4;
        private Button btnnuevoP;
        private Label label11;
        private TextBox txtBuscarP;
        private Label label4;
        private Button button10;
        private Button button11;
        private Label label1;
        private ComboBox pmtMostrar;
        private Label label3;
        private TextBox txtPagP;
        private Label label13;
        private Label label14;
        private ComboBox cmbPagP;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btCerrar;
    }
}