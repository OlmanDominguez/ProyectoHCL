namespace ProyectoHCL
{
    partial class BackWorker
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
            label1 = new Label();
            label2 = new Label();
            pgB = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 19);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Registrando permisos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(154, 39);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 1;
            label2.Text = "Espere un momento...";
            // 
            // pgB
            // 
            pgB.Location = new Point(29, 74);
            pgB.MarqueeAnimationSpeed = 30;
            pgB.Maximum = 200;
            pgB.Name = "pgB";
            pgB.Size = new Size(389, 17);
            pgB.Style = ProgressBarStyle.Continuous;
            pgB.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // BackWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 138);
            Controls.Add(pgB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BackWorker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BackGroundWorker";
            Load += BackWorker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar pgB;
        private System.Windows.Forms.Timer timer1;
    }
}