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
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            txtBuscarRe = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            dgvReservas = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 67);
            panel2.TabIndex = 20;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
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
            label11.Location = new Point(412, 19);
            label11.Name = "label11";
            label11.Size = new Size(154, 30);
            label11.TabIndex = 28;
            label11.Text = "Nueva Factura";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txtBuscarRe);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 341);
            panel1.TabIndex = 21;
            // 
            // txtBuscarRe
            // 
            txtBuscarRe.Anchor = AnchorStyles.Bottom;
            txtBuscarRe.BackColor = SystemColors.Info;
            txtBuscarRe.Location = new Point(75, 22);
            txtBuscarRe.Margin = new Padding(2);
            txtBuscarRe.Name = "txtBuscarRe";
            txtBuscarRe.Size = new Size(247, 23);
            txtBuscarRe.TabIndex = 46;
            txtBuscarRe.KeyDown += txtBuscarRe_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(15, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 47;
            label1.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(dgvReservas);
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 255);
            panel3.TabIndex = 0;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.AllowUserToResizeColumns = false;
            dgvReservas.AllowUserToResizeRows = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservas.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvReservas.BorderStyle = BorderStyle.None;
            dgvReservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 222, 73);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservas.ColumnHeadersHeight = 30;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservas.Dock = DockStyle.Fill;
            dgvReservas.EnableHeadersVisualStyles = false;
            dgvReservas.GridColor = Color.SteelBlue;
            dgvReservas.Location = new Point(0, 0);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvReservas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReservas.RowTemplate.Height = 25;
            dgvReservas.Size = new Size(1000, 255);
            dgvReservas.TabIndex = 2;
            dgvReservas.CellClick += dgvReservas_CellClick;
            dgvReservas.CellPainting += dgvReservas_CellPainting;
            // 
            // NuevaFact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 42, 65);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 408);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PictureBox pictureBox5;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvReservas;
        private TextBox txtBuscarRe;
        private Label label1;
    }
}