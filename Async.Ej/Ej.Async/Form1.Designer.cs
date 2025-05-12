namespace Ej.Async
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.miLabel = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // miLabel
            // 
            this.miLabel.AutoSize = true;
            this.miLabel.Location = new System.Drawing.Point(242, 152);
            this.miLabel.Name = "miLabel";
            this.miLabel.Size = new System.Drawing.Size(93, 16);
            this.miLabel.TabIndex = 0;
            this.miLabel.Text = "Pulse el Boton";
            this.miLabel.Click += new System.EventHandler(this.label1_click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(70, 131);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 58);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Descargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.miLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label miLabel;
        private System.Windows.Forms.Button btnCargar;
    }
}

