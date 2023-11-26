namespace ProyectoHCL.Formularios
{
    partial class CtrlRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlRoles));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            cerrar = new Button();
            btnCerrar = new Button();
            label11 = new Label();
            panel5 = new Panel();
            pdf = new Button();
            Excel = new Button();
            btnNuevo = new Button();
            txtBuscarR = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            btSiguiente = new Button();
            btAnterior = new Button();
            label6 = new Label();
            label7 = new Label();
            txtPagR = new TextBox();
            cmbPagR = new ComboBox();
            label2 = new Label();
            cmbMostrar = new ComboBox();
            label5 = new Label();
            dgvRoles = new DataGridView();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(cerrar);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1549, 108);
            panel2.TabIndex = 35;
            // 
            // cerrar
            // 
            cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cerrar.BackColor = Color.Transparent;
            cerrar.BackgroundImage = (Image)resources.GetObject("cerrar.BackgroundImage");
            cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Location = new Point(1516, 13);
            cerrar.Margin = new Padding(4, 5, 4, 5);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(20, 28);
            cerrar.TabIndex = 43;
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += button6_Click;
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
            btnCerrar.Location = new Point(2861, 20);
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
            label11.Location = new Point(27, 28);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(309, 48);
            label11.TabIndex = 41;
            label11.Text = "Roles Registrados";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(pdf);
            panel5.Controls.Add(Excel);
            panel5.Controls.Add(btnNuevo);
            panel5.Controls.Add(txtBuscarR);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 108);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1549, 112);
            panel5.TabIndex = 36;
            // 
            // pdf
            // 
            pdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pdf.BackColor = Color.Red;
            pdf.FlatAppearance.BorderSize = 0;
            pdf.FlatStyle = FlatStyle.Flat;
            pdf.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pdf.ForeColor = SystemColors.ButtonHighlight;
            pdf.Location = new Point(1389, 35);
            pdf.Margin = new Padding(1, 2, 1, 2);
            pdf.Name = "pdf";
            pdf.Size = new Size(111, 42);
            pdf.TabIndex = 55;
            pdf.Text = "PDF";
            pdf.UseVisualStyleBackColor = false;
            pdf.Click += pdf_Click;
            // 
            // Excel
            // 
            Excel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Excel.BackColor = Color.FromArgb(0, 192, 0);
            Excel.FlatAppearance.BorderSize = 0;
            Excel.FlatStyle = FlatStyle.Flat;
            Excel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Excel.ForeColor = SystemColors.ButtonHighlight;
            Excel.Location = new Point(1259, 35);
            Excel.Margin = new Padding(1, 2, 1, 2);
            Excel.Name = "Excel";
            Excel.Size = new Size(111, 42);
            Excel.TabIndex = 54;
            Excel.Text = "Excel ";
            Excel.UseVisualStyleBackColor = false;
            Excel.Click += Excel_Click;
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
            btnNuevo.Location = new Point(544, 27);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(71, 58);
            btnNuevo.TabIndex = 40;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.EnabledChanged += btnNuevo_EnabledChanged;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscarR
            // 
            txtBuscarR.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscarR.BackColor = SystemColors.Info;
            txtBuscarR.Location = new Point(121, 38);
            txtBuscarR.Margin = new Padding(1, 2, 1, 2);
            txtBuscarR.Name = "txtBuscarR";
            txtBuscarR.Size = new Size(358, 31);
            txtBuscarR.TabIndex = 44;
            txtBuscarR.TextChanged += txtBuscar_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(40, 38);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btSiguiente);
            panel1.Controls.Add(btAnterior);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPagR);
            panel1.Controls.Add(cmbPagR);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbMostrar);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 808);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1549, 127);
            panel1.TabIndex = 38;
            // 
            // btSiguiente
            // 
            btSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSiguiente.BackColor = Color.Transparent;
            btSiguiente.BackgroundImage = (Image)resources.GetObject("btSiguiente.BackgroundImage");
            btSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            btSiguiente.FlatAppearance.BorderSize = 0;
            btSiguiente.FlatAppearance.MouseOverBackColor = Color.Silver;
            btSiguiente.FlatStyle = FlatStyle.Flat;
            btSiguiente.Location = new Point(1123, 27);
            btSiguiente.Margin = new Padding(4, 5, 4, 5);
            btSiguiente.Name = "btSiguiente";
            btSiguiente.Size = new Size(43, 52);
            btSiguiente.TabIndex = 70;
            btSiguiente.UseVisualStyleBackColor = false;
            btSiguiente.Click += btSiguiente_Click;
            // 
            // btAnterior
            // 
            btAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btAnterior.BackColor = Color.Transparent;
            btAnterior.BackgroundImage = (Image)resources.GetObject("btAnterior.BackgroundImage");
            btAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btAnterior.FlatAppearance.BorderSize = 0;
            btAnterior.FlatAppearance.MouseOverBackColor = Color.Silver;
            btAnterior.FlatStyle = FlatStyle.Flat;
            btAnterior.Location = new Point(1071, 27);
            btAnterior.Margin = new Padding(4, 5, 4, 5);
            btAnterior.Name = "btAnterior";
            btAnterior.Size = new Size(43, 52);
            btAnterior.TabIndex = 69;
            btAnterior.UseVisualStyleBackColor = false;
            btAnterior.Click += btAnterior_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1363, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 28);
            label6.TabIndex = 68;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1173, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 67;
            label7.Text = "Página";
            // 
            // txtPagR
            // 
            txtPagR.Anchor = AnchorStyles.Right;
            txtPagR.BorderStyle = BorderStyle.FixedSingle;
            txtPagR.Location = new Point(1401, 33);
            txtPagR.Margin = new Padding(4, 5, 4, 5);
            txtPagR.Name = "txtPagR";
            txtPagR.ReadOnly = true;
            txtPagR.Size = new Size(92, 31);
            txtPagR.TabIndex = 66;
            // 
            // cmbPagR
            // 
            cmbPagR.Anchor = AnchorStyles.Right;
            cmbPagR.BackColor = SystemColors.Info;
            cmbPagR.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagR.FormattingEnabled = true;
            cmbPagR.Location = new Point(1246, 33);
            cmbPagR.Margin = new Padding(1, 2, 1, 2);
            cmbPagR.Name = "cmbPagR";
            cmbPagR.Size = new Size(91, 33);
            cmbPagR.TabIndex = 65;
            cmbPagR.SelectionChangeCommitted += cmbPagR_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(40, 33);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 39;
            label2.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            cmbMostrar.Location = new Point(123, 28);
            cmbMostrar.Margin = new Padding(1, 2, 1, 2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(108, 33);
            cmbMostrar.TabIndex = 38;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(237, 33);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 40;
            label5.Text = "registros";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.WhiteSmoke;
            dgvRoles.BorderStyle = BorderStyle.None;
            dgvRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoles.ColumnHeadersHeight = 30;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoles.EnableHeadersVisualStyles = false;
            dgvRoles.GridColor = Color.FromArgb(45, 66, 91);
            dgvRoles.Location = new Point(13, 230);
            dgvRoles.Margin = new Padding(4, 5, 4, 5);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoles.RowTemplate.Height = 25;
            dgvRoles.Size = new Size(1511, 568);
            dgvRoles.TabIndex = 6;
            dgvRoles.CellClick += dgvRoles_CellClick;
            dgvRoles.CellFormatting += dgvRoles_CellFormatting_1;
            // 
            // CtrlRoles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 935);
            Controls.Add(panel1);
            Controls.Add(dgvRoles);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 2, 1, 2);
            Name = "CtrlRoles";
            Text = "CtrlRoles";
            Load += CtrlRoles_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnCerrar;
        private Label label11;
        private Button button2;
        private Button button5;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Panel panel5;
        private Button btnNuevo;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button9;
        private Label label4;
        private Button pdf;
        private Button Excel;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbMostrar;
        private Label label5;
        private Button btSiguiente;
        private Button btAnterior;
        private Label label6;
        private Label label7;
        private TextBox txtPagR;
        private ComboBox cmbPagR;
        public DataGridView dgvRoles;
        private Button cerrar;
        public TextBox txtBuscarR;
    }
}