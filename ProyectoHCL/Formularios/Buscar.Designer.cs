namespace ProyectoHCL
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            lbl_titulo = new Label();
            btnCerrar = new Button();
            panel3 = new Panel();
            dgv_clientes = new DataGridView();
            txtBuscar_Por_Nombre = new TextBox();
            label4 = new Label();
            btn_guardar2 = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lbl_titulo);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 73);
            panel2.TabIndex = 52;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.Location = new Point(139, 30);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(83, 30);
            lbl_titulo.TabIndex = 19;
            lbl_titulo.Text = "Buscar ";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(778, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 33;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(dgv_clientes);
            panel3.Controls.Add(txtBuscar_Por_Nombre);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(btn_guardar2);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(815, 450);
            panel3.TabIndex = 53;
            // 
            // dgv_clientes
            // 
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_clientes.BackgroundColor = Color.WhiteSmoke;
            dgv_clientes.BorderStyle = BorderStyle.None;
            dgv_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_clientes.ColumnHeadersHeight = 30;
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_clientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_clientes.EnableHeadersVisualStyles = false;
            dgv_clientes.GridColor = Color.FromArgb(45, 66, 91);
            dgv_clientes.Location = new Point(12, 76);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_clientes.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgv_clientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(791, 362);
            dgv_clientes.TabIndex = 84;
            dgv_clientes.CellClick += dgv_clientes_CellClick;
            dgv_clientes.CellPainting += dgv_clientes_CellPainting;
            // 
            // txtBuscar_Por_Nombre
            // 
            txtBuscar_Por_Nombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar_Por_Nombre.BackColor = SystemColors.Info;
            txtBuscar_Por_Nombre.Location = new Point(129, 29);
            txtBuscar_Por_Nombre.Margin = new Padding(2);
            txtBuscar_Por_Nombre.Name = "txtBuscar_Por_Nombre";
            txtBuscar_Por_Nombre.Size = new Size(252, 23);
            txtBuscar_Por_Nombre.TabIndex = 78;
            txtBuscar_Por_Nombre.TextChanged += txtBuscar_reservas_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 79;
            label4.Text = "Buscar Cliente";
            // 
            // btn_guardar2
            // 
            btn_guardar2.Anchor = AnchorStyles.Top;
            btn_guardar2.BackColor = Color.Green;
            btn_guardar2.FlatAppearance.BorderSize = 0;
            btn_guardar2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btn_guardar2.FlatStyle = FlatStyle.Flat;
            btn_guardar2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar2.ForeColor = Color.White;
            btn_guardar2.Location = new Point(1052, 478);
            btn_guardar2.Name = "btn_guardar2";
            btn_guardar2.Size = new Size(82, 32);
            btn_guardar2.TabIndex = 77;
            btn_guardar2.Text = "Guardar";
            btn_guardar2.UseVisualStyleBackColor = false;
            btn_guardar2.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1140, 478);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1052, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 523);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Buscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar";
            Load += Buscar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox5;
        private Panel panel2;
        public Label lbl_titulo;
        private Button btnCerrar;
        public Panel panel3;
        public Button btn_guardar2;
        public Button btnCancelar;
        public Button btnGuardar;
        public TextBox txtBuscar_Por_Nombre;
        private Label label4;
        public DataGridView dgv_clientes;
    }
}