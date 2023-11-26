namespace ProyectoHCL.Formularios
{
    partial class PerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilUsuario));
            label2 = new Label();
            label4 = new Label();
            lblbienvenido = new Label();
            lblnombre = new Label();
            lblcorreo = new Label();
            panel1 = new Panel();
            pbBienvenido = new PictureBox();
            panel6 = new Panel();
            txtcontra = new Button();
            txtpreguntas = new Button();
            lblemail = new Label();
            lblnom = new Label();
            lblusuario = new Label();
            label1 = new Label();
            bnCerrar = new Button();
            bnMin = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBienvenido).BeginInit();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 11;
            label2.Text = "Usuario:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 64);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 13;
            label4.Text = "Nombre:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblbienvenido
            // 
            lblbienvenido.AutoSize = true;
            lblbienvenido.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblbienvenido.ForeColor = Color.White;
            lblbienvenido.Location = new Point(28, 123);
            lblbienvenido.Name = "lblbienvenido";
            lblbienvenido.Size = new Size(161, 32);
            lblbienvenido.TabIndex = 52;
            lblbienvenido.Text = "BIENVENIDO";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.ForeColor = Color.White;
            lblnombre.Location = new Point(195, 123);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(100, 32);
            lblnombre.TabIndex = 53;
            lblnombre.Text = "usuario";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.BackColor = Color.Transparent;
            lblcorreo.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcorreo.ForeColor = Color.White;
            lblcorreo.Location = new Point(3, 134);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(79, 25);
            lblcorreo.TabIndex = 57;
            lblcorreo.Text = "Correo:";
            lblcorreo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbBienvenido);
            panel1.Controls.Add(lblbienvenido);
            panel1.Controls.Add(lblnombre);
            panel1.Location = new Point(106, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 194);
            panel1.TabIndex = 58;
            // 
            // pbBienvenido
            // 
            pbBienvenido.Image = (Image)resources.GetObject("pbBienvenido.Image");
            pbBienvenido.Location = new Point(114, 3);
            pbBienvenido.Name = "pbBienvenido";
            pbBienvenido.Size = new Size(123, 117);
            pbBienvenido.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBienvenido.TabIndex = 60;
            pbBienvenido.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtcontra);
            panel6.Controls.Add(txtpreguntas);
            panel6.Controls.Add(lblcorreo);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lblemail);
            panel6.Controls.Add(lblnom);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(lblusuario);
            panel6.Location = new Point(101, 254);
            panel6.Name = "panel6";
            panel6.Size = new Size(351, 276);
            panel6.TabIndex = 59;
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.Gainsboro;
            txtcontra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontra.Location = new Point(3, 221);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(165, 52);
            txtcontra.TabIndex = 67;
            txtcontra.Text = "Cambiar Contraseña";
            txtcontra.UseVisualStyleBackColor = false;
            txtcontra.Click += txtcontra_Click;
            // 
            // txtpreguntas
            // 
            txtpreguntas.BackColor = Color.Gainsboro;
            txtpreguntas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpreguntas.ForeColor = Color.Black;
            txtpreguntas.Location = new Point(183, 221);
            txtpreguntas.Name = "txtpreguntas";
            txtpreguntas.Size = new Size(165, 52);
            txtpreguntas.TabIndex = 68;
            txtpreguntas.Text = "Editar preguntas de seguridad";
            txtpreguntas.UseVisualStyleBackColor = false;
            txtpreguntas.Click += txtpreguntas_Click;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblemail.ForeColor = Color.White;
            lblemail.Location = new Point(3, 159);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(63, 25);
            lblemail.TabIndex = 68;
            lblemail.Text = "label6";
            // 
            // lblnom
            // 
            lblnom.AutoSize = true;
            lblnom.Font = new Font("Ebrima", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnom.ForeColor = Color.White;
            lblnom.Location = new Point(3, 89);
            lblnom.Name = "lblnom";
            lblnom.Size = new Size(63, 25);
            lblnom.TabIndex = 67;
            lblnom.Text = "label5";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Ebrima", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(3, 26);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(63, 25);
            lblusuario.TabIndex = 66;
            lblusuario.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ebrima", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 58;
            label1.Text = "Perfil Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bnCerrar
            // 
            bnCerrar.BackColor = Color.Transparent;
            bnCerrar.BackgroundImage = (Image)resources.GetObject("bnCerrar.BackgroundImage");
            bnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            bnCerrar.FlatAppearance.BorderSize = 0;
            bnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            bnCerrar.FlatStyle = FlatStyle.Flat;
            bnCerrar.Location = new Point(1068, 3);
            bnCerrar.Name = "bnCerrar";
            bnCerrar.Size = new Size(14, 17);
            bnCerrar.TabIndex = 60;
            bnCerrar.UseVisualStyleBackColor = false;
            bnCerrar.Click += bnCerrar_Click;
            // 
            // bnMin
            // 
            bnMin.BackColor = Color.Transparent;
            bnMin.BackgroundImage = (Image)resources.GetObject("bnMin.BackgroundImage");
            bnMin.BackgroundImageLayout = ImageLayout.Stretch;
            bnMin.FlatAppearance.BorderSize = 0;
            bnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            bnMin.FlatStyle = FlatStyle.Flat;
            bnMin.Location = new Point(1043, 0);
            bnMin.Name = "bnMin";
            bnMin.Size = new Size(19, 20);
            bnMin.TabIndex = 65;
            bnMin.UseVisualStyleBackColor = false;
            bnMin.Click += bnMin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(286, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 543);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            // 
            // PerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1084, 558);
            Controls.Add(groupBox1);
            Controls.Add(bnCerrar);
            Controls.Add(bnMin);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1386, 788);
            Name = "PerfilUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "isuañ";
            Load += PerfilUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBienvenido).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label label2;
        public Label label4;
        public Label lblcontraseña;
        private Label lblnombre;
        private Label lblbienvenido;
        public Label lblcorreo;
        private Panel panel1;
        private Panel panel6;
        public Label label1;
        private Button bnCerrar;
        private Button bnMin;
        private Label lblusuario;
        private Label lblnom;
        private Label lblemail;
        private PictureBox pbBienvenido;
        private GroupBox groupBox1;
        private Button txtcontra;
        private Button txtpreguntas;
    }
}