namespace ProyectoHCL.Formularios
{
    partial class UserControlDias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDias));
            lblDias = new Label();
            pboxReservado = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxReservado).BeginInit();
            SuspendLayout();
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDias.Location = new Point(13, 12);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(25, 20);
            lblDias.TabIndex = 0;
            lblDias.Text = "00";
            // 
            // pboxReservado
            // 
            pboxReservado.Image = (Image)resources.GetObject("pboxReservado.Image");
            pboxReservado.Location = new Point(46, 14);
            pboxReservado.Name = "pboxReservado";
            pboxReservado.Size = new Size(40, 39);
            pboxReservado.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxReservado.TabIndex = 1;
            pboxReservado.TabStop = false;
            pboxReservado.Visible = false;
            // 
            // UserControlDias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pboxReservado);
            Controls.Add(lblDias);
            Name = "UserControlDias";
            Size = new Size(96, 64);
            Load += UserControlDias_Load;
            ((System.ComponentModel.ISupportInitialize)pboxReservado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox pboxReservado;
        public Label lblDias;
    }
}
