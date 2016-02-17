namespace GUI
{
    partial class DescargarMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescargarMensajes));
            this.labelUsuarioConectado = new System.Windows.Forms.Label();
            this.comboBoxCuentasDisponibles = new System.Windows.Forms.ComboBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.labelPuerto = new System.Windows.Forms.Label();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.buttonDescargarMensajes = new System.Windows.Forms.Button();
            this.groupBoxMensajes = new System.Windows.Forms.GroupBox();
            this.dataGridViewMensajes = new System.Windows.Forms.DataGridView();
            this.IdMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuerpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCCO = new System.Windows.Forms.TextBox();
            this.labelCCO = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.labelCC = new System.Windows.Forms.Label();
            this.textBoxDestinatarios = new System.Windows.Forms.TextBox();
            this.labelDestinatarios = new System.Windows.Forms.Label();
            this.textBoxRemitente = new System.Windows.Forms.TextBox();
            this.labelRemitenteCorreo = new System.Windows.Forms.Label();
            this.groupBoxInfoMensajes = new System.Windows.Forms.GroupBox();
            this.textBoxFechaMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAsuntoMail = new System.Windows.Forms.TextBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.textBoxCuerpoMensaje = new System.Windows.Forms.TextBox();
            this.labelCuerpoMensaje = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBoxMensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMensajes)).BeginInit();
            this.groupBoxInfoMensajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsuarioConectado
            // 
            this.labelUsuarioConectado.AutoSize = true;
            this.labelUsuarioConectado.Location = new System.Drawing.Point(13, 13);
            this.labelUsuarioConectado.Name = "labelUsuarioConectado";
            this.labelUsuarioConectado.Size = new System.Drawing.Size(43, 13);
            this.labelUsuarioConectado.TabIndex = 0;
            this.labelUsuarioConectado.Text = "Usuario";
            // 
            // comboBoxCuentasDisponibles
            // 
            this.comboBoxCuentasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCuentasDisponibles.FormattingEnabled = true;
            this.comboBoxCuentasDisponibles.Location = new System.Drawing.Point(62, 10);
            this.comboBoxCuentasDisponibles.Name = "comboBoxCuentasDisponibles";
            this.comboBoxCuentasDisponibles.Size = new System.Drawing.Size(189, 21);
            this.comboBoxCuentasDisponibles.TabIndex = 1;
            this.comboBoxCuentasDisponibles.SelectedIndexChanged += new System.EventHandler(this.SeleccionarItemComboBox_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(259, 13);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 2;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(326, 10);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.ReadOnly = true;
            this.textBoxContraseña.Size = new System.Drawing.Size(168, 20);
            this.textBoxContraseña.TabIndex = 3;
            // 
            // checkBoxMostrarContraseña
            // 
            this.checkBoxMostrarContraseña.AutoSize = true;
            this.checkBoxMostrarContraseña.Location = new System.Drawing.Point(326, 37);
            this.checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            this.checkBoxMostrarContraseña.Size = new System.Drawing.Size(117, 17);
            this.checkBoxMostrarContraseña.TabIndex = 4;
            this.checkBoxMostrarContraseña.Text = "Mostrar contraseña";
            this.checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContraseña.Click += new System.EventHandler(this.MostrarContraseña_Click);
            // 
            // labelPuerto
            // 
            this.labelPuerto.AutoSize = true;
            this.labelPuerto.Location = new System.Drawing.Point(500, 13);
            this.labelPuerto.Name = "labelPuerto";
            this.labelPuerto.Size = new System.Drawing.Size(38, 13);
            this.labelPuerto.TabIndex = 5;
            this.labelPuerto.Text = "Puerto";
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(544, 10);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.ReadOnly = true;
            this.textBoxPuerto.Size = new System.Drawing.Size(87, 20);
            this.textBoxPuerto.TabIndex = 6;
            // 
            // buttonDescargarMensajes
            // 
            this.buttonDescargarMensajes.Image = ((System.Drawing.Image)(resources.GetObject("buttonDescargarMensajes.Image")));
            this.buttonDescargarMensajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDescargarMensajes.Location = new System.Drawing.Point(637, 8);
            this.buttonDescargarMensajes.Name = "buttonDescargarMensajes";
            this.buttonDescargarMensajes.Size = new System.Drawing.Size(97, 39);
            this.buttonDescargarMensajes.TabIndex = 8;
            this.buttonDescargarMensajes.Text = "Descargar";
            this.buttonDescargarMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDescargarMensajes.UseVisualStyleBackColor = true;
            this.buttonDescargarMensajes.Click += new System.EventHandler(this.DescargarMensajes_Click);
            // 
            // groupBoxMensajes
            // 
            this.groupBoxMensajes.Controls.Add(this.dataGridViewMensajes);
            this.groupBoxMensajes.Location = new System.Drawing.Point(12, 60);
            this.groupBoxMensajes.Name = "groupBoxMensajes";
            this.groupBoxMensajes.Size = new System.Drawing.Size(803, 161);
            this.groupBoxMensajes.TabIndex = 9;
            this.groupBoxMensajes.TabStop = false;
            this.groupBoxMensajes.Text = "Mensajes";
            // 
            // dataGridViewMensajes
            // 
            this.dataGridViewMensajes.AllowUserToAddRows = false;
            this.dataGridViewMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMensajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMail,
            this.Remitente,
            this.Asunto,
            this.Cuerpo,
            this.Fecha,
            this.Leido});
            this.dataGridViewMensajes.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewMensajes.Name = "dataGridViewMensajes";
            this.dataGridViewMensajes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMensajes.Size = new System.Drawing.Size(780, 136);
            this.dataGridViewMensajes.TabIndex = 0;
            this.dataGridViewMensajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerInformacionMail_Click);
            // 
            // IdMail
            // 
            this.IdMail.HeaderText = "Id Mail";
            this.IdMail.Name = "IdMail";
            this.IdMail.ReadOnly = true;
            // 
            // Remitente
            // 
            this.Remitente.HeaderText = "Remitente";
            this.Remitente.Name = "Remitente";
            this.Remitente.ReadOnly = true;
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            // 
            // Cuerpo
            // 
            this.Cuerpo.HeaderText = "Cuerpo";
            this.Cuerpo.Name = "Cuerpo";
            this.Cuerpo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Leido
            // 
            this.Leido.HeaderText = "Leido";
            this.Leido.Name = "Leido";
            this.Leido.ReadOnly = true;
            // 
            // textBoxCCO
            // 
            this.textBoxCCO.Location = new System.Drawing.Point(585, 19);
            this.textBoxCCO.Multiline = true;
            this.textBoxCCO.Name = "textBoxCCO";
            this.textBoxCCO.ReadOnly = true;
            this.textBoxCCO.Size = new System.Drawing.Size(204, 77);
            this.textBoxCCO.TabIndex = 7;
            // 
            // labelCCO
            // 
            this.labelCCO.AutoSize = true;
            this.labelCCO.Location = new System.Drawing.Point(550, 22);
            this.labelCCO.Name = "labelCCO";
            this.labelCCO.Size = new System.Drawing.Size(29, 13);
            this.labelCCO.TabIndex = 6;
            this.labelCCO.Text = "CCO";
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(340, 19);
            this.textBoxCC.Multiline = true;
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new System.Drawing.Size(204, 77);
            this.textBoxCC.TabIndex = 5;
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(313, 22);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(21, 13);
            this.labelCC.TabIndex = 4;
            this.labelCC.Text = "CC";
            // 
            // textBoxDestinatarios
            // 
            this.textBoxDestinatarios.Location = new System.Drawing.Point(85, 45);
            this.textBoxDestinatarios.Multiline = true;
            this.textBoxDestinatarios.Name = "textBoxDestinatarios";
            this.textBoxDestinatarios.ReadOnly = true;
            this.textBoxDestinatarios.Size = new System.Drawing.Size(222, 51);
            this.textBoxDestinatarios.TabIndex = 3;
            // 
            // labelDestinatarios
            // 
            this.labelDestinatarios.AutoSize = true;
            this.labelDestinatarios.Location = new System.Drawing.Point(5, 42);
            this.labelDestinatarios.Name = "labelDestinatarios";
            this.labelDestinatarios.Size = new System.Drawing.Size(74, 13);
            this.labelDestinatarios.TabIndex = 2;
            this.labelDestinatarios.Text = "Destinatario(s)";
            // 
            // textBoxRemitente
            // 
            this.textBoxRemitente.Location = new System.Drawing.Point(85, 19);
            this.textBoxRemitente.Name = "textBoxRemitente";
            this.textBoxRemitente.ReadOnly = true;
            this.textBoxRemitente.Size = new System.Drawing.Size(222, 20);
            this.textBoxRemitente.TabIndex = 1;
            // 
            // labelRemitenteCorreo
            // 
            this.labelRemitenteCorreo.AutoSize = true;
            this.labelRemitenteCorreo.Location = new System.Drawing.Point(5, 22);
            this.labelRemitenteCorreo.Name = "labelRemitenteCorreo";
            this.labelRemitenteCorreo.Size = new System.Drawing.Size(55, 13);
            this.labelRemitenteCorreo.TabIndex = 0;
            this.labelRemitenteCorreo.Text = "Remitente";
            // 
            // groupBoxInfoMensajes
            // 
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxFechaMail);
            this.groupBoxInfoMensajes.Controls.Add(this.label1);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxAsuntoMail);
            this.groupBoxInfoMensajes.Controls.Add(this.labelAsunto);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxCCO);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxCuerpoMensaje);
            this.groupBoxInfoMensajes.Controls.Add(this.labelCCO);
            this.groupBoxInfoMensajes.Controls.Add(this.labelCuerpoMensaje);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxCC);
            this.groupBoxInfoMensajes.Controls.Add(this.labelCC);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxDestinatarios);
            this.groupBoxInfoMensajes.Controls.Add(this.labelDestinatarios);
            this.groupBoxInfoMensajes.Controls.Add(this.labelRemitenteCorreo);
            this.groupBoxInfoMensajes.Controls.Add(this.textBoxRemitente);
            this.groupBoxInfoMensajes.Location = new System.Drawing.Point(12, 227);
            this.groupBoxInfoMensajes.Name = "groupBoxInfoMensajes";
            this.groupBoxInfoMensajes.Size = new System.Drawing.Size(803, 323);
            this.groupBoxInfoMensajes.TabIndex = 17;
            this.groupBoxInfoMensajes.TabStop = false;
            this.groupBoxInfoMensajes.Text = "Información del mensaje";
            // 
            // textBoxFechaMail
            // 
            this.textBoxFechaMail.Location = new System.Drawing.Point(384, 112);
            this.textBoxFechaMail.Name = "textBoxFechaMail";
            this.textBoxFechaMail.ReadOnly = true;
            this.textBoxFechaMail.Size = new System.Drawing.Size(160, 20);
            this.textBoxFechaMail.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha";
            // 
            // textBoxAsuntoMail
            // 
            this.textBoxAsuntoMail.Location = new System.Drawing.Point(85, 112);
            this.textBoxAsuntoMail.Multiline = true;
            this.textBoxAsuntoMail.Name = "textBoxAsuntoMail";
            this.textBoxAsuntoMail.ReadOnly = true;
            this.textBoxAsuntoMail.Size = new System.Drawing.Size(222, 49);
            this.textBoxAsuntoMail.TabIndex = 26;
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Location = new System.Drawing.Point(6, 112);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(40, 13);
            this.labelAsunto.TabIndex = 25;
            this.labelAsunto.Text = "Asunto";
            // 
            // textBoxCuerpoMensaje
            // 
            this.textBoxCuerpoMensaje.Location = new System.Drawing.Point(6, 180);
            this.textBoxCuerpoMensaje.Multiline = true;
            this.textBoxCuerpoMensaje.Name = "textBoxCuerpoMensaje";
            this.textBoxCuerpoMensaje.ReadOnly = true;
            this.textBoxCuerpoMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCuerpoMensaje.Size = new System.Drawing.Size(783, 137);
            this.textBoxCuerpoMensaje.TabIndex = 24;
            // 
            // labelCuerpoMensaje
            // 
            this.labelCuerpoMensaje.AutoSize = true;
            this.labelCuerpoMensaje.Location = new System.Drawing.Point(6, 164);
            this.labelCuerpoMensaje.Name = "labelCuerpoMensaje";
            this.labelCuerpoMensaje.Size = new System.Drawing.Size(100, 13);
            this.labelCuerpoMensaje.TabIndex = 23;
            this.labelCuerpoMensaje.Text = "Cuerpo del mensaje";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(740, 8);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 39);
            this.buttonCerrar.TabIndex = 19;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.CerrarDescargarMensajes_Click);
            // 
            // DescargarMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 562);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.groupBoxInfoMensajes);
            this.Controls.Add(this.groupBoxMensajes);
            this.Controls.Add(this.buttonDescargarMensajes);
            this.Controls.Add(this.textBoxPuerto);
            this.Controls.Add(this.labelPuerto);
            this.Controls.Add(this.checkBoxMostrarContraseña);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.comboBoxCuentasDisponibles);
            this.Controls.Add(this.labelUsuarioConectado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DescargarMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Descargar mensajes";
            this.groupBoxMensajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMensajes)).EndInit();
            this.groupBoxInfoMensajes.ResumeLayout(false);
            this.groupBoxInfoMensajes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuarioConectado;
        private System.Windows.Forms.ComboBox comboBoxCuentasDisponibles;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.CheckBox checkBoxMostrarContraseña;
        private System.Windows.Forms.Label labelPuerto;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.Button buttonDescargarMensajes;
        private System.Windows.Forms.GroupBox groupBoxMensajes;
        private System.Windows.Forms.TextBox textBoxCCO;
        private System.Windows.Forms.Label labelCCO;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.TextBox textBoxDestinatarios;
        private System.Windows.Forms.Label labelDestinatarios;
        private System.Windows.Forms.TextBox textBoxRemitente;
        private System.Windows.Forms.Label labelRemitenteCorreo;
        private System.Windows.Forms.GroupBox groupBoxInfoMensajes;
        private System.Windows.Forms.TextBox textBoxCuerpoMensaje;
        private System.Windows.Forms.Label labelCuerpoMensaje;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridView dataGridViewMensajes;
        private System.Windows.Forms.TextBox textBoxAsuntoMail;
        private System.Windows.Forms.Label labelAsunto;
        private System.Windows.Forms.TextBox textBoxFechaMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuerpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leido;
    }
}