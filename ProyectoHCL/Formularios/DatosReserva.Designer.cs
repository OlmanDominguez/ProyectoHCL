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
            btnC = new Button();
            lblDatosR = new Label();
            txtSalida = new TextBox();
            label13 = new Label();
            txtEntrada = new TextBox();
            label12 = new Label();
            txtCliente = new TextBox();
            label10 = new Label();
            txtHab = new TextBox();
            label9 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnC);
            panel3.Controls.Add(lblDatosR);
            panel3.Controls.Add(txtSalida);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtEntrada);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtCliente);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtHab);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 318);
            panel3.TabIndex = 8;
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
            btnC.Location = new Point(449, 12);
            btnC.Name = "btnC";
            btnC.Size = new Size(14, 17);
            btnC.TabIndex = 35;
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // lblDatosR
            // 
            lblDatosR.AutoSize = true;
            lblDatosR.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatosR.Location = new Point(162, 22);
            lblDatosR.Name = "lblDatosR";
            lblDatosR.Size = new Size(136, 20);
            lblDatosR.TabIndex = 8;
            lblDatosR.Text = "Datos reservación:";
            // 
            // txtSalida
            // 
            txtSalida.BackColor = Color.White;
            txtSalida.BorderStyle = BorderStyle.FixedSingle;
            txtSalida.Location = new Point(41, 255);
            txtSalida.Name = "txtSalida";
            txtSalida.ReadOnly = true;
            txtSalida.Size = new Size(385, 23);
            txtSalida.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(41, 234);
            label13.Name = "label13";
            label13.Size = new Size(85, 19);
            label13.TabIndex = 6;
            label13.Text = "Fecha salida:";
            // 
            // txtEntrada
            // 
            txtEntrada.BackColor = Color.White;
            txtEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtEntrada.Location = new Point(41, 198);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ReadOnly = true;
            txtEntrada.Size = new Size(385, 23);
            txtEntrada.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(41, 177);
            label12.Name = "label12";
            label12.Size = new Size(98, 19);
            label12.TabIndex = 4;
            label12.Text = "Fecha entrada:";
            // 
            // txtCliente
            // 
            txtCliente.BackColor = Color.White;
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Location = new Point(41, 141);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(385, 23);
            txtCliente.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(41, 120);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 2;
            label10.Text = "Cliente:";
            // 
            // txtHab
            // 
            txtHab.BackColor = Color.White;
            txtHab.BorderStyle = BorderStyle.FixedSingle;
            txtHab.Location = new Point(41, 84);
            txtHab.Name = "txtHab";
            txtHab.ReadOnly = true;
            txtHab.Size = new Size(385, 23);
            txtHab.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(41, 63);
            label9.Name = "label9";
            label9.Size = new Size(77, 19);
            label9.TabIndex = 0;
            label9.Text = "Habitación:";
            // 
            // DatosReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 318);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosReserva";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosReserva";
            Load += DatosReserva_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label lblDatosR;
        public TextBox txtSalida;
        private Label label13;
        public TextBox txtEntrada;
        private Label label12;
        public TextBox txtCliente;
        private Label label10;
        public TextBox txtHab;
        private Label label9;
        private Button btnC;
    }
}