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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnNuevo = new Button();
            label11 = new Label();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            panel4 = new Panel();
            button6 = new Button();
            button5 = new Button();
            txtBuscarCl = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
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
            dgvClientes = new DataGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 125);
            panel2.TabIndex = 32;
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
            btnNuevo.Location = new Point(15, 68);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 39);
            btnNuevo.TabIndex = 36;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(15, 24);
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
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(txtBuscarCl);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(1084, 85);
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
            button6.Location = new Point(956, 32);
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
            button5.Location = new Point(863, 31);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(78, 25);
            button5.TabIndex = 50;
            button5.Text = "Excel ";
            button5.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCl
            // 
            txtBuscarCl.Anchor = AnchorStyles.Bottom;
            txtBuscarCl.BackColor = SystemColors.Info;
            txtBuscarCl.Location = new Point(78, 34);
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
            label1.Location = new Point(18, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 45;
            label1.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(dgvClientes);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 351);
            panel3.TabIndex = 34;
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
            panel5.Location = new Point(0, 275);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 76);
            panel5.TabIndex = 36;
            // 
            // txtPagCl
            // 
            txtPagCl.Anchor = AnchorStyles.Right;
            txtPagCl.Location = new Point(925, 16);
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
            label2.Location = new Point(898, 19);
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
            label5.Location = new Point(770, 19);
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
            cmbPagCl.Location = new Point(818, 16);
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
            label8.Location = new Point(29, 19);
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
            cmbMostrarCl.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cmbMostrarCl.Location = new Point(92, 16);
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
            label9.Location = new Point(173, 19);
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
            btnSig.Location = new Point(727, 15);
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
            btnAnt.Location = new Point(691, 15);
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
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.WhiteSmoke;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 222, 73);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 30;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.SteelBlue;
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(1084, 351);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            dgvClientes.CellPainting += dgvClientes_CellPainting;
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
            MinimumSize = new Size(680, 500);
            Name = "CtrlClientes";
            Text = "CtrlClientes";
            Load += CtrlClientes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private DataGridView dgvClientes;
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
    }
}