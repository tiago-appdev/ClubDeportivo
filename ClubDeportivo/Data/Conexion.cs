using MySql.Data.MySqlClient;
using System;
using DotEnv.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Conexion
    {
        private string? baseDatos;
        private string? servidor;
        private string? puerto;
        private string? usuario;
        private string? clave;
        private static Conexion? con = null;

        public Conexion()
        {
            // Load .env file
            new EnvLoader().Load();
            var reader = new EnvReader();
            this.baseDatos = reader.GetStringValue("DB_NAME"); ;
            this.servidor = reader.GetStringValue("DB_HOST");
            this.puerto = reader.GetStringValue("DB_PORT");
            this.usuario = reader.GetStringValue("DB_USER");
            this.clave = reader.GetStringValue("DB_PASS");
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection? conexion = new();
            try
            {
                string connectionString = $"Server={servidor};Port={puerto};Database={baseDatos};User={usuario};Password={clave};";
                conexion.ConnectionString = connectionString;
            }
            catch (Exception ex)
            {
                // Handle any connection error here
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                conexion = null;
                throw;
            }
            return conexion;
        }

        public static Conexion GetInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}
