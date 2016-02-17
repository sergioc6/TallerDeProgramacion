namespace GUI
{
    partial class AgregarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCuenta));
            this.panelAgregarNuevaCuenta = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregarCuenta = new System.Windows.Forms.Button();
            this.checkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelEjemploCuenta = new System.Windows.Forms.Label();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.textBoxDireccionCuenta = new System.Windows.Forms.TextBox();
            this.textBoxNombreCuenta = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelServicioMail = new System.Windows.Forms.Label();
            this.labelDireccionCuenta = new System.Windows.Forms.Label();
            this.labelNombreCuenta = new System.Windows.Forms.Label();
            this.panelAgregarNuevaCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregarNuevaCuenta
            // 
            this.panelAgregarNuevaCuenta.Controls.Add(this.buttonCancelar);
            this.panelAgregarNuevaCuenta.Controls.Add(this.buttonAgregarCuenta);
            this.panelAgregarNuevaCuenta.Controls.Add(this.checkBoxMostrarContraseña);
            this.panelAgregarNuevaCuenta.Controls.Add(this.textBoxContraseña);
            this.panelAgregarNuevaCuenta.Controls.Add(this.labelEjemploCuenta);
            this.panelAgregarNuevaCuenta.Controls.Add(this.comboBoxServicio);
            this.panelAgregarNuevaCuenta.Controls.Add(this.textBoxDireccionCuenta);
            this.panelAgregarNuevaCuenta.Controls.Add(this.textBoxNombreCuenta);
            this.panelAgregarNuevaCuenta.Controls.Add(this.labelContraseña);
            this.panelAgregarNuevaCuenta.Controls.Add(this.labelServicioMail);
            this.panelAgregarNuevaCuenta.Controls.Add(this.labelDireccionCuenta);
            this.panelAgregarNuevaCuenta.Controls.Add(this.labelNombreCuenta);
            this.panelAgregarNuevaCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAgregarNuevaCuenta.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarNuevaCuenta.Name = "panelAgregarNuevaCuenta";
            this.panelAgregarNuevaCuenta.Size = new System.Drawing.Size(472, 289);
            this.panelAgregarNuevaCuenta.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(265, 248);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 27);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.CerrarAgregarCuenta_Click);
            // 
            // buttonAgregarCuenta
            // 
            this.buttonAgregarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCuenta.Image")));
            this.buttonAgregarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarCuenta.Location = new System.Drawing.Point(142, 248);
            this.buttonAgregarCuenta.Name = "buttonAgregarCuenta";
            this.buttonAgregarCuenta.Size = new System.Drawing.Size(105, 27);
            this.buttonAgregarCuenta.TabIndex = 22;
            this.buttonAgregarCuenta.Text = "Agregar cuenta";
            this.buttonAgregarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarCuenta.UseVisualStyleBackColor = true;
            this.buttonAgregarCuenta.Click += new System.EventHandler(this.AgregarCuenta_Click);
            // 
            // checkBoxMostrarContraseña
            // 
            this.checkBoxMostrarContraseña.AutoSize = true;
            this.checkBoxMostrarContraseña.Location = new System.Drawing.Point(142, 212);
            this.checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            this.checkBoxMostrarContraseña.Size = new System.Drawing.Size(117, 17);
            this.checkBoxMostrarContraseña.TabIndex = 21;
            this.checkBoxMostrarContraseña.Text = "Mostrar contraseña";
            this.checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContraseña.Click += new System.EventHandler(this.MostrarContraseña_Click);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(142, 186);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(308, 20);
            this.textBoxContraseña.TabIndex = 20;
            // 
            // labelEjemploCuenta
            // 
            this.labelEjemploCuenta.AutoSize = true;
            this.labelEjemploCuenta.Location = new System.Drawing.Point(142, 98);
            this.labelEjemploCuenta.Name = "labelEjemploCuenta";
            this.labelEjemploCuenta.Size = new System.Drawing.Size(271, 13);
            this.labelEjemploCuenta.TabIndex = 19;
            this.labelEjemploCuenta.Text = "Por ejemplo: direcciónDeCorreo@servicioDeCorreo.com";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServicio.Location = new System.Drawing.Point(142, 129);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(308, 21);
            this.comboBoxServicio.TabIndex = 18;
            // 
            // textBoxDireccionCuenta
            // 
            this.textBoxDireccionCuenta.Location = new System.Drawing.Point(142, 71);
            this.textBoxDireccionCuenta.Name = "textBoxDireccionCuenta";
            this.textBoxDireccionCuenta.Size = new System.Drawing.Size(308, 20);
            this.textBoxDireccionCuenta.TabIndex = 17;
            // 
            // textBoxNombreCuenta
            // 
            this.textBoxNombreCuenta.Location = new System.Drawing.Point(142, 12);
            this.textBoxNombreCuenta.Name = "textBoxNombreCuenta";
            this.textBoxNombreCuenta.Size = new System.Drawing.Size(308, 20);
            this.textBoxNombreCuenta.TabIndex = 16;
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(23, 193);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 15;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelServicioMail
            // 
            this.labelServicioMail.AutoSize = true;
            this.labelServicioMail.Location = new System.Drawing.Point(23, 138);
            this.labelServicioMail.Name = "labelServicioMail";
            this.labelServicioMail.Size = new System.Drawing.Size(45, 13);
            this.labelServicioMail.TabIndex = 14;
            this.labelServicioMail.Text = "Servicio";
            // 
            // labelDireccionCuenta
            // 
            this.labelDireccionCuenta.AutoSize = true;
            this.labelDireccionCuenta.Location = new System.Drawing.Point(23, 79);
            this.labelDireccionCuenta.Name = "labelDireccionCuenta";
            this.labelDireccionCuenta.Size = new System.Drawing.Size(103, 13);
            this.labelDireccionCuenta.TabIndex = 13;
            this.labelDireccionCuenta.Text = "Dirección de cuenta";
            // 
            // labelNombreCuenta
            // 
            this.labelNombreCuenta.AutoSize = true;
            this.labelNombreCuenta.Location = new System.Drawing.Point(23, 20);
            this.labelNombreCuenta.Name = "labelNombreCuenta";
            this.labelNombreCuenta.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCuenta.TabIndex = 12;
            this.labelNombreCuenta.Text = "Nombre";
            // 
            // AgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 289);
            this.Controls.Add(this.panelAgregarNuevaCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Agregar nueva cuenta";
            this.panelAgregarNuevaCuenta.ResumeLayout(false);
            this.panelAgregarNuevaCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarNuevaCuenta;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAgregarCuenta;
        private System.Windows.Forms.CheckBox checkBoxMostrarContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelEjemploCuenta;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.TextBox textBoxDireccionCuenta;
        private System.Windows.Forms.TextBox textBoxNombreCuenta;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelServicioMail;
        private System.Windows.Forms.Label labelDireccionCuenta;
        private System.Windows.Forms.Label labelNombreCuenta;

    }
}