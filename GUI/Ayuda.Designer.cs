namespace GUI
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.panelAyuda = new System.Windows.Forms.Panel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.richTextBoxAyuda = new System.Windows.Forms.RichTextBox();
            this.panelAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAyuda
            // 
            this.panelAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAyuda.Controls.Add(this.buttonCerrar);
            this.panelAyuda.Controls.Add(this.richTextBoxAyuda);
            this.panelAyuda.Location = new System.Drawing.Point(12, 12);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Size = new System.Drawing.Size(775, 435);
            this.panelAyuda.TabIndex = 2;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.AutoSize = true;
            this.buttonCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCerrar.Location = new System.Drawing.Point(0, 409);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(775, 26);
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.CerrarAyuda_Click);
            // 
            // richTextBoxAyuda
            // 
            this.richTextBoxAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAyuda.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxAyuda.Name = "richTextBoxAyuda";
            this.richTextBoxAyuda.ReadOnly = true;
            this.richTextBoxAyuda.Size = new System.Drawing.Size(769, 384);
            this.richTextBoxAyuda.TabIndex = 2;
            this.richTextBoxAyuda.Text = resources.GetString("richTextBoxAyuda.Text");
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 459);
            this.Controls.Add(this.panelAyuda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Ayuda";
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAyuda;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.RichTextBox richTextBoxAyuda;

    }
}