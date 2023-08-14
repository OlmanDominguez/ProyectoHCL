namespace ProyectoHCL.Formularios
{
    partial class CtrlPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPreguntas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            label11 = new Label();
            btnCerrarSesion = new Button();
            panel5 = new Panel();
            button10 = new Button();
            button11 = new Button();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            btnSig = new Button();
            btnAnt = new Button();
            txtPreg = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            cmbMostrar = new ComboBox();
            cmbPreg = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            dgvPreguntas = new DataGridView();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 65);
            panel2.TabIndex = 37;
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
            btnCerrar.TabIndex = 80;
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
            label11.Size = new Size(311, 32);
            label11.TabIndex = 41;
            label11.Text = "Preguntas de Recuperación";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(6207, 71);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(35, 33);
            btnCerrarSesion.TabIndex = 35;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(button10);
            panel5.Controls.Add(button11);
            panel5.Controls.Add(btnNuevo);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 67);
            panel5.TabIndex = 38;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button10.BackColor = Color.Red;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(963, 22);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(78, 25);
            button10.TabIndex = 57;
            button10.Text = "PDF";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button11.BackColor = Color.FromArgb(0, 192, 0);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(872, 22);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(78, 25);
            button11.TabIndex = 56;
            button11.Text = "Excel ";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
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
            btnNuevo.Location = new Point(29, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(50, 35);
            btnNuevo.TabIndex = 40;
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(171, 22);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(252, 23);
            txtBuscar.TabIndex = 44;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(113, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btnSig);
            panel1.Controls.Add(btnAnt);
            panel1.Controls.Add(txtPreg);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbMostrar);
            panel1.Controls.Add(cmbPreg);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 485);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 76);
            panel1.TabIndex = 40;
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
            btnSig.TabIndex = 79;
            btnSig.UseVisualStyleBackColor = false;
            btnSig.Click += btnSig_Click_1;
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
            btnAnt.TabIndex = 78;
            btnAnt.UseVisualStyleBackColor = false;
            btnAnt.Click += btnAnt_Click_1;
            // 
            // txtPreg
            // 
            txtPreg.Anchor = AnchorStyles.Right;
            txtPreg.Location = new Point(979, 20);
            txtPreg.Name = "txtPreg";
            txtPreg.ReadOnly = true;
            txtPreg.Size = new Size(63, 23);
            txtPreg.TabIndex = 77;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(952, 23);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 76;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(824, 23);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 75;
            label7.Text = "Página";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(27, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 72;
            label1.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "5", "10", "20", "30", "40" });
            cmbMostrar.Location = new Point(90, 17);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 71;
            cmbMostrar.SelectedIndexChanged += cmbMostrar_SelectedIndexChanged_1;
            // 
            // cmbPreg
            // 
            cmbPreg.Anchor = AnchorStyles.Right;
            cmbPreg.BackColor = SystemColors.Info;
            cmbPreg.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreg.FormattingEnabled = true;
            cmbPreg.Location = new Point(872, 20);
            cmbPreg.Margin = new Padding(2);
            cmbPreg.Name = "cmbPreg";
            cmbPreg.Size = new Size(65, 23);
            cmbPreg.TabIndex = 73;
            cmbPreg.SelectionChangeCommitted += cmbPreg_SelectionChangeCommitted_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(171, 20);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 74;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(dgvPreguntas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 353);
            panel3.TabIndex = 42;
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToDeleteRows = false;
            dgvPreguntas.AllowUserToResizeColumns = false;
            dgvPreguntas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvPreguntas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPreguntas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.BackgroundColor = Color.WhiteSmoke;
            dgvPreguntas.BorderStyle = BorderStyle.None;
            dgvPreguntas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPreguntas.ColumnHeadersHeight = 30;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPreguntas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPreguntas.EnableHeadersVisualStyles = false;
            dgvPreguntas.GridColor = Color.FromArgb(45, 66, 91);
            dgvPreguntas.Location = new Point(27, 6);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPreguntas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPreguntas.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPreguntas.RowTemplate.Height = 25;
            dgvPreguntas.Size = new Size(1027, 341);
            dgvPreguntas.TabIndex = 4;
            dgvPreguntas.CellClick += dgvPreguntas_CellClick_1;
            dgvPreguntas.CellPainting += dgvPreguntas_CellPainting;
            // 
            // CtrlPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CtrlPreguntas";
            Text = "CtrlPreguntas";
            Load += CtrlPreguntas_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label11;
        private Button btnCerrarSesion;
        private Panel panel5;
        private Button button10;
        private Button button11;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label label4;
        private Panel panel1;
        private Button btnSig;
        private Button btnAnt;
        private TextBox txtPreg;
        private Label label6;
        private Label label7;
        private Label label1;
        private ComboBox cmbMostrar;
        private ComboBox cmbPreg;
        private Label label3;
        private Panel panel3;
        private DataGridView dgvPreguntas;
        private Button btnCerrar;
    }
}