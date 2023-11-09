namespace ProyectoHCL.Formularios
{
    partial class CtrlClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlClientes));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            btnNuevo = new Button();
            panel4 = new Panel();
            button6 = new Button();
            button5 = new Button();
            txtBuscarCl = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            dgvClientes = new DataGridView();
            panel5 = new Panel();
            txtPagCl = new TextBox();
            label2 = new Label();
            label5 = new Label();
            cmbPagCl = new ComboBox();
            label8 = new Label();
            cmbMostrarCl = new ComboBox();
            label9 = new Label();
            btnSig = new Button();
            btnAnt = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPag = new TextBox();
            cmbPag = new ComboBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 65);
            panel2.TabIndex = 32;
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
            btnCerrar.TabIndex = 43;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(18, 17);
            label11.Name = "label11";
            label11.Size = new Size(233, 32);
            label11.TabIndex = 37;
            label11.Text = "Clientes Registrados";
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.BackgroundImage = (Image)resources.GetObject("btnPerfil.BackgroundImage");
            btnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(1694, 73);
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
            btnCerrarSesion.Location = new Point(1741, 71);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(35, 33);
            btnCerrarSesion.TabIndex = 35;
            btnCerrarSesion.UseVisualStyleBackColor = false;
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
            btnNuevo.Location = new Point(635, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 35);
            btnNuevo.TabIndex = 36;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(button6);
            panel4.Controls.Add(btnNuevo);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(txtBuscarCl);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(1084, 67);
            panel4.TabIndex = 33;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.Red;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(963, 22);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(78, 25);
            button6.TabIndex = 51;
            button6.Text = "PDF";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.FromArgb(0, 192, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(872, 22);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(78, 25);
            button5.TabIndex = 50;
            button5.Text = "Excel ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtBuscarCl
            // 
            txtBuscarCl.Anchor = AnchorStyles.Bottom;
            txtBuscarCl.BackColor = SystemColors.Info;
            txtBuscarCl.Location = new Point(81, 22);
            txtBuscarCl.Margin = new Padding(2);
            txtBuscarCl.Name = "txtBuscarCl";
            txtBuscarCl.Size = new Size(247, 23);
            txtBuscarCl.TabIndex = 44;
            txtBuscarCl.TextChanged += txtBuscarCl_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 45;
            label1.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 429);
            panel3.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(dgvClientes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 353);
            panel1.TabIndex = 41;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.WhiteSmoke;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvClientes.ColumnHeadersHeight = 30;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(45, 66, 91);
            dgvClientes.Location = new Point(27, 6);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(1027, 341);
            dgvClientes.TabIndex = 4;
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            dgvClientes.CellPainting += dgvClientes_CellPainting;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 66, 91);
            panel5.Controls.Add(txtPagCl);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(cmbPagCl);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(cmbMostrarCl);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnSig);
            panel5.Controls.Add(btnAnt);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtPag);
            panel5.Controls.Add(cmbPag);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 353);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 76);
            panel5.TabIndex = 36;
            // 
            // txtPagCl
            // 
            txtPagCl.Anchor = AnchorStyles.Right;
            txtPagCl.Location = new Point(979, 20);
            txtPagCl.Name = "txtPagCl";
            txtPagCl.ReadOnly = true;
            txtPagCl.Size = new Size(63, 23);
            txtPagCl.TabIndex = 79;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(952, 23);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 78;
            label2.Text = "De";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(824, 23);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 77;
            label5.Text = "Página";
            // 
            // cmbPagCl
            // 
            cmbPagCl.Anchor = AnchorStyles.Right;
            cmbPagCl.BackColor = SystemColors.Info;
            cmbPagCl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagCl.FormattingEnabled = true;
            cmbPagCl.Location = new Point(872, 20);
            cmbPagCl.Margin = new Padding(2);
            cmbPagCl.Name = "cmbPagCl";
            cmbPagCl.Size = new Size(65, 23);
            cmbPagCl.TabIndex = 76;
            cmbPagCl.SelectionChangeCommitted += cmbPagCl_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(27, 20);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 74;
            label8.Text = "Mostrar";
            // 
            // cmbMostrarCl
            // 
            cmbMostrarCl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrarCl.BackColor = SystemColors.Info;
            cmbMostrarCl.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrarCl.FormattingEnabled = true;
            cmbMostrarCl.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            cmbMostrarCl.Location = new Point(90, 17);
            cmbMostrarCl.Margin = new Padding(2);
            cmbMostrarCl.Name = "cmbMostrarCl";
            cmbMostrarCl.Size = new Size(77, 23);
            cmbMostrarCl.TabIndex = 73;
            cmbMostrarCl.SelectedIndexChanged += cmbMostrarCl_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(171, 20);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(60, 17);
            label9.TabIndex = 75;
            label9.Text = "registros";
            label9.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSig.Location = new Point(787, 15);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(30, 31);
            btnSig.TabIndex = 72;
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
            btnAnt.Location = new Point(751, 15);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(30, 31);
            btnAnt.TabIndex = 71;
            btnAnt.UseVisualStyleBackColor = false;
            btnAnt.Click += btnAnt_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1782, 7);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 47;
            label4.Text = "De";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1654, 7);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 46;
            label3.Text = "Página";
            // 
            // txtPag
            // 
            txtPag.Anchor = AnchorStyles.Right;
            txtPag.Location = new Point(1809, 4);
            txtPag.Name = "txtPag";
            txtPag.Size = new Size(65, 23);
            txtPag.TabIndex = 45;
            // 
            // cmbPag
            // 
            cmbPag.Anchor = AnchorStyles.Right;
            cmbPag.BackColor = SystemColors.Info;
            cmbPag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPag.FormattingEnabled = true;
            cmbPag.Location = new Point(1702, 4);
            cmbPag.Margin = new Padding(2);
            cmbPag.Name = "cmbPag";
            cmbPag.Size = new Size(65, 23);
            cmbPag.TabIndex = 44;
            // 
            // CtrlClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(680, 500);
            Name = "CtrlClientes";
            Text = "CtrlClientes";
            Load += CtrlClientes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Panel panel4;
        private Panel panel3;
        private Button btnNuevo;
        private Label label11;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private TextBox txtPag;
        private ComboBox cmbPag;
        private Button button6;
        private Button button5;
        private TextBox txtBuscarCl;
        private Label label1;
        private Button btnSig;
        private Button btnAnt;
        private Label label8;
        private ComboBox cmbMostrarCl;
        private Label label9;
        private TextBox txtPagCl;
        private Label label2;
        private Label label5;
        private ComboBox cmbPagCl;
        private Panel panel1;
        private DataGridView dgvClientes;
        private Button btnCerrar;
    }
}