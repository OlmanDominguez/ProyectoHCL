namespace ProyectoHCL.Formularios
{
    partial class Nuevo_Registro_Rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Registro_Rol));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            Cancelar = new Button();
            Guardar = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            Crear_Rol_dataGridView1 = new DataGridView();
            ID_Rol = new DataGridViewTextBoxColumn();
            Objeto = new DataGridViewTextBoxColumn();
            Insertar = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewTextBoxColumn();
            Actualizar = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Crear_Rol_dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(130, 309);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.Red;
            Cancelar.Location = new Point(140, 385);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 34);
            Cancelar.TabIndex = 2;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += button1_Click;
            // 
            // Guardar
            // 
            Guardar.BackColor = Color.LimeGreen;
            Guardar.Location = new Point(140, 437);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(112, 34);
            Guardar.TabIndex = 3;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 585);
            panel1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(86, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 117);
            panel2.TabIndex = 15;
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
            // Crear_Rol_dataGridView1
            // 
            Crear_Rol_dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Crear_Rol_dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Crear_Rol_dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Crear_Rol_dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Rol, Objeto, Insertar, Ver, Actualizar, Eliminar });
            Crear_Rol_dataGridView1.EnableHeadersVisualStyles = false;
            Crear_Rol_dataGridView1.GridColor = Color.Black;
            Crear_Rol_dataGridView1.Location = new Point(365, 309);
            Crear_Rol_dataGridView1.Name = "Crear_Rol_dataGridView1";
            Crear_Rol_dataGridView1.RowHeadersVisible = false;
            Crear_Rol_dataGridView1.RowHeadersWidth = 62;
            Crear_Rol_dataGridView1.RowTemplate.Height = 33;
            Crear_Rol_dataGridView1.Size = new Size(906, 276);
            Crear_Rol_dataGridView1.TabIndex = 16;
            // 
            // ID_Rol
            // 
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 192);
            ID_Rol.DefaultCellStyle = dataGridViewCellStyle2;
            ID_Rol.HeaderText = "ID_Rol";
            ID_Rol.MinimumWidth = 8;
            ID_Rol.Name = "ID_Rol";
            ID_Rol.Width = 150;
            // 
            // Objeto
            // 
            Objeto.HeaderText = "Objeto";
            Objeto.MinimumWidth = 8;
            Objeto.Name = "Objeto";
            Objeto.Width = 150;
            // 
            // Insertar
            // 
            Insertar.HeaderText = "Insertar";
            Insertar.MinimumWidth = 8;
            Insertar.Name = "Insertar";
            Insertar.Width = 150;
            // 
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.MinimumWidth = 8;
            Ver.Name = "Ver";
            Ver.Width = 150;
            // 
            // Actualizar
            // 
            Actualizar.HeaderText = "Actualizar";
            Actualizar.MinimumWidth = 8;
            Actualizar.Name = "Actualizar";
            Actualizar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 150;
            // 
            // Nuevo_Registro_Rol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1271, 585);
            Controls.Add(Crear_Rol_dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Guardar);
            Controls.Add(Cancelar);
            Controls.Add(textBox1);
            Name = "Nuevo_Registro_Rol";
            Text = "Nuevo_Registro_Rol";
            Load += NuevoFormulario_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Crear_Rol_dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button Cancelar;
        private Button Guardar;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox5;
        private DataGridView Crear_Rol_dataGridView1;
        private DataGridViewTextBoxColumn ID_Rol;
        private DataGridViewTextBoxColumn Objeto;
        private DataGridViewTextBoxColumn Insertar;
        private DataGridViewTextBoxColumn Ver;
        private DataGridViewTextBoxColumn Actualizar;
        private DataGridViewTextBoxColumn Eliminar;
    }
}