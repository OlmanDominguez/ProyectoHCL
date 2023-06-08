namespace ProyectoHCL
{
    partial class RecuContra
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
            label1 = new Label();
            label2 = new Label();
            TXT_Usuario = new TextBox();
            label3 = new Label();
            RBTN_Pregu = new RadioButton();
            RBTN_Email = new RadioButton();
            BTN_Aceptar = new Button();
            BTN_Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(139, 42);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "¿Olvidaste tu Contraseña?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(57, 112);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // TXT_Usuario
            // 
            TXT_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TXT_Usuario.BackColor = Color.DeepSkyBlue;
            TXT_Usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Usuario.Location = new Point(57, 145);
            TXT_Usuario.Margin = new Padding(2);
            TXT_Usuario.Name = "TXT_Usuario";
            TXT_Usuario.Size = new Size(423, 27);
            TXT_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 221);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 4;
            label3.Text = "Metodo:";
            // 
            // RBTN_Pregu
            // 
            RBTN_Pregu.AutoSize = true;
            RBTN_Pregu.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RBTN_Pregu.ForeColor = SystemColors.ButtonHighlight;
            RBTN_Pregu.Location = new Point(62, 254);
            RBTN_Pregu.Name = "RBTN_Pregu";
            RBTN_Pregu.Size = new Size(185, 24);
            RBTN_Pregu.TabIndex = 5;
            RBTN_Pregu.TabStop = true;
            RBTN_Pregu.Text = "Preguntas de Seguridad";
            RBTN_Pregu.UseVisualStyleBackColor = true;
            RBTN_Pregu.CheckedChanged += RBTN_Pregu_CheckedChanged;
            // 
            // RBTN_Email
            // 
            RBTN_Email.AutoSize = true;
            RBTN_Email.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RBTN_Email.ForeColor = SystemColors.ButtonHighlight;
            RBTN_Email.Location = new Point(295, 254);
            RBTN_Email.Name = "RBTN_Email";
            RBTN_Email.Size = new Size(64, 24);
            RBTN_Email.TabIndex = 6;
            RBTN_Email.TabStop = true;
            RBTN_Email.Text = "Email";
            RBTN_Email.UseVisualStyleBackColor = true;
            // 
            // BTN_Aceptar
            // 
            BTN_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Aceptar.BackColor = SystemColors.GradientActiveCaption;
            BTN_Aceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Aceptar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Aceptar.Location = new Point(295, 359);
            BTN_Aceptar.Margin = new Padding(2);
            BTN_Aceptar.Name = "BTN_Aceptar";
            BTN_Aceptar.Size = new Size(185, 33);
            BTN_Aceptar.TabIndex = 8;
            BTN_Aceptar.Text = "Aceptar";
            BTN_Aceptar.UseVisualStyleBackColor = false;
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Cancelar.BackColor = SystemColors.ButtonFace;
            BTN_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Cancelar.Location = new Point(62, 359);
            BTN_Cancelar.Margin = new Padding(2);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(185, 33);
            BTN_Cancelar.TabIndex = 9;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = false;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // RecuContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(529, 450);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Aceptar);
            Controls.Add(RBTN_Email);
            Controls.Add(RBTN_Pregu);
            Controls.Add(label3);
            Controls.Add(TXT_Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecuContra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuContra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXT_Usuario;
        private Label label3;
        private RadioButton RBTN_Pregu;
        private RadioButton RBTN_Email;
        private Button BTN_Aceptar;
        private Button BTN_Cancelar;
    }
}