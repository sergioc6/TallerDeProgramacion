namespace GUI
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.pictureBoxLogotipoMailApp = new System.Windows.Forms.PictureBox();
            this.labelInformacion1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipoMailApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogotipoMailApp
            // 
            this.pictureBoxLogotipoMailApp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogotipoMailApp.Image")));
            this.pictureBoxLogotipoMailApp.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogotipoMailApp.Name = "pictureBoxLogotipoMailApp";
            this.pictureBoxLogotipoMailApp.Size = new System.Drawing.Size(258, 260);
            this.pictureBoxLogotipoMailApp.TabIndex = 0;
            this.pictureBoxLogotipoMailApp.TabStop = false;
            // 
            // labelInformacion1
            // 
            this.labelInformacion1.AutoSize = true;
            this.labelInformacion1.Location = new System.Drawing.Point(276, 12);
            this.labelInformacion1.Name = "labelInformacion1";
            this.labelInformacion1.Size = new System.Drawing.Size(53, 13);
            this.labelInformacion1.TabIndex = 1;
            this.labelInformacion1.Text = "MailApp®";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Versión del software: 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "© 2016 - Todos los derechos reservados\r\na los autores.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autores:\r\n- Cabral, Sergio\r\n- Leiva, Nahuel\r\n- Pacheco, Santiago";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInformacion1);
            this.Controls.Add(this.pictureBoxLogotipoMailApp);
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailApp - Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogotipoMailApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogotipoMailApp;
        private System.Windows.Forms.Label labelInformacion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}