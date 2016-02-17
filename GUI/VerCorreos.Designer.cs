namespace GUI
{
    partial class VerCorreos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCorreos));
            this.richTextBoxCuerpoMensajes = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxMostrarTodos = new System.Windows.Forms.CheckBox();
            this.checkBoxMostrarEnviados = new System.Windows.Forms.CheckBox();
            this.checkBoxMostrarRecibidos = new System.Windows.Forms.CheckBox();
            this.checkBoxBorradores = new System.Windows.Forms.CheckBox();
            this.labelRemitente = new System.Windows.Forms.Label();
            this.labelDestinatarios = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelCCO = new System.Windows.Forms.Label();
            this.textBoxRemitente = new System.Windows.Forms.TextBox();
            this.textBoxDestinatarios = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxCCO = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelCuerpo = new System.Windows.Forms.Label();
            this.textBoxFechaMail = new System.Windows.Forms.TextBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.textBoxAsuntoMail = new System.Windows.Forms.TextBox();
            this.groupBoxInformacionMail = new System.Windows.Forms.GroupBox();
            this.textBoxIDMail = new System.Windows.Forms.TextBox();
            this.labelIDMail = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.comboBoxFiltroCuentas = new System.Windows.Forms.ComboBox();
            this.labelFiltrarCuenta = new System.Windows.Forms.Label();
            this.dataGridViewCorreos = new System.Windows.Forms.DataGridView();
            this.IdMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanelOpciones.SuspendLayout();
            this.groupBoxInformacionMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxCuerpoMensajes
            // 
            this.richTextBoxCuerpoMensajes.Location = new System.Drawing.Point(9, 139);
            this.richTextBoxCuerpoMensajes.Name = "richTextBoxCuerpoMensajes";
            this.richTextBoxCuerpoMensajes.ReadOnly = true;
            this.richTextBoxCuerpoMensajes.Size = new System.Drawing.Size(839, 115);
            this.richTextBoxCuerpoMensajes.TabIndex = 1;
            this.richTextBoxCuerpoMensajes.Text = "";
            // 
            // flowLayoutPanelOpciones
            // 
            this.flowLayoutPanelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelOpciones.Controls.Add(this.checkBoxMostrarTodos);
            this.flowLayoutPanelOpciones.Controls.Add(this.checkBoxMostrarEnviados);
            this.flowLayoutPanelOpciones.Controls.Add(this.checkBoxMostrarRecibidos);
            this.flowLayoutPanelOpciones.Controls.Add(this.checkBoxBorradores);
            this.flowLayoutPanelOpciones.Location = new System.Drawing.Point(6, 12);
            this.flowLayoutPanelOpciones.Name = "flowLayoutPanelOpciones";
            this.flowLayoutPanelOpciones.Size = new System.Drawing.Size(90, 96);
            this.flowLayoutPanelOpciones.TabIndex = 3;
            // 
            // checkBoxMostrarTodos
            // 
            this.checkBoxMostrarTodos.AutoSize = true;
            this.checkBoxMostrarTodos.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMostrarTodos.Name = "checkBoxMostrarTodos";
            this.checkBoxMostrarTodos.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMostrarTodos.TabIndex = 0;
            this.checkBoxMostrarTodos.Text = "Todos";
            this.checkBoxMostrarTodos.UseVisualStyleBackColor = true;
            this.checkBoxMostrarTodos.Click += new System.EventHandler(this.MostrarTodos);
            // 
            // checkBoxMostrarEnviados
            // 
            this.checkBoxMostrarEnviados.AutoSize = true;
            this.checkBoxMostrarEnviados.Location = new System.Drawing.Point(3, 26);
            this.checkBoxMostrarEnviados.Name = "checkBoxMostrarEnviados";
            this.checkBoxMostrarEnviados.Size = new System.Drawing.Size(70, 17);
            this.checkBoxMostrarEnviados.TabIndex = 1;
            this.checkBoxMostrarEnviados.Text = "Enviados";
            this.checkBoxMostrarEnviados.UseVisualStyleBackColor = true;
            this.checkBoxMostrarEnviados.Click += new System.EventHandler(this.MostrarEnviados);
            // 
            // checkBoxMostrarRecibidos
            // 
            this.checkBoxMostrarRecibidos.AutoSize = true;
            this.checkBoxMostrarRecibidos.Location = new System.Drawing.Point(3, 49);
            this.checkBoxMostrarRecibidos.Name = "checkBoxMostrarRecibidos";
            this.checkBoxMostrarRecibidos.Size = new System.Drawing.Size(73, 17);
            this.checkBoxMostrarRecibidos.TabIndex = 2;
            this.checkBoxMostrarRecibidos.Text = "Recibidos";
            this.checkBoxMostrarRecibidos.UseVisualStyleBackColor = true;
            this.checkBoxMostrarRecibidos.Click += new System.EventHandler(this.MostrarRecibidos);
            // 
            // checkBoxBorradores
            // 
            this.checkBoxBorradores.AutoSize = true;
            this.checkBoxBorradores.Location = new System.Drawing.Point(3, 72);
            this.checkBoxBorradores.Name = "checkBoxBorradores";
            this.checkBoxBorradores.Size = new System.Drawing.Size(77, 17);
            this.checkBoxBorradores.TabIndex = 3;
            this.checkBoxBorradores.Text = "Borradores";
            this.checkBoxBorradores.UseVisualStyleBackColor = true;
            this.checkBoxBorradores.Click += new System.EventHandler(this.MostrarBorradores);
            // 
            // labelRemitente
            // 
            this.labelRemitente.AutoSize = true;
            this.labelRemitente.Location = new System.Drawing.Point(6, 26);
            this.labelRemitente.Name = "labelRemitente";
            this.labelRemitente.Size = new System.Drawing.Size(55, 13);
            this.labelRemitente.TabIndex = 4;
            this.labelRemitente.Text = "Remitente";
            // 
            // labelDestinatarios
            // 
            this.labelDestinatarios.AutoSize = true;
            this.labelDestinatarios.Location = new System.Drawing.Point(6, 49);
            this.labelDestinatarios.Name = "labelDestinatarios";
            this.labelDestinatarios.Size = new System.Drawing.Size(74, 13);
            this.labelDestinatarios.TabIndex = 5;
            this.labelDestinatarios.Text = "Destinatario(s)";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(6, 75);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(21, 13);
            this.labelCC.TabIndex = 6;
            this.labelCC.Text = "CC";
            // 
            // labelCCO
            // 
            this.labelCCO.AutoSize = true;
            this.labelCCO.Location = new System.Drawing.Point(6, 98);
            this.labelCCO.Name = "labelCCO";
            this.labelCCO.Size = new System.Drawing.Size(29, 13);
            this.labelCCO.TabIndex = 7;
            this.labelCCO.Text = "CCO";
            // 
            // textBoxRemitente
            // 
            this.textBoxRemitente.Location = new System.Drawing.Point(96, 19);
            this.textBoxRemitente.Name = "textBoxRemitente";
            this.textBoxRemitente.ReadOnly = true;
            this.textBoxRemitente.Size = new System.Drawing.Size(361, 20);
            this.textBoxRemitente.TabIndex = 8;
            // 
            // textBoxDestinatarios
            // 
            this.textBoxDestinatarios.Location = new System.Drawing.Point(96, 42);
            this.textBoxDestinatarios.Name = "textBoxDestinatarios";
            this.textBoxDestinatarios.ReadOnly = true;
            this.textBoxDestinatarios.Size = new System.Drawing.Size(361, 20);
            this.textBoxDestinatarios.TabIndex = 9;
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(96, 67);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ReadOnly = true;
            this.textBoxCC.Size = new System.Drawing.Size(361, 20);
            this.textBoxCC.TabIndex = 10;
            // 
            // textBoxCCO
            // 
            this.textBoxCCO.Location = new System.Drawing.Point(96, 90);
            this.textBoxCCO.Name = "textBoxCCO";
            this.textBoxCCO.ReadOnly = true;
            this.textBoxCCO.Size = new System.Drawing.Size(361, 20);
            this.textBoxCCO.TabIndex = 11;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(463, 16);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha";
            // 
            // labelCuerpo
            // 
            this.labelCuerpo.AutoSize = true;
            this.labelCuerpo.Location = new System.Drawing.Point(6, 123);
            this.labelCuerpo.Name = "labelCuerpo";
            this.labelCuerpo.Size = new System.Drawing.Size(41, 13);
            this.labelCuerpo.TabIndex = 13;
            this.labelCuerpo.Text = "Cuerpo";
            // 
            // textBoxFechaMail
            // 
            this.textBoxFechaMail.Location = new System.Drawing.Point(506, 16);
            this.textBoxFechaMail.Name = "textBoxFechaMail";
            this.textBoxFechaMail.ReadOnly = true;
            this.textBoxFechaMail.Size = new System.Drawing.Size(162, 20);
            this.textBoxFechaMail.TabIndex = 14;
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Location = new System.Drawing.Point(463, 42);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(40, 13);
            this.labelAsunto.TabIndex = 15;
            this.labelAsunto.Text = "Asunto";
            // 
            // textBoxAsuntoMail
            // 
            this.textBoxAsuntoMail.Location = new System.Drawing.Point(506, 46);
            this.textBoxAsuntoMail.Multiline = true;
            this.textBoxAsuntoMail.Name = "textBoxAsuntoMail";
            this.textBoxAsuntoMail.ReadOnly = true;
            this.textBoxAsuntoMail.Size = new System.Drawing.Size(162, 69);
            this.textBoxAsuntoMail.TabIndex = 16;
            // 
            // groupBoxInformacionMail
            // 
            this.groupBoxInformacionMail.Controls.Add(this.textBoxIDMail);
            this.groupBoxInformacionMail.Controls.Add(this.labelIDMail);
            this.groupBoxInformacionMail.Controls.Add(this.button2);
            this.groupBoxInformacionMail.Controls.Add(this.button1);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxAsuntoMail);
            this.groupBoxInformacionMail.Controls.Add(this.labelAsunto);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxFechaMail);
            this.groupBoxInformacionMail.Controls.Add(this.labelCuerpo);
            this.groupBoxInformacionMail.Controls.Add(this.labelFecha);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxCCO);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxCC);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxDestinatarios);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.labelCCO);
            this.groupBoxInformacionMail.Controls.Add(this.labelCC);
            this.groupBoxInformacionMail.Controls.Add(this.labelDestinatarios);
            this.groupBoxInformacionMail.Controls.Add(this.labelRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.richTextBoxCuerpoMensajes);
            this.groupBoxInformacionMail.Location = new System.Drawing.Point(102, 243);
            this.groupBoxInformacionMail.Name = "groupBoxInformacionMail";
            this.groupBoxInformacionMail.Size = new System.Drawing.Size(863, 314);
            this.groupBoxInformacionMail.TabIndex = 18;
            this.groupBoxInformacionMail.TabStop = false;
            this.groupBoxInformacionMail.Text = "Información del email";
            // 
            // textBoxIDMail
            // 
            this.textBoxIDMail.Location = new System.Drawing.Point(722, 16);
            this.textBoxIDMail.Name = "textBoxIDMail";
            this.textBoxIDMail.ReadOnly = true;
            this.textBoxIDMail.Size = new System.Drawing.Size(135, 20);
            this.textBoxIDMail.TabIndex = 26;
            // 
            // labelIDMail
            // 
            this.labelIDMail.AutoSize = true;
            this.labelIDMail.Location = new System.Drawing.Point(675, 16);
            this.labelIDMail.Name = "labelIDMail";
            this.labelIDMail.Size = new System.Drawing.Size(40, 13);
            this.labelIDMail.TabIndex = 25;
            this.labelIDMail.Text = "ID Mail";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(466, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Exportar a TXT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ExportarTXT_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(252, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exportar a EML";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExportarEML_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(484, 568);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 19;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.CerrarVerCorreos_Click);
            // 
            // comboBoxFiltroCuentas
            // 
            this.comboBoxFiltroCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroCuentas.FormattingEnabled = true;
            this.comboBoxFiltroCuentas.Location = new System.Drawing.Point(860, 29);
            this.comboBoxFiltroCuentas.Name = "comboBoxFiltroCuentas";
            this.comboBoxFiltroCuentas.Size = new System.Drawing.Size(192, 21);
            this.comboBoxFiltroCuentas.TabIndex = 20;
            this.comboBoxFiltroCuentas.SelectedIndexChanged += new System.EventHandler(this.TodosLosMails_Click);
            // 
            // labelFiltrarCuenta
            // 
            this.labelFiltrarCuenta.AutoSize = true;
            this.labelFiltrarCuenta.Location = new System.Drawing.Point(860, 13);
            this.labelFiltrarCuenta.Name = "labelFiltrarCuenta";
            this.labelFiltrarCuenta.Size = new System.Drawing.Size(86, 13);
            this.labelFiltrarCuenta.TabIndex = 21;
            this.labelFiltrarCuenta.Text = "Filtrar por cuenta";
            // 
            // dataGridViewCorreos
            // 
            this.dataGridViewCorreos.AllowUserToAddRows = false;
            this.dataGridViewCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMail,
            this.Remitente,
            this.Cuenta,
            this.Asunto,
            this.Fecha,
            this.Estado,
            this.Leido});
            this.dataGridViewCorreos.Location = new System.Drawing.Point(102, 13);
            this.dataGridViewCorreos.Name = "dataGridViewCorreos";
            this.dataGridViewCorreos.Size = new System.Drawing.Size(752, 224);
            this.dataGridViewCorreos.TabIndex = 22;
            this.dataGridViewCorreos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerInformacionMail_Click);
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
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Leido
            // 
            this.Leido.HeaderText = "Leido";
            this.Leido.Name = "Leido";
            this.Leido.ReadOnly = true;
            // 
            // VerCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 603);
            this.Controls.Add(this.dataGridViewCorreos);
            this.Controls.Add(this.labelFiltrarCuenta);
            this.Controls.Add(this.comboBoxFiltroCuentas);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.groupBoxInformacionMail);
            this.Controls.Add(this.flowLayoutPanelOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerCorreos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Ver correos";
            this.flowLayoutPanelOpciones.ResumeLayout(false);
            this.flowLayoutPanelOpciones.PerformLayout();
            this.groupBoxInformacionMail.ResumeLayout(false);
            this.groupBoxInformacionMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorreos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCuerpoMensajes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOpciones;
        private System.Windows.Forms.Label labelRemitente;
        private System.Windows.Forms.Label labelDestinatarios;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelCCO;
        private System.Windows.Forms.TextBox textBoxRemitente;
        private System.Windows.Forms.TextBox textBoxDestinatarios;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxCCO;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelCuerpo;
        private System.Windows.Forms.TextBox textBoxFechaMail;
        private System.Windows.Forms.Label labelAsunto;
        private System.Windows.Forms.TextBox textBoxAsuntoMail;
        private System.Windows.Forms.GroupBox groupBoxInformacionMail;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.ComboBox comboBoxFiltroCuentas;
        private System.Windows.Forms.Label labelFiltrarCuenta;
        private System.Windows.Forms.DataGridView dataGridViewCorreos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxMostrarTodos;
        private System.Windows.Forms.CheckBox checkBoxMostrarEnviados;
        private System.Windows.Forms.CheckBox checkBoxMostrarRecibidos;
        private System.Windows.Forms.CheckBox checkBoxBorradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leido;
        private System.Windows.Forms.TextBox textBoxIDMail;
        private System.Windows.Forms.Label labelIDMail;
    }
}