﻿namespace ProyectoHCL.Formularios
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
            linkLabelContraseña = new LinkLabel();
            linkLabelPreguntas = new LinkLabel();
            lblcorreo = new Label();
            panel1 = new Panel();
            pbBienvenido = new PictureBox();
            panel6 = new Panel();
            lblemail = new Label();
            lblnom = new Label();
            lblusuario = new Label();
            label1 = new Label();
            bnCerrar = new Button();
            bnMin = new Button();
            panel7 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBienvenido).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
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
            lblbienvenido.Location = new Point(33, 141);
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
            lblnombre.Location = new Point(188, 141);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(100, 32);
            lblnombre.TabIndex = 53;
            lblnombre.Text = "usuario";
            // 
            // linkLabelContraseña
            // 
            linkLabelContraseña.AutoSize = true;
            linkLabelContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelContraseña.LinkColor = Color.Black;
            linkLabelContraseña.Location = new Point(99, 212);
            linkLabelContraseña.Name = "linkLabelContraseña";
            linkLabelContraseña.Size = new Size(164, 21);
            linkLabelContraseña.TabIndex = 54;
            linkLabelContraseña.TabStop = true;
            linkLabelContraseña.Text = "Cambiar Contraseña";
            linkLabelContraseña.LinkClicked += linkLabelContraseña_LinkClicked_1;
            // 
            // linkLabelPreguntas
            // 
            linkLabelPreguntas.AutoSize = true;
            linkLabelPreguntas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelPreguntas.LinkColor = Color.Black;
            linkLabelPreguntas.Location = new Point(59, 233);
            linkLabelPreguntas.Name = "linkLabelPreguntas";
            linkLabelPreguntas.Size = new Size(241, 21);
            linkLabelPreguntas.TabIndex = 56;
            linkLabelPreguntas.TabStop = true;
            linkLabelPreguntas.Text = "Editar Preguntas de Seguridad";
            linkLabelPreguntas.LinkClicked += linkLabelPreguntas_LinkClicked;
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
            panel1.Location = new Point(131, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 194);
            panel1.TabIndex = 58;
            // 
            // pbBienvenido
            // 
            pbBienvenido.Image = (Image)resources.GetObject("pbBienvenido.Image");
            pbBienvenido.Location = new Point(99, 3);
            pbBienvenido.Name = "pbBienvenido";
            pbBienvenido.Size = new Size(137, 135);
            pbBienvenido.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBienvenido.TabIndex = 60;
            pbBienvenido.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblcorreo);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(lblemail);
            panel6.Controls.Add(linkLabelPreguntas);
            panel6.Controls.Add(lblnom);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(lblusuario);
            panel6.Controls.Add(linkLabelContraseña);
            panel6.Location = new Point(131, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(351, 276);
            panel6.TabIndex = 59;
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
            label1.Location = new Point(230, 19);
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
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(45, 66, 91);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(panel6);
            panel7.Controls.Add(panel1);
            panel7.Location = new Point(240, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(597, 557);
            panel7.TabIndex = 56;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(0, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 10);
            panel3.TabIndex = 2;
            // 
            // PerfilUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 558);
            Controls.Add(bnCerrar);
            Controls.Add(bnMin);
            Controls.Add(panel7);
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label label2;
        public Label label4;
        public Label lblcontraseña;
        private Label lblnombre;
        private Label lblbienvenido;
        private LinkLabel linkLabelContraseña;
        private LinkLabel linkLabelPreguntas;
        public Label lblcorreo;
        private Panel panel1;
        private Panel panel6;
        public Label label1;
        private Button bnCerrar;
        private Button bnMin;
        private Panel panel7;
        private Label lblusuario;
        private Label lblnom;
        private Label lblemail;
        private PictureBox pbBienvenido;
        private Panel panel3;
    }
}