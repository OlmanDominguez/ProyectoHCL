namespace ProyectoHCL.Formularios
{
    partial class DatosReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosReserva));
            panel3 = new Panel();
            btnEditar = new Button();
            panel1 = new Panel();
            lblDatosR = new Label();
            btnC = new Button();
            lblSalida = new Label();
            lblEntrada = new Label();
            lblCliente = new Label();
            lblHab = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(lblSalida);
            panel3.Controls.Add(lblEntrada);
            panel3.Controls.Add(lblCliente);
            panel3.Controls.Add(lblHab);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(426, 238);
            panel3.TabIndex = 8;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.Teal;
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(160, 191);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 26);
            btnEditar.TabIndex = 41;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 100, 150);
            panel1.Controls.Add(lblDatosR);
            panel1.Controls.Add(btnC);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 32);
            panel1.TabIndex = 40;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // lblDatosR
            // 
            lblDatosR.AutoSize = true;
            lblDatosR.BackColor = Color.Transparent;
            lblDatosR.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosR.ForeColor = Color.White;
            lblDatosR.Location = new Point(147, 7);
            lblDatosR.Name = "lblDatosR";
            lblDatosR.Size = new Size(135, 20);
            lblDatosR.TabIndex = 8;
            lblDatosR.Text = "Datos Reservación";
            // 
            // btnC
            // 
            btnC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnC.BackColor = Color.Transparent;
            btnC.BackgroundImage = (Image)resources.GetObject("btnC.BackgroundImage");
            btnC.BackgroundImageLayout = ImageLayout.Stretch;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Location = new Point(400, 9);
            btnC.Name = "btnC";
            btnC.Size = new Size(14, 17);
            btnC.TabIndex = 35;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(123, 155);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(38, 15);
            lblSalida.TabIndex = 39;
            lblSalida.Text = "label4";
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Location = new Point(135, 119);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(38, 15);
            lblEntrada.TabIndex = 38;
            lblEntrada.Text = "label3";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(93, 85);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(38, 15);
            lblCliente.TabIndex = 37;
            lblCliente.Text = "label2";
            // 
            // lblHab
            // 
            lblHab.AutoSize = true;
            lblHab.Location = new Point(115, 53);
            lblHab.Name = "lblHab";
            lblHab.Size = new Size(38, 15);
            lblHab.TabIndex = 36;
            lblHab.Text = "label1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(33, 153);
            label13.Name = "label13";
            label13.Size = new Size(84, 17);
            label13.TabIndex = 6;
            label13.Text = "Fecha salida:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(33, 117);
            label12.Name = "label12";
            label12.Size = new Size(96, 17);
            label12.TabIndex = 4;
            label12.Text = "Fecha entrada:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(33, 83);
            label10.Name = "label10";
            label10.Size = new Size(54, 17);
            label10.TabIndex = 2;
            label10.Text = "Cliente:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(33, 51);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 0;
            label9.Text = "Habitación:";
            // 
            // DatosReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 238);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosReserva";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosReserva";
            Load += DatosReserva_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label lblDatosR;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Button btnC;
        private Panel panel1;
        public Label lblSalida;
        public Label lblEntrada;
        public Label lblCliente;
        public Label lblHab;
        public Button btnEditar;
    }
}