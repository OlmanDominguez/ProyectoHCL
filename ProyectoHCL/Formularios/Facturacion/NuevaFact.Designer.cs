namespace ProyectoHCL.Formularios
{
    partial class NuevaFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaFact));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            btnSig = new Button();
            btnAnt = new Button();
            txtPaginacion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cmbPaginacion = new ComboBox();
            label2 = new Label();
            cmbMostrar = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            btnNuevo = new Button();
            txtBuscarRe = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            dgvReservas = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 61);
            panel2.TabIndex = 20;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(974, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 31;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(29, 12);
            label11.Name = "label11";
            label11.Size = new Size(154, 30);
            label11.TabIndex = 28;
            label11.Text = "Nueva Factura";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 389);
            panel1.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 66, 91);
            panel5.Controls.Add(btnSig);
            panel5.Controls.Add(btnAnt);
            panel5.Controls.Add(txtPaginacion);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(cmbPaginacion);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cmbMostrar);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 335);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 54);
            panel5.TabIndex = 2;
            // 
            // btnSig
            // 
            btnSig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSig.BackColor = Color.Transparent;
            btnSig.BackgroundImage = (Image)resources.GetObject("btnSig.BackgroundImage");
            btnSig.BackgroundImageLayout = ImageLayout.Stretch;
            btnSig.FlatAppearance.BorderSize = 0;
            btnSig.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSig.FlatStyle = FlatStyle.Flat;
            btnSig.Location = new Point(703, 12);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(30, 31);
            btnSig.TabIndex = 76;
            btnSig.UseVisualStyleBackColor = false;
            btnSig.Click += btnSig_Click;
            // 
            // btnAnt
            // 
            btnAnt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnt.BackColor = Color.Transparent;
            btnAnt.BackgroundImage = (Image)resources.GetObject("btnAnt.BackgroundImage");
            btnAnt.BackgroundImageLayout = ImageLayout.Stretch;
            btnAnt.FlatAppearance.BorderSize = 0;
            btnAnt.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAnt.FlatStyle = FlatStyle.Flat;
            btnAnt.Location = new Point(667, 12);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(30, 31);
            btnAnt.TabIndex = 75;
            btnAnt.UseVisualStyleBackColor = false;
            btnAnt.Click += btnAnt_Click;
            // 
            // txtPaginacion
            // 
            txtPaginacion.Anchor = AnchorStyles.Right;
            txtPaginacion.Location = new Point(895, 17);
            txtPaginacion.Name = "txtPaginacion";
            txtPaginacion.ReadOnly = true;
            txtPaginacion.Size = new Size(63, 23);
            txtPaginacion.TabIndex = 74;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(868, 20);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 73;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(740, 20);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 72;
            label7.Text = "Página";
            // 
            // cmbPaginacion
            // 
            cmbPaginacion.Anchor = AnchorStyles.Right;
            cmbPaginacion.BackColor = SystemColors.Info;
            cmbPaginacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaginacion.FormattingEnabled = true;
            cmbPaginacion.Location = new Point(788, 17);
            cmbPaginacion.Margin = new Padding(2);
            cmbPaginacion.Name = "cmbPaginacion";
            cmbPaginacion.Size = new Size(65, 23);
            cmbPaginacion.TabIndex = 71;
            cmbPaginacion.SelectionChangeCommitted += cmbPaginacion_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(32, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 50;
            label2.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            cmbMostrar.Location = new Point(95, 17);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 49;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(176, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 51;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(txtBuscarRe);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 61);
            panel4.TabIndex = 1;
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
            btnNuevo.Location = new Point(392, 14);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 35);
            btnNuevo.TabIndex = 41;
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscarRe
            // 
            txtBuscarRe.Anchor = AnchorStyles.Bottom;
            txtBuscarRe.BackColor = SystemColors.Info;
            txtBuscarRe.Location = new Point(95, 20);
            txtBuscarRe.Margin = new Padding(2);
            txtBuscarRe.Name = "txtBuscarRe";
            txtBuscarRe.Size = new Size(247, 23);
            txtBuscarRe.TabIndex = 46;
            txtBuscarRe.TextChanged += txtBuscarRe_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(35, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 47;
            label1.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(dgvReservas);
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 274);
            panel3.TabIndex = 0;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AllowUserToResizeColumns = false;
            dgvReservas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.BackgroundColor = Color.WhiteSmoke;
            dgvReservas.BorderStyle = BorderStyle.None;
            dgvReservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservas.ColumnHeadersHeight = 30;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReservas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReservas.EnableHeadersVisualStyles = false;
            dgvReservas.GridColor = Color.FromArgb(45, 66, 91);
            dgvReservas.Location = new Point(29, 3);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReservas.RowTemplate.Height = 25;
            dgvReservas.Size = new Size(945, 268);
            dgvReservas.TabIndex = 5;
            dgvReservas.CellClick += dgvReservas_CellClick;
            dgvReservas.CellFormatting += dgvReservas_CellFormatting;
            // 
            // NuevaFact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevaFact";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarObjeto";
            Load += NuevaFact_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label11;
        public TextBox txtDescripcion;
        public ComboBox cmbEstado;
        private Button btnCerrar;
        private Panel panel1;
        private Panel panel3;
        private TextBox txtBuscarRe;
        private Label label1;
        private Button btnNuevo;
        private DataGridView dgvReservas;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private ComboBox cmbMostrar;
        private Label label3;
        private Button btnSig;
        private Button btnAnt;
        private TextBox txtPaginacion;
        private Label label6;
        private Label label7;
        private ComboBox cmbPaginacion;
    }
}