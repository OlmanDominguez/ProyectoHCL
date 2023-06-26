namespace ProyectoHCL.Formularios
{
    partial class Cliente
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
            txt_buscar = new TextBox();
            dgvClientes = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(12, 118);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(162, 23);
            txt_buscar.TabIndex = 1;
            txt_buscar.TextChanged += txt_buscar_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(21, 173);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(787, 150);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(210, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(button1);
            Controls.Add(dgvClientes);
            Controls.Add(txt_buscar);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_buscar;
        private DataGridView dgvClientes;
        private Button button1;
    }
}