namespace ProyectoHCL.Formularios
{
    partial class PreguntasRecuContra
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
            BTN_Cancelar = new Button();
            BTN_Aceptar = new Button();
            TXT_Respuesta = new TextBox();
            COBPREG = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Cancelar.BackColor = SystemColors.ButtonFace;
            BTN_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Cancelar.Location = new Point(276, 318);
            BTN_Cancelar.Margin = new Padding(2);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(185, 33);
            BTN_Cancelar.TabIndex = 11;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = false;
            BTN_Cancelar.Click += BTN_Cancelar_Click;
            // 
            // BTN_Aceptar
            // 
            BTN_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Aceptar.BackColor = SystemColors.GradientActiveCaption;
            BTN_Aceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Aceptar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Aceptar.Location = new Point(45, 318);
            BTN_Aceptar.Margin = new Padding(2);
            BTN_Aceptar.Name = "BTN_Aceptar";
            BTN_Aceptar.Size = new Size(185, 33);
            BTN_Aceptar.TabIndex = 10;
            BTN_Aceptar.Text = "Aceptar";
            BTN_Aceptar.UseVisualStyleBackColor = false;
            BTN_Aceptar.Click += BTN_Aceptar_Click;
            // 
            // TXT_Respuesta
            // 
            TXT_Respuesta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TXT_Respuesta.BackColor = Color.DeepSkyBlue;
            TXT_Respuesta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Respuesta.Location = new Point(45, 231);
            TXT_Respuesta.Margin = new Padding(2);
            TXT_Respuesta.Name = "TXT_Respuesta";
            TXT_Respuesta.Size = new Size(423, 27);
            TXT_Respuesta.TabIndex = 12;
            TXT_Respuesta.TextChanged += TXT_Respuesta_TextChanged;
            // 
            // COBPREG
            // 
            COBPREG.DropDownStyle = ComboBoxStyle.DropDownList;
            COBPREG.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            COBPREG.FormattingEnabled = true;
            COBPREG.Location = new Point(45, 151);
            COBPREG.Name = "COBPREG";
            COBPREG.Size = new Size(423, 28);
            COBPREG.TabIndex = 13;
            COBPREG.KeyPress += COBPREG_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 36);
            label1.Name = "label1";
            label1.Size = new Size(418, 54);
            label1.TabIndex = 14;
            label1.Text = "Responde a una de tus preguntas de seguridad para restablecer tu contraseña.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(45, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 15;
            label2.Text = "Pregunta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(45, 203);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 16;
            label3.Text = "Respuesta:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PreguntasRecuContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(513, 411);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(COBPREG);
            Controls.Add(TXT_Respuesta);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Aceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PreguntasRecuContra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PreguntasRecuContra";
            Load += PreguntasRecuContra_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Cancelar;
        private Button BTN_Aceptar;
        private TextBox TXT_Respuesta;
        private ComboBox COBPREG;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}