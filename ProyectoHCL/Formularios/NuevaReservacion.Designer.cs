namespace ProyectoHCL
{
    partial class NuevaReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaReservacion));
            btnExit = new PictureBox();
            txt_cod_cliente = new TextBox();
            label3 = new Label();
            cb_metodo = new ComboBox();
            label4 = new Label();
            txt_huespedes = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            lbl_titulo = new Label();
            btnCerrar = new Button();
            btnMin = new Button();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            lbl_correonum = new Label();
            lbl_correo = new Label();
            lbl_telefononum = new Label();
            lbl_telefono = new Label();
            lbl_cliente = new Label();
            button1 = new Button();
            lbl_1c = new Label();
            btn_guardar2 = new Button();
            dt_fecha_coti = new DateTimePicker();
            label14 = new Label();
            txt_codigo = new TextBox();
            label10 = new Label();
            txt_id_solicitud = new TextBox();
            groupBox1 = new GroupBox();
            txt_motivo = new TextBox();
            label1 = new Label();
            lbl_noches = new Label();
            label2 = new Label();
            cb_estado = new ComboBox();
            label11 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label13 = new Label();
            txt_monto = new TextBox();
            dt_fecha_entrada = new DateTimePicker();
            dt_fecha_salida = new DateTimePicker();
            radioButton2 = new RadioButton();
            txt_habi_vieja = new TextBox();
            radioButton1 = new RadioButton();
            label8 = new Label();
            cb_tipo = new ComboBox();
            txt_id = new TextBox();
            txt_tipo_habitacion = new TextBox();
            txt_vehiculo = new TextBox();
            label12 = new Label();
            cb_numero = new ComboBox();
            label9 = new Label();
            txt_metodo_reserva = new TextBox();
            txt_estado = new TextBox();
            txt_capacidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(920, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            // 
            // txt_cod_cliente
            // 
            txt_cod_cliente.Location = new Point(653, 28);
            txt_cod_cliente.Name = "txt_cod_cliente";
            txt_cod_cliente.ReadOnly = true;
            txt_cod_cliente.Size = new Size(47, 25);
            txt_cod_cliente.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(486, 33);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 43;
            label3.Text = "Metodo de reservacion";
            label3.Click += label3_Click;
            // 
            // cb_metodo
            // 
            cb_metodo.FormattingEnabled = true;
            cb_metodo.Items.AddRange(new object[] { "Booking", "Whatsapp", "Airbnb", "Presencial o llamada celular" });
            cb_metodo.Location = new Point(653, 28);
            cb_metodo.Name = "cb_metodo";
            cb_metodo.Size = new Size(163, 25);
            cb_metodo.TabIndex = 44;
            cb_metodo.SelectedIndexChanged += cb_metodo_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(486, 133);
            label4.Name = "label4";
            label4.Size = new Size(146, 17);
            label4.TabIndex = 45;
            label4.Text = "Numero de huespedes";
            // 
            // txt_huespedes
            // 
            txt_huespedes.Location = new Point(652, 129);
            txt_huespedes.Name = "txt_huespedes";
            txt_huespedes.Size = new Size(47, 25);
            txt_huespedes.TabIndex = 46;
            txt_huespedes.TextChanged += txt_huespedes_TextChanged;
            txt_huespedes.KeyPress += txt_huespedes_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 79);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 47;
            label5.Text = "Fecha de entrada ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 127);
            label6.Name = "label6";
            label6.Size = new Size(102, 17);
            label6.TabIndex = 48;
            label6.Text = "Fecha de salida";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lbl_titulo);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnMin);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 73);
            panel2.TabIndex = 51;
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
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.Location = new Point(134, 19);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(202, 30);
            lbl_titulo.TabIndex = 19;
            lbl_titulo.Text = "Nueva Reservacion";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(923, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(894, 8);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(19, 20);
            btnMin.TabIndex = 32;
            btnMin.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(btn_guardar2);
            panel3.Controls.Add(dt_fecha_coti);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txt_codigo);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txt_id_solicitud);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 576);
            panel3.TabIndex = 52;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_correonum);
            groupBox2.Controls.Add(lbl_correo);
            groupBox2.Controls.Add(lbl_telefononum);
            groupBox2.Controls.Add(lbl_telefono);
            groupBox2.Controls.Add(lbl_cliente);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(lbl_1c);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(53, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(877, 97);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos cliente";
            // 
            // lbl_correonum
            // 
            lbl_correonum.AutoSize = true;
            lbl_correonum.BackColor = Color.Gainsboro;
            lbl_correonum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_correonum.Location = new Point(151, 62);
            lbl_correonum.Name = "lbl_correonum";
            lbl_correonum.Size = new Size(13, 17);
            lbl_correonum.TabIndex = 90;
            lbl_correonum.Text = "-";
            lbl_correonum.Visible = false;
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.BackColor = Color.Gainsboro;
            lbl_correo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_correo.Location = new Point(81, 62);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(57, 17);
            lbl_correo.TabIndex = 89;
            lbl_correo.Text = "Correo :";
            lbl_correo.Visible = false;
            // 
            // lbl_telefononum
            // 
            lbl_telefononum.AutoSize = true;
            lbl_telefononum.BackColor = Color.Gainsboro;
            lbl_telefononum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefononum.Location = new Point(569, 62);
            lbl_telefononum.Name = "lbl_telefononum";
            lbl_telefononum.Size = new Size(13, 17);
            lbl_telefononum.TabIndex = 88;
            lbl_telefononum.Text = "-";
            lbl_telefononum.Visible = false;
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.BackColor = Color.Gainsboro;
            lbl_telefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(486, 62);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(76, 17);
            lbl_telefono.TabIndex = 87;
            lbl_telefono.Text = "Telefonos :";
            lbl_telefono.Visible = false;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.BackColor = Color.Gainsboro;
            lbl_cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cliente.Location = new Point(151, 31);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(13, 17);
            lbl_cliente.TabIndex = 83;
            lbl_cliente.Text = "-";
            lbl_cliente.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 24);
            button1.Name = "button1";
            button1.Size = new Size(36, 28);
            button1.TabIndex = 86;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_1c
            // 
            lbl_1c.AutoSize = true;
            lbl_1c.BackColor = Color.Gainsboro;
            lbl_1c.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_1c.Location = new Point(81, 31);
            lbl_1c.Name = "lbl_1c";
            lbl_1c.Size = new Size(59, 17);
            lbl_1c.TabIndex = 82;
            lbl_1c.Text = "Cliente :";
            lbl_1c.Visible = false;
            // 
            // btn_guardar2
            // 
            btn_guardar2.Anchor = AnchorStyles.Top;
            btn_guardar2.BackColor = Color.Green;
            btn_guardar2.FlatAppearance.BorderSize = 0;
            btn_guardar2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btn_guardar2.FlatStyle = FlatStyle.Flat;
            btn_guardar2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar2.ForeColor = Color.White;
            btn_guardar2.Location = new Point(745, 505);
            btn_guardar2.Name = "btn_guardar2";
            btn_guardar2.Size = new Size(82, 32);
            btn_guardar2.TabIndex = 77;
            btn_guardar2.Text = "Guardar";
            btn_guardar2.UseVisualStyleBackColor = false;
            btn_guardar2.Visible = false;
            btn_guardar2.Click += btn_guardar2_Click;
            // 
            // dt_fecha_coti
            // 
            dt_fecha_coti.CustomFormat = "yyy/MM/dd";
            dt_fecha_coti.Enabled = false;
            dt_fecha_coti.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dt_fecha_coti.Location = new Point(709, 88);
            dt_fecha_coti.Name = "dt_fecha_coti";
            dt_fecha_coti.Size = new Size(227, 24);
            dt_fecha_coti.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(648, 92);
            label14.Name = "label14";
            label14.Size = new Size(47, 17);
            label14.TabIndex = 70;
            label14.Text = "Fecha ";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(176, 86);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.ReadOnly = true;
            txt_codigo.Size = new Size(47, 23);
            txt_codigo.TabIndex = 57;
            txt_codigo.TextChanged += txt_codigo_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(53, 92);
            label10.Name = "label10";
            label10.Size = new Size(117, 17);
            label10.TabIndex = 56;
            label10.Text = "Codigo empleado";
            // 
            // txt_id_solicitud
            // 
            txt_id_solicitud.Location = new Point(176, 86);
            txt_id_solicitud.Name = "txt_id_solicitud";
            txt_id_solicitud.ReadOnly = true;
            txt_id_solicitud.Size = new Size(47, 23);
            txt_id_solicitud.TabIndex = 78;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txt_motivo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_noches);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cb_estado);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_huespedes);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_monto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cb_metodo);
            groupBox1.Controls.Add(dt_fecha_entrada);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dt_fecha_salida);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(txt_habi_vieja);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cb_tipo);
            groupBox1.Controls.Add(txt_id);
            groupBox1.Controls.Add(txt_tipo_habitacion);
            groupBox1.Controls.Add(txt_vehiculo);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cb_numero);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_metodo_reserva);
            groupBox1.Controls.Add(txt_cod_cliente);
            groupBox1.Controls.Add(txt_estado);
            groupBox1.Controls.Add(txt_capacidad);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ImeMode = ImeMode.NoControl;
            groupBox1.Location = new Point(53, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 323);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de reserva";
            // 
            // txt_motivo
            // 
            txt_motivo.CharacterCasing = CharacterCasing.Upper;
            txt_motivo.Location = new Point(652, 179);
            txt_motivo.Name = "txt_motivo";
            txt_motivo.Size = new Size(219, 25);
            txt_motivo.TabIndex = 94;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(486, 182);
            label1.Name = "label1";
            label1.Size = new Size(135, 17);
            label1.TabIndex = 93;
            label1.Text = "Motivo de la reserva";
            // 
            // lbl_noches
            // 
            lbl_noches.AutoSize = true;
            lbl_noches.BackColor = Color.Gainsboro;
            lbl_noches.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_noches.Location = new Point(159, 169);
            lbl_noches.Name = "lbl_noches";
            lbl_noches.Size = new Size(21, 30);
            lbl_noches.TabIndex = 91;
            lbl_noches.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 179);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 90;
            label2.Text = "Numero de noches";
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Items.AddRange(new object[] { "RESERVADO", "CONFIRMADO", "ANULADO", "FACTURADA" });
            cb_estado.Location = new Point(652, 77);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(163, 25);
            cb_estado.TabIndex = 63;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(7, 31);
            label11.Name = "label11";
            label11.Size = new Size(117, 17);
            label11.TabIndex = 58;
            label11.Text = "Monto de reserva";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(692, 277);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(780, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(486, 81);
            label13.Name = "label13";
            label13.Size = new Size(158, 17);
            label13.TabIndex = 62;
            label13.Text = "Estado de la reservacion";
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(161, 30);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(121, 25);
            txt_monto.TabIndex = 59;
            txt_monto.TextAlign = HorizontalAlignment.Right;
            txt_monto.TextChanged += txt_monto_TextChanged;
            txt_monto.KeyPress += txt_monto_KeyPress;
            // 
            // dt_fecha_entrada
            // 
            dt_fecha_entrada.CustomFormat = "yyyy/MM/dd";
            dt_fecha_entrada.Format = DateTimePickerFormat.Custom;
            dt_fecha_entrada.Location = new Point(161, 79);
            dt_fecha_entrada.Name = "dt_fecha_entrada";
            dt_fecha_entrada.Size = new Size(128, 25);
            dt_fecha_entrada.TabIndex = 75;
            dt_fecha_entrada.ValueChanged += dt_fecha_entrada_ValueChanged;
            // 
            // dt_fecha_salida
            // 
            dt_fecha_salida.CustomFormat = "yyyy/MM/dd";
            dt_fecha_salida.Format = DateTimePickerFormat.Custom;
            dt_fecha_salida.Location = new Point(161, 127);
            dt_fecha_salida.Name = "dt_fecha_salida";
            dt_fecha_salida.Size = new Size(128, 25);
            dt_fecha_salida.TabIndex = 76;
            dt_fecha_salida.ValueChanged += dt_fecha_salida_ValueChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gainsboro;
            radioButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(639, 239);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 21);
            radioButton2.TabIndex = 81;
            radioButton2.TabStop = true;
            radioButton2.Text = "NO";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // txt_habi_vieja
            // 
            txt_habi_vieja.Location = new Point(161, 127);
            txt_habi_vieja.Name = "txt_habi_vieja";
            txt_habi_vieja.Size = new Size(91, 25);
            txt_habi_vieja.TabIndex = 79;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Gainsboro;
            radioButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(640, 218);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 21);
            radioButton1.TabIndex = 80;
            radioButton1.TabStop = true;
            radioButton1.Text = "SI";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 223);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 49;
            label8.Text = "Tipo de habitacion";
            // 
            // cb_tipo
            // 
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Location = new Point(161, 222);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(163, 25);
            cb_tipo.TabIndex = 53;
            cb_tipo.SelectedIndexChanged += cb_tipo_SelectedIndexChanged;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(161, 222);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(47, 25);
            txt_id.TabIndex = 73;
            // 
            // txt_tipo_habitacion
            // 
            txt_tipo_habitacion.Location = new Point(242, 222);
            txt_tipo_habitacion.Name = "txt_tipo_habitacion";
            txt_tipo_habitacion.ReadOnly = true;
            txt_tipo_habitacion.Size = new Size(47, 25);
            txt_tipo_habitacion.TabIndex = 67;
            // 
            // txt_vehiculo
            // 
            txt_vehiculo.Location = new Point(640, 233);
            txt_vehiculo.Name = "txt_vehiculo";
            txt_vehiculo.Size = new Size(30, 25);
            txt_vehiculo.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(7, 274);
            label12.Name = "label12";
            label12.Size = new Size(146, 17);
            label12.TabIndex = 60;
            label12.Text = "Numero de habitacion";
            // 
            // cb_numero
            // 
            cb_numero.FormattingEnabled = true;
            cb_numero.Location = new Point(161, 268);
            cb_numero.Name = "cb_numero";
            cb_numero.Size = new Size(163, 25);
            cb_numero.TabIndex = 61;
            cb_numero.SelectedIndexChanged += cb_numero_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(486, 222);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 54;
            label9.Text = "Vehiculo";
            // 
            // txt_metodo_reserva
            // 
            txt_metodo_reserva.Location = new Point(722, 28);
            txt_metodo_reserva.Name = "txt_metodo_reserva";
            txt_metodo_reserva.ReadOnly = true;
            txt_metodo_reserva.Size = new Size(47, 25);
            txt_metodo_reserva.TabIndex = 66;
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(653, 77);
            txt_estado.Name = "txt_estado";
            txt_estado.ReadOnly = true;
            txt_estado.Size = new Size(47, 25);
            txt_estado.TabIndex = 65;
            // 
            // txt_capacidad
            // 
            txt_capacidad.Location = new Point(235, 222);
            txt_capacidad.Name = "txt_capacidad";
            txt_capacidad.Size = new Size(47, 25);
            txt_capacidad.TabIndex = 92;
            // 
            // NuevaReservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 576);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevaReservacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaReservacion";
            Load += NuevaReservacion_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnExit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Button btnCerrar;
        private Button btnMin;
        public Panel panel3;
        public Button btnCancelar;
        public Button btnGuardar;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private DateTimePicker dt_fecha_salida;
        public Label lbl_titulo;
        public TextBox txt_cod_cliente;
        public ComboBox cb_metodo;
        public TextBox txt_huespedes;
        public TextBox txt_vehiculo;
        public ComboBox cb_tipo;
        public TextBox txt_monto;
        public TextBox txt_codigo;
        public ComboBox cb_numero;
        public ComboBox cb_estado;
        public TextBox txt_estado;
        public TextBox txt_metodo_reserva;
        public TextBox txt_id;
        public TextBox txt_tipo_habitacion;
        public DateTimePicker dt_fecha_entrada;
        public DateTimePicker dt_fecha_coti;
        public Button btn_guardar2;
        public TextBox txt_id_solicitud;
        public TextBox txt_habi_vieja;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        public Label lbl_cliente;
        public Label lbl_1c;
        public Button button1;
        private GroupBox groupBox1;
        public Label lbl_noches;
        private Label label2;
        private GroupBox groupBox2;
        public Label lbl_telefononum;
        public Label lbl_telefono;
        public Label lbl_correonum;
        public Label lbl_correo;
        public TextBox txt_capacidad;
        public TextBox txt_motivo;
        private Label label1;
    }
}