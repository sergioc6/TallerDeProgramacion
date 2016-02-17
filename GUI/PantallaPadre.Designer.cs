namespace GUI
{
    partial class PantallaPadre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPadre));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuAcciones = new System.Windows.Forms.MenuStrip();
            this.cuentasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.verCorreosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoresMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelInicio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxArroba = new System.Windows.Forms.PictureBox();
            this.statusStripVentanaPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoraActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerRefrescar = new System.Windows.Forms.Timer(this.components);
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.menuAcciones.SuspendLayout();
            this.PanelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArroba)).BeginInit();
            this.statusStripVentanaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAcciones
            // 
            this.menuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasMenu,
            this.correosMenu,
            this.desarrolladoresMenu});
            this.menuAcciones.Location = new System.Drawing.Point(0, 0);
            this.menuAcciones.Name = "menuAcciones";
            this.menuAcciones.Size = new System.Drawing.Size(798, 24);
            this.menuAcciones.TabIndex = 4;
            this.menuAcciones.Text = "Acciones";
            // 
            // cuentasMenu
            // 
            this.cuentasMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCuentaToolStripMenuItem,
            this.agregarNuevaCuentaToolStripMenuItem,
            this.modificarCuentaToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cuentasMenu.Image = ((System.Drawing.Image)(resources.GetObject("cuentasMenu.Image")));
            this.cuentasMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cuentasMenu.Name = "cuentasMenu";
            this.cuentasMenu.Size = new System.Drawing.Size(78, 20);
            this.cuentasMenu.Text = "Cuentas";
            this.cuentasMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // verCuentaToolStripMenuItem
            // 
            this.verCuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verCuentaToolStripMenuItem.Image")));
            this.verCuentaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verCuentaToolStripMenuItem.Name = "verCuentaToolStripMenuItem";
            this.verCuentaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.verCuentaToolStripMenuItem.Text = "Ver cuentas";
            this.verCuentaToolStripMenuItem.Click += new System.EventHandler(this.AbrirVerCuentas_Click);
            // 
            // agregarNuevaCuentaToolStripMenuItem
            // 
            this.agregarNuevaCuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevaCuentaToolStripMenuItem.Image")));
            this.agregarNuevaCuentaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarNuevaCuentaToolStripMenuItem.Name = "agregarNuevaCuentaToolStripMenuItem";
            this.agregarNuevaCuentaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.agregarNuevaCuentaToolStripMenuItem.Text = "Agregar nueva cuenta";
            this.agregarNuevaCuentaToolStripMenuItem.Click += new System.EventHandler(this.AbrirAgregarCuenta_Click);
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarCuentaToolStripMenuItem.Image")));
            this.modificarCuentaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modificarCuentaToolStripMenuItem.Text = "Modificar cuenta";
            this.modificarCuentaToolStripMenuItem.Click += new System.EventHandler(this.AbrirModificarCuenta_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar cuenta";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.AbrirEliminarCuenta_Click);
            // 
            // correosMenu
            // 
            this.correosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCorreosToolStripMenuItem,
            this.enviarCorreoToolStripMenuItem,
            this.descargarMailsToolStripMenuItem});
            this.correosMenu.Image = ((System.Drawing.Image)(resources.GetObject("correosMenu.Image")));
            this.correosMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.correosMenu.Name = "correosMenu";
            this.correosMenu.Size = new System.Drawing.Size(76, 20);
            this.correosMenu.Text = "Correos";
            this.correosMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // verCorreosToolStripMenuItem
            // 
            this.verCorreosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verCorreosToolStripMenuItem.Image")));
            this.verCorreosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verCorreosToolStripMenuItem.Name = "verCorreosToolStripMenuItem";
            this.verCorreosToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.verCorreosToolStripMenuItem.Text = "Ver mails";
            this.verCorreosToolStripMenuItem.Click += new System.EventHandler(this.AbrirVerCorreos_Click);
            // 
            // enviarCorreoToolStripMenuItem
            // 
            this.enviarCorreoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enviarCorreoToolStripMenuItem.Image")));
            this.enviarCorreoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enviarCorreoToolStripMenuItem.Name = "enviarCorreoToolStripMenuItem";
            this.enviarCorreoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enviarCorreoToolStripMenuItem.Text = "Enviar mail";
            this.enviarCorreoToolStripMenuItem.Click += new System.EventHandler(this.AbrirEnviarMail_Click);
            // 
            // descargarMailsToolStripMenuItem
            // 
            this.descargarMailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descargarMailsToolStripMenuItem.Image")));
            this.descargarMailsToolStripMenuItem.Name = "descargarMailsToolStripMenuItem";
            this.descargarMailsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.descargarMailsToolStripMenuItem.Text = "Descargar mails";
            this.descargarMailsToolStripMenuItem.Click += new System.EventHandler(this.AbrirDescargarMails_Click);
            // 
            // desarrolladoresMenu
            // 
            this.desarrolladoresMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.contactoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.desarrolladoresMenu.Image = ((System.Drawing.Image)(resources.GetObject("desarrolladoresMenu.Image")));
            this.desarrolladoresMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.desarrolladoresMenu.Name = "desarrolladoresMenu";
            this.desarrolladoresMenu.Size = new System.Drawing.Size(116, 20);
            this.desarrolladoresMenu.Text = "Desarrolladores";
            this.desarrolladoresMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.AbrirAyuda_Click);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contactoToolStripMenuItem.Image")));
            this.contactoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.contactoToolStripMenuItem.Text = "Contacto";
            this.contactoToolStripMenuItem.Click += new System.EventHandler(this.AbrirContacto_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AbrirAcercaDe_Click);
            // 
            // PanelInicio
            // 
            this.PanelInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInicio.AutoSize = true;
            this.PanelInicio.Controls.Add(this.label2);
            this.PanelInicio.Controls.Add(this.label1);
            this.PanelInicio.Controls.Add(this.pictureBoxArroba);
            this.PanelInicio.Location = new System.Drawing.Point(0, 27);
            this.PanelInicio.Name = "PanelInicio";
            this.PanelInicio.Size = new System.Drawing.Size(798, 352);
            this.PanelInicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una opción del menú principal";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenidos al Gestor de Correos MailApp";
            // 
            // pictureBoxArroba
            // 
            this.pictureBoxArroba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxArroba.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArroba.Image")));
            this.pictureBoxArroba.InitialImage = null;
            this.pictureBoxArroba.Location = new System.Drawing.Point(528, 41);
            this.pictureBoxArroba.Name = "pictureBoxArroba";
            this.pictureBoxArroba.Size = new System.Drawing.Size(258, 270);
            this.pictureBoxArroba.TabIndex = 0;
            this.pictureBoxArroba.TabStop = false;
            // 
            // statusStripVentanaPrincipal
            // 
            this.statusStripVentanaPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEstadoConexion,
            this.toolStripStatusLabelHoraActual});
            this.statusStripVentanaPrincipal.Location = new System.Drawing.Point(0, 360);
            this.statusStripVentanaPrincipal.Name = "statusStripVentanaPrincipal";
            this.statusStripVentanaPrincipal.Size = new System.Drawing.Size(798, 22);
            this.statusStripVentanaPrincipal.TabIndex = 7;
            this.statusStripVentanaPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabelEstadoConexion
            // 
            this.toolStripStatusLabelEstadoConexion.Name = "toolStripStatusLabelEstadoConexion";
            this.toolStripStatusLabelEstadoConexion.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabelEstadoConexion.Text = "Estado de conexión a internet: ";
            // 
            // toolStripStatusLabelHoraActual
            // 
            this.toolStripStatusLabelHoraActual.Name = "toolStripStatusLabelHoraActual";
            this.toolStripStatusLabelHoraActual.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabelHoraActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.TimerHoraFechaActual_Tick);
            // 
            // PantallaPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 382);
            this.Controls.Add(this.statusStripVentanaPrincipal);
            this.Controls.Add(this.PanelInicio);
            this.Controls.Add(this.menuAcciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "PantallaPadre";
            this.Text = "MailApp - Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuAcciones.ResumeLayout(false);
            this.menuAcciones.PerformLayout();
            this.PanelInicio.ResumeLayout(false);
            this.PanelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArroba)).EndInit();
            this.statusStripVentanaPrincipal.ResumeLayout(false);
            this.statusStripVentanaPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuAcciones;
        private System.Windows.Forms.ToolStripMenuItem cuentasMenu;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correosMenu;
        private System.Windows.Forms.ToolStripMenuItem verCorreosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoresMenu;
        private System.Windows.Forms.ToolStripMenuItem descargarMailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInicio;
        private System.Windows.Forms.PictureBox pictureBoxArroba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem verCuentaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripVentanaPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEstadoConexion;
        private System.Windows.Forms.Timer timerRefrescar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoraActual;
        private System.Windows.Forms.Timer timerHoraActual;
    }
}



