namespace ProyectoHCL
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            BtnBuscar = new Button();
            dateTimePicker_Desde = new DateTimePicker();
            dateTimePicker_Hasta = new DateTimePicker();
            desde = new Label();
            label2 = new Label();
            panel5 = new Panel();
            btnCerrar = new Button();
            label1 = new Label();
            btnPdf = new Button();
            btnExcel = new Button();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = Color.Green;
            BtnBuscar.FlatAppearance.BorderSize = 0;
            BtnBuscar.FlatStyle = FlatStyle.Flat;
            BtnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.Location = new Point(212, 199);
            BtnBuscar.Margin = new Padding(2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(78, 30);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "Aceptar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // dateTimePicker_Desde
            // 
            dateTimePicker_Desde.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Desde.Location = new Point(143, 90);
            dateTimePicker_Desde.Margin = new Padding(2);
            dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            dateTimePicker_Desde.Size = new Size(258, 23);
            dateTimePicker_Desde.TabIndex = 1;
            // 
            // dateTimePicker_Hasta
            // 
            dateTimePicker_Hasta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Hasta.Location = new Point(143, 140);
            dateTimePicker_Hasta.Margin = new Padding(2);
            dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            dateTimePicker_Hasta.Size = new Size(258, 23);
            dateTimePicker_Hasta.TabIndex = 2;
            // 
            // desde
            // 
            desde.AutoSize = true;
            desde.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            desde.Location = new Point(82, 95);
            desde.Margin = new Padding(2, 0, 2, 0);
            desde.Name = "desde";
            desde.Size = new Size(48, 17);
            desde.TabIndex = 3;
            desde.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(btnCerrar);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnPdf);
            panel5.Controls.Add(btnExcel);
            panel5.Controls.Add(desde);
            panel5.Controls.Add(BtnBuscar);
            panel5.Controls.Add(dateTimePicker_Hasta);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dateTimePicker_Desde);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(509, 262);
            panel5.TabIndex = 35;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(483, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 53;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 19);
            label1.TabIndex = 52;
            label1.Text = "Filtrar fechas de facturación";
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.Red;
            btnPdf.FlatAppearance.BorderSize = 0;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = SystemColors.ButtonHighlight;
            btnPdf.Location = new Point(1339, 224);
            btnPdf.Margin = new Padding(2);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(78, 25);
            btnPdf.TabIndex = 51;
            btnPdf.Text = "PDF";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcel.BackColor = Color.FromArgb(0, 192, 0);
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = SystemColors.ButtonHighlight;
            btnExcel.Location = new Point(1249, 224);
            btnExcel.Margin = new Padding(2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(78, 25);
            btnExcel.TabIndex = 50;
            btnExcel.Text = "Excel ";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 262);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "imprimir";
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBuscar;
        private DateTimePicker dateTimePicker_Desde;
        private DateTimePicker dateTimePicker_Hasta;
        private Label desde;
        private Label label2;
        private Panel panel5;
        public Button btnPdf;
        private Button btnExcel;
        private Label label1;
        private Button btnCerrar;
    }
}