namespace ProyectoHCL.Formularios
{
    partial class CtrlHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlHabitaciones));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnNuevo = new Button();
            panel5 = new Panel();
            btnPDF = new Button();
            btnExcel = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            txtPagH = new TextBox();
            label10 = new Label();
            label12 = new Label();
            cmbPagH = new ComboBox();
            label1 = new Label();
            cmbMostrar = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            dgvHab = new DataGridView();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHab).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 65);
            panel2.TabIndex = 35;
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
            btnCerrar.TabIndex = 42;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(18, 17);
            label11.Name = "label11";
            label11.Size = new Size(287, 32);
            label11.TabIndex = 41;
            label11.Text = "Habitaciones Registradas";
            // 
            // button2
            // 
            // 
            // button5
            // 
            // 
            // btnPerfil
            // 
            // 
            // btnCerrarSesion
            // 
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
            btnNuevo.Location = new Point(371, 17);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 35);
            btnNuevo.TabIndex = 40;
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.EnabledChanged += btnNuevo_EnabledChanged;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(btnNuevo);
            panel5.Controls.Add(btnPDF);
            panel5.Controls.Add(btnExcel);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 67);
            panel5.TabIndex = 36;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDF.BackColor = Color.Red;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPDF.ForeColor = SystemColors.ButtonHighlight;
            btnPDF.Location = new Point(963, 22);
            btnPDF.Margin = new Padding(1);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(78, 25);
            btnPDF.TabIndex = 55;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
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
            btnExcel.Margin = new Padding(1);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(78, 25);
            btnExcel.TabIndex = 54;
            btnExcel.Text = "Excel ";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // button3
            // 
            // 
            // button4
            // 
            // 
            // button7
            // 
            // 
            // button9
            // 
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(81, 22);
            txtBuscar.Margin = new Padding(1);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(252, 23);
            txtBuscar.TabIndex = 44;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(23, 24);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 66, 91);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(txtPagH);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(cmbPagH);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbMostrar);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 485);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 76);
            panel3.TabIndex = 38;
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
            btnSiguiente.Location = new Point(787, 15);
            btnSiguiente.Margin = new Padding(2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(30, 31);
            btnSiguiente.TabIndex = 62;
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
            btnAnterior.Location = new Point(751, 15);
            btnAnterior.Margin = new Padding(2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(30, 31);
            btnAnterior.TabIndex = 61;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // txtPagH
            // 
            txtPagH.Anchor = AnchorStyles.Right;
            txtPagH.Location = new Point(979, 20);
            txtPagH.Margin = new Padding(2);
            txtPagH.Name = "txtPagH";
            txtPagH.ReadOnly = true;
            txtPagH.Size = new Size(63, 23);
            txtPagH.TabIndex = 60;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(952, 23);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(24, 17);
            label10.TabIndex = 59;
            label10.Text = "De";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(824, 23);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(47, 17);
            label12.TabIndex = 58;
            label12.Text = "Página";
            // 
            // cmbPagH
            // 
            cmbPagH.Anchor = AnchorStyles.Right;
            cmbPagH.BackColor = SystemColors.Info;
            cmbPagH.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagH.FormattingEnabled = true;
            cmbPagH.Location = new Point(872, 20);
            cmbPagH.Margin = new Padding(1);
            cmbPagH.Name = "cmbPagH";
            cmbPagH.Size = new Size(65, 23);
            cmbPagH.TabIndex = 57;
            cmbPagH.SelectionChangeCommitted += cmbPagH_SelectionChangeCommitted;
            // 
            // txtPagTH
            // 
            // 
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 47;
            label1.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "10", "20", "30", "40" });
            cmbMostrar.Location = new Point(90, 18);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 46;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // cmbPaginacion
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(171, 21);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 48;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            // 
            // cmbPag
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(dgvHab);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 132);
            panel4.Name = "panel4";
            panel4.Size = new Size(1084, 353);
            panel4.TabIndex = 39;
            // 
            // dgvHab
            // 
            dgvHab.AllowUserToAddRows = false;
            dgvHab.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvHab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHab.BackgroundColor = Color.WhiteSmoke;
            dgvHab.BorderStyle = BorderStyle.None;
            dgvHab.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHab.ColumnHeadersHeight = 30;
            dgvHab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHab.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHab.EnableHeadersVisualStyles = false;
            dgvHab.GridColor = Color.FromArgb(45, 66, 91);
            dgvHab.Location = new Point(27, 6);
            dgvHab.Margin = new Padding(2);
            dgvHab.Name = "dgvHab";
            dgvHab.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHab.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHab.RowHeadersVisible = false;
            dgvHab.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvHab.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvHab.RowTemplate.Height = 25;
            dgvHab.Size = new Size(1027, 341);
            dgvHab.TabIndex = 4;
            dgvHab.CellClick += dgvHab_CellClick;
            dgvHab.CellFormatting += dgvHab_CellFormatting;
            // 
            // CtrlHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CtrlHabitaciones";
            Text = "CtrlHabitaciones";
            WindowState = FormWindowState.Maximized;
            Load += CtrlHabitaciones_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHab).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label11;
        private Panel panel5;
        private TextBox txtBuscar;
        private Label label4;
        private Button btnPDF;
        private Button btnExcel;
        private Panel panel3;
        private Label label1;
        private ComboBox cmbMostrar;
        private Label label3;
        private TextBox txtPagH;
        private Label label10;
        private Label label12;
        private ComboBox cmbPagH;
        private Panel panel4;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Button btnCerrar;
        public Button btnNuevo;
        public DataGridView dgvHab;
    }
}