using System;
using System.Data.SQLite;
using System.IO;

namespace Inversiones_XTB
{
    public static class DatabaseHelper
    {
        // 1. El nombre del archivo y la "cadena de conexión"
        private static string dbName = "PortafolioXTB.db";
        private static string connectionString = $"Data Source={dbName};Version=3;";

        // 2. Método para crear la base de datos la primera vez que se abre la app
        public static void InicializarBaseDeDatos()
        {
            // Ya no usamos File.Exists. Al abrir la conexión, SQLite crea el archivo si no lo encuentra.
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Agregamos la instrucción clave: IF NOT EXISTS (crea la tabla solo si no existe)
                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Transacciones (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Ticker TEXT NOT NULL,
                Tipo TEXT NOT NULL,
                Cantidad REAL NOT NULL,
                Precio REAL NOT NULL,
                Fecha TEXT NOT NULL
            )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // 3. Método que usaremos más adelante cada vez que queramos guardar o leer datos
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}