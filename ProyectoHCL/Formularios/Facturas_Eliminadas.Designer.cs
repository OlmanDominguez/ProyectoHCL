namespace Perfiles
{
    partial class Facturas_Eliminadas
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
            Btn_Generarpdf = new Button();
            btn_regresar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Btn_Generarpdf
            // 
            Btn_Generarpdf.Location = new Point(570, 80);
            Btn_Generarpdf.Name = "Btn_Generarpdf";
            Btn_Generarpdf.Size = new Size(107, 23);
            Btn_Generarpdf.TabIndex = 0;
            Btn_Generarpdf.Text = "Generar PDF";
            Btn_Generarpdf.UseVisualStyleBackColor = true;
            Btn_Generarpdf.Click += Btn_Generarpdf_Click;
            // 
            // btn_regresar
            // 
            btn_regresar.Location = new Point(646, 129);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(83, 23);
            btn_regresar.TabIndex = 1;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(111, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 213);
            dataGridView1.TabIndex = 2;
            // 
            // Facturas_Eliminadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ProyectoHCL.Properties.Resources.fondo;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_regresar);
            Controls.Add(Btn_Generarpdf);
            Name = "Facturas_Eliminadas";
            Text = "Facturas_Eliminadas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Generarpdf;
        private Button btn_regresar;
        private DataGridView dataGridView1;
    }
}