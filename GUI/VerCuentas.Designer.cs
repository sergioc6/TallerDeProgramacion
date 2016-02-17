namespace GUI
{
    partial class VerCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCuentas));
            this.buttonBuscarCuenta = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.labelCuentasDisponibles = new System.Windows.Forms.Label();
            this.dataGridViewDatosCuentas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxConfiguracionCuenta = new System.Windows.Forms.GroupBox();
            this.checkBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelServicio = new System.Windows.Forms.Label();
            this.textBoxServicio = new System.Windows.Forms.TextBox();
            this.labelDireccionCuenta = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombreCuenta = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCuentas)).BeginInit();
            this.groupBoxConfiguracionCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarCuenta
            // 
            this.buttonBuscarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCuenta.Image")));
            this.buttonBuscarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCuenta.Location = new System.Drawing.Point(12, 15);
            this.buttonBuscarCuenta.Name = "buttonBuscarCuenta";
            this.buttonBuscarCuenta.Size = new System.Drawing.Size(109, 38);
            this.buttonBuscarCuenta.TabIndex = 0;
            this.buttonBuscarCuenta.Text = "Buscar cuenta";
            this.buttonBuscarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuenta.UseVisualStyleBackColor = true;
            this.buttonBuscarCuenta.Click += new System.EventHandler(this.BuscarCuenta_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(142, 25);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(343, 20);
            this.textBoxBuscador.TabIndex = 1;
            // 
            // labelCuentasDisponibles
            // 
            this.labelCuentasDisponibles.AutoSize = true;
            this.labelCuentasDisponibles.Location = new System.Drawing.Point(12, 63);
            this.labelCuentasDisponibles.Name = "labelCuentasDisponibles";
            this.labelCuentasDisponibles.Size = new System.Drawing.Size(46, 13);
            this.labelCuentasDisponibles.TabIndex = 3;
            this.labelCuentasDisponibles.Text = "Cuentas";
            // 
            // dataGridViewDatosCuentas
            // 
            this.dataGridViewDatosCuentas.AllowUserToAddRows = false;
            this.dataGridViewDatosCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.Servicio});
            this.dataGridViewDatosCuentas.Location = new System.Drawing.Point(142, 63);
            this.dataGridViewDatosCuentas.Name = "dataGridViewDatosCuentas";
            this.dataGridViewDatosCuentas.Size = new System.Drawing.Size(343, 190);
            this.dataGridViewDatosCuentas.TabIndex = 5;
            this.dataGridViewDatosCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVerDatosCuenta_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // groupBoxConfiguracionCuenta
            // 
            this.groupBoxConfiguracionCuenta.Controls.Add(this.checkBoxMostrarContraseña);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.labelContraseña);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.textBoxContraseña);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.labelServicio);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.textBoxServicio);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.labelDireccionCuenta);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.textBoxDireccion);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.textBoxNombre);
            this.groupBoxConfiguracionCuenta.Controls.Add(this.labelNombreCuenta);
            this.groupBoxConfiguracionCuenta.Location = new System.Drawing.Point(15, 259);
            this.groupBoxConfiguracionCuenta.Name = "groupBoxConfiguracionCuenta";
            this.groupBoxConfiguracionCuenta.Size = new System.Drawing.Size(470, 151);
            this.groupBoxConfiguracionCuenta.TabIndex = 6;
            this.groupBoxConfiguracionCuenta.TabStop = false;
            this.groupBoxConfiguracionCuenta.Text = "Configuración de la cuenta";
            // 
            // checkBoxMostrarContraseña
            // 
            this.checkBoxMostrarContraseña.AutoSize = true;
            this.checkBoxMostrarContraseña.Location = new System.Drawing.Point(127, 128);
            this.checkBoxMostrarContraseña.Name = "checkBoxMostrarContraseña";
            this.checkBoxMostrarContraseña.Size = new System.Drawing.Size(111, 17);
            this.checkBoxMostrarContraseña.TabIndex = 8;
            this.checkBoxMostrarContraseña.Text = "Mostrar contrseña";
            this.checkBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContraseña.Click += new System.EventHandler(this.MostrarContraseña_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(6, 104);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 7;
            this.labelContraseña.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(127, 101);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.ReadOnly = true;
            this.textBoxContraseña.Size = new System.Drawing.Size(337, 20);
            this.textBoxContraseña.TabIndex = 6;
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(7, 77);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(45, 13);
            this.labelServicio.TabIndex = 5;
            this.labelServicio.Text = "Servicio";
            // 
            // textBoxServicio
            // 
            this.textBoxServicio.Location = new System.Drawing.Point(127, 74);
            this.textBoxServicio.Name = "textBoxServicio";
            this.textBoxServicio.ReadOnly = true;
            this.textBoxServicio.Size = new System.Drawing.Size(337, 20);
            this.textBoxServicio.TabIndex = 4;
            // 
            // labelDireccionCuenta
            // 
            this.labelDireccionCuenta.AutoSize = true;
            this.labelDireccionCuenta.Location = new System.Drawing.Point(6, 50);
            this.labelDireccionCuenta.Name = "labelDireccionCuenta";
            this.labelDireccionCuenta.Size = new System.Drawing.Size(52, 13);
            this.labelDireccionCuenta.TabIndex = 3;
            this.labelDireccionCuenta.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(127, 47);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.ReadOnly = true;
            this.textBoxDireccion.Size = new System.Drawing.Size(337, 20);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(127, 20);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(337, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNombreCuenta
            // 
            this.labelNombreCuenta.AutoSize = true;
            this.labelNombreCuenta.Location = new System.Drawing.Point(6, 23);
            this.labelNombreCuenta.Name = "labelNombreCuenta";
            this.labelNombreCuenta.Size = new System.Drawing.Size(44, 13);
            this.labelNombreCuenta.TabIndex = 0;
            this.labelNombreCuenta.Text = "Nombre";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(226, 416);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.CerrarVerCuentas_Click);
            // 
            // VerCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 447);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.groupBoxConfiguracionCuenta);
            this.Controls.Add(this.dataGridViewDatosCuentas);
            this.Controls.Add(this.labelCuentasDisponibles);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonBuscarCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Ver cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCuentas)).EndInit();
            this.groupBoxConfiguracionCuenta.ResumeLayout(false);
            this.groupBoxConfiguracionCuenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscarCuenta;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Label labelCuentasDisponibles;
        private System.Windows.Forms.DataGridView dataGridViewDatosCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.GroupBox groupBoxConfiguracionCuenta;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.TextBox textBoxServicio;
        private System.Windows.Forms.Label labelDireccionCuenta;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombreCuenta;
        private System.Windows.Forms.CheckBox checkBoxMostrarContraseña;
        private System.Windows.Forms.Button buttonCerrar;
    }
}