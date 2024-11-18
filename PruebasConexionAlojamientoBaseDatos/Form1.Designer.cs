namespace PruebasConexionAlojamientoBaseDatos {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.button_Conectar = new System.Windows.Forms.Button();
            this.button_Redirigir = new System.Windows.Forms.Button();
            this.button_Direccion = new System.Windows.Forms.Button();
            this.button_Restaurar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_Estado = new System.Windows.Forms.Label();
            this.label_Direccion = new System.Windows.Forms.Label();
            this.label_EstadoConect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Conectar
            // 
            this.button_Conectar.Location = new System.Drawing.Point(12, 12);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(75, 23);
            this.button_Conectar.TabIndex = 0;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            // 
            // button_Redirigir
            // 
            this.button_Redirigir.Location = new System.Drawing.Point(12, 41);
            this.button_Redirigir.Name = "button_Redirigir";
            this.button_Redirigir.Size = new System.Drawing.Size(75, 23);
            this.button_Redirigir.TabIndex = 1;
            this.button_Redirigir.Text = "Redirigir";
            this.button_Redirigir.UseVisualStyleBackColor = true;
            // 
            // button_Direccion
            // 
            this.button_Direccion.Location = new System.Drawing.Point(12, 70);
            this.button_Direccion.Name = "button_Direccion";
            this.button_Direccion.Size = new System.Drawing.Size(75, 23);
            this.button_Direccion.TabIndex = 2;
            this.button_Direccion.Text = "Direccion";
            this.button_Direccion.UseVisualStyleBackColor = true;
            // 
            // button_Restaurar
            // 
            this.button_Restaurar.Location = new System.Drawing.Point(12, 99);
            this.button_Restaurar.Name = "button_Restaurar";
            this.button_Restaurar.Size = new System.Drawing.Size(75, 23);
            this.button_Restaurar.TabIndex = 3;
            this.button_Restaurar.Text = "Restaurar";
            this.button_Restaurar.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(121, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Datos:";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Location = new System.Drawing.Point(136, 41);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(40, 13);
            this.label_Estado.TabIndex = 5;
            this.label_Estado.Text = "Estado";
            // 
            // label_Direccion
            // 
            this.label_Direccion.AutoSize = true;
            this.label_Direccion.Location = new System.Drawing.Point(136, 70);
            this.label_Direccion.Name = "label_Direccion";
            this.label_Direccion.Size = new System.Drawing.Size(40, 13);
            this.label_Direccion.TabIndex = 6;
            this.label_Direccion.Text = "Estado";
            // 
            // label_EstadoConect
            // 
            this.label_EstadoConect.AutoSize = true;
            this.label_EstadoConect.Location = new System.Drawing.Point(165, 12);
            this.label_EstadoConect.Name = "label_EstadoConect";
            this.label_EstadoConect.Size = new System.Drawing.Size(40, 13);
            this.label_EstadoConect.TabIndex = 7;
            this.label_EstadoConect.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 136);
            this.Controls.Add(this.label_EstadoConect);
            this.Controls.Add(this.label_Direccion);
            this.Controls.Add(this.label_Estado);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_Restaurar);
            this.Controls.Add(this.button_Direccion);
            this.Controls.Add(this.button_Redirigir);
            this.Controls.Add(this.button_Conectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.Button button_Redirigir;
        private System.Windows.Forms.Button button_Direccion;
        private System.Windows.Forms.Button button_Restaurar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.Label label_Direccion;
        private System.Windows.Forms.Label label_EstadoConect;
    }
}

