using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using Google.Apis.Gmail.v1.Data;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.Xml;


namespace PruebasConexionAlojamientoBaseDatos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        public void pruebaUno() {
            try {
                using (Conexion.ObtenerConexion()) {
                    Console.WriteLine("CONEXION EXITOSA");
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void PedidoDatos() {
            string datos = "";
            try {
                using (Conexion.ObtenerConexion()) {

                    string query = "SELECT * FROM Version";

                    SQLiteCommand cmd = new SQLiteCommand(query, Conexion.ObtenerConexion());

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {
                            datos += reader["Versiones"].ToString() + "\n";
                        }
                    }

                    Console.WriteLine(datos);
                }
            } catch (Exception ex) {
                throw ex;
            }
        }
        private void Form1_Load(object sender, EventArgs e) {

            PedidoDatos();


        }

        private void button_EnviarGmail_Click(object sender, EventArgs e) {
            /*
            string email = string.Empty;
            string password = string.Empty; //eksz rikn akkz ezjb
            string Destinatario = string.Empty;
       
            try {

                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587; 

                string subject = "Reporte de Bug";
                string body = $"Hola, quisiera reportar un problema encontrado en la aplicación.";

                // Ruta del archivo .db
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpPrueba", "prueba_backUp.db");

                // Crear un objeto MailMessage
                var mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(email);
                mailMessage.To.Add(Destinatario);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                // Adjuntar el archivo
                if (File.Exists(filePath)) {
                    mailMessage.Attachments.Add(new Attachment(filePath));
                } else {
                    MessageBox.Show("El archivo no existe.");
                    return;
                }

                // Configurar el servidor SMTP de Gmail
                var smtpClient = new System.Net.Mail.SmtpClient(smtpServer) {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true
                };

                // Enviar el correo
                smtpClient.Send(mailMessage);
                MessageBox.Show("Correo enviado exitosamente.");
            } catch (Exception ex) {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            MessageBox.Show("El correo se ha enviado correctamente");
            */
        }

        private void button_Login_Click(object sender, EventArgs e) {
            if(EnviarGmail.Login(textBox1.Text, textBox2.Text)) {
                MessageBox.Show("Logueado con exito");
            }
        }
    }
}
