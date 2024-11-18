using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using MimeKit;
using MailKit.Net.Smtp;
using Google.Apis.Gmail.v1.Data;

using System.Security.Cryptography.Xml;

namespace PruebasConexionAlojamientoBaseDatos {
    public class EnviarGmail {

        private string Destinatario = string.Empty;

        public static bool Login(string email, string password) {
            try {
                using (var client = new MailKit.Net.Smtp.SmtpClient()) {
                    client.Connect("smtp.gmail.com", 587, false);
                    // Intentamos autenticar con el correo y la contraseña
                    client.Authenticate(email, password);

                    // Si la autenticación es exitosa, desconectamos
                    client.Disconnect(true);
                }

                // Si no se produce ninguna excepción, la autenticación fue exitosa
                return true;
            } catch (Exception ex) {
                // Si ocurre un error, mostramos el mensaje de error y devolvemos false
                MessageBox.Show("Error de autenticación: " + ex.Message);
                return false;
            }
        }




    }
}
