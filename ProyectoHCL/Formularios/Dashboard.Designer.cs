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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panelmanteSubMenu = new Panel();
            Ibtn_parametros = new FontAwesome.Sharp.IconButton();
            Ibtn_permisos = new FontAwesome.Sharp.IconButton();
            Ibtn_objetos = new FontAwesome.Sharp.IconButton();
            Ibtn_roles = new FontAwesome.Sharp.IconButton();
            Ibtn_mantenimiento = new FontAwesome.Sharp.IconButton();
            Ibtn_reservacion = new FontAwesome.Sharp.IconButton();
            Ibtn_facturacion = new FontAwesome.Sharp.IconButton();
            paneladminSubMenu = new Panel();
            Ibtn_clientes = new FontAwesome.Sharp.IconButton();
            Ibtn_usuarios = new FontAwesome.Sharp.IconButton();
            Ibtn_descuentos = new FontAwesome.Sharp.IconButton();
            Ibtn_servicios = new FontAwesome.Sharp.IconButton();
            Ibtn_habitaciones = new FontAwesome.Sharp.IconButton();
            Ibtn_administracion = new FontAwesome.Sharp.IconButton();
            Ibtn_perfil = new FontAwesome.Sharp.IconButton();
            btn_perfil = new Button();
            panel_logo = new Panel();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            lbl_titulo = new Label();
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
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            panelmanteSubMenu.SuspendLayout();
            paneladminSubMenu.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(60, 150, 249);
            panel1.Controls.Add(panelmanteSubMenu);
            panel1.Controls.Add(Ibtn_mantenimiento);
            panel1.Controls.Add(Ibtn_reservacion);
            panel1.Controls.Add(Ibtn_facturacion);
            panel1.Controls.Add(paneladminSubMenu);
            panel1.Controls.Add(Ibtn_administracion);
            panel1.Controls.Add(Ibtn_perfil);
            panel1.Controls.Add(btn_perfil);
            panel1.Controls.Add(panel_logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 723);
            panel1.TabIndex = 1;
            // 
            // panelmanteSubMenu
            // 
            panelmanteSubMenu.BackColor = Color.FromArgb(74, 181, 221);
            panelmanteSubMenu.Controls.Add(Ibtn_parametros);
            panelmanteSubMenu.Controls.Add(Ibtn_permisos);
            panelmanteSubMenu.Controls.Add(Ibtn_objetos);
            panelmanteSubMenu.Controls.Add(Ibtn_roles);
            panelmanteSubMenu.Dock = DockStyle.Top;
            panelmanteSubMenu.Location = new Point(0, 546);
            panelmanteSubMenu.Name = "panelmanteSubMenu";
            panelmanteSubMenu.Size = new Size(246, 183);
            panelmanteSubMenu.TabIndex = 34;
            // 
            // Ibtn_parametros
            // 
            Ibtn_parametros.Dock = DockStyle.Top;
            Ibtn_parametros.FlatAppearance.BorderSize = 0;
            Ibtn_parametros.FlatStyle = FlatStyle.Flat;
            Ibtn_parametros.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_parametros.IconChar = FontAwesome.Sharp.IconChar.Coins;
            Ibtn_parametros.IconColor = Color.Black;
            Ibtn_parametros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_parametros.IconSize = 25;
            Ibtn_parametros.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_parametros.Location = new Point(0, 135);
            Ibtn_parametros.Name = "Ibtn_parametros";
            Ibtn_parametros.Padding = new Padding(35, 0, 0, 0);
            Ibtn_parametros.Size = new Size(246, 45);
            Ibtn_parametros.TabIndex = 34;
            Ibtn_parametros.Text = "Parametros";
            Ibtn_parametros.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_parametros.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_parametros.UseVisualStyleBackColor = true;
            Ibtn_parametros.Click += Ibtn_parametros_Click;
            // 
            // Ibtn_permisos
            // 
            Ibtn_permisos.Dock = DockStyle.Top;
            Ibtn_permisos.FlatAppearance.BorderSize = 0;
            Ibtn_permisos.FlatStyle = FlatStyle.Flat;
            Ibtn_permisos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_permisos.IconChar = FontAwesome.Sharp.IconChar.SimCard;
            Ibtn_permisos.IconColor = Color.Black;
            Ibtn_permisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_permisos.IconSize = 25;
            Ibtn_permisos.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_permisos.Location = new Point(0, 90);
            Ibtn_permisos.Name = "Ibtn_permisos";
            Ibtn_permisos.Padding = new Padding(35, 0, 0, 0);
            Ibtn_permisos.Size = new Size(246, 45);
            Ibtn_permisos.TabIndex = 33;
            Ibtn_permisos.Text = "Permisos ";
            Ibtn_permisos.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_permisos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_permisos.UseVisualStyleBackColor = true;
            Ibtn_permisos.Click += Ibtn_permisos_Click;
            // 
            // Ibtn_objetos
            // 
            Ibtn_objetos.Dock = DockStyle.Top;
            Ibtn_objetos.FlatAppearance.BorderSize = 0;
            Ibtn_objetos.FlatStyle = FlatStyle.Flat;
            Ibtn_objetos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_objetos.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            Ibtn_objetos.IconColor = Color.Black;
            Ibtn_objetos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_objetos.IconSize = 25;
            Ibtn_objetos.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_objetos.Location = new Point(0, 45);
            Ibtn_objetos.Name = "Ibtn_objetos";
            Ibtn_objetos.Padding = new Padding(35, 0, 0, 0);
            Ibtn_objetos.Size = new Size(246, 45);
            Ibtn_objetos.TabIndex = 32;
            Ibtn_objetos.Text = "Objetos";
            Ibtn_objetos.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_objetos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_objetos.UseVisualStyleBackColor = true;
            Ibtn_objetos.Click += Ibtn_objetos_Click;
            // 
            // Ibtn_roles
            // 
            Ibtn_roles.Dock = DockStyle.Top;
            Ibtn_roles.FlatAppearance.BorderSize = 0;
            Ibtn_roles.FlatStyle = FlatStyle.Flat;
            Ibtn_roles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_roles.IconChar = FontAwesome.Sharp.IconChar.Key;
            Ibtn_roles.IconColor = Color.Black;
            Ibtn_roles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_roles.IconSize = 25;
            Ibtn_roles.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_roles.Location = new Point(0, 0);
            Ibtn_roles.Name = "Ibtn_roles";
            Ibtn_roles.Padding = new Padding(35, 0, 0, 0);
            Ibtn_roles.Size = new Size(246, 45);
            Ibtn_roles.TabIndex = 31;
            Ibtn_roles.Text = "Roles";
            Ibtn_roles.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_roles.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_roles.UseVisualStyleBackColor = true;
            Ibtn_roles.Click += Ibtn_roles_Click;
            // 
            // Ibtn_mantenimiento
            // 
            Ibtn_mantenimiento.Dock = DockStyle.Top;
            Ibtn_mantenimiento.FlatAppearance.BorderSize = 0;
            Ibtn_mantenimiento.FlatStyle = FlatStyle.Flat;
            Ibtn_mantenimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ibtn_mantenimiento.IconChar = FontAwesome.Sharp.IconChar.Gear;
            Ibtn_mantenimiento.IconColor = Color.Black;
            Ibtn_mantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_mantenimiento.IconSize = 25;
            Ibtn_mantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_mantenimiento.Location = new Point(0, 501);
            Ibtn_mantenimiento.Name = "Ibtn_mantenimiento";
            Ibtn_mantenimiento.Padding = new Padding(15, 0, 0, 0);
            Ibtn_mantenimiento.Size = new Size(246, 45);
            Ibtn_mantenimiento.TabIndex = 33;
            Ibtn_mantenimiento.Text = "Mantenimiento";
            Ibtn_mantenimiento.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_mantenimiento.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_mantenimiento.UseVisualStyleBackColor = true;
            Ibtn_mantenimiento.Click += Ibtn_mantenimiento_Click_1;
            // 
            // Ibtn_reservacion
            // 
            Ibtn_reservacion.Dock = DockStyle.Top;
            Ibtn_reservacion.FlatAppearance.BorderSize = 0;
            Ibtn_reservacion.FlatStyle = FlatStyle.Flat;
            Ibtn_reservacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ibtn_reservacion.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            Ibtn_reservacion.IconColor = Color.Black;
            Ibtn_reservacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_reservacion.IconSize = 25;
            Ibtn_reservacion.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_reservacion.Location = new Point(0, 456);
            Ibtn_reservacion.Name = "Ibtn_reservacion";
            Ibtn_reservacion.Padding = new Padding(15, 0, 0, 0);
            Ibtn_reservacion.Size = new Size(246, 45);
            Ibtn_reservacion.TabIndex = 32;
            Ibtn_reservacion.Text = "Reservacion";
            Ibtn_reservacion.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_reservacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_reservacion.UseVisualStyleBackColor = true;
            Ibtn_reservacion.Click += Ibtn_reservacion_Click_1;
            // 
            // Ibtn_facturacion
            // 
            Ibtn_facturacion.Dock = DockStyle.Top;
            Ibtn_facturacion.FlatAppearance.BorderSize = 0;
            Ibtn_facturacion.FlatStyle = FlatStyle.Flat;
            Ibtn_facturacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ibtn_facturacion.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            Ibtn_facturacion.IconColor = Color.Black;
            Ibtn_facturacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_facturacion.IconSize = 25;
            Ibtn_facturacion.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_facturacion.Location = new Point(0, 411);
            Ibtn_facturacion.Name = "Ibtn_facturacion";
            Ibtn_facturacion.Padding = new Padding(15, 0, 0, 0);
            Ibtn_facturacion.Size = new Size(246, 45);
            Ibtn_facturacion.TabIndex = 31;
            Ibtn_facturacion.Text = "Facturacion";
            Ibtn_facturacion.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_facturacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_facturacion.UseVisualStyleBackColor = true;
            // 
            // paneladminSubMenu
            // 
            paneladminSubMenu.BackColor = Color.FromArgb(74, 181, 221);
            paneladminSubMenu.Controls.Add(Ibtn_clientes);
            paneladminSubMenu.Controls.Add(Ibtn_usuarios);
            paneladminSubMenu.Controls.Add(Ibtn_descuentos);
            paneladminSubMenu.Controls.Add(Ibtn_servicios);
            paneladminSubMenu.Controls.Add(Ibtn_habitaciones);
            paneladminSubMenu.Dock = DockStyle.Top;
            paneladminSubMenu.Location = new Point(0, 177);
            paneladminSubMenu.Name = "paneladminSubMenu";
            paneladminSubMenu.Size = new Size(246, 234);
            paneladminSubMenu.TabIndex = 29;
            // 
            // Ibtn_clientes
            // 
            Ibtn_clientes.Dock = DockStyle.Top;
            Ibtn_clientes.FlatAppearance.BorderSize = 0;
            Ibtn_clientes.FlatStyle = FlatStyle.Flat;
            Ibtn_clientes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_clientes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            Ibtn_clientes.IconColor = Color.Black;
            Ibtn_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_clientes.IconSize = 25;
            Ibtn_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_clientes.Location = new Point(0, 180);
            Ibtn_clientes.Name = "Ibtn_clientes";
            Ibtn_clientes.Padding = new Padding(35, 0, 0, 0);
            Ibtn_clientes.Size = new Size(246, 45);
            Ibtn_clientes.TabIndex = 33;
            Ibtn_clientes.Text = "Clientes";
            Ibtn_clientes.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_clientes.UseVisualStyleBackColor = true;
            Ibtn_clientes.Click += Ibtn_clientes_Click;
            // 
            // Ibtn_usuarios
            // 
            Ibtn_usuarios.Dock = DockStyle.Top;
            Ibtn_usuarios.FlatAppearance.BorderSize = 0;
            Ibtn_usuarios.FlatStyle = FlatStyle.Flat;
            Ibtn_usuarios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            Ibtn_usuarios.IconColor = Color.Black;
            Ibtn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_usuarios.IconSize = 25;
            Ibtn_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_usuarios.Location = new Point(0, 135);
            Ibtn_usuarios.Name = "Ibtn_usuarios";
            Ibtn_usuarios.Padding = new Padding(35, 0, 0, 0);
            Ibtn_usuarios.Size = new Size(246, 45);
            Ibtn_usuarios.TabIndex = 32;
            Ibtn_usuarios.Text = "Usuarios";
            Ibtn_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_usuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_usuarios.UseVisualStyleBackColor = true;
            Ibtn_usuarios.Click += Ibtn_usuarios_Click;
            // 
            // Ibtn_descuentos
            // 
            Ibtn_descuentos.Dock = DockStyle.Top;
            Ibtn_descuentos.FlatAppearance.BorderSize = 0;
            Ibtn_descuentos.FlatStyle = FlatStyle.Flat;
            Ibtn_descuentos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_descuentos.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            Ibtn_descuentos.IconColor = Color.Black;
            Ibtn_descuentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_descuentos.IconSize = 25;
            Ibtn_descuentos.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_descuentos.Location = new Point(0, 90);
            Ibtn_descuentos.Name = "Ibtn_descuentos";
            Ibtn_descuentos.Padding = new Padding(35, 0, 0, 0);
            Ibtn_descuentos.Size = new Size(246, 45);
            Ibtn_descuentos.TabIndex = 31;
            Ibtn_descuentos.Text = "Descuantos ";
            Ibtn_descuentos.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_descuentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_descuentos.UseVisualStyleBackColor = true;
            Ibtn_descuentos.Click += Ibtn_descuentos_Click;
            // 
            // Ibtn_servicios
            // 
            Ibtn_servicios.Dock = DockStyle.Top;
            Ibtn_servicios.FlatAppearance.BorderSize = 0;
            Ibtn_servicios.FlatStyle = FlatStyle.Flat;
            Ibtn_servicios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_servicios.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            Ibtn_servicios.IconColor = Color.Black;
            Ibtn_servicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_servicios.IconSize = 25;
            Ibtn_servicios.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_servicios.Location = new Point(0, 45);
            Ibtn_servicios.Name = "Ibtn_servicios";
            Ibtn_servicios.Padding = new Padding(35, 0, 0, 0);
            Ibtn_servicios.Size = new Size(246, 45);
            Ibtn_servicios.TabIndex = 30;
            Ibtn_servicios.Text = "Servicios";
            Ibtn_servicios.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_servicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_servicios.UseVisualStyleBackColor = true;
            Ibtn_servicios.Click += Ibtn_servicios_Click;
            // 
            // Ibtn_habitaciones
            // 
            Ibtn_habitaciones.Dock = DockStyle.Top;
            Ibtn_habitaciones.FlatAppearance.BorderSize = 0;
            Ibtn_habitaciones.FlatStyle = FlatStyle.Flat;
            Ibtn_habitaciones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ibtn_habitaciones.IconChar = FontAwesome.Sharp.IconChar.City;
            Ibtn_habitaciones.IconColor = Color.Black;
            Ibtn_habitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_habitaciones.IconSize = 25;
            Ibtn_habitaciones.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_habitaciones.Location = new Point(0, 0);
            Ibtn_habitaciones.Name = "Ibtn_habitaciones";
            Ibtn_habitaciones.Padding = new Padding(35, 0, 0, 0);
            Ibtn_habitaciones.Size = new Size(246, 45);
            Ibtn_habitaciones.TabIndex = 29;
            Ibtn_habitaciones.Text = "Habitaciones";
            Ibtn_habitaciones.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_habitaciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_habitaciones.UseVisualStyleBackColor = true;
            Ibtn_habitaciones.Click += Ibtn_habitaciones_Click;
            // 
            // Ibtn_administracion
            // 
            Ibtn_administracion.Dock = DockStyle.Top;
            Ibtn_administracion.FlatAppearance.BorderSize = 0;
            Ibtn_administracion.FlatStyle = FlatStyle.Flat;
            Ibtn_administracion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ibtn_administracion.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            Ibtn_administracion.IconColor = Color.Black;
            Ibtn_administracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_administracion.IconSize = 25;
            Ibtn_administracion.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_administracion.Location = new Point(0, 132);
            Ibtn_administracion.Name = "Ibtn_administracion";
            Ibtn_administracion.Padding = new Padding(15, 0, 0, 0);
            Ibtn_administracion.Size = new Size(246, 45);
            Ibtn_administracion.TabIndex = 28;
            Ibtn_administracion.Text = "Administracion";
            Ibtn_administracion.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_administracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_administracion.UseVisualStyleBackColor = true;
            Ibtn_administracion.Click += Ibtn_administracion_Click;
            // 
            // Ibtn_perfil
            // 
            Ibtn_perfil.Dock = DockStyle.Top;
            Ibtn_perfil.FlatAppearance.BorderSize = 0;
            Ibtn_perfil.FlatStyle = FlatStyle.Flat;
            Ibtn_perfil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ibtn_perfil.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            Ibtn_perfil.IconColor = Color.Black;
            Ibtn_perfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Ibtn_perfil.IconSize = 25;
            Ibtn_perfil.ImageAlign = ContentAlignment.MiddleLeft;
            Ibtn_perfil.Location = new Point(0, 87);
            Ibtn_perfil.Name = "Ibtn_perfil";
            Ibtn_perfil.Padding = new Padding(15, 0, 0, 0);
            Ibtn_perfil.Size = new Size(246, 45);
            Ibtn_perfil.TabIndex = 27;
            Ibtn_perfil.Text = "Perfil";
            Ibtn_perfil.TextAlign = ContentAlignment.MiddleLeft;
            Ibtn_perfil.TextImageRelation = TextImageRelation.ImageBeforeText;
            Ibtn_perfil.UseVisualStyleBackColor = true;
            // 
            // btn_perfil
            // 
            btn_perfil.BackgroundImageLayout = ImageLayout.Zoom;
            btn_perfil.FlatAppearance.BorderSize = 0;
            btn_perfil.FlatStyle = FlatStyle.Flat;
            btn_perfil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_perfil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_perfil.Location = new Point(0, 87);
            btn_perfil.Name = "btn_perfil";
            btn_perfil.Padding = new Padding(10, 0, 0, 0);
            btn_perfil.RightToLeft = RightToLeft.No;
            btn_perfil.Size = new Size(246, 45);
            btn_perfil.TabIndex = 1;
            btn_perfil.Text = "Perlfil";
            btn_perfil.TextAlign = ContentAlignment.MiddleLeft;
            btn_perfil.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(pictureBox5);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(246, 87);
            panel_logo.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(73, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 78);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbl_titulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(246, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 70);
            panel2.TabIndex = 2;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = AnchorStyles.None;
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Lucida Bright", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_titulo.ForeColor = Color.White;
            lbl_titulo.Location = new Point(106, 20);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(362, 36);
            lbl_titulo.TabIndex = 16;
            lbl_titulo.Text = "HOTEL CASA LOMAS";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top;
            monthCalendar1.BackColor = SystemColors.Window;
            monthCalendar1.Location = new Point(303, 237);
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
            label2.Location = new Point(290, 203);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 9;
            label2.Text = "Reservaciones Programadas";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox1.Location = new Point(285, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 223);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox3.Location = new Point(630, 192);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 100);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.FromArgb(60, 150, 249);
            pictureBox4.Location = new Point(630, 298);
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
            label3.Location = new Point(654, 204);
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
            lbl_reserva.Location = new Point(640, 236);
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
            lbl_disp.Location = new Point(640, 261);
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
            lbl_disponible.Location = new Point(727, 262);
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
            lbl_reservadas.Location = new Point(727, 237);
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
            label8.Location = new Point(654, 302);
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
            lbl_confirmadas.Location = new Point(731, 361);
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
            lbl_pendientes.Location = new Point(731, 336);
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
            lbl_confirma.Location = new Point(644, 359);
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
            lbl_confir.Location = new Point(644, 335);
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
            lbl_anuladas.Location = new Point(731, 385);
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
            lbl_anu.Location = new Point(645, 384);
            lbl_anu.Name = "lbl_anu";
            lbl_anu.Size = new Size(69, 17);
            lbl_anu.TabIndex = 23;
            lbl_anu.Text = "Anuladas:";
            // 
            // panelChildForm
            // 
            panelChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChildForm.BackColor = Color.Transparent;
            panelChildForm.Location = new Point(246, 76);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(656, 653);
            panelChildForm.TabIndex = 25;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 723);
            Controls.Add(panelChildForm);
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
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panelmanteSubMenu.ResumeLayout(false);
            paneladminSubMenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lbl_titulo;
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
        private Panel panel_logo;
        private PictureBox pictureBox5;
        private Button btn_perfil;
        private FontAwesome.Sharp.IconButton Ibtn_perfil;
        private FontAwesome.Sharp.IconButton Ibtn_administracion;
        private Panel paneladminSubMenu;
        private FontAwesome.Sharp.IconButton Ibtn_descuentos;
        private FontAwesome.Sharp.IconButton Ibtn_servicios;
        private FontAwesome.Sharp.IconButton Ibtn_habitaciones;
        private FontAwesome.Sharp.IconButton Ibtn_clientes;
        private FontAwesome.Sharp.IconButton Ibtn_usuarios;
        private Panel panelmanteSubMenu;
        private FontAwesome.Sharp.IconButton Ibtn_parametros;
        private FontAwesome.Sharp.IconButton Ibtn_permisos;
        private FontAwesome.Sharp.IconButton Ibtn_objetos;
        private FontAwesome.Sharp.IconButton Ibtn_roles;
        private FontAwesome.Sharp.IconButton Ibtn_mantenimiento;
        private FontAwesome.Sharp.IconButton Ibtn_reservacion;
        private FontAwesome.Sharp.IconButton Ibtn_facturacion;
        private Panel panelChildForm;
    }
}