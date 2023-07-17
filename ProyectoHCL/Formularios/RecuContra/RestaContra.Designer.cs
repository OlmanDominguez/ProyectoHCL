namespace ProyectoHCL.Formularios
{
    partial class RestaContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaContra));
            label1 = new Label();
            TXT_Contra = new TextBox();
            TXT_Confi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BTN_Cancelar = new Button();
            BTN_Aceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            MostrarBox3 = new PictureBox();
            OcultarBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 40);
            label1.Name = "label1";
            label1.Size = new Size(418, 33);
            label1.TabIndex = 15;
            label1.Text = "Cambiar Contraseña";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TXT_Contra
            // 
            TXT_Contra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TXT_Contra.BackColor = Color.DeepSkyBlue;
            TXT_Contra.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Contra.Location = new Point(31, 121);
            TXT_Contra.Margin = new Padding(2);
            TXT_Contra.Name = "TXT_Contra";
            TXT_Contra.Size = new Size(423, 27);
            TXT_Contra.TabIndex = 16;
            TXT_Contra.KeyPress += TXT_Contra_KeyPress;
            // 
            // TXT_Confi
            // 
            TXT_Confi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TXT_Confi.BackColor = Color.DeepSkyBlue;
            TXT_Confi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TXT_Confi.Location = new Point(31, 199);
            TXT_Confi.Margin = new Padding(2);
            TXT_Confi.Name = "TXT_Confi";
            TXT_Confi.Size = new Size(423, 27);
            TXT_Confi.TabIndex = 17;
            TXT_Confi.TextChanged += TXT_Confi_TextChanged;
            TXT_Confi.KeyPress += TXT_Confi_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 18;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 176);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 19;
            label3.Text = "Confirmar Contraseña:";
            // 
            // BTN_Cancelar
            // 
            BTN_Cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_Cancelar.BackColor = SystemColors.ButtonFace;
            BTN_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_Cancelar.ForeColor = SystemColors.ActiveCaptionText;
            BTN_Cancelar.Location = new Point(269, 290);
            BTN_Cancelar.Margin = new Padding(2);
            BTN_Cancelar.Name = "BTN_Cancelar";
            BTN_Cancelar.Size = new Size(185, 33);
            BTN_Cancelar.TabIndex = 21;
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
            BTN_Aceptar.Location = new Point(31, 290);
            BTN_Aceptar.Margin = new Padding(2);
            BTN_Aceptar.Name = "BTN_Aceptar";
            BTN_Aceptar.Size = new Size(185, 33);
            BTN_Aceptar.TabIndex = 20;
            BTN_Aceptar.Text = "Aceptar";
            BTN_Aceptar.UseVisualStyleBackColor = false;
            BTN_Aceptar.Click += BTN_Aceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MostrarBox3
            // 
            MostrarBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MostrarBox3.BackColor = Color.DeepSkyBlue;
            MostrarBox3.Image = (Image)resources.GetObject("MostrarBox3.Image");
            MostrarBox3.Location = new Point(417, 124);
            MostrarBox3.Margin = new Padding(2);
            MostrarBox3.Name = "MostrarBox3";
            MostrarBox3.Size = new Size(31, 19);
            MostrarBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarBox3.TabIndex = 22;
            MostrarBox3.TabStop = false;
            MostrarBox3.Click += MostrarBox3_Click;
            // 
            // OcultarBox4
            // 
            OcultarBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OcultarBox4.BackColor = Color.DeepSkyBlue;
            OcultarBox4.Image = (Image)resources.GetObject("OcultarBox4.Image");
            OcultarBox4.Location = new Point(417, 124);
            OcultarBox4.Margin = new Padding(2);
            OcultarBox4.Name = "OcultarBox4";
            OcultarBox4.Size = new Size(31, 19);
            OcultarBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            OcultarBox4.TabIndex = 23;
            OcultarBox4.TabStop = false;
            OcultarBox4.Click += OcultarBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.DeepSkyBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(417, 203);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DeepSkyBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 203);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RestaContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(497, 372);
            Controls.Add(MostrarBox3);
            Controls.Add(OcultarBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(BTN_Cancelar);
            Controls.Add(BTN_Aceptar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TXT_Confi);
            Controls.Add(TXT_Contra);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestaContra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestaContra";
            Load += RestaContra_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TXT_Contra;
        private TextBox TXT_Confi;
        private Label label2;
        private Label label3;
        private Button BTN_Cancelar;
        private Button BTN_Aceptar;
        private ErrorProvider errorProvider1;
        private PictureBox MostrarBox3;
        private PictureBox OcultarBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}