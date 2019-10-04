namespace Central
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
            this.ButtonGenerarLlamada = new System.Windows.Forms.Button();
            this.ButtonFacturacionTotal = new System.Windows.Forms.Button();
            this.ButtonFacturacionLocal = new System.Windows.Forms.Button();
            this.ButtonFacturacionProvincial = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGenerarLlamada
            // 
            this.ButtonGenerarLlamada.Location = new System.Drawing.Point(32, 23);
            this.ButtonGenerarLlamada.Name = "ButtonGenerarLlamada";
            this.ButtonGenerarLlamada.Size = new System.Drawing.Size(254, 65);
            this.ButtonGenerarLlamada.TabIndex = 0;
            this.ButtonGenerarLlamada.Text = "Generar llamada";
            this.ButtonGenerarLlamada.UseVisualStyleBackColor = true;
            this.ButtonGenerarLlamada.Click += new System.EventHandler(this.ButtonGenerarLlamada_Click);
            // 
            // ButtonFacturacionTotal
            // 
            this.ButtonFacturacionTotal.Location = new System.Drawing.Point(32, 110);
            this.ButtonFacturacionTotal.Name = "ButtonFacturacionTotal";
            this.ButtonFacturacionTotal.Size = new System.Drawing.Size(254, 65);
            this.ButtonFacturacionTotal.TabIndex = 1;
            this.ButtonFacturacionTotal.Text = "Facturacion total";
            this.ButtonFacturacionTotal.UseVisualStyleBackColor = true;
            // 
            // ButtonFacturacionLocal
            // 
            this.ButtonFacturacionLocal.Location = new System.Drawing.Point(32, 196);
            this.ButtonFacturacionLocal.Name = "ButtonFacturacionLocal";
            this.ButtonFacturacionLocal.Size = new System.Drawing.Size(254, 65);
            this.ButtonFacturacionLocal.TabIndex = 2;
            this.ButtonFacturacionLocal.Text = "Facturacion local";
            this.ButtonFacturacionLocal.UseVisualStyleBackColor = true;
            // 
            // ButtonFacturacionProvincial
            // 
            this.ButtonFacturacionProvincial.Location = new System.Drawing.Point(32, 279);
            this.ButtonFacturacionProvincial.Name = "ButtonFacturacionProvincial";
            this.ButtonFacturacionProvincial.Size = new System.Drawing.Size(254, 65);
            this.ButtonFacturacionProvincial.TabIndex = 3;
            this.ButtonFacturacionProvincial.Text = "Facturacion provincial";
            this.ButtonFacturacionProvincial.UseVisualStyleBackColor = true;
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(32, 361);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(254, 65);
            this.ButtonSalir.TabIndex = 4;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.ButtonSalir);
            this.Controls.Add(this.ButtonFacturacionProvincial);
            this.Controls.Add(this.ButtonFacturacionLocal);
            this.Controls.Add(this.ButtonFacturacionTotal);
            this.Controls.Add(this.ButtonGenerarLlamada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGenerarLlamada;
        private System.Windows.Forms.Button ButtonFacturacionTotal;
        private System.Windows.Forms.Button ButtonFacturacionLocal;
        private System.Windows.Forms.Button ButtonFacturacionProvincial;
        private System.Windows.Forms.Button ButtonSalir;
    }
}

