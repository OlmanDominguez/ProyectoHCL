namespace ProyectoHCL
{
    partial class Reservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservaciones));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnExit = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            btnNuevo = new Button();
            label11 = new Label();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            btn_pdf = new Button();
            btn_imprimir = new Button();
            btn_excel = new Button();
            label2 = new Label();
            cb_registros = new ComboBox();
            label5 = new Label();
            panel4 = new Panel();
            txt_buscar = new TextBox();
            label3 = new Label();
            txtBuscar = new TextBox();
            label1 = new Label();
            dgv_reservaciones = new DataGridView();
            label4 = new Label();
            cb_pagina = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reservaciones).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(826, -2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 125);
            panel2.TabIndex = 35;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1574, 74);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 38;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1621, 72);
            button3.Name = "button3";
            button3.Size = new Size(35, 33);
            button3.TabIndex = 39;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevo.BackColor = Color.RoyalBlue;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(15, 64);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(167, 39);
            btnNuevo.TabIndex = 36;
            btnNuevo.Text = "Nueva reservacion";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 15);
            label11.Name = "label11";
            label11.Size = new Size(167, 32);
            label11.TabIndex = 37;
            label11.Text = "Reservaciones";
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.BackgroundImage = (Image)resources.GetObject("btnPerfil.BackgroundImage");
            btnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(2289, 73);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(30, 29);
            btnPerfil.TabIndex = 34;
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(2336, 71);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(35, 33);
            btnCerrarSesion.TabIndex = 35;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btn_pdf
            // 
            btn_pdf.Anchor = AnchorStyles.Bottom;
            btn_pdf.BackColor = Color.Red;
            btn_pdf.FlatAppearance.BorderSize = 0;
            btn_pdf.FlatStyle = FlatStyle.Flat;
            btn_pdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_pdf.ForeColor = SystemColors.ButtonHighlight;
            btn_pdf.Location = new Point(558, 26);
            btn_pdf.Margin = new Padding(2);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(78, 25);
            btn_pdf.TabIndex = 43;
            btn_pdf.Text = "PDF";
            btn_pdf.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            btn_imprimir.Anchor = AnchorStyles.Bottom;
            btn_imprimir.BackColor = Color.DarkOrange;
            btn_imprimir.FlatAppearance.BorderSize = 0;
            btn_imprimir.FlatStyle = FlatStyle.Flat;
            btn_imprimir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_imprimir.ForeColor = SystemColors.ButtonHighlight;
            btn_imprimir.Location = new Point(375, 26);
            btn_imprimir.Margin = new Padding(2);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(78, 25);
            btn_imprimir.TabIndex = 41;
            btn_imprimir.Text = "Imprimir";
            btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_excel
            // 
            btn_excel.Anchor = AnchorStyles.Bottom;
            btn_excel.BackColor = Color.FromArgb(0, 192, 0);
            btn_excel.FlatAppearance.BorderSize = 0;
            btn_excel.FlatStyle = FlatStyle.Flat;
            btn_excel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_excel.ForeColor = SystemColors.ButtonHighlight;
            btn_excel.Location = new Point(467, 26);
            btn_excel.Margin = new Padding(2);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(78, 25);
            btn_excel.TabIndex = 42;
            btn_excel.Text = "Excel ";
            btn_excel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(115, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 39;
            label2.Text = "Mostrar";
            // 
            // cb_registros
            // 
            cb_registros.Anchor = AnchorStyles.Bottom;
            cb_registros.BackColor = SystemColors.Info;
            cb_registros.FormattingEnabled = true;
            cb_registros.Location = new Point(178, 26);
            cb_registros.Margin = new Padding(2);
            cb_registros.Name = "cb_registros";
            cb_registros.Size = new Size(77, 23);
            cb_registros.TabIndex = 38;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(259, 26);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 40;
            label5.Text = "registros";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(txt_buscar);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btn_pdf);
            panel4.Controls.Add(btn_imprimir);
            panel4.Controls.Add(btn_excel);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cb_registros);
            panel4.Controls.Add(txtBuscar);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(855, 85);
            panel4.TabIndex = 36;
            // 
            // txt_buscar
            // 
            txt_buscar.Anchor = AnchorStyles.Bottom;
            txt_buscar.BackColor = SystemColors.Info;
            txt_buscar.Location = new Point(738, 29);
            txt_buscar.Margin = new Padding(2);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(106, 23);
            txt_buscar.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(678, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 45;
            label3.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(1099, 14);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(106, 23);
            txtBuscar.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1039, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 37;
            label1.Text = "Buscar:";
            // 
            // dgv_reservaciones
            // 
            dgv_reservaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_reservaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_reservaciones.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgv_reservaciones.BorderStyle = BorderStyle.None;
            dgv_reservaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 222, 73);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_reservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_reservaciones.ColumnHeadersHeight = 30;
            dgv_reservaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_reservaciones.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_reservaciones.EnableHeadersVisualStyles = false;
            dgv_reservaciones.GridColor = Color.SteelBlue;
            dgv_reservaciones.Location = new Point(0, 210);
            dgv_reservaciones.Name = "dgv_reservaciones";
            dgv_reservaciones.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_reservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_reservaciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv_reservaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_reservaciones.RowTemplate.Height = 25;
            dgv_reservaciones.Size = new Size(855, 284);
            dgv_reservaciones.TabIndex = 34;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(724, 507);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 48;
            label4.Text = "Página";
            // 
            // cb_pagina
            // 
            cb_pagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cb_pagina.BackColor = SystemColors.Info;
            cb_pagina.FormattingEnabled = true;
            cb_pagina.Location = new Point(772, 504);
            cb_pagina.Margin = new Padding(2);
            cb_pagina.Name = "cb_pagina";
            cb_pagina.Size = new Size(65, 23);
            cb_pagina.TabIndex = 47;
            // 
            // Reservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 537);
            Controls.Add(label4);
            Controls.Add(cb_pagina);
            Controls.Add(panel4);
            Controls.Add(dgv_reservaciones);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservaciones";
            Text = "Reservaciones";
            Load += Reservaciones_Load;
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reservaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnExit;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button btnNuevo;
        private Label label11;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Button btn_pdf;
        private Button btn_imprimir;
        private Button btn_excel;
        private Label label2;
        private ComboBox cb_registros;
        private Label label5;
        private Panel panel4;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dgv_reservaciones;
        private TextBox txt_buscar;
        private Label label3;
        private Label label4;
        private ComboBox cb_pagina;
    }
}