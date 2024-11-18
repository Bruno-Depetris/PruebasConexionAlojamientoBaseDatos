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
            this.button_EnviarGmail = new System.Windows.Forms.Button();
            this.button_Restaurar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
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
            // button_EnviarGmail
            // 
            this.button_EnviarGmail.Location = new System.Drawing.Point(12, 70);
            this.button_EnviarGmail.Name = "button_EnviarGmail";
            this.button_EnviarGmail.Size = new System.Drawing.Size(75, 23);
            this.button_EnviarGmail.TabIndex = 2;
            this.button_EnviarGmail.Text = "Gmail";
            this.button_EnviarGmail.UseVisualStyleBackColor = true;
            this.button_EnviarGmail.Click += new System.EventHandler(this.button_EnviarGmail_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(139, 70);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 259);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Restaurar);
            this.Controls.Add(this.button_EnviarGmail);
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
        private System.Windows.Forms.Button button_EnviarGmail;
        private System.Windows.Forms.Button button_Restaurar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Login;
    }
}

