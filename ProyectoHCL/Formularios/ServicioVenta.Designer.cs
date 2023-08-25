namespace ProyectoHCL.Formularios
{
    partial class ServicioVenta
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicioVenta));
            panelPrincipal = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnEliminar = new Button();
            btnVenta = new Button();
            txtTotal = new TextBox();
            label9 = new Label();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            cmbEstado = new ComboBox();
            label8 = new Label();
            label10 = new Label();
            cmbServicio = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            btnReservacion = new Button();
            label5 = new Label();
            txtSalida = new TextBox();
            txtEntrada = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCliente = new TextBox();
            txtHab = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            errorT = new ErrorProvider(components);
            panelPrincipal.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.ActiveCaption;
            panelPrincipal.Controls.Add(panel3);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1084, 561);
            panelPrincipal.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 490);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnVenta);
            panel5.Controls.Add(txtTotal);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(listView);
            panel5.Location = new Point(0, 276);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 216);
            panel5.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.Red;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(721, 32);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(38, 32);
            btnEliminar.TabIndex = 88;
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVenta
            // 
            btnVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVenta.BackColor = Color.CadetBlue;
            btnVenta.BackgroundImageLayout = ImageLayout.Stretch;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = Color.Black;
            btnVenta.Image = (Image)resources.GetObject("btnVenta.Image");
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(909, 84);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(92, 32);
            btnVenta.TabIndex = 86;
            btnVenta.Text = "Guardar";
            btnVenta.TextAlign = ContentAlignment.MiddleRight;
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ButtonHighlight;
            txtTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(867, 33);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(169, 25);
            txtTotal.TabIndex = 83;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(816, 35);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 18);
            label9.TabIndex = 82;
            label9.Text = "Total:";
            // 
            // listView
            // 
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(30, 32);
            listView.Name = "listView";
            listView.Size = new Size(671, 153);
            listView.TabIndex = 0;
            listView.TileSize = new Size(228, 36);
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Servicio";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Precio";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SubTotal";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado";
            columnHeader4.Width = 120;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(txtPrecio);
            panel4.Controls.Add(cmbEstado);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(cmbServicio);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(1084, 121);
            panel4.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.CadetBlue;
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(909, 64);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 32);
            btnAgregar.TabIndex = 85;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ButtonHighlight;
            txtPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(379, 71);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(184, 25);
            txtPrecio.TabIndex = 82;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Pagado", "Pendiente" });
            cmbEstado.Location = new Point(614, 71);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(232, 25);
            cmbEstado.TabIndex = 87;
            cmbEstado.Leave += cmbEstado_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(379, 50);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 18);
            label8.TabIndex = 84;
            label8.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(614, 50);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 18);
            label10.TabIndex = 86;
            label10.Text = "Estado:";
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(30, 71);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(292, 25);
            cmbServicio.TabIndex = 83;
            cmbServicio.SelectedIndexChanged += cmbServicio_SelectedIndexChanged;
            cmbServicio.Leave += cmbServicio_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(30, 50);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 18);
            label7.TabIndex = 82;
            label7.Text = "Servicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(30, 22);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 18);
            label6.TabIndex = 82;
            label6.Text = "Detalle venta:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReservacion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSalida);
            panel2.Controls.Add(txtEntrada);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCliente);
            panel2.Controls.Add(txtHab);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 157);
            panel2.TabIndex = 0;
            // 
            // btnReservacion
            // 
            btnReservacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReservacion.BackColor = Color.CadetBlue;
            btnReservacion.BackgroundImageLayout = ImageLayout.Stretch;
            btnReservacion.FlatAppearance.BorderSize = 0;
            btnReservacion.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnReservacion.FlatStyle = FlatStyle.Flat;
            btnReservacion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservacion.ForeColor = Color.Black;
            btnReservacion.Image = (Image)resources.GetObject("btnReservacion.Image");
            btnReservacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservacion.Location = new Point(909, 46);
            btnReservacion.Name = "btnReservacion";
            btnReservacion.Size = new Size(92, 32);
            btnReservacion.TabIndex = 89;
            btnReservacion.Text = "Buscar";
            btnReservacion.TextAlign = ContentAlignment.MiddleRight;
            btnReservacion.UseVisualStyleBackColor = false;
            btnReservacion.Click += btnReservacion_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(30, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 18);
            label5.TabIndex = 81;
            label5.Text = "Datos reservación:";
            // 
            // txtSalida
            // 
            txtSalida.BackColor = SystemColors.ButtonHighlight;
            txtSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalida.Location = new Point(568, 100);
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.Size = new Size(278, 25);
            txtSalida.TabIndex = 80;
            // 
            // txtEntrada
            // 
            txtEntrada.BackColor = SystemColors.ButtonHighlight;
            txtEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEntrada.Location = new Point(568, 51);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ReadOnly = true;
            txtEntrada.Size = new Size(278, 25);
            txtEntrada.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(443, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 79;
            label3.Text = "Fecha salida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(443, 53);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 18);
            label4.TabIndex = 78;
            label4.Text = "Fecha entrada:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = SystemColors.ButtonHighlight;
            txtCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(127, 98);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(278, 25);
            txtCliente.TabIndex = 76;
            // 
            // txtHab
            // 
            txtHab.BackColor = SystemColors.ButtonHighlight;
            txtHab.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtHab.Location = new Point(127, 51);
            txtHab.Name = "txtHab";
            txtHab.ReadOnly = true;
            txtHab.Size = new Size(278, 25);
            txtHab.TabIndex = 0;
            txtHab.TextChanged += txtHab_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 100);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 75;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 18);
            label1.TabIndex = 74;
            label1.Text = "Habitación:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 71);
            panel1.TabIndex = 2;
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
            btnCerrar.TabIndex = 44;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(25, 18);
            label11.Name = "label11";
            label11.Size = new Size(266, 32);
            label11.TabIndex = 31;
            label11.Text = "Servicio a la habitación";
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // ServicioVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1084, 561);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(678, 446);
            Name = "ServicioVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABC";
            panelPrincipal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Panel panel1;
        private Label label11;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        public Label label2;
        public Label label1;
        public Label label5;
        public Label label3;
        public Label label4;
        private TextBox txtPrecio;
        public Label label8;
        private ComboBox cmbServicio;
        public Label label7;
        public Label label6;
        public Button btnAgregar;
        private Button btnCerrar;
        private TextBox txtTotal;
        public Label label9;
        public Button btnVenta;
        public Label label10;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        public ListView listView;
        public Button btnEliminar;
        public ComboBox cmbEstado;
        private ColumnHeader columnHeader4;
        public Button btnReservacion;
        public TextBox txtHab;
        public TextBox txtSalida;
        public TextBox txtEntrada;
        public TextBox txtCliente;
        private ErrorProvider errorT;
    }
}