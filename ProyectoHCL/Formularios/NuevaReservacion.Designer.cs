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
            label1 = new Label();
            cb_cliente = new ComboBox();
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
            txt_id_solicitud = new TextBox();
            btn_guardar2 = new Button();
            dt_fecha_salida = new DateTimePicker();
            dt_fecha_entrada = new DateTimePicker();
            dt_fecha_coti = new DateTimePicker();
            label14 = new Label();
            cb_estado = new ComboBox();
            label13 = new Label();
            cb_numero = new ComboBox();
            label12 = new Label();
            txt_monto = new TextBox();
            label11 = new Label();
            txt_codigo = new TextBox();
            label10 = new Label();
            txt_vehiculo = new TextBox();
            label9 = new Label();
            cb_tipo = new ComboBox();
            label8 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txt_id = new TextBox();
            txt_tipo_habitacion = new TextBox();
            txt_metodo_reserva = new TextBox();
            txt_estado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 179);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 39;
            label1.Text = "Cliente";
            // 
            // cb_cliente
            // 
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(255, 171);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(241, 23);
            cb_cliente.TabIndex = 40;
            cb_cliente.SelectedIndexChanged += cb_cliente_SelectedIndexChanged_1;
            // 
            // txt_cod_cliente
            // 
            txt_cod_cliente.Location = new Point(255, 171);
            txt_cod_cliente.Name = "txt_cod_cliente";
            txt_cod_cliente.ReadOnly = true;
            txt_cod_cliente.Size = new Size(47, 23);
            txt_cod_cliente.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 264);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 43;
            label3.Text = "Metodo de reservacion";
            // 
            // cb_metodo
            // 
            cb_metodo.FormattingEnabled = true;
            cb_metodo.Location = new Point(255, 256);
            cb_metodo.Name = "cb_metodo";
            cb_metodo.Size = new Size(163, 23);
            cb_metodo.TabIndex = 44;
            cb_metodo.SelectedIndexChanged += cb_metodo_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 352);
            label4.Name = "label4";
            label4.Size = new Size(148, 17);
            label4.TabIndex = 45;
            label4.Text = "Numero de Huespedes";
            // 
            // txt_huespedes
            // 
            txt_huespedes.Location = new Point(255, 347);
            txt_huespedes.Name = "txt_huespedes";
            txt_huespedes.Size = new Size(47, 23);
            txt_huespedes.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(83, 214);
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
            label6.Location = new Point(518, 208);
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
            lbl_titulo.Size = new Size(197, 30);
            lbl_titulo.TabIndex = 19;
            lbl_titulo.Text = "Nueva reservacion";
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
            panel3.Controls.Add(btn_guardar2);
            panel3.Controls.Add(dt_fecha_salida);
            panel3.Controls.Add(dt_fecha_entrada);
            panel3.Controls.Add(dt_fecha_coti);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cb_estado);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cb_numero);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txt_monto);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txt_codigo);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txt_vehiculo);
            panel3.Controls.Add(txt_huespedes);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cb_metodo);
            panel3.Controls.Add(cb_tipo);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(cb_cliente);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_id);
            panel3.Controls.Add(txt_tipo_habitacion);
            panel3.Controls.Add(txt_metodo_reserva);
            panel3.Controls.Add(txt_estado);
            panel3.Controls.Add(txt_cod_cliente);
            panel3.Controls.Add(txt_id_solicitud);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 531);
            panel3.TabIndex = 52;
            // 
            // txt_id_solicitud
            // 
            txt_id_solicitud.Location = new Point(299, 127);
            txt_id_solicitud.Name = "txt_id_solicitud";
            txt_id_solicitud.ReadOnly = true;
            txt_id_solicitud.Size = new Size(47, 23);
            txt_id_solicitud.TabIndex = 78;
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
            btn_guardar2.Location = new Point(745, 478);
            btn_guardar2.Name = "btn_guardar2";
            btn_guardar2.Size = new Size(82, 32);
            btn_guardar2.TabIndex = 77;
            btn_guardar2.Text = "Guardar";
            btn_guardar2.UseVisualStyleBackColor = false;
            btn_guardar2.Visible = false;
            btn_guardar2.Click += btn_guardar2_Click;
            // 
            // dt_fecha_salida
            // 
            dt_fecha_salida.CustomFormat = "yyyy/MM/dd";
            dt_fecha_salida.Format = DateTimePickerFormat.Custom;
            dt_fecha_salida.Location = new Point(686, 202);
            dt_fecha_salida.Name = "dt_fecha_salida";
            dt_fecha_salida.Size = new Size(105, 23);
            dt_fecha_salida.TabIndex = 76;
            // 
            // dt_fecha_entrada
            // 
            dt_fecha_entrada.CustomFormat = "yyyy/MM/dd";
            dt_fecha_entrada.Format = DateTimePickerFormat.Custom;
            dt_fecha_entrada.Location = new Point(255, 208);
            dt_fecha_entrada.Name = "dt_fecha_entrada";
            dt_fecha_entrada.Size = new Size(128, 23);
            dt_fecha_entrada.TabIndex = 75;
            // 
            // dt_fecha_coti
            // 
            dt_fecha_coti.CustomFormat = "yyy/MM/dd";
            dt_fecha_coti.Format = DateTimePickerFormat.Custom;
            dt_fecha_coti.Location = new Point(686, 165);
            dt_fecha_coti.Name = "dt_fecha_coti";
            dt_fecha_coti.Size = new Size(105, 23);
            dt_fecha_coti.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Gainsboro;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(520, 171);
            label14.Name = "label14";
            label14.Size = new Size(130, 17);
            label14.TabIndex = 70;
            label14.Text = "Fecha de Cotizacion";
            // 
            // cb_estado
            // 
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(255, 306);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(163, 23);
            cb_estado.TabIndex = 63;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Gainsboro;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(81, 312);
            label13.Name = "label13";
            label13.Size = new Size(158, 17);
            label13.TabIndex = 62;
            label13.Text = "Estado de la reservacion";
            // 
            // cb_numero
            // 
            cb_numero.FormattingEnabled = true;
            cb_numero.Location = new Point(682, 306);
            cb_numero.Name = "cb_numero";
            cb_numero.Size = new Size(163, 23);
            cb_numero.TabIndex = 61;
            cb_numero.SelectedIndexChanged += cb_numero_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Gainsboro;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(516, 312);
            label12.Name = "label12";
            label12.Size = new Size(146, 17);
            label12.TabIndex = 60;
            label12.Text = "Numero de habitacion";
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(684, 133);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(121, 23);
            txt_monto.TabIndex = 59;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Gainsboro;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(518, 133);
            label11.Name = "label11";
            label11.Size = new Size(117, 17);
            label11.TabIndex = 58;
            label11.Text = "Monto de reserva";
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(255, 127);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(91, 23);
            txt_codigo.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Gainsboro;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(81, 133);
            label10.Name = "label10";
            label10.Size = new Size(117, 17);
            label10.TabIndex = 56;
            label10.Text = "Codigo empleado";
            // 
            // txt_vehiculo
            // 
            txt_vehiculo.Location = new Point(682, 352);
            txt_vehiculo.Name = "txt_vehiculo";
            txt_vehiculo.Size = new Size(47, 23);
            txt_vehiculo.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(516, 358);
            label9.Name = "label9";
            label9.Size = new Size(61, 17);
            label9.TabIndex = 54;
            label9.Text = "Vehiculo";
            // 
            // cb_tipo
            // 
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Location = new Point(682, 256);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(163, 23);
            cb_tipo.TabIndex = 53;
            cb_tipo.SelectedIndexChanged += cb_tipo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gainsboro;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(516, 264);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 49;
            label8.Text = "Tipo de habitacion";
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
            btnCancelar.Location = new Point(833, 478);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
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
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(745, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(798, 306);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(47, 23);
            txt_id.TabIndex = 73;
            // 
            // txt_tipo_habitacion
            // 
            txt_tipo_habitacion.Location = new Point(797, 256);
            txt_tipo_habitacion.Name = "txt_tipo_habitacion";
            txt_tipo_habitacion.ReadOnly = true;
            txt_tipo_habitacion.Size = new Size(47, 23);
            txt_tipo_habitacion.TabIndex = 67;
            // 
            // txt_metodo_reserva
            // 
            txt_metodo_reserva.Location = new Point(371, 256);
            txt_metodo_reserva.Name = "txt_metodo_reserva";
            txt_metodo_reserva.ReadOnly = true;
            txt_metodo_reserva.Size = new Size(47, 23);
            txt_metodo_reserva.TabIndex = 66;
            // 
            // txt_estado
            // 
            txt_estado.Location = new Point(371, 306);
            txt_estado.Name = "txt_estado";
            txt_estado.ReadOnly = true;
            txt_estado.Size = new Size(47, 23);
            txt_estado.TabIndex = 65;
            // 
            // NuevaReservacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 531);
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnExit;
        private Label label1;
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
        public ComboBox cb_cliente;
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
    }
}