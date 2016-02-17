namespace GUI
{
    partial class EliminarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCuenta));
            this.dataGridViewDatosCuentas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminarCuenta = new System.Windows.Forms.Button();
            this.labelCuentasDisponibles = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.buttonBuscarCuenta = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatosCuentas
            // 
            this.dataGridViewDatosCuentas.AllowUserToAddRows = false;
            this.dataGridViewDatosCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.Servicio});
            this.dataGridViewDatosCuentas.Location = new System.Drawing.Point(137, 50);
            this.dataGridViewDatosCuentas.Name = "dataGridViewDatosCuentas";
            this.dataGridViewDatosCuentas.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewDatosCuentas.TabIndex = 10;
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
            // buttonEliminarCuenta
            // 
            this.buttonEliminarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCuenta.Image")));
            this.buttonEliminarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarCuenta.Location = new System.Drawing.Point(137, 206);
            this.buttonEliminarCuenta.Name = "buttonEliminarCuenta";
            this.buttonEliminarCuenta.Size = new System.Drawing.Size(106, 35);
            this.buttonEliminarCuenta.TabIndex = 9;
            this.buttonEliminarCuenta.Text = "Eliminar cuenta";
            this.buttonEliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarCuenta.UseVisualStyleBackColor = true;
            this.buttonEliminarCuenta.Click += new System.EventHandler(this.EliminarCuenta_Click);
            // 
            // labelCuentasDisponibles
            // 
            this.labelCuentasDisponibles.AutoSize = true;
            this.labelCuentasDisponibles.Location = new System.Drawing.Point(7, 50);
            this.labelCuentasDisponibles.Name = "labelCuentasDisponibles";
            this.labelCuentasDisponibles.Size = new System.Drawing.Size(46, 13);
            this.labelCuentasDisponibles.TabIndex = 8;
            this.labelCuentasDisponibles.Text = "Cuentas";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(137, 12);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(343, 20);
            this.textBoxBuscador.TabIndex = 7;
            // 
            // buttonBuscarCuenta
            // 
            this.buttonBuscarCuenta.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCuenta.Image")));
            this.buttonBuscarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarCuenta.Location = new System.Drawing.Point(10, 2);
            this.buttonBuscarCuenta.Name = "buttonBuscarCuenta";
            this.buttonBuscarCuenta.Size = new System.Drawing.Size(109, 38);
            this.buttonBuscarCuenta.TabIndex = 6;
            this.buttonBuscarCuenta.Text = "Buscar cuenta";
            this.buttonBuscarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarCuenta.UseVisualStyleBackColor = true;
            this.buttonBuscarCuenta.Click += new System.EventHandler(this.BuscarCuenta_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(249, 206);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 35);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.CerrarEliminarCuenta);
            // 
            // EliminarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 253);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewDatosCuentas);
            this.Controls.Add(this.buttonEliminarCuenta);
            this.Controls.Add(this.labelCuentasDisponibles);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonBuscarCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EliminarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Eliminar cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatosCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.Button buttonEliminarCuenta;
        private System.Windows.Forms.Label labelCuentasDisponibles;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Button buttonBuscarCuenta;
        private System.Windows.Forms.Button buttonCancelar;
    }
}