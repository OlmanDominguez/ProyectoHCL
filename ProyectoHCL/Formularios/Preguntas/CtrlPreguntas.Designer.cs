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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label11 = new Label();
            btnCerrarSesion = new Button();
            panel5 = new Panel();
            button10 = new Button();
            button11 = new Button();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            dgvPreguntas = new DataGridView();
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
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 65);
            panel2.TabIndex = 37;
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
            btnNuevo.Location = new Point(29, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 35);
            btnNuevo.TabIndex = 40;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(236, 22);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(252, 23);
            txtBuscar.TabIndex = 44;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(176, 24);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AllowUserToAddRows = false;
            dgvPreguntas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvPreguntas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvPreguntas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.BackgroundColor = Color.WhiteSmoke;
            dgvPreguntas.BorderStyle = BorderStyle.None;
            dgvPreguntas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPreguntas.ColumnHeadersHeight = 30;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPreguntas.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPreguntas.EnableHeadersVisualStyles = false;
            dgvPreguntas.GridColor = Color.FromArgb(45, 66, 91);
            dgvPreguntas.Location = new Point(0, 134);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.SelectionBackColor = Color.CadetBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPreguntas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPreguntas.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = Color.Gainsboro;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvPreguntas.RowTemplate.Height = 25;
            dgvPreguntas.Size = new Size(1084, 354);
            dgvPreguntas.TabIndex = 39;
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
            btnSig.Location = new Point(761, 23);
            btnSig.Name = "btnSig";
            btnSig.Size = new Size(30, 31);
            btnSig.TabIndex = 79;
            btnSig.UseVisualStyleBackColor = false;
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
            btnAnt.Location = new Point(725, 23);
            btnAnt.Name = "btnAnt";
            btnAnt.Size = new Size(30, 31);
            btnAnt.TabIndex = 78;
            btnAnt.UseVisualStyleBackColor = false;
            // 
            // txtPreg
            // 
            txtPreg.Anchor = AnchorStyles.Right;
            txtPreg.Location = new Point(959, 24);
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
            label6.Location = new Point(932, 27);
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
            label7.Location = new Point(804, 27);
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
            label1.Location = new Point(63, 27);
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
            cmbMostrar.Items.AddRange(new object[] { "2", "3", "4", "5", "6" });
            cmbMostrar.Location = new Point(126, 24);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 71;
            // 
            // cmbPreg
            // 
            cmbPreg.Anchor = AnchorStyles.Right;
            cmbPreg.BackColor = SystemColors.Info;
            cmbPreg.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPreg.FormattingEnabled = true;
            cmbPreg.Location = new Point(852, 24);
            cmbPreg.Margin = new Padding(2);
            cmbPreg.Name = "cmbPreg";
            cmbPreg.Size = new Size(65, 23);
            cmbPreg.TabIndex = 73;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(207, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 74;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CtrlPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel1);
            Controls.Add(dgvPreguntas);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Name = "CtrlPreguntas";
            Text = "CtrlPreguntas";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private DataGridView dgvPreguntas;
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
    }
}