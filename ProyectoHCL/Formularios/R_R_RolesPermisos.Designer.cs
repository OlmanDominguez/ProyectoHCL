namespace ProyectoHCL.Formularios
{
    partial class R_R_RolesPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_R_RolesPermisos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnCerrar = new Button();
            lblTitulo = new Label();
            panel5 = new Panel();
            label1 = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            cmbRol = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            rBtnDeshabilitar = new RadioButton();
            rbtnHabilitar = new RadioButton();
            label3 = new Label();
            dgvRolPermiso = new DataGridView();
            label13 = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolPermiso).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(lblTitulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 73);
            panel2.TabIndex = 36;
            panel2.MouseMove += panel2_MouseMove;
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
            btnCerrar.Location = new Point(1074, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 43;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 32);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Registrar Permisos";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnNuevo);
            panel5.Controls.Add(btnEditar);
            panel5.Controls.Add(cmbRol);
            panel5.Controls.Add(btnCancelar);
            panel5.Controls.Add(btnGuardar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(1100, 59);
            panel5.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(35, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 44;
            label1.Text = "Rol:";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.RoyalBlue;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(436, 13);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(48, 35);
            btnNuevo.TabIndex = 41;
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Visible = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSeaGreen;
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(436, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(48, 35);
            btnEditar.TabIndex = 72;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(79, 16);
            cmbRol.Margin = new Padding(2);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(303, 28);
            cmbRol.TabIndex = 71;
            cmbRol.SelectedValueChanged += cmbRol_SelectedValueChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(974, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 70;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(854, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 69;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 38;
            label2.Text = "Rol:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 66, 91);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 569);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1100, 31);
            panel3.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(dgvRolPermiso);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 437);
            panel1.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(rBtnDeshabilitar);
            panel4.Controls.Add(rbtnHabilitar);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1100, 36);
            panel4.TabIndex = 38;
            // 
            // rBtnDeshabilitar
            // 
            rBtnDeshabilitar.AutoSize = true;
            rBtnDeshabilitar.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 0, 192);
            rBtnDeshabilitar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnDeshabilitar.Location = new Point(123, 7);
            rBtnDeshabilitar.Name = "rBtnDeshabilitar";
            rBtnDeshabilitar.Size = new Size(99, 23);
            rBtnDeshabilitar.TabIndex = 75;
            rBtnDeshabilitar.Text = "Deshabilitar";
            rBtnDeshabilitar.UseVisualStyleBackColor = true;
            rBtnDeshabilitar.CheckedChanged += rBtnDeshabilitar_CheckedChanged;
            // 
            // rbtnHabilitar
            // 
            rbtnHabilitar.AutoSize = true;
            rbtnHabilitar.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 0, 192);
            rbtnHabilitar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnHabilitar.Location = new Point(39, 7);
            rbtnHabilitar.Name = "rbtnHabilitar";
            rbtnHabilitar.Size = new Size(78, 23);
            rbtnHabilitar.TabIndex = 74;
            rbtnHabilitar.Text = "Habilitar";
            rbtnHabilitar.UseVisualStyleBackColor = true;
            rbtnHabilitar.CheckedChanged += rbtnHabilitar_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(479, 8);
            label3.Name = "label3";
            label3.Size = new Size(170, 19);
            label3.TabIndex = 73;
            label3.Text = "Listado de Permisos";
            // 
            // dgvRolPermiso
            // 
            dgvRolPermiso.AllowUserToAddRows = false;
            dgvRolPermiso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvRolPermiso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRolPermiso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRolPermiso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRolPermiso.BackgroundColor = Color.WhiteSmoke;
            dgvRolPermiso.BorderStyle = BorderStyle.None;
            dgvRolPermiso.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRolPermiso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRolPermiso.ColumnHeadersHeight = 30;
            dgvRolPermiso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRolPermiso.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRolPermiso.EnableHeadersVisualStyles = false;
            dgvRolPermiso.GridColor = Color.FromArgb(45, 66, 91);
            dgvRolPermiso.Location = new Point(35, 41);
            dgvRolPermiso.Margin = new Padding(2);
            dgvRolPermiso.Name = "dgvRolPermiso";
            dgvRolPermiso.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRolPermiso.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRolPermiso.RowHeadersVisible = false;
            dgvRolPermiso.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvRolPermiso.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRolPermiso.RowTemplate.Height = 25;
            dgvRolPermiso.Size = new Size(1027, 388);
            dgvRolPermiso.TabIndex = 5;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(481, 8);
            label13.Name = "label13";
            label13.Size = new Size(157, 19);
            label13.TabIndex = 38;
            label13.Text = "Listado de Permisos";
            // 
            // R_R_RolesPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "R_R_RolesPermisos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RolesPermisos";
            FormClosing += R_R_RolesPermisos_FormClosing;
            Load += RolesPermisos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolPermiso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTitulo;
        private Panel panel5;
        public Label label2;
        private Panel panel3;
        public Button btnCancelar;
        public Button btnGuardar;
        private Panel panel1;
        private Button btnCerrar;
        private Panel panel4;
        public Label label13;
        public Button btnEditar;
        public DataGridView dgvRolPermiso;
        public ComboBox cmbRol;
        public Button btnNuevo;
        private Label label1;
        private Label label3;
        private RadioButton rBtnDeshabilitar;
        private RadioButton rbtnHabilitar;
    }
}