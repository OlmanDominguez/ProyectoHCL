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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            BtnBuscar = new Button();
            dateTimePicker_Desde = new DateTimePicker();
            dateTimePicker_Hasta = new DateTimePicker();
            desde = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            panel5 = new Panel();
            btnPdf = new Button();
            btnExcel = new Button();
            dgvReportes = new DataGridView();
            panel3 = new Panel();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            txtPaginacion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            cmbMostrar = new ComboBox();
            cmbPaginacion = new ComboBox();
            label3 = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(905, 31);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(112, 34);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "BtnBuscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // dateTimePicker_Desde
            // 
            dateTimePicker_Desde.Location = new Point(101, 40);
            dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            dateTimePicker_Desde.Size = new Size(300, 31);
            dateTimePicker_Desde.TabIndex = 1;
            // 
            // dateTimePicker_Hasta
            // 
            dateTimePicker_Hasta.Location = new Point(542, 34);
            dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            dateTimePicker_Hasta.Size = new Size(300, 31);
            dateTimePicker_Hasta.TabIndex = 2;
            // 
            // desde
            // 
            desde.AutoSize = true;
            desde.Location = new Point(12, 40);
            desde.Name = "desde";
            desde.Size = new Size(62, 25);
            desde.TabIndex = 3;
            desde.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 46);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1469, 108);
            panel2.TabIndex = 34;
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
            btnCerrar.Location = new Point(2780, 20);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 28);
            btnCerrar.TabIndex = 42;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(29, 28);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(176, 48);
            label11.TabIndex = 41;
            label11.Text = "Reportes ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(btnPdf);
            panel5.Controls.Add(btnExcel);
            panel5.Controls.Add(desde);
            panel5.Controls.Add(BtnBuscar);
            panel5.Controls.Add(dateTimePicker_Hasta);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dateTimePicker_Desde);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 108);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1469, 112);
            panel5.TabIndex = 35;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPdf.BackColor = Color.Red;
            btnPdf.FlatAppearance.BorderSize = 0;
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPdf.ForeColor = SystemColors.ButtonHighlight;
            btnPdf.Location = new Point(2655, 49);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(111, 42);
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
            btnExcel.Location = new Point(2525, 49);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(111, 42);
            btnExcel.TabIndex = 50;
            btnExcel.Text = "Excel ";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.WhiteSmoke;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvReportes.ColumnHeadersHeight = 30;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.GridColor = Color.FromArgb(45, 66, 91);
            dgvReportes.Location = new Point(13, 242);
            dgvReportes.Margin = new Padding(4, 5, 4, 5);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvReportes.RowTemplate.Height = 25;
            dgvReportes.Size = new Size(1443, 281);
            dgvReportes.TabIndex = 36;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 66, 91);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(btnSiguiente);
            panel3.Controls.Add(btnAnterior);
            panel3.Controls.Add(txtPaginacion);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbMostrar);
            panel3.Controls.Add(cmbPaginacion);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 541);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1469, 127);
            panel3.TabIndex = 37;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1092, 53);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(43, 52);
            button2.TabIndex = 70;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1040, 53);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(43, 52);
            button3.TabIndex = 69;
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(1365, 58);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(88, 31);
            textBox1.TabIndex = 68;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1326, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 67;
            label4.Text = "De";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(1143, 63);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 66;
            label5.Text = "Página";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1212, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(91, 33);
            comboBox1.TabIndex = 65;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.Transparent;
            btnSiguiente.BackgroundImage = (Image)resources.GetObject("btnSiguiente.BackgroundImage");
            btnSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Location = new Point(2405, 27);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(43, 52);
            btnSiguiente.TabIndex = 64;
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.BackgroundImage = (Image)resources.GetObject("btnAnterior.BackgroundImage");
            btnAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Location = new Point(2353, 27);
            btnAnterior.Margin = new Padding(4, 5, 4, 5);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(43, 52);
            btnAnterior.TabIndex = 63;
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // txtPaginacion
            // 
            txtPaginacion.Anchor = AnchorStyles.Right;
            txtPaginacion.Location = new Point(2678, 45);
            txtPaginacion.Margin = new Padding(4, 5, 4, 5);
            txtPaginacion.Name = "txtPaginacion";
            txtPaginacion.ReadOnly = true;
            txtPaginacion.Size = new Size(88, 31);
            txtPaginacion.TabIndex = 52;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(2639, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 28);
            label6.TabIndex = 51;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(2456, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 50;
            label7.Text = "Página";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(41, 64);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 47;
            label1.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            cmbMostrar.Location = new Point(131, 59);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(108, 33);
            cmbMostrar.TabIndex = 46;
            // 
            // cmbPaginacion
            // 
            cmbPaginacion.Anchor = AnchorStyles.Right;
            cmbPaginacion.BackColor = SystemColors.Info;
            cmbPaginacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaginacion.FormattingEnabled = true;
            cmbPaginacion.Location = new Point(2525, 45);
            cmbPaginacion.Name = "cmbPaginacion";
            cmbPaginacion.Size = new Size(91, 33);
            cmbPaginacion.TabIndex = 48;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(247, 64);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 48;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 668);
            Controls.Add(panel3);
            Controls.Add(dgvReportes);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Name = "Reportes";
            Text = "imprimir";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBuscar;
        private DateTimePicker dateTimePicker_Desde;
        private DateTimePicker dateTimePicker_Hasta;
        private Label desde;
        private Label label2;
        private Panel panel2;
        private Button btnCerrar;
        private Label label11;
        private Panel panel5;
        public Button btnPdf;
        private Button btnExcel;
        public DataGridView dgvReportes;
        private Panel panel3;
        private Button btnSiguiente;
        private Button btnAnterior;
        private TextBox txtPaginacion;
        private Label label6;
        private Label label7;
        private Label label1;
        private ComboBox cmbMostrar;
        private ComboBox cmbPaginacion;
        private Label label3;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
    }
}