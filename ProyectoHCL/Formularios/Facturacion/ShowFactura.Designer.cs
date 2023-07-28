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
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
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
            pl_scroll = new Panel();
            groupBox2 = new GroupBox();
            lb_StS = new Label();
            label34 = new Label();
            lb_St3 = new Label();
            lb_Pr3 = new Label();
            lb_Ca3 = new Label();
            lb_Ser3 = new Label();
            lb_St2 = new Label();
            lb_Pr2 = new Label();
            lb_Ca2 = new Label();
            lb_St1 = new Label();
            lb_Pr1 = new Label();
            lb_Ca1 = new Label();
            lb_Ser2 = new Label();
            lb_Ser1 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label19 = new Label();
            label20 = new Label();
            label22 = new Label();
            groupBox1 = new GroupBox();
            lb_StH = new Label();
            label = new Label();
            label18 = new Label();
            lb_sbt3 = new Label();
            lb_Habi3 = new Label();
            label21 = new Label();
            lb_pre3 = new Label();
            label23 = new Label();
            label24 = new Label();
            lb_Tipo3 = new Label();
            label17 = new Label();
            lb_sbt2 = new Label();
            lb_Habi1 = new Label();
            lb_sbt1 = new Label();
            label6 = new Label();
            label8 = new Label();
            label15 = new Label();
            lb_Tipo1 = new Label();
            lb_Habi2 = new Label();
            label13 = new Label();
            lb_pre2 = new Label();
            label12 = new Label();
            label14 = new Label();
            lb_Tipo2 = new Label();
            lb_pre1 = new Label();
            label16 = new Label();
            label37 = new Label();
            label35 = new Label();
            lb_isv = new Label();
            label36 = new Label();
            lb_Total = new Label();
            lb_it = new Label();
            label38 = new Label();
            lb_Stotal = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupinfo.SuspendLayout();
            pl_scroll.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 73);
            panel2.TabIndex = 20;
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
            pictureBox5.TabIndex = 22;
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
            label11.Location = new Point(282, 21);
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
            panel1.Controls.Add(label37);
            panel1.Controls.Add(label35);
            panel1.Controls.Add(lb_isv);
            panel1.Controls.Add(label36);
            panel1.Controls.Add(lb_Total);
            panel1.Controls.Add(lb_it);
            panel1.Controls.Add(label38);
            panel1.Controls.Add(lb_Stotal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 599);
            panel1.TabIndex = 21;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
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
            txt_OCExenta.Location = new Point(502, 120);
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
            label40.Location = new Point(403, 123);
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
            cb_MPago.Location = new Point(341, 88);
            cb_MPago.Name = "cb_MPago";
            cb_MPago.Size = new Size(121, 26);
            cb_MPago.TabIndex = 122;
            // 
            // label39
            // 
            label39.Anchor = AnchorStyles.Top;
            label39.AutoSize = true;
            label39.BackColor = Color.Transparent;
            label39.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label39.ForeColor = Color.Black;
            label39.Location = new Point(202, 91);
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
            btnFacturar.Location = new Point(158, 540);
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
            groupinfo.Controls.Add(pl_scroll);
            groupinfo.Location = new Point(13, 215);
            groupinfo.Name = "groupinfo";
            groupinfo.Size = new Size(767, 237);
            groupinfo.TabIndex = 64;
            groupinfo.TabStop = false;
            // 
            // pl_scroll
            // 
            pl_scroll.AutoScroll = true;
            pl_scroll.Controls.Add(groupBox2);
            pl_scroll.Controls.Add(groupBox1);
            pl_scroll.Location = new Point(6, 12);
            pl_scroll.Name = "pl_scroll";
            pl_scroll.Size = new Size(755, 219);
            pl_scroll.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(lb_StS);
            groupBox2.Controls.Add(label34);
            groupBox2.Controls.Add(lb_St3);
            groupBox2.Controls.Add(lb_Pr3);
            groupBox2.Controls.Add(lb_Ca3);
            groupBox2.Controls.Add(lb_Ser3);
            groupBox2.Controls.Add(lb_St2);
            groupBox2.Controls.Add(lb_Pr2);
            groupBox2.Controls.Add(lb_Ca2);
            groupBox2.Controls.Add(lb_St1);
            groupBox2.Controls.Add(lb_Pr1);
            groupBox2.Controls.Add(lb_Ca1);
            groupBox2.Controls.Add(lb_Ser2);
            groupBox2.Controls.Add(lb_Ser1);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(label32);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(label30);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label22);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 151);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios";
            // 
            // lb_StS
            // 
            lb_StS.Anchor = AnchorStyles.Top;
            lb_StS.AutoSize = true;
            lb_StS.BackColor = Color.Transparent;
            lb_StS.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_StS.ForeColor = Color.Black;
            lb_StS.Location = new Point(608, 120);
            lb_StS.Name = "lb_StS";
            lb_StS.Size = new Size(0, 18);
            lb_StS.TabIndex = 90;
            // 
            // label34
            // 
            label34.Anchor = AnchorStyles.Top;
            label34.AutoSize = true;
            label34.BackColor = Color.Transparent;
            label34.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(533, 120);
            label34.Name = "label34";
            label34.Size = new Size(73, 18);
            label34.TabIndex = 89;
            label34.Text = "SubTotal:";
            // 
            // lb_St3
            // 
            lb_St3.Anchor = AnchorStyles.Top;
            lb_St3.AutoSize = true;
            lb_St3.BackColor = Color.Transparent;
            lb_St3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_St3.ForeColor = Color.Black;
            lb_St3.Location = new Point(607, 90);
            lb_St3.Name = "lb_St3";
            lb_St3.Size = new Size(0, 18);
            lb_St3.TabIndex = 88;
            // 
            // lb_Pr3
            // 
            lb_Pr3.Anchor = AnchorStyles.Top;
            lb_Pr3.AutoSize = true;
            lb_Pr3.BackColor = Color.Transparent;
            lb_Pr3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Pr3.ForeColor = Color.Black;
            lb_Pr3.Location = new Point(438, 90);
            lb_Pr3.Name = "lb_Pr3";
            lb_Pr3.Size = new Size(0, 18);
            lb_Pr3.TabIndex = 87;
            // 
            // lb_Ca3
            // 
            lb_Ca3.Anchor = AnchorStyles.Top;
            lb_Ca3.AutoSize = true;
            lb_Ca3.BackColor = Color.Transparent;
            lb_Ca3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ca3.ForeColor = Color.Black;
            lb_Ca3.Location = new Point(322, 90);
            lb_Ca3.Name = "lb_Ca3";
            lb_Ca3.Size = new Size(0, 18);
            lb_Ca3.TabIndex = 86;
            // 
            // lb_Ser3
            // 
            lb_Ser3.Anchor = AnchorStyles.Top;
            lb_Ser3.AutoSize = true;
            lb_Ser3.BackColor = Color.Transparent;
            lb_Ser3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ser3.ForeColor = Color.Black;
            lb_Ser3.Location = new Point(100, 90);
            lb_Ser3.Name = "lb_Ser3";
            lb_Ser3.Size = new Size(0, 18);
            lb_Ser3.TabIndex = 85;
            // 
            // lb_St2
            // 
            lb_St2.Anchor = AnchorStyles.Top;
            lb_St2.AutoSize = true;
            lb_St2.BackColor = Color.Transparent;
            lb_St2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_St2.ForeColor = Color.Black;
            lb_St2.Location = new Point(607, 60);
            lb_St2.Name = "lb_St2";
            lb_St2.Size = new Size(0, 18);
            lb_St2.TabIndex = 84;
            // 
            // lb_Pr2
            // 
            lb_Pr2.Anchor = AnchorStyles.Top;
            lb_Pr2.AutoSize = true;
            lb_Pr2.BackColor = Color.Transparent;
            lb_Pr2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Pr2.ForeColor = Color.Black;
            lb_Pr2.Location = new Point(438, 60);
            lb_Pr2.Name = "lb_Pr2";
            lb_Pr2.Size = new Size(0, 18);
            lb_Pr2.TabIndex = 83;
            // 
            // lb_Ca2
            // 
            lb_Ca2.Anchor = AnchorStyles.Top;
            lb_Ca2.AutoSize = true;
            lb_Ca2.BackColor = Color.Transparent;
            lb_Ca2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ca2.ForeColor = Color.Black;
            lb_Ca2.Location = new Point(322, 60);
            lb_Ca2.Name = "lb_Ca2";
            lb_Ca2.Size = new Size(0, 18);
            lb_Ca2.TabIndex = 82;
            // 
            // lb_St1
            // 
            lb_St1.Anchor = AnchorStyles.Top;
            lb_St1.AutoSize = true;
            lb_St1.BackColor = Color.Transparent;
            lb_St1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_St1.ForeColor = Color.Black;
            lb_St1.Location = new Point(607, 30);
            lb_St1.Name = "lb_St1";
            lb_St1.Size = new Size(0, 18);
            lb_St1.TabIndex = 81;
            // 
            // lb_Pr1
            // 
            lb_Pr1.Anchor = AnchorStyles.Top;
            lb_Pr1.AutoSize = true;
            lb_Pr1.BackColor = Color.Transparent;
            lb_Pr1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Pr1.ForeColor = Color.Black;
            lb_Pr1.Location = new Point(438, 30);
            lb_Pr1.Name = "lb_Pr1";
            lb_Pr1.Size = new Size(0, 18);
            lb_Pr1.TabIndex = 80;
            // 
            // lb_Ca1
            // 
            lb_Ca1.Anchor = AnchorStyles.Top;
            lb_Ca1.AutoSize = true;
            lb_Ca1.BackColor = Color.Transparent;
            lb_Ca1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ca1.ForeColor = Color.Black;
            lb_Ca1.Location = new Point(322, 30);
            lb_Ca1.Name = "lb_Ca1";
            lb_Ca1.Size = new Size(0, 18);
            lb_Ca1.TabIndex = 79;
            // 
            // lb_Ser2
            // 
            lb_Ser2.Anchor = AnchorStyles.Top;
            lb_Ser2.AutoSize = true;
            lb_Ser2.BackColor = Color.Transparent;
            lb_Ser2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ser2.ForeColor = Color.Black;
            lb_Ser2.Location = new Point(100, 60);
            lb_Ser2.Name = "lb_Ser2";
            lb_Ser2.Size = new Size(0, 18);
            lb_Ser2.TabIndex = 78;
            // 
            // lb_Ser1
            // 
            lb_Ser1.Anchor = AnchorStyles.Top;
            lb_Ser1.AutoSize = true;
            lb_Ser1.BackColor = Color.Transparent;
            lb_Ser1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ser1.ForeColor = Color.Black;
            lb_Ser1.Location = new Point(100, 30);
            lb_Ser1.Name = "lb_Ser1";
            lb_Ser1.Size = new Size(0, 18);
            lb_Ser1.TabIndex = 77;
            // 
            // label31
            // 
            label31.Anchor = AnchorStyles.Top;
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(533, 90);
            label31.Name = "label31";
            label31.Size = new Size(73, 18);
            label31.TabIndex = 76;
            label31.Text = "SubTotal:";
            // 
            // label32
            // 
            label32.Anchor = AnchorStyles.Top;
            label32.AutoSize = true;
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(380, 90);
            label32.Name = "label32";
            label32.Size = new Size(59, 18);
            label32.TabIndex = 75;
            label32.Text = "Precio:";
            // 
            // label33
            // 
            label33.Anchor = AnchorStyles.Top;
            label33.AutoSize = true;
            label33.BackColor = Color.Transparent;
            label33.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.Black;
            label33.Location = new Point(240, 90);
            label33.Name = "label33";
            label33.Size = new Size(81, 18);
            label33.TabIndex = 74;
            label33.Text = "Cantidad:";
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(533, 60);
            label28.Name = "label28";
            label28.Size = new Size(73, 18);
            label28.TabIndex = 73;
            label28.Text = "SubTotal:";
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top;
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(380, 60);
            label29.Name = "label29";
            label29.Size = new Size(59, 18);
            label29.TabIndex = 72;
            label29.Text = "Precio:";
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top;
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(240, 60);
            label30.Name = "label30";
            label30.Size = new Size(81, 18);
            label30.TabIndex = 71;
            label30.Text = "Cantidad:";
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top;
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(533, 30);
            label27.Name = "label27";
            label27.Size = new Size(73, 18);
            label27.TabIndex = 70;
            label27.Text = "SubTotal:";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top;
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(380, 30);
            label26.Name = "label26";
            label26.Size = new Size(59, 18);
            label26.TabIndex = 69;
            label26.Text = "Precio:";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(240, 30);
            label25.Name = "label25";
            label25.Size = new Size(81, 18);
            label25.TabIndex = 68;
            label25.Text = "Cantidad:";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(17, 90);
            label19.Name = "label19";
            label19.Size = new Size(83, 18);
            label19.TabIndex = 67;
            label19.Text = "Servicio 3:";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(17, 30);
            label20.Name = "label20";
            label20.Size = new Size(83, 18);
            label20.TabIndex = 65;
            label20.Text = "Servicio 1:";
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top;
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(17, 60);
            label22.Name = "label22";
            label22.Size = new Size(83, 18);
            label22.TabIndex = 66;
            label22.Text = "Servicio 2:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(lb_StH);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lb_sbt3);
            groupBox1.Controls.Add(lb_Habi3);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(lb_pre3);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(lb_Tipo3);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(lb_sbt2);
            groupBox1.Controls.Add(lb_Habi1);
            groupBox1.Controls.Add(lb_sbt1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lb_Tipo1);
            groupBox1.Controls.Add(lb_Habi2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lb_pre2);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lb_Tipo2);
            groupBox1.Controls.Add(lb_pre1);
            groupBox1.Controls.Add(label16);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 151);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Habitaciones";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lb_StH
            // 
            lb_StH.Anchor = AnchorStyles.Top;
            lb_StH.AutoSize = true;
            lb_StH.BackColor = Color.Transparent;
            lb_StH.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_StH.ForeColor = Color.Black;
            lb_StH.Location = new Point(608, 120);
            lb_StH.Name = "lb_StH";
            lb_StH.Size = new Size(0, 18);
            lb_StH.TabIndex = 72;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Black;
            label.Location = new Point(533, 120);
            label.Name = "label";
            label.Size = new Size(73, 18);
            label.TabIndex = 71;
            label.Text = "SubTotal:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(533, 90);
            label18.Name = "label18";
            label18.Size = new Size(73, 18);
            label18.TabIndex = 69;
            label18.Text = "SubTotal:";
            // 
            // lb_sbt3
            // 
            lb_sbt3.Anchor = AnchorStyles.Top;
            lb_sbt3.AutoSize = true;
            lb_sbt3.BackColor = Color.Transparent;
            lb_sbt3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sbt3.ForeColor = Color.Black;
            lb_sbt3.Location = new Point(608, 90);
            lb_sbt3.Name = "lb_sbt3";
            lb_sbt3.Size = new Size(0, 18);
            lb_sbt3.TabIndex = 70;
            // 
            // lb_Habi3
            // 
            lb_Habi3.Anchor = AnchorStyles.Top;
            lb_Habi3.AutoSize = true;
            lb_Habi3.BackColor = Color.Transparent;
            lb_Habi3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Habi3.ForeColor = Color.Black;
            lb_Habi3.Location = new Point(125, 90);
            lb_Habi3.Name = "lb_Habi3";
            lb_Habi3.Size = new Size(0, 18);
            lb_Habi3.TabIndex = 63;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(17, 90);
            label21.Name = "label21";
            label21.Size = new Size(105, 18);
            label21.TabIndex = 64;
            label21.Text = "Habitación 3:";
            // 
            // lb_pre3
            // 
            lb_pre3.Anchor = AnchorStyles.Top;
            lb_pre3.AutoSize = true;
            lb_pre3.BackColor = Color.Transparent;
            lb_pre3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pre3.ForeColor = Color.Black;
            lb_pre3.Location = new Point(440, 90);
            lb_pre3.Name = "lb_pre3";
            lb_pre3.Size = new Size(0, 18);
            lb_pre3.TabIndex = 68;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(240, 90);
            label23.Name = "label23";
            label23.Size = new Size(42, 18);
            label23.TabIndex = 65;
            label23.Text = "Tipo:";
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(380, 90);
            label24.Name = "label24";
            label24.Size = new Size(59, 18);
            label24.TabIndex = 67;
            label24.Text = "Precio:";
            // 
            // lb_Tipo3
            // 
            lb_Tipo3.Anchor = AnchorStyles.Top;
            lb_Tipo3.AutoSize = true;
            lb_Tipo3.BackColor = Color.Transparent;
            lb_Tipo3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Tipo3.ForeColor = Color.Black;
            lb_Tipo3.Location = new Point(283, 90);
            lb_Tipo3.Name = "lb_Tipo3";
            lb_Tipo3.Size = new Size(0, 18);
            lb_Tipo3.TabIndex = 66;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(533, 60);
            label17.Name = "label17";
            label17.Size = new Size(73, 18);
            label17.TabIndex = 60;
            label17.Text = "SubTotal:";
            // 
            // lb_sbt2
            // 
            lb_sbt2.Anchor = AnchorStyles.Top;
            lb_sbt2.AutoSize = true;
            lb_sbt2.BackColor = Color.Transparent;
            lb_sbt2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sbt2.ForeColor = Color.Black;
            lb_sbt2.Location = new Point(608, 60);
            lb_sbt2.Name = "lb_sbt2";
            lb_sbt2.Size = new Size(0, 18);
            lb_sbt2.TabIndex = 62;
            // 
            // lb_Habi1
            // 
            lb_Habi1.Anchor = AnchorStyles.Top;
            lb_Habi1.AutoSize = true;
            lb_Habi1.BackColor = Color.Transparent;
            lb_Habi1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Habi1.ForeColor = Color.Black;
            lb_Habi1.Location = new Point(125, 30);
            lb_Habi1.Name = "lb_Habi1";
            lb_Habi1.Size = new Size(0, 18);
            lb_Habi1.TabIndex = 39;
            // 
            // lb_sbt1
            // 
            lb_sbt1.Anchor = AnchorStyles.Top;
            lb_sbt1.AutoSize = true;
            lb_sbt1.BackColor = Color.Transparent;
            lb_sbt1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_sbt1.ForeColor = Color.Black;
            lb_sbt1.Location = new Point(608, 30);
            lb_sbt1.Name = "lb_sbt1";
            lb_sbt1.Size = new Size(0, 18);
            lb_sbt1.TabIndex = 61;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(17, 30);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 40;
            label6.Text = "Habitación 1:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(240, 30);
            label8.Name = "label8";
            label8.Size = new Size(42, 18);
            label8.TabIndex = 45;
            label8.Text = "Tipo:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(533, 30);
            label15.Name = "label15";
            label15.Size = new Size(73, 18);
            label15.TabIndex = 59;
            label15.Text = "SubTotal:";
            // 
            // lb_Tipo1
            // 
            lb_Tipo1.Anchor = AnchorStyles.Top;
            lb_Tipo1.AutoSize = true;
            lb_Tipo1.BackColor = Color.Transparent;
            lb_Tipo1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Tipo1.ForeColor = Color.Black;
            lb_Tipo1.Location = new Point(283, 30);
            lb_Tipo1.Name = "lb_Tipo1";
            lb_Tipo1.Size = new Size(0, 18);
            lb_Tipo1.TabIndex = 46;
            // 
            // lb_Habi2
            // 
            lb_Habi2.Anchor = AnchorStyles.Top;
            lb_Habi2.AutoSize = true;
            lb_Habi2.BackColor = Color.Transparent;
            lb_Habi2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Habi2.ForeColor = Color.Black;
            lb_Habi2.Location = new Point(125, 60);
            lb_Habi2.Name = "lb_Habi2";
            lb_Habi2.Size = new Size(0, 18);
            lb_Habi2.TabIndex = 49;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(17, 60);
            label13.Name = "label13";
            label13.Size = new Size(105, 18);
            label13.TabIndex = 50;
            label13.Text = "Habitación 2:";
            // 
            // lb_pre2
            // 
            lb_pre2.Anchor = AnchorStyles.Top;
            lb_pre2.AutoSize = true;
            lb_pre2.BackColor = Color.Transparent;
            lb_pre2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pre2.ForeColor = Color.Black;
            lb_pre2.Location = new Point(440, 60);
            lb_pre2.Name = "lb_pre2";
            lb_pre2.Size = new Size(0, 18);
            lb_pre2.TabIndex = 56;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(240, 60);
            label12.Name = "label12";
            label12.Size = new Size(42, 18);
            label12.TabIndex = 51;
            label12.Text = "Tipo:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(380, 60);
            label14.Name = "label14";
            label14.Size = new Size(59, 18);
            label14.TabIndex = 55;
            label14.Text = "Precio:";
            // 
            // lb_Tipo2
            // 
            lb_Tipo2.Anchor = AnchorStyles.Top;
            lb_Tipo2.AutoSize = true;
            lb_Tipo2.BackColor = Color.Transparent;
            lb_Tipo2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Tipo2.ForeColor = Color.Black;
            lb_Tipo2.Location = new Point(283, 60);
            lb_Tipo2.Name = "lb_Tipo2";
            lb_Tipo2.Size = new Size(0, 18);
            lb_Tipo2.TabIndex = 52;
            // 
            // lb_pre1
            // 
            lb_pre1.Anchor = AnchorStyles.Top;
            lb_pre1.AutoSize = true;
            lb_pre1.BackColor = Color.Transparent;
            lb_pre1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_pre1.ForeColor = Color.Black;
            lb_pre1.Location = new Point(440, 30);
            lb_pre1.Name = "lb_pre1";
            lb_pre1.Size = new Size(0, 18);
            lb_pre1.TabIndex = 54;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(380, 30);
            label16.Name = "label16";
            label16.Size = new Size(59, 18);
            label16.TabIndex = 53;
            label16.Text = "Precio:";
            // 
            // label37
            // 
            label37.Anchor = AnchorStyles.Top;
            label37.AutoSize = true;
            label37.BackColor = Color.Transparent;
            label37.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(466, 473);
            label37.Name = "label37";
            label37.Size = new Size(73, 18);
            label37.TabIndex = 117;
            label37.Text = "SubTotal:";
            // 
            // label35
            // 
            label35.Anchor = AnchorStyles.Top;
            label35.AutoSize = true;
            label35.BackColor = Color.Transparent;
            label35.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(78, 473);
            label35.Name = "label35";
            label35.Size = new Size(35, 18);
            label35.TabIndex = 113;
            label35.Text = "ISV:";
            // 
            // lb_isv
            // 
            lb_isv.Anchor = AnchorStyles.Top;
            lb_isv.AutoSize = true;
            lb_isv.BackColor = Color.Transparent;
            lb_isv.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_isv.ForeColor = Color.Black;
            lb_isv.Location = new Point(111, 473);
            lb_isv.Name = "lb_isv";
            lb_isv.Size = new Size(0, 18);
            lb_isv.TabIndex = 114;
            // 
            // label36
            // 
            label36.Anchor = AnchorStyles.Top;
            label36.AutoSize = true;
            label36.BackColor = Color.Transparent;
            label36.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(224, 473);
            label36.Name = "label36";
            label36.Size = new Size(116, 18);
            label36.TabIndex = 115;
            label36.Text = "Impto. Turismo:";
            // 
            // lb_Total
            // 
            lb_Total.Anchor = AnchorStyles.Top;
            lb_Total.AutoSize = true;
            lb_Total.BackColor = Color.Transparent;
            lb_Total.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Total.ForeColor = Color.Black;
            lb_Total.Location = new Point(703, 473);
            lb_Total.Name = "lb_Total";
            lb_Total.Size = new Size(0, 18);
            lb_Total.TabIndex = 120;
            // 
            // lb_it
            // 
            lb_it.Anchor = AnchorStyles.Top;
            lb_it.AutoSize = true;
            lb_it.BackColor = Color.Transparent;
            lb_it.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_it.ForeColor = Color.Black;
            lb_it.Location = new Point(346, 473);
            lb_it.Name = "lb_it";
            lb_it.Size = new Size(0, 18);
            lb_it.TabIndex = 116;
            // 
            // label38
            // 
            label38.Anchor = AnchorStyles.Top;
            label38.AutoSize = true;
            label38.BackColor = Color.Transparent;
            label38.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(654, 473);
            label38.Name = "label38";
            label38.Size = new Size(46, 18);
            label38.TabIndex = 119;
            label38.Text = "Total:";
            // 
            // lb_Stotal
            // 
            lb_Stotal.Anchor = AnchorStyles.Top;
            lb_Stotal.AutoSize = true;
            lb_Stotal.BackColor = Color.Transparent;
            lb_Stotal.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Stotal.ForeColor = Color.Black;
            lb_Stotal.Location = new Point(545, 473);
            lb_Stotal.Name = "lb_Stotal";
            lb_Stotal.Size = new Size(0, 18);
            lb_Stotal.TabIndex = 118;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupinfo.ResumeLayout(false);
            pl_scroll.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label11;
        public TextBox txtDescripcion;
        public ComboBox cmbEstado;
        private Panel panel1;
        private Button btnCerrar;
        private Label label6;
        private Label lb_Habi1;
        private Label lb_Tipo1;
        private Label label8;
        private PictureBox pictureBox5;
        private Label lb_Tipo2;
        private Label label12;
        private Label label13;
        private Label lb_Habi2;
        private Label lb_pre2;
        private Label label14;
        private Label lb_pre1;
        private Label label16;
        private Label lb_sbt2;
        private Label lb_sbt1;
        private Label label17;
        private Label label15;
        private GroupBox groupBox1;
        private Label label18;
        private Label lb_sbt3;
        private Label lb_Habi3;
        private Label label21;
        private Label lb_pre3;
        private Label label23;
        private Label label24;
        private Label lb_Tipo3;
        private GroupBox groupinfo;
        private Panel pl_scroll;
        private GroupBox groupBox2;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label19;
        private Label label20;
        private Label label22;
        private Label lb_Ser1;
        private Label lb_Ser2;
        private Label lb_St1;
        private Label lb_Pr1;
        private Label lb_Ca1;
        private Label lb_Ca2;
        private Label lb_Pr2;
        private Label lb_St2;
        private Label lb_Pr3;
        private Label lb_Ca3;
        private Label lb_Ser3;
        private Label lb_St3;
        private Label lb_StH;
        private Label label;
        private Label lb_StS;
        private Label label34;
        private Button btnCancelar;
        private Button btnFacturar;
        private GroupBox groupBox3;
        private Label lb_Total;
        private Label label38;
        private Label lb_Stotal;
        private Label label37;
        private Label lb_it;
        private Label label36;
        private Label lb_isv;
        private Label label35;
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
        private Label lb_nombres;
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
    }
}