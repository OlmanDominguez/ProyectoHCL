namespace ProyectoHCL
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button_menu1 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            rjDropdownMenu1 = new RJDropdownMenu(components);
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem1 = new ToolStripMenuItem();
            habitacionesToolStripMenuItem = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            descuentosToolStripMenuItem1 = new ToolStripMenuItem();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            pruebaToolStripMenuItem = new ToolStripMenuItem();
            reservacionesToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            descuentosToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            lbl_reserva = new Label();
            lbl_disp = new Label();
            lbl_disponible = new Label();
            lbl_reservadas = new Label();
            label8 = new Label();
            lbl_confirmadas = new Label();
            lbl_pendientes = new Label();
            lbl_confirma = new Label();
            lbl_confir = new Label();
            lbl_anuladas = new Label();
            lbl_anu = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            rjDropdownMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button_menu1
            // 
            button_menu1.BackColor = Color.Transparent;
            button_menu1.BackgroundImage = (Image)resources.GetObject("button_menu1.BackgroundImage");
            button_menu1.BackgroundImageLayout = ImageLayout.Stretch;
            button_menu1.FlatAppearance.BorderSize = 0;
            button_menu1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button_menu1.FlatStyle = FlatStyle.Flat;
            button_menu1.Location = new Point(5, 20);
            button_menu1.Name = "button_menu1";
            button_menu1.Size = new Size(49, 36);
            button_menu1.TabIndex = 1;
            button_menu1.UseVisualStyleBackColor = false;
            button_menu1.Click += button_menu1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 150, 249);
            panel1.Controls.Add(button_menu1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 573);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 70);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 20);
            label1.Name = "label1";
            label1.Size = new Size(362, 36);
            label1.TabIndex = 16;
            label1.Text = "HOTEL CASA LOMAS";
            // 
            // rjDropdownMenu1
            // 
            rjDropdownMenu1.IsMainMenu = false;
            rjDropdownMenu1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, administracionToolStripMenuItem, pruebaToolStripMenuItem, descuentosToolStripMenuItem, mantenimientoToolStripMenuItem });
            rjDropdownMenu1.MenuItemHeight = 25;
            rjDropdownMenu1.MenuItemTextColor = Color.Empty;
            rjDropdownMenu1.Name = "rjDropdownMenu1";
            rjDropdownMenu1.PrimaryColor = Color.Empty;
            rjDropdownMenu1.Size = new Size(157, 114);
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(156, 22);
            usuariosToolStripMenuItem.Text = "Mi perfil";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // administracionToolStripMenuItem
            // 
            administracionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem1, habitacionesToolStripMenuItem, serviciosToolStripMenuItem, descuentosToolStripMenuItem1, mantenimientosToolStripMenuItem });
            administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            administracionToolStripMenuItem.Size = new Size(156, 22);
            administracionToolStripMenuItem.Text = "Administracion";
            administracionToolStripMenuItem.Click += administracionToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem1
            // 
            usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            usuariosToolStripMenuItem1.Size = new Size(161, 22);
            usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // habitacionesToolStripMenuItem
            // 
            habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            habitacionesToolStripMenuItem.Size = new Size(161, 22);
            habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(161, 22);
            serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // descuentosToolStripMenuItem1
            // 
            descuentosToolStripMenuItem1.Name = "descuentosToolStripMenuItem1";
            descuentosToolStripMenuItem1.Size = new Size(161, 22);
            descuentosToolStripMenuItem1.Text = "Descuentos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(161, 22);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // pruebaToolStripMenuItem
            // 
            pruebaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reservacionesToolStripMenuItem1, clientesToolStripMenuItem1 });
            pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            pruebaToolStripMenuItem.Size = new Size(156, 22);
            pruebaToolStripMenuItem.Text = "Reservacion";
            // 
            // reservacionesToolStripMenuItem1
            // 
            reservacionesToolStripMenuItem1.Name = "reservacionesToolStripMenuItem1";
            reservacionesToolStripMenuItem1.Size = new Size(148, 22);
            reservacionesToolStripMenuItem1.Text = "Reservaciones";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(148, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // descuentosToolStripMenuItem
            // 
            descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            descuentosToolStripMenuItem.Size = new Size(156, 22);
            descuentosToolStripMenuItem.Text = "Facturacion";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(156, 22);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top;
            monthCalendar1.BackColor = SystemColors.Window;
            monthCalendar1.Location = new Point(320, 237);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(60, 150, 249);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(307, 203);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 9;
            label2.Text = "Reservaciones Programadas";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox1.Location = new Point(302, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 223);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox3.Location = new Point(647, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 100);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox4.Location = new Point(647, 298);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(199, 113);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(60, 150, 249);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(671, 204);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 13;
            label3.Text = "Habitaciones";
            // 
            // lbl_reserva
            // 
            lbl_reserva.Anchor = AnchorStyles.Top;
            lbl_reserva.AutoSize = true;
            lbl_reserva.BackColor = Color.FromArgb(60, 150, 249);
            lbl_reserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_reserva.ForeColor = SystemColors.ButtonFace;
            lbl_reserva.Location = new Point(657, 236);
            lbl_reserva.Name = "lbl_reserva";
            lbl_reserva.Size = new Size(81, 17);
            lbl_reserva.TabIndex = 14;
            lbl_reserva.Text = "Reservadas:";
            // 
            // lbl_disp
            // 
            lbl_disp.Anchor = AnchorStyles.Top;
            lbl_disp.AutoSize = true;
            lbl_disp.BackColor = Color.FromArgb(60, 150, 249);
            lbl_disp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_disp.ForeColor = SystemColors.ButtonFace;
            lbl_disp.Location = new Point(657, 261);
            lbl_disp.Name = "lbl_disp";
            lbl_disp.Size = new Size(85, 17);
            lbl_disp.TabIndex = 15;
            lbl_disp.Text = "Disponibles:";
            // 
            // lbl_disponible
            // 
            lbl_disponible.Anchor = AnchorStyles.Top;
            lbl_disponible.AutoSize = true;
            lbl_disponible.BackColor = Color.FromArgb(60, 150, 249);
            lbl_disponible.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_disponible.ForeColor = SystemColors.ButtonFace;
            lbl_disponible.Location = new Point(744, 262);
            lbl_disponible.Name = "lbl_disponible";
            lbl_disponible.Size = new Size(13, 17);
            lbl_disponible.TabIndex = 17;
            lbl_disponible.Text = "-";
            // 
            // lbl_reservadas
            // 
            lbl_reservadas.Anchor = AnchorStyles.Top;
            lbl_reservadas.AutoSize = true;
            lbl_reservadas.BackColor = Color.FromArgb(60, 150, 249);
            lbl_reservadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_reservadas.ForeColor = SystemColors.ButtonFace;
            lbl_reservadas.Location = new Point(744, 237);
            lbl_reservadas.Name = "lbl_reservadas";
            lbl_reservadas.Size = new Size(13, 17);
            lbl_reservadas.TabIndex = 16;
            lbl_reservadas.Text = "-";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(60, 150, 249);
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(671, 302);
            label8.Name = "label8";
            label8.Size = new Size(137, 25);
            label8.TabIndex = 18;
            label8.Text = "Reservaciones";
            // 
            // lbl_confirmadas
            // 
            lbl_confirmadas.Anchor = AnchorStyles.Top;
            lbl_confirmadas.AutoSize = true;
            lbl_confirmadas.BackColor = Color.FromArgb(60, 150, 249);
            lbl_confirmadas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirmadas.ForeColor = SystemColors.ButtonFace;
            lbl_confirmadas.Location = new Point(748, 361);
            lbl_confirmadas.Name = "lbl_confirmadas";
            lbl_confirmadas.Size = new Size(13, 17);
            lbl_confirmadas.TabIndex = 22;
            lbl_confirmadas.Text = "-";
            // 
            // lbl_pendientes
            // 
            lbl_pendientes.Anchor = AnchorStyles.Top;
            lbl_pendientes.AutoSize = true;
            lbl_pendientes.BackColor = Color.FromArgb(60, 150, 249);
            lbl_pendientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_pendientes.ForeColor = SystemColors.ButtonFace;
            lbl_pendientes.Location = new Point(748, 336);
            lbl_pendientes.Name = "lbl_pendientes";
            lbl_pendientes.Size = new Size(13, 17);
            lbl_pendientes.TabIndex = 21;
            lbl_pendientes.Text = "-";
            // 
            // lbl_confirma
            // 
            lbl_confirma.Anchor = AnchorStyles.Top;
            lbl_confirma.AutoSize = true;
            lbl_confirma.BackColor = Color.FromArgb(60, 150, 249);
            lbl_confirma.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirma.ForeColor = SystemColors.ButtonFace;
            lbl_confirma.Location = new Point(661, 359);
            lbl_confirma.Name = "lbl_confirma";
            lbl_confirma.Size = new Size(90, 17);
            lbl_confirma.TabIndex = 20;
            lbl_confirma.Text = "Confirmadas:";
            // 
            // lbl_confir
            // 
            lbl_confir.Anchor = AnchorStyles.Top;
            lbl_confir.AutoSize = true;
            lbl_confir.BackColor = Color.FromArgb(60, 150, 249);
            lbl_confir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confir.ForeColor = SystemColors.ButtonFace;
            lbl_confir.Location = new Point(661, 335);
            lbl_confir.Name = "lbl_confir";
            lbl_confir.Size = new Size(80, 17);
            lbl_confir.TabIndex = 19;
            lbl_confir.Text = "Pendientes:";
            // 
            // lbl_anuladas
            // 
            lbl_anuladas.Anchor = AnchorStyles.Top;
            lbl_anuladas.AutoSize = true;
            lbl_anuladas.BackColor = Color.FromArgb(60, 150, 249);
            lbl_anuladas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_anuladas.ForeColor = SystemColors.ButtonFace;
            lbl_anuladas.Location = new Point(748, 385);
            lbl_anuladas.Name = "lbl_anuladas";
            lbl_anuladas.Size = new Size(13, 17);
            lbl_anuladas.TabIndex = 24;
            lbl_anuladas.Text = "-";
            // 
            // lbl_anu
            // 
            lbl_anu.Anchor = AnchorStyles.Top;
            lbl_anu.AutoSize = true;
            lbl_anu.BackColor = Color.FromArgb(60, 150, 249);
            lbl_anu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_anu.ForeColor = SystemColors.ButtonFace;
            lbl_anu.Location = new Point(662, 384);
            lbl_anu.Name = "lbl_anu";
            lbl_anu.Size = new Size(69, 17);
            lbl_anu.TabIndex = 23;
            lbl_anu.Text = "Anuladas:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 573);
            Controls.Add(lbl_anuladas);
            Controls.Add(lbl_anu);
            Controls.Add(lbl_confirmadas);
            Controls.Add(lbl_pendientes);
            Controls.Add(lbl_confirma);
            Controls.Add(lbl_confir);
            Controls.Add(label8);
            Controls.Add(lbl_disponible);
            Controls.Add(lbl_reservadas);
            Controls.Add(lbl_disp);
            Controls.Add(lbl_reserva);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            rjDropdownMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_menu1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private RJDropdownMenu rjDropdownMenu1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem administracionToolStripMenuItem;
        private ToolStripMenuItem pruebaToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label lbl_reserva;
        private Label lbl_disp;
        private Label lbl_disponible;
        private Label lbl_reservadas;
        private Label label8;
        private Label lbl_confirmadas;
        private Label lbl_pendientes;
        private Label lbl_confirma;
        private Label lbl_confir;
        private Label lbl_anuladas;
        private Label lbl_anu;
        private ToolStripMenuItem usuariosToolStripMenuItem1;
        private ToolStripMenuItem habitacionesToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem descuentosToolStripMenuItem1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem reservacionesToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem1;
    }
}