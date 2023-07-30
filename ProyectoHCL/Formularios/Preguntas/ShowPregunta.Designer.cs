namespace ProyectoHCL.Formularios.Preguntas
{
    partial class ShowPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPregunta));
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            btnCerrar = new Button();
            label11 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtPregunta = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
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
            panel2.Size = new Size(775, 73);
            panel2.TabIndex = 21;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(25, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 60;
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
            btnCerrar.Location = new Point(739, 12);
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
            label11.Location = new Point(293, 18);
            label11.Name = "label11";
            label11.Size = new Size(181, 30);
            label11.TabIndex = 28;
            label11.Text = "Detalle Pregunta";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPregunta);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 281);
            panel1.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(447, 182);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 59;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(235, 182);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 32);
            btnGuardar.TabIndex = 58;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtPregunta
            // 
            txtPregunta.Anchor = AnchorStyles.Top;
            txtPregunta.BackColor = Color.DarkGray;
            txtPregunta.BorderStyle = BorderStyle.FixedSingle;
            txtPregunta.CharacterCasing = CharacterCasing.Upper;
            txtPregunta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPregunta.Location = new Point(154, 92);
            txtPregunta.MaxLength = 15;
            txtPregunta.Name = "txtPregunta";
            txtPregunta.ShortcutsEnabled = false;
            txtPregunta.Size = new Size(446, 27);
            txtPregunta.TabIndex = 52;
            // 
            // ShowPregunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 354);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowPregunta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowPregunta";
            Load += ShowPregunta_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox5;
        private Button btnCerrar;
        private Label label11;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        public TextBox txtPregunta;
    }
}