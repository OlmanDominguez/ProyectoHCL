namespace ProyectoHCL.Formularios.Clientes
{
    partial class EliminarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCliente));
            BTN_Cancelar = new Button();
            BTN_Aceptar = new Button();
            btnExit = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Cancelar.BackColor = SystemColors.ButtonFace;
            BTN_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Cancelar.Location = new Point(291, 141);
            BTN_Cancelar.Margin = new Padding(2);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(185, 33);
            BTN_Cancelar.TabIndex = 36;
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
            BTN_Aceptar.Location = new Point(44, 141);
            BTN_Aceptar.Margin = new Padding(2);
            BTN_Aceptar.Name = "BTN_Aceptar";
            BTN_Aceptar.Size = new Size(185, 33);
            BTN_Aceptar.TabIndex = 35;
            BTN_Aceptar.Text = "Aceptar";
            BTN_Aceptar.UseVisualStyleBackColor = false;
            BTN_Aceptar.Click += BTN_Aceptar_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(495, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 18);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 34;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(98, 55);
            label1.Name = "label1";
            label1.Size = new Size(336, 25);
            label1.TabIndex = 37;
            label1.Text = "¿Seguro que desea eliminar el cliente?";
            // 
            // EliminarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(527, 192);
            Controls.Add(label1);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Aceptar);
            Controls.Add(btnExit);
            Name = "EliminarCliente";
            Text = "EliminarCliente";
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Cancelar;
        private Button BTN_Aceptar;
        private PictureBox btnExit;
        private Label label1;
    }
}