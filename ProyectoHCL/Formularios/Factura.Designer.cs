namespace ProyectoHCL.Formularios
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            panel1 = new Panel();
            label11 = new Label();
            btnCerrar = new Button();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            txtOC = new TextBox();
            label12 = new Label();
            txtConstEx = new TextBox();
            txtSar = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            lblNoches = new Label();
            lblSalida = new Label();
            lblIngreso = new Label();
            lblFecha = new Label();
            lblHuesp = new Label();
            lblHab = new Label();
            lblId = new Label();
            lblNombre = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            cmbPago = new ComboBox();
            label13 = new Label();
            btnDescuento = new Button();
            btnServicio = new Button();
            panel5 = new Panel();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            lblTImp = new Label();
            lblTur = new Label();
            lblSV = new Label();
            lblSubtD = new Label();
            lblDesc = new Label();
            lblSubt = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel6 = new Panel();
            btnCancelar = new Button();
            btnFacturar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 60);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(338, 15);
            label11.Name = "label11";
            label11.Size = new Size(210, 30);
            label11.TabIndex = 33;
            label11.Text = "Información Factura";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(861, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 32;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 149);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtOC);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtConstEx);
            groupBox3.Controls.Add(txtSar);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(538, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 130);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // txtOC
            // 
            txtOC.Location = new Point(105, 97);
            txtOC.Name = "txtOC";
            txtOC.Size = new Size(207, 23);
            txtOC.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 99);
            label12.Name = "label12";
            label12.Size = new Size(87, 16);
            label12.TabIndex = 8;
            label12.Text = "OC Excenta:";
            // 
            // txtConstEx
            // 
            txtConstEx.Location = new Point(105, 20);
            txtConstEx.Name = "txtConstEx";
            txtConstEx.Size = new Size(207, 23);
            txtConstEx.TabIndex = 9;
            // 
            // txtSar
            // 
            txtSar.Location = new Point(116, 65);
            txtSar.Name = "txtSar";
            txtSar.Size = new Size(196, 23);
            txtSar.TabIndex = 10;
            // 
            // label9
            // 
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 20);
            label9.Name = "label9";
            label9.Size = new Size(87, 42);
            label9.TabIndex = 6;
            label9.Text = "Constancia Exonerado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 67);
            label10.Name = "label10";
            label10.Size = new Size(98, 16);
            label10.TabIndex = 7;
            label10.Text = "Resgistro SAR:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNoches);
            groupBox1.Controls.Add(lblSalida);
            groupBox1.Controls.Add(lblIngreso);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblHuesp);
            groupBox1.Controls.Add(lblHab);
            groupBox1.Controls.Add(lblId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(391, 100);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(44, 15);
            lblNoches.TabIndex = 15;
            lblNoches.Text = "label28";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(373, 73);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(44, 15);
            lblSalida.TabIndex = 14;
            lblSalida.Text = "label27";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(379, 45);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(44, 15);
            lblIngreso.TabIndex = 13;
            lblIngreso.Text = "label26";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(370, 20);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "label25";
            // 
            // lblHuesp
            // 
            lblHuesp.AutoSize = true;
            lblHuesp.Location = new Point(106, 100);
            lblHuesp.Name = "lblHuesp";
            lblHuesp.Size = new Size(44, 15);
            lblHuesp.TabIndex = 11;
            lblHuesp.Text = "label24";
            // 
            // lblHab
            // 
            lblHab.AutoSize = true;
            lblHab.Location = new Point(95, 73);
            lblHab.Name = "lblHab";
            lblHab.Size = new Size(44, 15);
            lblHab.TabIndex = 10;
            lblHab.Text = "label23";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(113, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(44, 15);
            lblId.TabIndex = 9;
            lblId.Text = "label22";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(23, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "lba";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(314, 99);
            label8.Name = "label8";
            label8.Size = new Size(71, 16);
            label8.TabIndex = 7;
            label8.Text = "# Noches:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(314, 72);
            label7.Name = "label7";
            label7.Size = new Size(53, 16);
            label7.TabIndex = 6;
            label7.Text = "Salida:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(314, 45);
            label6.Name = "label6";
            label6.Size = new Size(59, 16);
            label6.TabIndex = 5;
            label6.Text = "Ingreso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(314, 19);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 4;
            label5.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(94, 16);
            label4.TabIndex = 3;
            label4.Text = "# Huéspedes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 16);
            label3.TabIndex = 2;
            label3.Text = "Habitación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 45);
            label2.Name = "label2";
            label2.Size = new Size(101, 16);
            label2.TabIndex = 1;
            label2.Text = "Identificación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(listView1);
            panel3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 264);
            panel3.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(26, 16);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(464, 229);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cant.";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descripción";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "P. Unitario";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Importe";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 100;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cmbPago);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(btnDescuento);
            panel4.Controls.Add(btnServicio);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(887, 52);
            panel4.TabIndex = 3;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(658, 16);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(198, 23);
            cmbPago.TabIndex = 88;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(531, 18);
            label13.Name = "label13";
            label13.Size = new Size(120, 16);
            label13.TabIndex = 12;
            label13.Text = "Método de pago:";
            // 
            // btnDescuento
            // 
            btnDescuento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDescuento.BackColor = Color.BurlyWood;
            btnDescuento.BackgroundImageLayout = ImageLayout.Stretch;
            btnDescuento.FlatAppearance.BorderSize = 0;
            btnDescuento.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnDescuento.FlatStyle = FlatStyle.Flat;
            btnDescuento.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDescuento.ForeColor = SystemColors.ActiveCaptionText;
            btnDescuento.Image = (Image)resources.GetObject("btnDescuento.Image");
            btnDescuento.ImageAlign = ContentAlignment.MiddleLeft;
            btnDescuento.Location = new Point(263, 9);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(129, 32);
            btnDescuento.TabIndex = 87;
            btnDescuento.Text = "Descuentos";
            btnDescuento.TextAlign = ContentAlignment.MiddleRight;
            btnDescuento.UseVisualStyleBackColor = false;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // btnServicio
            // 
            btnServicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServicio.BackColor = Color.LightSteelBlue;
            btnServicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnServicio.FlatAppearance.BorderSize = 0;
            btnServicio.FlatAppearance.MouseOverBackColor = Color.LightSlateGray;
            btnServicio.FlatStyle = FlatStyle.Flat;
            btnServicio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnServicio.ForeColor = SystemColors.ActiveCaptionText;
            btnServicio.Image = (Image)resources.GetObject("btnServicio.Image");
            btnServicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnServicio.Location = new Point(123, 9);
            btnServicio.Name = "btnServicio";
            btnServicio.Size = new Size(111, 32);
            btnServicio.TabIndex = 86;
            btnServicio.Text = "Servicios";
            btnServicio.TextAlign = ContentAlignment.MiddleRight;
            btnServicio.UseVisualStyleBackColor = false;
            btnServicio.Click += btnServicio_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(groupBox2);
            panel5.Location = new Point(514, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(373, 264);
            panel5.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblTImp);
            groupBox2.Controls.Add(lblTur);
            groupBox2.Controls.Add(lblSV);
            groupBox2.Controls.Add(lblSubtD);
            groupBox2.Controls.Add(lblDesc);
            groupBox2.Controls.Add(lblSubt);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(24, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 236);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(245, 189);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "label35";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTImp
            // 
            lblTImp.AutoSize = true;
            lblTImp.Location = new Point(245, 161);
            lblTImp.Name = "lblTImp";
            lblTImp.Size = new Size(44, 15);
            lblTImp.TabIndex = 21;
            lblTImp.Text = "label34";
            lblTImp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(245, 135);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(44, 15);
            lblTur.TabIndex = 20;
            lblTur.Text = "label33";
            lblTur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSV
            // 
            lblSV.AutoSize = true;
            lblSV.Location = new Point(245, 109);
            lblSV.Name = "lblSV";
            lblSV.Size = new Size(44, 15);
            lblSV.TabIndex = 19;
            lblSV.Text = "label32";
            lblSV.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtD
            // 
            lblSubtD.AutoSize = true;
            lblSubtD.Location = new Point(245, 83);
            lblSubtD.Name = "lblSubtD";
            lblSubtD.Size = new Size(44, 15);
            lblSubtD.TabIndex = 18;
            lblSubtD.Text = "label31";
            lblSubtD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(245, 57);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(44, 15);
            lblDesc.TabIndex = 17;
            lblDesc.Text = "label30";
            lblDesc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubt
            // 
            lblSubt.AutoSize = true;
            lblSubt.Location = new Point(245, 32);
            lblSubt.Name = "lblSubt";
            lblSubt.Size = new Size(44, 15);
            lblSubt.TabIndex = 16;
            lblSubt.Text = "label29";
            lblSubt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(108, 189);
            label20.Name = "label20";
            label20.Size = new Size(38, 16);
            label20.TabIndex = 6;
            label20.Text = "Total:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(51, 160);
            label19.Name = "label19";
            label19.Size = new Size(95, 16);
            label19.TabIndex = 5;
            label19.Text = "Total Impuesto:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(35, 134);
            label18.Name = "label18";
            label18.Size = new Size(111, 16);
            label18.TabIndex = 4;
            label18.Text = "Impuesto Turismo:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(33, 108);
            label17.Name = "label17";
            label17.Size = new Size(113, 16);
            label17.TabIndex = 3;
            label17.Text = "Impuesto S/Venta:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(13, 82);
            label16.Name = "label16";
            label16.Size = new Size(133, 16);
            label16.TabIndex = 2;
            label16.Text = "SubTotal menos desc:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(74, 56);
            label15.Name = "label15";
            label15.Size = new Size(72, 16);
            label15.TabIndex = 1;
            label15.Text = "Descuento:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(87, 31);
            label14.Name = "label14";
            label14.Size = new Size(59, 16);
            label14.TabIndex = 0;
            label14.Text = "SubTotal:";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancelar);
            panel6.Controls.Add(btnFacturar);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 525);
            panel6.Name = "panel6";
            panel6.Size = new Size(887, 79);
            panel6.TabIndex = 5;
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
            btnCancelar.Location = new Point(556, 19);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 75;
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
            btnFacturar.Location = new Point(213, 19);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(82, 32);
            btnFacturar.TabIndex = 74;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = false;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 604);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Text = "Factura";
            FormClosing += Factura_FormClosing;
            Load += Factura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCerrar;
        private Label label11;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox txtOC;
        private TextBox txtSar;
        private TextBox txtConstEx;
        private Panel panel3;
        private Panel panel4;
        public Button btnServicio;
        public Button btnDescuento;
        private ListView listView1;
        private ComboBox cmbPago;
        private Label label13;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel5;
        private GroupBox groupBox2;
        private Label label14;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label lblNoches;
        private Label lblSalida;
        private Label lblIngreso;
        private Label lblFecha;
        private Label lblHuesp;
        private Label lblHab;
        private Label lblId;
        private Label lblNombre;
        private Label lblTotal;
        private Label lblTImp;
        private Label lblTur;
        private Label lblSV;
        private Label lblSubtD;
        private Label lblDesc;
        private Label lblSubt;
        private Panel panel6;
        private Button btnFacturar;
        private Button btnCancelar;
        private GroupBox groupBox3;
    }
}