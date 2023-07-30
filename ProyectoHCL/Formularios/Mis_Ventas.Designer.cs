namespace Perfiles
{
    partial class Mis_Ventas
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
            Btn_regresar = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Btn_regresar
            // 
            Btn_regresar.Location = new Point(662, 97);
            Btn_regresar.Name = "Btn_regresar";
            Btn_regresar.Size = new Size(75, 23);
            Btn_regresar.TabIndex = 0;
            Btn_regresar.Text = "Regresar";
            Btn_regresar.UseVisualStyleBackColor = true;
            Btn_regresar.Click += Btn_regresar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(598, 243);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(502, 23);
            textBox1.TabIndex = 2;
            // 
            // Mis_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ProyectoHCL.Properties.Resources.fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Btn_regresar);
            Name = "Mis_Ventas";
            Text = "Mis_Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_regresar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}