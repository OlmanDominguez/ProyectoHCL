﻿namespace ProyectoHCL.Formularios
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
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnVenta = new Button();
            txtTotal = new TextBox();
            label9 = new Label();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel4 = new Panel();
            txt_cantidad = new TextBox();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            label8 = new Label();
            label10 = new Label();
            cmbServicio = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lblSalida = new Label();
            lblEntrada = new Label();
            lblCliente = new Label();
            lblHabitacion = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            panelPrincipal.Size = new Size(1058, 541);
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
            panel3.Size = new Size(1058, 470);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnCancelar);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(btnVenta);
            panel5.Controls.Add(txtTotal);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(listView);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(1058, 216);
            panel5.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(909, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 32);
            btnCancelar.TabIndex = 89;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
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
            btnEliminar.Location = new Point(760, 32);
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
            btnVenta.BackColor = Color.Green;
            btnVenta.BackgroundImageLayout = ImageLayout.Stretch;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = Color.White;
            btnVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenta.Location = new Point(909, 98);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(92, 32);
            btnVenta.TabIndex = 86;
            btnVenta.Text = "Guardar";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.ButtonHighlight;
            txtTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(889, 33);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(134, 25);
            txtTotal.TabIndex = 83;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(838, 35);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(46, 18);
            label9.TabIndex = 82;
            label9.Text = "Total:";
            // 
            // listView
            // 
            listView.BorderStyle = BorderStyle.FixedSingle;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader5, columnHeader3, columnHeader4 });
            listView.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Location = new Point(30, 32);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(702, 153);
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
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cantid.";
            columnHeader5.TextAlign = HorizontalAlignment.Right;
            columnHeader5.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SubTotal";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Codigo";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txt_cantidad);
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(txtPrecio);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(cmbServicio);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(1058, 130);
            panel4.TabIndex = 1;
            // 
            // txt_cantidad
            // 
            txt_cantidad.BackColor = SystemColors.ButtonHighlight;
            txt_cantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cantidad.Location = new Point(614, 77);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(184, 25);
            txt_cantidad.TabIndex = 87;
            txt_cantidad.TextAlign = HorizontalAlignment.Right;
            txt_cantidad.KeyPress += txt_cantidad_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.BackColor = Color.RoyalBlue;
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(932, 72);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(44, 32);
            btnAgregar.TabIndex = 85;
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ButtonHighlight;
            txtPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(379, 77);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(184, 25);
            txtPrecio.TabIndex = 82;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(379, 56);
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
            label10.Location = new Point(614, 56);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 18);
            label10.TabIndex = 86;
            label10.Text = "Cantidad";
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(30, 77);
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
            label7.Location = new Point(30, 56);
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
            label6.ForeColor = Color.MidnightBlue;
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
            panel2.Controls.Add(lblSalida);
            panel2.Controls.Add(lblEntrada);
            panel2.Controls.Add(lblCliente);
            panel2.Controls.Add(lblHabitacion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1058, 126);
            panel2.TabIndex = 0;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalida.ForeColor = Color.Black;
            lblSalida.Location = new Point(553, 82);
            lblSalida.Margin = new Padding(2, 0, 2, 0);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(48, 20);
            lblSalida.TabIndex = 93;
            lblSalida.Text = "salida";
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEntrada.ForeColor = Color.Black;
            lblEntrada.Location = new Point(567, 52);
            lblEntrada.Margin = new Padding(2, 0, 2, 0);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(60, 20);
            lblEntrada.TabIndex = 92;
            lblEntrada.Text = "entrada";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(99, 82);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(53, 20);
            lblCliente.TabIndex = 91;
            lblCliente.Text = "cliente";
            // 
            // lblHabitacion
            // 
            lblHabitacion.AutoSize = true;
            lblHabitacion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabitacion.ForeColor = Color.Black;
            lblHabitacion.Location = new Point(127, 51);
            lblHabitacion.Margin = new Padding(2, 0, 2, 0);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(79, 20);
            lblHabitacion.TabIndex = 90;
            lblHabitacion.Text = "habitacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(30, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 18);
            label5.TabIndex = 81;
            label5.Text = "Datos reservación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(443, 83);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 83);
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
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 71);
            panel1.TabIndex = 2;
            panel1.MouseMove += panel1_MouseMove;
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
            btnCerrar.Location = new Point(1032, 12);
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
            ClientSize = new Size(1058, 541);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(678, 446);
            Name = "ServicioVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABC";
            Load += ServicioVenta_Load;
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
        private ErrorProvider errorT;
        private ColumnHeader columnHeader5;
        private TextBox txt_cantidad;
        private ColumnHeader columnHeader4;
        public Label lblSalida;
        public Label lblEntrada;
        public Label lblCliente;
        public Label lblHabitacion;
        public Button btnCancelar;
    }
}