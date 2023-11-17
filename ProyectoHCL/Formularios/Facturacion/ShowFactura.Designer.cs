namespace ProyectoHCL.Formularios
{
    partial class ShowFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFactura));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            lbl_servicios = new LinkLabel();
            lbl_Descuento = new LinkLabel();
            txt_RegSar = new TextBox();
            label42 = new Label();
            txt_ConsExone = new TextBox();
            label41 = new Label();
            txt_OCExenta = new TextBox();
            label40 = new Label();
            cb_MPago = new ComboBox();
            label39 = new Label();
            lb_noches = new Label();
            label10 = new Label();
            lb_Salida = new Label();
            label9 = new Label();
            lb_ingreso = new Label();
            lb_fecha = new Label();
            label7 = new Label();
            label5 = new Label();
            lb_huespedes = new Label();
            lb_ID = new Label();
            label4 = new Label();
            label3 = new Label();
            lb_nombres = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnFacturar = new Button();
            groupinfo = new GroupBox();
            panel3 = new Panel();
            dgvMontos = new DataGridView();
            pl_scroll = new Panel();
            dgvDetalleFact = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupinfo.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMontos).BeginInit();
            pl_scroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFact).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 61);
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
            btnCerrar.Location = new Point(759, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 31;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(286, 16);
            label11.Name = "label11";
            label11.Size = new Size(210, 30);
            label11.TabIndex = 28;
            label11.Text = "Información Factura";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnFacturar);
            panel1.Controls.Add(groupinfo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 611);
            panel1.TabIndex = 21;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(lbl_servicios);
            groupBox3.Controls.Add(lbl_Descuento);
            groupBox3.Controls.Add(txt_RegSar);
            groupBox3.Controls.Add(label42);
            groupBox3.Controls.Add(txt_ConsExone);
            groupBox3.Controls.Add(label41);
            groupBox3.Controls.Add(txt_OCExenta);
            groupBox3.Controls.Add(label40);
            groupBox3.Controls.Add(cb_MPago);
            groupBox3.Controls.Add(label39);
            groupBox3.Controls.Add(lb_noches);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lb_Salida);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lb_ingreso);
            groupBox3.Controls.Add(lb_fecha);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lb_huespedes);
            groupBox3.Controls.Add(lb_ID);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(lb_nombres);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(31, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(723, 193);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información ";
            // 
            // lbl_servicios
            // 
            lbl_servicios.AutoSize = true;
            lbl_servicios.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_servicios.Location = new Point(403, 91);
            lbl_servicios.Name = "lbl_servicios";
            lbl_servicios.Size = new Size(73, 18);
            lbl_servicios.TabIndex = 130;
            lbl_servicios.TabStop = true;
            lbl_servicios.Text = "Servicios";
            lbl_servicios.LinkClicked += lbl_servicios_LinkClicked;
            // 
            // lbl_Descuento
            // 
            lbl_Descuento.AutoSize = true;
            lbl_Descuento.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Descuento.Location = new Point(585, 91);
            lbl_Descuento.Name = "lbl_Descuento";
            lbl_Descuento.Size = new Size(93, 18);
            lbl_Descuento.TabIndex = 129;
            lbl_Descuento.TabStop = true;
            lbl_Descuento.Text = "Descuentos";
            // 
            // txt_RegSar
            // 
            txt_RegSar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_RegSar.Location = new Point(122, 156);
            txt_RegSar.Name = "txt_RegSar";
            txt_RegSar.Size = new Size(172, 26);
            txt_RegSar.TabIndex = 128;
            // 
            // label42
            // 
            label42.Anchor = AnchorStyles.Top;
            label42.AutoSize = true;
            label42.BackColor = Color.Transparent;
            label42.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label42.ForeColor = Color.Black;
            label42.Location = new Point(15, 159);
            label42.Name = "label42";
            label42.Size = new Size(102, 18);
            label42.TabIndex = 127;
            label42.Text = "Registro SAR:";
            // 
            // txt_ConsExone
            // 
            txt_ConsExone.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ConsExone.Location = new Point(202, 120);
            txt_ConsExone.Name = "txt_ConsExone";
            txt_ConsExone.Size = new Size(172, 26);
            txt_ConsExone.TabIndex = 126;
            // 
            // label41
            // 
            label41.Anchor = AnchorStyles.Top;
            label41.AutoSize = true;
            label41.BackColor = Color.Transparent;
            label41.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label41.ForeColor = Color.Black;
            label41.Location = new Point(15, 123);
            label41.Name = "label41";
            label41.Size = new Size(180, 18);
            label41.TabIndex = 125;
            label41.Text = "Constancia Exonerado:";
            // 
            // txt_OCExenta
            // 
            txt_OCExenta.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_OCExenta.Location = new Point(528, 151);
            txt_OCExenta.Name = "txt_OCExenta";
            txt_OCExenta.Size = new Size(172, 26);
            txt_OCExenta.TabIndex = 124;
            // 
            // label40
            // 
            label40.Anchor = AnchorStyles.Top;
            label40.AutoSize = true;
            label40.BackColor = Color.Transparent;
            label40.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label40.ForeColor = Color.Black;
            label40.Location = new Point(429, 154);
            label40.Name = "label40";
            label40.Size = new Size(100, 18);
            label40.TabIndex = 123;
            label40.Text = "OC Excenta:";
            // 
            // cb_MPago
            // 
            cb_MPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_MPago.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cb_MPago.FormattingEnabled = true;
            cb_MPago.Location = new Point(538, 115);
            cb_MPago.Name = "cb_MPago";
            cb_MPago.Size = new Size(162, 26);
            cb_MPago.TabIndex = 122;
            // 
            // label39
            // 
            label39.Anchor = AnchorStyles.Top;
            label39.AutoSize = true;
            label39.BackColor = Color.Transparent;
            label39.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = Color.Black;
            label39.Location = new Point(399, 118);
            label39.Name = "label39";
            label39.Size = new Size(136, 18);
            label39.TabIndex = 121;
            label39.Text = "Metodo de Pago:";
            // 
            // lb_noches
            // 
            lb_noches.Anchor = AnchorStyles.Top;
            lb_noches.AutoSize = true;
            lb_noches.BackColor = Color.Transparent;
            lb_noches.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noches.ForeColor = Color.Black;
            lb_noches.Location = new Point(661, 59);
            lb_noches.Name = "lb_noches";
            lb_noches.Size = new Size(0, 18);
            lb_noches.TabIndex = 112;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(580, 59);
            label10.Name = "label10";
            label10.Size = new Size(81, 18);
            label10.TabIndex = 111;
            label10.Text = "# Noches:";
            // 
            // lb_Salida
            // 
            lb_Salida.Anchor = AnchorStyles.Top;
            lb_Salida.AutoSize = true;
            lb_Salida.BackColor = Color.Transparent;
            lb_Salida.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Salida.ForeColor = Color.Black;
            lb_Salida.Location = new Point(462, 59);
            lb_Salida.Name = "lb_Salida";
            lb_Salida.Size = new Size(0, 18);
            lb_Salida.TabIndex = 110;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(403, 59);
            label9.Name = "label9";
            label9.Size = new Size(62, 18);
            label9.TabIndex = 109;
            label9.Text = "Salida: ";
            // 
            // lb_ingreso
            // 
            lb_ingreso.Anchor = AnchorStyles.Top;
            lb_ingreso.AutoSize = true;
            lb_ingreso.BackColor = Color.Transparent;
            lb_ingreso.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ingreso.ForeColor = Color.Black;
            lb_ingreso.Location = new Point(270, 59);
            lb_ingreso.Name = "lb_ingreso";
            lb_ingreso.Size = new Size(0, 18);
            lb_ingreso.TabIndex = 108;
            // 
            // lb_fecha
            // 
            lb_fecha.Anchor = AnchorStyles.Top;
            lb_fecha.AutoSize = true;
            lb_fecha.BackColor = Color.Transparent;
            lb_fecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_fecha.ForeColor = Color.Black;
            lb_fecha.Location = new Point(74, 59);
            lb_fecha.Name = "lb_fecha";
            lb_fecha.Size = new Size(0, 18);
            lb_fecha.TabIndex = 107;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(202, 59);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 106;
            label7.Text = "Ingreso:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(15, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 105;
            label5.Text = "Fecha:";
            // 
            // lb_huespedes
            // 
            lb_huespedes.Anchor = AnchorStyles.Top;
            lb_huespedes.AutoSize = true;
            lb_huespedes.BackColor = Color.Transparent;
            lb_huespedes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_huespedes.ForeColor = Color.Black;
            lb_huespedes.Location = new Point(122, 91);
            lb_huespedes.Name = "lb_huespedes";
            lb_huespedes.Size = new Size(0, 18);
            lb_huespedes.TabIndex = 104;
            // 
            // lb_ID
            // 
            lb_ID.Anchor = AnchorStyles.Top;
            lb_ID.AutoSize = true;
            lb_ID.BackColor = Color.Transparent;
            lb_ID.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ID.ForeColor = Color.Black;
            lb_ID.Location = new Point(528, 28);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(0, 18);
            lb_ID.TabIndex = 103;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 91);
            label4.Name = "label4";
            label4.Size = new Size(106, 18);
            label4.TabIndex = 102;
            label4.Text = "# Huespedes:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(403, 28);
            label3.Name = "label3";
            label3.Size = new Size(114, 18);
            label3.TabIndex = 101;
            label3.Text = "Identificación:";
            // 
            // lb_nombres
            // 
            lb_nombres.Anchor = AnchorStyles.Top;
            lb_nombres.AutoSize = true;
            lb_nombres.BackColor = Color.Transparent;
            lb_nombres.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_nombres.ForeColor = Color.Black;
            lb_nombres.Location = new Point(104, 28);
            lb_nombres.Name = "lb_nombres";
            lb_nombres.Size = new Size(0, 18);
            lb_nombres.TabIndex = 99;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 97;
            label2.Text = "Nombres:";
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
            btnCancelar.Location = new Point(483, 540);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 74;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.Anchor = AnchorStyles.Top;
            btnFacturar.BackColor = Color.ForestGreen;
            btnFacturar.FlatAppearance.BorderSize = 0;
            btnFacturar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnFacturar.FlatStyle = FlatStyle.Flat;
            btnFacturar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturar.ForeColor = Color.White;
            btnFacturar.Location = new Point(219, 540);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(82, 32);
            btnFacturar.TabIndex = 73;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // groupinfo
            // 
            groupinfo.BackColor = Color.DarkGray;
            groupinfo.Controls.Add(panel3);
            groupinfo.Controls.Add(pl_scroll);
            groupinfo.Location = new Point(13, 215);
            groupinfo.Name = "groupinfo";
            groupinfo.Size = new Size(767, 305);
            groupinfo.TabIndex = 64;
            groupinfo.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(dgvMontos);
            panel3.Location = new Point(507, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 287);
            panel3.TabIndex = 3;
            // 
            // dgvMontos
            // 
            dgvMontos.AllowUserToAddRows = false;
            dgvMontos.AllowUserToDeleteRows = false;
            dgvMontos.AllowUserToResizeColumns = false;
            dgvMontos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvMontos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMontos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMontos.BackgroundColor = Color.WhiteSmoke;
            dgvMontos.BorderStyle = BorderStyle.None;
            dgvMontos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMontos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMontos.ColumnHeadersHeight = 30;
            dgvMontos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMontos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMontos.Dock = DockStyle.Fill;
            dgvMontos.EnableHeadersVisualStyles = false;
            dgvMontos.GridColor = Color.FromArgb(45, 66, 91);
            dgvMontos.Location = new Point(0, 0);
            dgvMontos.Margin = new Padding(2);
            dgvMontos.Name = "dgvMontos";
            dgvMontos.ReadOnly = true;
            dgvMontos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMontos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMontos.RowHeadersVisible = false;
            dgvMontos.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvMontos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMontos.RowTemplate.Height = 25;
            dgvMontos.Size = new Size(257, 287);
            dgvMontos.TabIndex = 2;
            // 
            // pl_scroll
            // 
            pl_scroll.AutoScroll = true;
            pl_scroll.Controls.Add(dgvDetalleFact);
            pl_scroll.Location = new Point(6, 12);
            pl_scroll.Name = "pl_scroll";
            pl_scroll.Size = new Size(495, 287);
            pl_scroll.TabIndex = 0;
            // 
            // dgvDetalleFact
            // 
            dgvDetalleFact.AllowUserToAddRows = false;
            dgvDetalleFact.AllowUserToDeleteRows = false;
            dgvDetalleFact.AllowUserToResizeColumns = false;
            dgvDetalleFact.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvDetalleFact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvDetalleFact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFact.BackgroundColor = Color.WhiteSmoke;
            dgvDetalleFact.BorderStyle = BorderStyle.None;
            dgvDetalleFact.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDetalleFact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalleFact.ColumnHeadersHeight = 30;
            dgvDetalleFact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDetalleFact.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDetalleFact.Dock = DockStyle.Fill;
            dgvDetalleFact.EnableHeadersVisualStyles = false;
            dgvDetalleFact.GridColor = Color.FromArgb(45, 66, 91);
            dgvDetalleFact.Location = new Point(0, 0);
            dgvDetalleFact.Margin = new Padding(2);
            dgvDetalleFact.Name = "dgvDetalleFact";
            dgvDetalleFact.ReadOnly = true;
            dgvDetalleFact.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvDetalleFact.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvDetalleFact.RowHeadersVisible = false;
            dgvDetalleFact.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvDetalleFact.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvDetalleFact.RowTemplate.Height = 25;
            dgvDetalleFact.Size = new Size(495, 287);
            dgvDetalleFact.TabIndex = 2;
            // 
            // ShowFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(792, 672);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowFactura";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            Load += ShowFactura_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupinfo.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMontos).EndInit();
            pl_scroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFact).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label11;
        public TextBox txtDescripcion;
        public ComboBox cmbEstado;
        private Panel panel1;
        private Button btnCerrar;
        private GroupBox groupinfo;
        private Panel pl_scroll;
        private Button btnCancelar;
        private Button btnFacturar;
        private GroupBox groupBox3;
        private Label lb_noches;
        private Label label10;
        private Label lb_Salida;
        private Label label9;
        private Label lb_ingreso;
        public Label lb_fecha;
        private Label label7;
        private Label label5;
        private Label lb_huespedes;
        private Label lb_ID;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cb_MPago;
        private Label label39;
        private TextBox txt_OCExenta;
        private Label label40;
        private TextBox txt_ConsExone;
        private Label label41;
        private TextBox lb_RegSar;
        private Label label42;
        public TextBox txt_RegSar;
        public DataGridView dgvDetalleFact;
        private Panel panel3;
        public DataGridView dgvMontos;
        private LinkLabel lbl_servicios;
        private LinkLabel lbl_Descuento;
        private Label lb_nombres;
    }
}