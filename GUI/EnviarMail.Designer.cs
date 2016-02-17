namespace GUI
{
    partial class EnviarMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMail));
            this.groupBoxInformacionMail = new System.Windows.Forms.GroupBox();
            this.treeViewAdjuntos = new System.Windows.Forms.TreeView();
            this.textBoxNombreRemitente = new System.Windows.Forms.TextBox();
            this.labelNombreRemitente = new System.Windows.Forms.Label();
            this.buttonQuitarAdjunto = new System.Windows.Forms.Button();
            this.buttonAdjuntarArchivos = new System.Windows.Forms.Button();
            this.comboBoxRemitente = new System.Windows.Forms.ComboBox();
            this.labelArchivosAdjuntos = new System.Windows.Forms.Label();
            this.textBoxAsuntoMail = new System.Windows.Forms.TextBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.textBoxFechaMail = new System.Windows.Forms.TextBox();
            this.labelCuerpo = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxCCO = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxDestinatarios = new System.Windows.Forms.TextBox();
            this.labelCCO = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelDestinatarios = new System.Windows.Forms.Label();
            this.labelRemitente = new System.Windows.Forms.Label();
            this.richTextBoxCuerpoMensajes = new System.Windows.Forms.RichTextBox();
            this.buttonEnviarEmail = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarBorrador = new System.Windows.Forms.Button();
            this.timerFechaHoraActual = new System.Windows.Forms.Timer(this.components);
            this.groupBoxInformacionMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformacionMail
            // 
            this.groupBoxInformacionMail.Controls.Add(this.treeViewAdjuntos);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxNombreRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.labelNombreRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.buttonQuitarAdjunto);
            this.groupBoxInformacionMail.Controls.Add(this.buttonAdjuntarArchivos);
            this.groupBoxInformacionMail.Controls.Add(this.comboBoxRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.labelArchivosAdjuntos);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxAsuntoMail);
            this.groupBoxInformacionMail.Controls.Add(this.labelAsunto);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxFechaMail);
            this.groupBoxInformacionMail.Controls.Add(this.labelCuerpo);
            this.groupBoxInformacionMail.Controls.Add(this.labelFecha);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxCCO);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxCC);
            this.groupBoxInformacionMail.Controls.Add(this.textBoxDestinatarios);
            this.groupBoxInformacionMail.Controls.Add(this.labelCCO);
            this.groupBoxInformacionMail.Controls.Add(this.labelCC);
            this.groupBoxInformacionMail.Controls.Add(this.labelDestinatarios);
            this.groupBoxInformacionMail.Controls.Add(this.labelRemitente);
            this.groupBoxInformacionMail.Controls.Add(this.richTextBoxCuerpoMensajes);
            this.groupBoxInformacionMail.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformacionMail.Name = "groupBoxInformacionMail";
            this.groupBoxInformacionMail.Size = new System.Drawing.Size(886, 328);
            this.groupBoxInformacionMail.TabIndex = 19;
            this.groupBoxInformacionMail.TabStop = false;
            this.groupBoxInformacionMail.Text = "Información del email";
            // 
            // treeViewAdjuntos
            // 
            this.treeViewAdjuntos.Location = new System.Drawing.Point(677, 41);
            this.treeViewAdjuntos.Name = "treeViewAdjuntos";
            this.treeViewAdjuntos.Size = new System.Drawing.Size(203, 245);
            this.treeViewAdjuntos.TabIndex = 23;
            // 
            // textBoxNombreRemitente
            // 
            this.textBoxNombreRemitente.Location = new System.Drawing.Point(96, 49);
            this.textBoxNombreRemitente.Name = "textBoxNombreRemitente";
            this.textBoxNombreRemitente.ReadOnly = true;
            this.textBoxNombreRemitente.Size = new System.Drawing.Size(227, 20);
            this.textBoxNombreRemitente.TabIndex = 22;
            // 
            // labelNombreRemitente
            // 
            this.labelNombreRemitente.AutoSize = true;
            this.labelNombreRemitente.Location = new System.Drawing.Point(7, 49);
            this.labelNombreRemitente.Name = "labelNombreRemitente";
            this.labelNombreRemitente.Size = new System.Drawing.Size(44, 13);
            this.labelNombreRemitente.TabIndex = 21;
            this.labelNombreRemitente.Text = "Nombre";
            // 
            // buttonQuitarAdjunto
            // 
            this.buttonQuitarAdjunto.Enabled = false;
            this.buttonQuitarAdjunto.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuitarAdjunto.Image")));
            this.buttonQuitarAdjunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuitarAdjunto.Location = new System.Drawing.Point(811, 292);
            this.buttonQuitarAdjunto.Name = "buttonQuitarAdjunto";
            this.buttonQuitarAdjunto.Size = new System.Drawing.Size(69, 31);
            this.buttonQuitarAdjunto.TabIndex = 20;
            this.buttonQuitarAdjunto.Text = "Quitar";
            this.buttonQuitarAdjunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuitarAdjunto.UseVisualStyleBackColor = true;
            this.buttonQuitarAdjunto.Click += new System.EventHandler(this.QuitarArchivoAdjunto_Click);
            // 
            // buttonAdjuntarArchivos
            // 
            this.buttonAdjuntarArchivos.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdjuntarArchivos.Image")));
            this.buttonAdjuntarArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdjuntarArchivos.Location = new System.Drawing.Point(677, 292);
            this.buttonAdjuntarArchivos.Name = "buttonAdjuntarArchivos";
            this.buttonAdjuntarArchivos.Size = new System.Drawing.Size(120, 31);
            this.buttonAdjuntarArchivos.TabIndex = 19;
            this.buttonAdjuntarArchivos.Text = "Adjuntar archivos";
            this.buttonAdjuntarArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdjuntarArchivos.UseVisualStyleBackColor = true;
            this.buttonAdjuntarArchivos.Click += new System.EventHandler(this.AdjuntarArchivos_Click);
            // 
            // comboBoxRemitente
            // 
            this.comboBoxRemitente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemitente.FormattingEnabled = true;
            this.comboBoxRemitente.Location = new System.Drawing.Point(96, 19);
            this.comboBoxRemitente.Name = "comboBoxRemitente";
            this.comboBoxRemitente.Size = new System.Drawing.Size(227, 21);
            this.comboBoxRemitente.TabIndex = 18;
            this.comboBoxRemitente.SelectedIndexChanged += new System.EventHandler(this.CambiarNombreRemitente_Click);
            // 
            // labelArchivosAdjuntos
            // 
            this.labelArchivosAdjuntos.AutoSize = true;
            this.labelArchivosAdjuntos.Location = new System.Drawing.Point(674, 22);
            this.labelArchivosAdjuntos.Name = "labelArchivosAdjuntos";
            this.labelArchivosAdjuntos.Size = new System.Drawing.Size(130, 13);
            this.labelArchivosAdjuntos.TabIndex = 17;
            this.labelArchivosAdjuntos.Text = "Lista de archivos adjuntos";
            // 
            // textBoxAsuntoMail
            // 
            this.textBoxAsuntoMail.Location = new System.Drawing.Point(385, 41);
            this.textBoxAsuntoMail.Multiline = true;
            this.textBoxAsuntoMail.Name = "textBoxAsuntoMail";
            this.textBoxAsuntoMail.Size = new System.Drawing.Size(283, 55);
            this.textBoxAsuntoMail.TabIndex = 16;
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Location = new System.Drawing.Point(341, 49);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(40, 13);
            this.labelAsunto.TabIndex = 15;
            this.labelAsunto.Text = "Asunto";
            // 
            // textBoxFechaMail
            // 
            this.textBoxFechaMail.Location = new System.Drawing.Point(385, 18);
            this.textBoxFechaMail.Name = "textBoxFechaMail";
            this.textBoxFechaMail.ReadOnly = true;
            this.textBoxFechaMail.Size = new System.Drawing.Size(283, 20);
            this.textBoxFechaMail.TabIndex = 14;
            // 
            // labelCuerpo
            // 
            this.labelCuerpo.AutoSize = true;
            this.labelCuerpo.Location = new System.Drawing.Point(6, 162);
            this.labelCuerpo.Name = "labelCuerpo";
            this.labelCuerpo.Size = new System.Drawing.Size(41, 13);
            this.labelCuerpo.TabIndex = 13;
            this.labelCuerpo.Text = "Cuerpo";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(341, 22);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(37, 13);
            this.labelFecha.TabIndex = 12;
            this.labelFecha.Text = "Fecha";
            // 
            // textBoxCCO
            // 
            this.textBoxCCO.Location = new System.Drawing.Point(96, 136);
            this.textBoxCCO.Multiline = true;
            this.textBoxCCO.Name = "textBoxCCO";
            this.textBoxCCO.Size = new System.Drawing.Size(227, 20);
            this.textBoxCCO.TabIndex = 11;
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(96, 110);
            this.textBoxCC.Multiline = true;
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(227, 20);
            this.textBoxCC.TabIndex = 10;
            // 
            // textBoxDestinatarios
            // 
            this.textBoxDestinatarios.Location = new System.Drawing.Point(96, 80);
            this.textBoxDestinatarios.Multiline = true;
            this.textBoxDestinatarios.Name = "textBoxDestinatarios";
            this.textBoxDestinatarios.Size = new System.Drawing.Size(227, 20);
            this.textBoxDestinatarios.TabIndex = 9;
            // 
            // labelCCO
            // 
            this.labelCCO.AutoSize = true;
            this.labelCCO.Location = new System.Drawing.Point(6, 139);
            this.labelCCO.Name = "labelCCO";
            this.labelCCO.Size = new System.Drawing.Size(29, 13);
            this.labelCCO.TabIndex = 7;
            this.labelCCO.Text = "CCO";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(6, 113);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(21, 13);
            this.labelCC.TabIndex = 6;
            this.labelCC.Text = "CC";
            // 
            // labelDestinatarios
            // 
            this.labelDestinatarios.AutoSize = true;
            this.labelDestinatarios.Location = new System.Drawing.Point(6, 83);
            this.labelDestinatarios.Name = "labelDestinatarios";
            this.labelDestinatarios.Size = new System.Drawing.Size(74, 13);
            this.labelDestinatarios.TabIndex = 5;
            this.labelDestinatarios.Text = "Destinatario(s)";
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
            // richTextBoxCuerpoMensajes
            // 
            this.richTextBoxCuerpoMensajes.Location = new System.Drawing.Point(9, 178);
            this.richTextBoxCuerpoMensajes.Name = "richTextBoxCuerpoMensajes";
            this.richTextBoxCuerpoMensajes.Size = new System.Drawing.Size(662, 145);
            this.richTextBoxCuerpoMensajes.TabIndex = 1;
            this.richTextBoxCuerpoMensajes.Text = "";
            // 
            // buttonEnviarEmail
            // 
            this.buttonEnviarEmail.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnviarEmail.Image")));
            this.buttonEnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnviarEmail.Location = new System.Drawing.Point(271, 346);
            this.buttonEnviarEmail.Name = "buttonEnviarEmail";
            this.buttonEnviarEmail.Size = new System.Drawing.Size(64, 33);
            this.buttonEnviarEmail.TabIndex = 20;
            this.buttonEnviarEmail.Text = "Enviar";
            this.buttonEnviarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnviarEmail.UseVisualStyleBackColor = true;
            this.buttonEnviarEmail.Click += new System.EventHandler(this.EnviarMail_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(493, 346);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 33);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.CerrarEnviarMail_Click);
            // 
            // buttonGuardarBorrador
            // 
            this.buttonGuardarBorrador.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarBorrador.Image")));
            this.buttonGuardarBorrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardarBorrador.Location = new System.Drawing.Point(340, 346);
            this.buttonGuardarBorrador.Name = "buttonGuardarBorrador";
            this.buttonGuardarBorrador.Size = new System.Drawing.Size(147, 33);
            this.buttonGuardarBorrador.TabIndex = 22;
            this.buttonGuardarBorrador.Text = "Guardar como borrador";
            this.buttonGuardarBorrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardarBorrador.UseVisualStyleBackColor = true;
            this.buttonGuardarBorrador.Click += new System.EventHandler(this.GuardarBorrador_Click);
            // 
            // timerFechaHoraActual
            // 
            this.timerFechaHoraActual.Tick += new System.EventHandler(this.TimerHoraFechaActual_Tick);
            // 
            // EnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 391);
            this.Controls.Add(this.buttonGuardarBorrador);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEnviarEmail);
            this.Controls.Add(this.groupBoxInformacionMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Enviar mail";
            this.groupBoxInformacionMail.ResumeLayout(false);
            this.groupBoxInformacionMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformacionMail;
        private System.Windows.Forms.Button buttonQuitarAdjunto;
        private System.Windows.Forms.Button buttonAdjuntarArchivos;
        private System.Windows.Forms.ComboBox comboBoxRemitente;
        private System.Windows.Forms.Label labelArchivosAdjuntos;
        private System.Windows.Forms.TextBox textBoxAsuntoMail;
        private System.Windows.Forms.Label labelAsunto;
        private System.Windows.Forms.TextBox textBoxFechaMail;
        private System.Windows.Forms.Label labelCuerpo;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxCCO;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxDestinatarios;
        private System.Windows.Forms.Label labelCCO;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelDestinatarios;
        private System.Windows.Forms.Label labelRemitente;
        private System.Windows.Forms.RichTextBox richTextBoxCuerpoMensajes;
        private System.Windows.Forms.Button buttonEnviarEmail;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarBorrador;
        private System.Windows.Forms.TextBox textBoxNombreRemitente;
        private System.Windows.Forms.Label labelNombreRemitente;
        private System.Windows.Forms.TreeView treeViewAdjuntos;
        private System.Windows.Forms.Timer timerFechaHoraActual;
    }
}