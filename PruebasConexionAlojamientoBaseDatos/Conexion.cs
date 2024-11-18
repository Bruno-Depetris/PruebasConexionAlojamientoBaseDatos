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
        private static string BackUp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpPrueba", "prueba.db");

        public string datos = string.Empty;



        private static Conexion _Conexion;
        public static Conexion Instancia {
            get {
                if (_Conexion == null) {
                    _Conexion = new Conexion();

                }
                return _Conexion;
            }
        }

        private static void ComprobarVersion() {

           int oldVersion = 0;
           int newVersion = 0;

            try {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {
                    conexion.Open();

                    string query = "SELECT * FROM Version";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {
                            newVersion = Convert.ToInt32(reader["VersionID"]);
                        }
                    }

                   
                }
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaAppData)) {
                    conexion.Open();

                    string query = "SELECT * FROM Version";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    using (SQLiteDataReader reader = cmd.ExecuteReader()) {

                        while (reader.Read()) {
                            oldVersion = Convert.ToInt32(reader["VersionID"]);
                        }
                    }


                }
                Console.WriteLine(newVersion + "\n" + oldVersion);



                if (newVersion < oldVersion || newVersion == oldVersion) {
                    Console.WriteLine("Tu base de datos esta actualizada");
                } else if (newVersion > oldVersion) {
                    Console.WriteLine("actualizando...");
                    CrearBackUp();

                }

                  




            } catch (Exception ex) {
                throw ex;
            }
        }


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

            ComprobarVersion();
        }

        public void pruebaUno() {
            try {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaAppData)) {
                    conexion.Open();
                    Console.WriteLine("CONEXION EXITOSA");
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void PedidoDatos() {
            try {
                using (SQLiteConnection conexion = new SQLiteConnection(cadenaAppData)) {
                    conexion.Open();

                    string query = "SELECT * FROM Version";

                    SQLiteCommand cmd = new SQLiteCommand(query,conexion);

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

        public static void CrearBackUp() {
            try {
                if (!File.Exists(BackUp)) {

                    File.Copy(pathDBAppData, BackUp, true);
                    Console.WriteLine("backUpCreado");
                } else {

            

                }

            } catch (Exception ex) {

                Console.WriteLine("HUBO UN ERROR" + ex);
            }
        }

    }
}

