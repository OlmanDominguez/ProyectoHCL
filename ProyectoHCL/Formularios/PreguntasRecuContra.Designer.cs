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
            BTN_Cancelar = new Button();
            BTN_Aceptar = new Button();
            SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Cancelar.BackColor = SystemColors.ButtonFace;
            BTN_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Cancelar.Location = new Point(43, 318);
            BTN_Cancelar.Margin = new Padding(2);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(185, 33);
            BTN_Cancelar.TabIndex = 11;
            BTN_Cancelar.Text = "Cancelar";
            BTN_Cancelar.UseVisualStyleBackColor = false;
            // 
            // BTN_Aceptar
            // 
            BTN_Aceptar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Aceptar.BackColor = SystemColors.GradientActiveCaption;
            BTN_Aceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Aceptar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Aceptar.Location = new Point(276, 318);
            BTN_Aceptar.Margin = new Padding(2);
            BTN_Aceptar.Name = "BTN_Aceptar";
            BTN_Aceptar.Size = new Size(185, 33);
            BTN_Aceptar.TabIndex = 10;
            BTN_Aceptar.Text = "Aceptar";
            BTN_Aceptar.UseVisualStyleBackColor = false;
            // 
            // PreguntasRecuContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(513, 411);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Aceptar);
            Name = "PreguntasRecuContra";
            Text = "PreguntasRecuContra";
            ResumeLayout(false);
        }

        #endregion

        private Button BTN_Cancelar;
        private Button BTN_Aceptar;
    }
}