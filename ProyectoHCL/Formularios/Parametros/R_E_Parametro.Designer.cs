namespace ProyectoHCL.Formularios
{
    partial class R_E_Parametro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_E_Parametro));
            panel2 = new Panel();
            lbPar = new Label();
            panel3 = new Panel();
            txtValor = new TextBox();
            texPa = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            label2 = new Label();
            errorp = new ErrorProvider(components);
            btnMin = new Button();
            cerrar = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorp).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnMin);
            panel2.Controls.Add(cerrar);
            panel2.Controls.Add(lbPar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 122);
            panel2.TabIndex = 23;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // lbPar
            // 
            lbPar.Anchor = AnchorStyles.Top;
            lbPar.AutoSize = true;
            lbPar.BackColor = Color.Transparent;
            lbPar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbPar.ForeColor = Color.White;
            lbPar.Location = new Point(264, 50);
            lbPar.Margin = new Padding(4, 0, 4, 0);
            lbPar.Name = "lbPar";
            lbPar.Size = new Size(283, 45);
            lbPar.TabIndex = 19;
            lbPar.Text = "Detalle Parametro";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(txtValor);
            panel3.Controls.Add(texPa);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 122);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 543);
            panel3.TabIndex = 25;
            // 
            // txtValor
            // 
            txtValor.CharacterCasing = CharacterCasing.Upper;
            txtValor.Location = new Point(160, 258);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(504, 31);
            txtValor.TabIndex = 24;
            // 
            // texPa
            // 
            texPa.CharacterCasing = CharacterCasing.Upper;
            texPa.Location = new Point(160, 98);
            texPa.Name = "texPa";
            texPa.Size = new Size(504, 31);
            texPa.TabIndex = 23;
            texPa.KeyPress += texPar_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(551, 370);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 47);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(160, 370);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 47);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(160, 205);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 5;
            label6.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(160, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 1;
            label2.Text = "Parametro:";
            // 
            // errorp
            // 
            errorp.ContainerControl = this;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = (Image)resources.GetObject("btnMin.BackgroundImage");
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(756, 3);
            btnMin.Margin = new Padding(4, 5, 4, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(27, 33);
            btnMin.TabIndex = 66;
            btnMin.UseVisualStyleBackColor = false;
            // 
            // cerrar
            // 
            cerrar.BackColor = Color.Transparent;
            cerrar.BackgroundImage = (Image)resources.GetObject("cerrar.BackgroundImage");
            cerrar.BackgroundImageLayout = ImageLayout.Stretch;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Location = new Point(791, 5);
            cerrar.Margin = new Padding(4, 5, 4, 5);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(20, 28);
            cerrar.TabIndex = 65;
            cerrar.UseVisualStyleBackColor = false;
            cerrar.Click += cerrar_Click;
            // 
            // R_E_Parametro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 665);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "R_E_Parametro";
            Text = "EditarParametro";
            Load += R_E_Parametro_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Panel panel3;
        private ErrorProvider errorp;
        public Button btnCancelar;
        public Button btnGuardar;
        public Label lbPar;
        public Label label6;
        public Label label2;
        public TextBox texPa;
        public TextBox txtValor;
        private Button btnMin;
        private Button cerrar;
    }
}