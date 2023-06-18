namespace ProyectoHCL.Formularios
{
    partial class PermisosRoLes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermisosRoLes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            Roles_Permisos_DG = new DataGridView();
            Roles = new DataGridViewTextBoxColumn();
            Nombre_Rol = new DataGridViewTextBoxColumn();
            Estado_Rol = new DataGridViewTextBoxColumn();
            Primer_Ingreso = new DataGridViewTextBoxColumn();
            Fecha_Vencimiento = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewTextBoxColumn();
            BuscadorBox1 = new TextBox();
            Buscar = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            RegistroBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            Excel = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Roles_Permisos_DG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 599);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(7, 33);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(70, 60);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // Roles_Permisos_DG
            // 
            Roles_Permisos_DG.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Roles_Permisos_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Roles_Permisos_DG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Roles_Permisos_DG.Columns.AddRange(new DataGridViewColumn[] { Roles, Nombre_Rol, Estado_Rol, Primer_Ingreso, Fecha_Vencimiento, Editar, Eliminar });
            Roles_Permisos_DG.EnableHeadersVisualStyles = false;
            Roles_Permisos_DG.GridColor = Color.Black;
            Roles_Permisos_DG.Location = new Point(86, 320);
            Roles_Permisos_DG.Name = "Roles_Permisos_DG";
            Roles_Permisos_DG.RowHeadersVisible = false;
            Roles_Permisos_DG.RowHeadersWidth = 62;
            Roles_Permisos_DG.RowTemplate.Height = 33;
            Roles_Permisos_DG.Size = new Size(1203, 276);
            Roles_Permisos_DG.TabIndex = 2;
            // 
            // Roles
            // 
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 192);
            Roles.DefaultCellStyle = dataGridViewCellStyle2;
            Roles.HeaderText = "Codigo";
            Roles.MinimumWidth = 25;
            Roles.Name = "Roles";
            Roles.Width = 300;
            // 
            // Nombre_Rol
            // 
            Nombre_Rol.HeaderText = "Nombre_Rol";
            Nombre_Rol.MinimumWidth = 8;
            Nombre_Rol.Name = "Nombre_Rol";
            Nombre_Rol.Width = 150;
            // 
            // Estado_Rol
            // 
            Estado_Rol.HeaderText = "Estado_Rol";
            Estado_Rol.MinimumWidth = 8;
            Estado_Rol.Name = "Estado_Rol";
            Estado_Rol.Width = 150;
            // 
            // Primer_Ingreso
            // 
            Primer_Ingreso.HeaderText = "Primer_Ingreso";
            Primer_Ingreso.MinimumWidth = 8;
            Primer_Ingreso.Name = "Primer_Ingreso";
            Primer_Ingreso.Width = 150;
            // 
            // Fecha_Vencimiento
            // 
            Fecha_Vencimiento.HeaderText = "Fecha_Vencimiento";
            Fecha_Vencimiento.MinimumWidth = 8;
            Fecha_Vencimiento.Name = "Fecha_Vencimiento";
            Fecha_Vencimiento.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 150;
            // 
            // BuscadorBox1
            // 
            BuscadorBox1.Location = new Point(974, 35);
            BuscadorBox1.Name = "BuscadorBox1";
            BuscadorBox1.Size = new Size(150, 31);
            BuscadorBox1.TabIndex = 3;
            // 
            // Buscar
            // 
            Buscar.AutoSize = true;
            Buscar.BackColor = Color.Transparent;
            Buscar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar.ForeColor = Color.Black;
            Buscar.Location = new Point(868, 29);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(100, 38);
            Buscar.TabIndex = 4;
            Buscar.Text = "Buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(758, 340);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 38);
            label2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1040, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1171, 350);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(699, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // RegistroBox1
            // 
            RegistroBox1.FormattingEnabled = true;
            RegistroBox1.Location = new Point(126, 32);
            RegistroBox1.Name = "RegistroBox1";
            RegistroBox1.Size = new Size(182, 33);
            RegistroBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 29);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 11;
            label1.Text = "Mostrar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(314, 29);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 13;
            label4.Text = "Registro";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(86, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1209, 117);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(151, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(540, 55);
            label3.TabIndex = 16;
            label3.Text = "HOTEL CASA LOMAS";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 5);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 107);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(Excel);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(RegistroBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(Buscar);
            panel3.Controls.Add(BuscadorBox1);
            panel3.Location = new Point(86, 247);
            panel3.Name = "panel3";
            panel3.Size = new Size(1203, 74);
            panel3.TabIndex = 15;
            // 
            // Excel
            // 
            Excel.BackColor = Color.FromArgb(0, 192, 0);
            Excel.ForeColor = SystemColors.ButtonHighlight;
            Excel.Location = new Point(660, 32);
            Excel.Name = "Excel";
            Excel.Size = new Size(112, 34);
            Excel.TabIndex = 15;
            Excel.Text = "Excel ";
            Excel.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(542, 31);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = false;
            // 
            // PermisosRoLes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1295, 599);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(Roles_Permisos_DG);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "PermisosRoLes";
            Text = "PermisosRoLes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Roles_Permisos_DG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView Roles_Permisos_DG;
        private TextBox BuscadorBox1;
        private Label Buscar;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ComboBox RegistroBox1;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox5;
        private Panel panel3;
        private DataGridViewTextBoxColumn Roles;
        private DataGridViewTextBoxColumn Nombre_Rol;
        private DataGridViewTextBoxColumn Estado_Rol;
        private DataGridViewTextBoxColumn Primer_Ingreso;
        private DataGridViewTextBoxColumn Fecha_Vencimiento;
        private DataGridViewTextBoxColumn Editar;
        private DataGridViewTextBoxColumn Eliminar;
        private Button Excel;
        private Button button2;
    }
}