namespace ProyectoHCL.Formularios
{
    partial class CalendarioReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioReservas));
            monthCalendar = new MonthCalendar();
            label1 = new Label();
            cmbHabitacion = new ComboBox();
            panel1 = new Panel();
            button1 = new Button();
            btnCerrar = new Button();
            label11 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = Color.White;
            monthCalendar.CalendarDimensions = new Size(4, 2);
            monthCalendar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendar.Location = new Point(26, 74);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 0;
            monthCalendar.TitleBackColor = Color.SteelBlue;
            monthCalendar.TitleForeColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(213, 18);
            label1.TabIndex = 1;
            label1.Text = "Seleccione una habitación:";
            // 
            // cmbHabitacion
            // 
            cmbHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHabitacion.FormattingEnabled = true;
            cmbHabitacion.Location = new Point(251, 27);
            cmbHabitacion.Name = "cmbHabitacion";
            cmbHabitacion.Size = new Size(208, 23);
            cmbHabitacion.TabIndex = 2;
            cmbHabitacion.SelectedIndexChanged += cmbHabitacion_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 62);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(869, 12);
            button1.Name = "button1";
            button1.Size = new Size(14, 17);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1753, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(14, 17);
            btnCerrar.TabIndex = 44;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(26, 12);
            label11.Name = "label11";
            label11.Size = new Size(318, 32);
            label11.TabIndex = 31;
            label11.Text = "Reservaciones programadas";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbHabitacion);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(monthCalendar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 472);
            panel2.TabIndex = 4;
            // 
            // CalendarioReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 534);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalendarioReservas";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Label label1;
        private ComboBox cmbHabitacion;
        private Panel panel1;
        private Button btnCerrar;
        private Label label11;
        private Button button1;
        private Panel panel2;
    }
}