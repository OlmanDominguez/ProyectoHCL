namespace ProyectoHCL
{
    partial class MsgB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgB));
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitulo = new Label();
            lblMsg = new Label();
            pbPregunta = new PictureBox();
            pbAdvertencia = new PictureBox();
            pbError = new PictureBox();
            btnOk = new Button();
            btnCancelar = new Button();
            panel3 = new Panel();
            pbInfo = new PictureBox();
            btnCerrar = new Button();
            btnAOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPregunta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbError).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 4);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(-1, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 4);
            panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Ebrima", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(65, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(65, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.Location = new Point(12, 81);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(396, 62);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "label1";
            // 
            // pbPregunta
            // 
            pbPregunta.Image = (Image)resources.GetObject("pbPregunta.Image");
            pbPregunta.Location = new Point(12, 12);
            pbPregunta.Name = "pbPregunta";
            pbPregunta.Size = new Size(45, 45);
            pbPregunta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPregunta.TabIndex = 4;
            pbPregunta.TabStop = false;
            pbPregunta.Visible = false;
            // 
            // pbAdvertencia
            // 
            pbAdvertencia.Image = (Image)resources.GetObject("pbAdvertencia.Image");
            pbAdvertencia.Location = new Point(12, 12);
            pbAdvertencia.Name = "pbAdvertencia";
            pbAdvertencia.Size = new Size(45, 45);
            pbAdvertencia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdvertencia.TabIndex = 5;
            pbAdvertencia.TabStop = false;
            pbAdvertencia.Visible = false;
            // 
            // pbError
            // 
            pbError.Image = (Image)resources.GetObject("pbError.Image");
            pbError.Location = new Point(12, 12);
            pbError.Name = "pbError";
            pbError.Size = new Size(45, 45);
            pbError.SizeMode = PictureBoxSizeMode.StretchImage;
            pbError.TabIndex = 6;
            pbError.TabStop = false;
            pbError.Visible = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Green;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = SystemColors.ButtonHighlight;
            btnOk.Location = new Point(235, 165);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(85, 30);
            btnOk.TabIndex = 7;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(326, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pbInfo);
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(pbPregunta);
            panel3.Controls.Add(pbError);
            panel3.Controls.Add(pbAdvertencia);
            panel3.Controls.Add(lblTitulo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 65);
            panel3.TabIndex = 9;
            panel3.MouseMove += panel3_MouseMove;
            // 
            // pbInfo
            // 
            pbInfo.Image = (Image)resources.GetObject("pbInfo.Image");
            pbInfo.Location = new Point(12, 12);
            pbInfo.Name = "pbInfo";
            pbInfo.Size = new Size(45, 45);
            pbInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInfo.TabIndex = 35;
            pbInfo.TabStop = false;
            pbInfo.Visible = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(397, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(11, 13);
            btnCerrar.TabIndex = 34;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAOk
            // 
            btnAOk.BackColor = Color.RoyalBlue;
            btnAOk.FlatAppearance.BorderSize = 0;
            btnAOk.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnAOk.FlatStyle = FlatStyle.Flat;
            btnAOk.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAOk.ForeColor = SystemColors.ButtonHighlight;
            btnAOk.Location = new Point(323, 165);
            btnAOk.Name = "btnAOk";
            btnAOk.Size = new Size(85, 30);
            btnAOk.TabIndex = 10;
            btnAOk.Text = "Ok";
            btnAOk.UseVisualStyleBackColor = false;
            btnAOk.Visible = false;
            btnAOk.Click += btnAOk_Click;
            // 
            // MsgB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 200);
            Controls.Add(btnAOk);
            Controls.Add(panel3);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(lblMsg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MsgB";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)pbPregunta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdvertencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbError).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private Label lblMsg;
        private PictureBox pbPregunta;
        private PictureBox pbAdvertencia;
        private PictureBox pbError;
        private Button btnOk;
        private Button btnCancelar;
        private Panel panel3;
        private Button btnCerrar;
        private PictureBox pbInfo;
        private Button btnAOk;
    }
}