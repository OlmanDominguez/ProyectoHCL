namespace Perfiles
{
    partial class Preguntas_de_Seguridad
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Btn_Ingrese = new Button();
            Btn_regresar = new Button();
            Btn_ingrese2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 45);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Cual es su color favorito?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 118);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "¿Mascota preferida?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 185);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 2;
            label3.Text = "¿Cual es tu palabra secreta?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 296);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 296);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Nueva Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(441, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(441, 23);
            textBox3.TabIndex = 7;
            // 
            // Btn_Ingrese
            // 
            Btn_Ingrese.Location = new Point(77, 333);
            Btn_Ingrese.Name = "Btn_Ingrese";
            Btn_Ingrese.Size = new Size(137, 23);
            Btn_Ingrese.TabIndex = 8;
            Btn_Ingrese.Text = "Ingrese";
            Btn_Ingrese.UseVisualStyleBackColor = true;
            // 
            // Btn_regresar
            // 
            Btn_regresar.Location = new Point(277, 333);
            Btn_regresar.Name = "Btn_regresar";
            Btn_regresar.Size = new Size(108, 23);
            Btn_regresar.TabIndex = 9;
            Btn_regresar.Text = "Regresar";
            Btn_regresar.UseVisualStyleBackColor = true;
            Btn_regresar.Click += button2_Click;
            // 
            // Btn_ingrese2
            // 
            Btn_ingrese2.Location = new Point(459, 333);
            Btn_ingrese2.Name = "Btn_ingrese2";
            Btn_ingrese2.Size = new Size(131, 23);
            Btn_ingrese2.TabIndex = 10;
            Btn_ingrese2.Text = "Ingrese";
            Btn_ingrese2.UseVisualStyleBackColor = true;
            // 
            // Preguntas_de_Seguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = ProyectoHCL.Properties.Resources.fondo;
            ClientSize = new Size(688, 428);
            Controls.Add(Btn_ingrese2);
            Controls.Add(Btn_regresar);
            Controls.Add(Btn_Ingrese);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Preguntas_de_Seguridad";
            Text = "Preguntas_de_Seguridad";
            Load += Preguntas_de_Seguridad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Btn_Ingrese;
        private Button Btn_regresar;
        private Button Btn_ingrese2;
    }
}