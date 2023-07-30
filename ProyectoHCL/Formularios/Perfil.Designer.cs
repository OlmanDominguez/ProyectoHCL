namespace ProyectoHCL.Formularios
{
    partial class Frm_Perfiles
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
            Btn_EditPerfil = new Button();
            Btn_PolPrivacidad = new Button();
            Btn_FactElim = new Button();
            Btn_MisVentas = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LBL2_ITEC = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Btn_EditPerfil
            // 
            Btn_EditPerfil.Location = new Point(228, 157);
            Btn_EditPerfil.Name = "Btn_EditPerfil";
            Btn_EditPerfil.Size = new Size(75, 23);
            Btn_EditPerfil.TabIndex = 0;
            Btn_EditPerfil.Text = "Editar Perfil";
            Btn_EditPerfil.UseVisualStyleBackColor = true;
            // 
            // Btn_PolPrivacidad
            // 
            Btn_PolPrivacidad.Location = new Point(302, 272);
            Btn_PolPrivacidad.Name = "Btn_PolPrivacidad";
            Btn_PolPrivacidad.Size = new Size(123, 23);
            Btn_PolPrivacidad.TabIndex = 1;
            Btn_PolPrivacidad.Text = "Privacidad Politicas";
            Btn_PolPrivacidad.UseVisualStyleBackColor = true;
            // 
            // Btn_FactElim
            // 
            Btn_FactElim.Location = new Point(182, 377);
            Btn_FactElim.Name = "Btn_FactElim";
            Btn_FactElim.Size = new Size(121, 23);
            Btn_FactElim.TabIndex = 2;
            Btn_FactElim.Text = "Facturas Eliminadas";
            Btn_FactElim.UseVisualStyleBackColor = true;
            // 
            // Btn_MisVentas
            // 
            Btn_MisVentas.Location = new Point(479, 377);
            Btn_MisVentas.Name = "Btn_MisVentas";
            Btn_MisVentas.Size = new Size(75, 23);
            Btn_MisVentas.TabIndex = 3;
            Btn_MisVentas.Text = "Mis Ventas";
            Btn_MisVentas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(228, 118);
            label1.Name = "label1";
            label1.Size = new Size(112, 16);
            label1.TabIndex = 4;
            label1.Text = "Detalles del Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(212, 192);
            label2.Name = "label2";
            label2.Size = new Size(114, 16);
            label2.TabIndex = 5;
            label2.Text = "Direccion de correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(338, 318);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 6;
            label3.Text = "Micelanea";
            // 
            // LBL2_ITEC
            // 
            LBL2_ITEC.AutoSize = true;
            LBL2_ITEC.BackColor = Color.Transparent;
            LBL2_ITEC.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBL2_ITEC.ForeColor = SystemColors.ControlLightLight;
            LBL2_ITEC.Location = new Point(302, 72);
            LBL2_ITEC.Name = "LBL2_ITEC";
            LBL2_ITEC.Size = new Size(32, 16);
            LBL2_ITEC.TabIndex = 7;
            LBL2_ITEC.Text = "ITEC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(212, 213);
            label5.Name = "label5";
            label5.Size = new Size(124, 16);
            label5.TabIndex = 8;
            label5.Text = "andres.osorto@hcl.hn";
            // 
            // Frm_Perfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(716, 441);
            Controls.Add(label5);
            Controls.Add(LBL2_ITEC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_MisVentas);
            Controls.Add(Btn_FactElim);
            Controls.Add(Btn_PolPrivacidad);
            Controls.Add(Btn_EditPerfil);
            Name = "Frm_Perfiles";
            Text = "Perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_EditPerfil;
        private Button Btn_PolPrivacidad;
        private Button Btn_FactElim;
        private Button Btn_MisVentas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LBL2_ITEC;
        private Label label5;
    }
}