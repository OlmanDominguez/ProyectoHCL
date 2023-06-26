namespace ProyectoHCL.Formularios
{
    partial class RegistrarObjeto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarObjeto));
            panel2 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            label11 = new Label();
            txtDescripcion = new TextBox();
            txtObjeto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            errorT = new ErrorProvider(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(740, 70);
            panel2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(106, 20);
            label3.Name = "label3";
            label3.Size = new Size(362, 36);
            label3.TabIndex = 16;
            label3.Text = "HOTEL CASA LOMAS";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 450);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(5, 20);
            button1.Name = "button1";
            button1.Size = new Size(49, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(320, 84);
            label11.Name = "label11";
            label11.Size = new Size(198, 32);
            label11.TabIndex = 21;
            label11.Text = "Registrar objetos";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top;
            txtDescripcion.BackColor = SystemColors.MenuHighlight;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(143, 260);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ShortcutsEnabled = false;
            txtDescripcion.Size = new Size(333, 27);
            txtDescripcion.TabIndex = 25;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // txtObjeto
            // 
            txtObjeto.Anchor = AnchorStyles.Top;
            txtObjeto.BackColor = SystemColors.MenuHighlight;
            txtObjeto.BorderStyle = BorderStyle.FixedSingle;
            txtObjeto.CharacterCasing = CharacterCasing.Upper;
            txtObjeto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtObjeto.Location = new Point(143, 176);
            txtObjeto.MaxLength = 15;
            txtObjeto.Name = "txtObjeto";
            txtObjeto.ShortcutsEnabled = false;
            txtObjeto.Size = new Size(333, 27);
            txtObjeto.TabIndex = 24;
            txtObjeto.KeyPress += txtObjeto_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 232);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 23;
            label1.Text = "Descripción del objeto:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(143, 148);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 22;
            label2.Text = "Nombre del objeto:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(494, 338);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(281, 338);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorT
            // 
            errorT.ContainerControl = this;
            // 
            // RegistrarObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtObjeto);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistrarObjeto";
            Text = "RegistrarObjeto";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button button1;
        private Label label11;
        private TextBox txtDescripcion;
        private TextBox txtObjeto;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnGuardar;
        private ErrorProvider errorT;
    }
}