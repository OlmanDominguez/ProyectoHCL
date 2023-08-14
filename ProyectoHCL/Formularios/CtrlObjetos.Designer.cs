namespace ProyectoHCL.Formularios
{
    partial class CtrlObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlObjetos));
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            btnNuevo = new Button();
            panel4 = new Panel();
            button6 = new Button();
            btnExcel = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbMostrar = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            dgvObjetos = new DataGridView();
            panel5 = new Panel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPag = new TextBox();
            cmbPag = new ComboBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjetos).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 65);
            panel2.TabIndex = 32;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1058, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 38;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(14, 10);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(226, 32);
            label11.TabIndex = 37;
            label11.Text = "Objetos registrados";
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.BackgroundImage = (Image)resources.GetObject("btnPerfil.BackgroundImage");
            btnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(1694, 73);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(30, 29);
            btnPerfil.TabIndex = 34;
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(1741, 71);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(35, 33);
            btnCerrarSesion.TabIndex = 35;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevo.BackColor = Color.RoyalBlue;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(29, 17);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 35);
            btnNuevo.TabIndex = 36;
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.EnabledChanged += btnNuevo_EnabledChanged;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(btnExcel);
            panel4.Controls.Add(txtBuscar);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(1084, 67);
            panel4.TabIndex = 33;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.Red;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(963, 22);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(78, 25);
            button6.TabIndex = 43;
            button6.Text = "PDF";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcel.BackColor = Color.FromArgb(0, 192, 0);
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = SystemColors.ButtonHighlight;
            btnExcel.Location = new Point(872, 22);
            btnExcel.Margin = new Padding(1, 1, 1, 1);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(78, 25);
            btnExcel.TabIndex = 42;
            btnExcel.Text = "Excel ";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(171, 22);
            txtBuscar.Margin = new Padding(1, 1, 1, 1);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(252, 23);
            txtBuscar.TabIndex = 36;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(113, 24);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 37;
            label1.Text = "Buscar:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(27, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 39;
            label2.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            cmbMostrar.Location = new Point(86, 19);
            cmbMostrar.Margin = new Padding(2, 2, 2, 2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 38;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(167, 22);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 40;
            label5.Text = "registros";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(dgvObjetos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 429);
            panel3.TabIndex = 34;
            // 
            // dgvObjetos
            // 
            dgvObjetos.AllowUserToAddRows = false;
            dgvObjetos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle36.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle36.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle36.ForeColor = Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle36.SelectionForeColor = Color.Black;
            dgvObjetos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            dgvObjetos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvObjetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObjetos.BackgroundColor = Color.WhiteSmoke;
            dgvObjetos.BorderStyle = BorderStyle.None;
            dgvObjetos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle37.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle37.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle37.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle37.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            dgvObjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            dgvObjetos.ColumnHeadersHeight = 30;
            dgvObjetos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle38.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle38.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.False;
            dgvObjetos.DefaultCellStyle = dataGridViewCellStyle38;
            dgvObjetos.EnableHeadersVisualStyles = false;
            dgvObjetos.GridColor = Color.FromArgb(45, 66, 91);
            dgvObjetos.Location = new Point(27, 6);
            dgvObjetos.Margin = new Padding(2, 2, 2, 2);
            dgvObjetos.Name = "dgvObjetos";
            dgvObjetos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = Color.Gainsboro;
            dataGridViewCellStyle39.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle39.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle39.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle39.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dgvObjetos.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dgvObjetos.RowHeadersVisible = false;
            dgvObjetos.RowHeadersWidth = 62;
            dataGridViewCellStyle40.BackColor = Color.Gainsboro;
            dataGridViewCellStyle40.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle40.ForeColor = Color.Black;
            dataGridViewCellStyle40.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle40.SelectionForeColor = Color.Black;
            dgvObjetos.RowsDefaultCellStyle = dataGridViewCellStyle40;
            dgvObjetos.RowTemplate.Height = 25;
            dgvObjetos.Size = new Size(1027, 341);
            dgvObjetos.TabIndex = 1;
            dgvObjetos.CellClick += dgvObjetos_CellClick_1;
            dgvObjetos.CellPainting += dgvObjetos_CellPainting_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 66, 91);
            panel5.Controls.Add(btnSiguiente);
            panel5.Controls.Add(btnAnterior);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtPag);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cmbPag);
            panel5.Controls.Add(cmbMostrar);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 485);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 76);
            panel5.TabIndex = 35;
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
            btnSiguiente.Location = new Point(787, 16);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(30, 31);
            btnSiguiente.TabIndex = 64;
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
            btnAnterior.Location = new Point(751, 16);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(30, 31);
            btnAnterior.TabIndex = 63;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(955, 23);
            label4.Name = "label4";
            label4.Size = new Size(24, 17);
            label4.TabIndex = 47;
            label4.Text = "De";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(823, 23);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 46;
            label3.Text = "Página";
            // 
            // txtPag
            // 
            txtPag.Anchor = AnchorStyles.Right;
            txtPag.BorderStyle = BorderStyle.FixedSingle;
            txtPag.Location = new Point(982, 20);
            txtPag.Name = "txtPag";
            txtPag.ReadOnly = true;
            txtPag.Size = new Size(65, 23);
            txtPag.TabIndex = 45;
            // 
            // cmbPag
            // 
            cmbPag.Anchor = AnchorStyles.Right;
            cmbPag.BackColor = SystemColors.Info;
            cmbPag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPag.FormattingEnabled = true;
            cmbPag.Location = new Point(875, 20);
            cmbPag.Margin = new Padding(2, 2, 2, 2);
            cmbPag.Name = "cmbPag";
            cmbPag.Size = new Size(65, 23);
            cmbPag.TabIndex = 44;
            cmbPag.SelectionChangeCommitted += cmbPag_SelectionChangeCommitted;
            // 
            // CtrlObjetos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(680, 431);
            Name = "CtrlObjetos";
            Text = "CtrlObjetos";
            WindowState = FormWindowState.Maximized;
            Load += CtrlObjetos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvObjetos).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Panel panel4;
        private Panel panel3;
        private Label label11;
        private Button btnExcel;
        private Label label2;
        private ComboBox cmbMostrar;
        private TextBox txtBuscar;
        private Label label5;
        private Label label1;
        private Button button6;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private TextBox txtPag;
        private ComboBox cmbPag;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnCerrar;
        public Button btnNuevo;
        public DataGridView dgvObjetos;
    }
}