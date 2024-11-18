using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.IO;


namespace PruebasConexionAlojamientoBaseDatos {
    public class Conexion {
        private static string pathDB = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "prueba.db");
        private static string cadena = $"Data Source={Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "prueba.db")};Version=3;";

        private static string cadenaAppData = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"prueba", "prueba.db")};Version=3;";
        private static string pathDBAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "prueba", "prueba.db");
        private static string BackUp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpPrueba", "prueba_backUp.db");

        public string datos = string.Empty;

        public static void Comprobar() {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "prueba");
            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("La carpeta no existia, fue creada con exito");

            }
            Console.WriteLine("Carpeta encontrada con exito");

            if (!File.Exists(pathDBAppData)) {
                
                if (File.Exists(pathDB)) {
                    File.Copy(pathDB, pathDBAppData, true);
                } else {
                    Console.WriteLine("El archivo de base de datos original no se encuentra en la ruta especificada.");
                }
            }

       
        }
        public static void CrearBackUp() {
            try {
                string backupFolderPath = Path.GetDirectoryName(BackUp);

                if (!Directory.Exists(backupFolderPath)) {
                    Directory.CreateDirectory(backupFolderPath);
                    Console.WriteLine("La carpeta de respaldo no existía, fue creada con éxito");
                }


                if (!File.Exists(BackUp)) {

                    if (File.Exists(pathDBAppData)) {
                        File.Copy(pathDBAppData, BackUp, true);
                    } else {
                        Console.WriteLine("El archivo no se encuentra en ruta especificada");
                    }
                    Console.WriteLine("backUpCreado");

                } else {


                }

            } catch (Exception ex) {

                Console.WriteLine("HUBO UN ERROR" + ex);
            }
        }
        public static SQLiteConnection ObtenerConexion() {
            try {
                string cadenaConexion = cadenaAppData;
                var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open(); 

                return conexion;

            } catch (Exception ex) {
                Console.WriteLine($"Error al obtener la conexión: {ex.Message}");
                throw;
            }
        }




    }
}

