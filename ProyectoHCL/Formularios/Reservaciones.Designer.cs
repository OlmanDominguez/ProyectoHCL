namespace ProyectoHCL
{
    partial class Reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservaciones));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnExit = new PictureBox();
            dgv_reservaciones = new DataGridView();
            panel3 = new Panel();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            TXT_PAGINACION_X = new TextBox();
            label1 = new Label();
            label3 = new Label();
            CB_PAGINACION_R = new ComboBox();
            label10 = new Label();
            cmbMostrar = new ComboBox();
            label12 = new Label();
            txtPagTH = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cboxPag = new ComboBox();
            txtPaginacion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbPaginacion = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            txtPag = new TextBox();
            cmbPag = new ComboBox();
            panel2 = new Panel();
            button2 = new Button();
            button5 = new Button();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            btnNuevo = new Button();
            label11 = new Label();
            panel5 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button9 = new Button();
            btn_pdf = new Button();
            btn_excel = new Button();
            txtBuscar_reservas = new TextBox();
            label4 = new Label();
            panelChildForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reservaciones).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(867, -2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgv_reservaciones
            // 
            dgv_reservaciones.AllowUserToAddRows = false;
            dgv_reservaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgv_reservaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv_reservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_reservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_reservaciones.BackgroundColor = Color.WhiteSmoke;
            dgv_reservaciones.BorderStyle = BorderStyle.None;
            dgv_reservaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_reservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_reservaciones.ColumnHeadersHeight = 30;
            dgv_reservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_reservaciones.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_reservaciones.EnableHeadersVisualStyles = false;
            dgv_reservaciones.GridColor = Color.FromArgb(45, 66, 91);
            dgv_reservaciones.Location = new Point(2, 213);
            dgv_reservaciones.Name = "dgv_reservaciones";
            dgv_reservaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_reservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_reservaciones.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgv_reservaciones.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv_reservaciones.RowTemplate.Height = 25;
            dgv_reservaciones.Size = new Size(896, 306);
            dgv_reservaciones.TabIndex = 37;
            dgv_reservaciones.CellClick += dgv_reservaciones_CellClick;
            dgv_reservaciones.CellContentClick += dgv_reservaciones_CellContentClick;
            dgv_reservaciones.CellPainting += dgv_reservaciones_CellPainting;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 66, 91);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(TXT_PAGINACION_X);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(CB_PAGINACION_R);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cmbMostrar);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtPagTH);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cboxPag);
            panel3.Controls.Add(txtPaginacion);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbPaginacion);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtPag);
            panel3.Controls.Add(cmbPag);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 537);
            panel3.Name = "panel3";
            panel3.Size = new Size(896, 76);
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
            btnSiguiente.Location = new Point(631, 17);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(30, 31);
            btnSiguiente.TabIndex = 66;
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
            btnAnterior.Location = new Point(595, 17);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(30, 31);
            btnAnterior.TabIndex = 65;
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // TXT_PAGINACION_X
            // 
            TXT_PAGINACION_X.Anchor = AnchorStyles.Right;
            TXT_PAGINACION_X.Location = new Point(825, 24);
            TXT_PAGINACION_X.Name = "TXT_PAGINACION_X";
            TXT_PAGINACION_X.ReadOnly = true;
            TXT_PAGINACION_X.Size = new Size(63, 23);
            TXT_PAGINACION_X.TabIndex = 63;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(795, 25);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 62;
            label1.Text = "De";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(667, 25);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 61;
            label3.Text = "Página";
            // 
            // CB_PAGINACION_R
            // 
            CB_PAGINACION_R.Anchor = AnchorStyles.Right;
            CB_PAGINACION_R.BackColor = SystemColors.Info;
            CB_PAGINACION_R.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_PAGINACION_R.FormattingEnabled = true;
            CB_PAGINACION_R.Location = new Point(715, 22);
            CB_PAGINACION_R.Margin = new Padding(2);
            CB_PAGINACION_R.Name = "CB_PAGINACION_R";
            CB_PAGINACION_R.Size = new Size(65, 23);
            CB_PAGINACION_R.TabIndex = 60;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(14, 25);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 17);
            label10.TabIndex = 58;
            label10.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "5", "10", "15", "20" });
            cmbMostrar.Location = new Point(77, 22);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 57;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(158, 25);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 59;
            label12.Text = "registros";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPagTH
            // 
            txtPagTH.Anchor = AnchorStyles.Right;
            txtPagTH.Location = new Point(1615, 5);
            txtPagTH.Name = "txtPagTH";
            txtPagTH.ReadOnly = true;
            txtPagTH.Size = new Size(63, 23);
            txtPagTH.TabIndex = 56;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(1588, 8);
            label8.Name = "label8";
            label8.Size = new Size(24, 17);
            label8.TabIndex = 55;
            label8.Text = "De";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(1460, 8);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 54;
            label9.Text = "Página";
            // 
            // cboxPag
            // 
            cboxPag.Anchor = AnchorStyles.Right;
            cboxPag.BackColor = SystemColors.Info;
            cboxPag.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxPag.FormattingEnabled = true;
            cboxPag.Location = new Point(1508, 5);
            cboxPag.Margin = new Padding(2);
            cboxPag.Name = "cboxPag";
            cboxPag.Size = new Size(65, 23);
            cboxPag.TabIndex = 53;
            // 
            // txtPaginacion
            // 
            txtPaginacion.Anchor = AnchorStyles.Right;
            txtPaginacion.Location = new Point(2445, -8);
            txtPaginacion.Name = "txtPaginacion";
            txtPaginacion.ReadOnly = true;
            txtPaginacion.Size = new Size(63, 23);
            txtPaginacion.TabIndex = 52;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(2418, -5);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 51;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(2290, -5);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 50;
            label7.Text = "Página";
            // 
            // cmbPaginacion
            // 
            cmbPaginacion.Anchor = AnchorStyles.Right;
            cmbPaginacion.BackColor = SystemColors.Info;
            cmbPaginacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaginacion.FormattingEnabled = true;
            cmbPaginacion.Location = new Point(2338, -8);
            cmbPaginacion.Margin = new Padding(2);
            cmbPaginacion.Name = "cmbPaginacion";
            cmbPaginacion.Size = new Size(65, 23);
            cmbPaginacion.TabIndex = 48;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3242, -17);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 47;
            label2.Text = "De";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3114, -17);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 46;
            label5.Text = "Página";
            // 
            // txtPag
            // 
            txtPag.Anchor = AnchorStyles.Right;
            txtPag.Location = new Point(3269, -20);
            txtPag.Name = "txtPag";
            txtPag.Size = new Size(65, 23);
            txtPag.TabIndex = 45;
            // 
            // cmbPag
            // 
            cmbPag.Anchor = AnchorStyles.Right;
            cmbPag.BackColor = SystemColors.Info;
            cmbPag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPag.FormattingEnabled = true;
            cmbPag.Location = new Point(3162, -20);
            cmbPag.Margin = new Padding(2);
            cmbPag.Name = "cmbPag";
            cmbPag.Size = new Size(65, 23);
            cmbPag.TabIndex = 44;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 125);
            panel2.TabIndex = 35;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(3549, 74);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 38;
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(3596, 72);
            button5.Name = "button5";
            button5.Size = new Size(35, 33);
            button5.TabIndex = 39;
            button5.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.BackgroundImage = (Image)resources.GetObject("btnPerfil.BackgroundImage");
            btnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(4264, 73);
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
            btnCerrarSesion.Location = new Point(4311, 71);
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
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(29, 64);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 39);
            btnNuevo.TabIndex = 40;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(19, 17);
            label11.Name = "label11";
            label11.Size = new Size(167, 32);
            label11.TabIndex = 41;
            label11.Text = "Reservaciones";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button9);
            panel5.Controls.Add(btn_pdf);
            panel5.Controls.Add(btn_excel);
            panel5.Controls.Add(txtBuscar_reservas);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(896, 85);
            panel5.TabIndex = 36;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1599, 12);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(78, 25);
            button3.TabIndex = 53;
            button3.Text = "PDF";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1508, 12);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 25);
            button4.TabIndex = 52;
            button4.Text = "Excel ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.Red;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(2430, -2);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(78, 25);
            button7.TabIndex = 51;
            button7.Text = "PDF";
            button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(0, 192, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(2339, -2);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(78, 25);
            button9.TabIndex = 50;
            button9.Text = "Excel ";
            button9.UseVisualStyleBackColor = false;
            // 
            // btn_pdf
            // 
            btn_pdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_pdf.BackColor = Color.Red;
            btn_pdf.FlatAppearance.BorderSize = 0;
            btn_pdf.FlatStyle = FlatStyle.Flat;
            btn_pdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pdf.ForeColor = SystemColors.ButtonHighlight;
            btn_pdf.Location = new Point(806, 34);
            btn_pdf.Margin = new Padding(2);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(78, 25);
            btn_pdf.TabIndex = 55;
            btn_pdf.Text = "PDF";
            btn_pdf.UseVisualStyleBackColor = false;
            btn_pdf.Click += button1_Click;
            // 
            // btn_excel
            // 
            btn_excel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_excel.BackColor = Color.FromArgb(0, 192, 0);
            btn_excel.FlatAppearance.BorderSize = 0;
            btn_excel.FlatStyle = FlatStyle.Flat;
            btn_excel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_excel.ForeColor = SystemColors.ButtonHighlight;
            btn_excel.Location = new Point(715, 34);
            btn_excel.Margin = new Padding(2);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(78, 25);
            btn_excel.TabIndex = 54;
            btn_excel.Text = "Excel ";
            btn_excel.UseVisualStyleBackColor = false;
            btn_excel.Click += button6_Click;
            // 
            // txtBuscar_reservas
            // 
            txtBuscar_reservas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar_reservas.BackColor = SystemColors.Info;
            txtBuscar_reservas.Location = new Point(89, 32);
            txtBuscar_reservas.Margin = new Padding(2);
            txtBuscar_reservas.Name = "txtBuscar_reservas";
            txtBuscar_reservas.Size = new Size(252, 23);
            txtBuscar_reservas.TabIndex = 44;
            txtBuscar_reservas.TextChanged += txtBuscar_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(29, 34);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.Transparent;
            panelChildForm.Controls.Add(panel5);
            panelChildForm.Controls.Add(panel2);
            panelChildForm.Dock = DockStyle.Top;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(896, 531);
            panelChildForm.TabIndex = 2;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Reservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 613);
            Controls.Add(panel3);
            Controls.Add(dgv_reservaciones);
            Controls.Add(btnExit);
            Controls.Add(panelChildForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservaciones";
            Text = "Reservaciones";
            Load += Reservaciones_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_reservaciones).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnExit;
        private Panel panel3;
        private TextBox txtPagTH;
        private Label label8;
        private Label label9;
        private ComboBox cboxPag;
        private TextBox txtPaginacion;
        private Label label6;
        private Label label7;
        private ComboBox cmbPaginacion;
        private Label label2;
        private Label label5;
        private TextBox txtPag;
        private ComboBox cmbPag;
        private Label label1;
        private Label label3;
        private Label label10;
        private Label label12;
        private Panel panel2;
        private Button button2;
        private Button button5;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Label label11;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button9;
        private Label label4;
        private Panel panelChildForm;
        public DataGridView dgv_reservaciones;
        public ComboBox CB_PAGINACION_R;
        public ComboBox cmbMostrar;
        public TextBox TXT_PAGINACION_X;
        public Button btnNuevo;
        public Panel panel5;
        public Button btn_pdf;
        public Button btn_excel;
        public TextBox txtBuscar_reservas;
        private Button btnSiguiente;
        private Button btnAnterior;
    }
}