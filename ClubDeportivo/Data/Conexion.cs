using DotEnv.Core;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Data
{
    internal class Conexion
    {
        private readonly string? _baseDatos;
        private readonly string? _servidor;
        private readonly string? _puerto;
        private readonly string? _usuario;
        private readonly string? _clave;
        private static Conexion? _con;

        private Conexion()
        {
            new EnvLoader().Load();
            var reader = new EnvReader();
            this._baseDatos = reader.GetStringValue("DB_NAME");
            this._servidor = reader.GetStringValue("DB_HOST");
            this._puerto = reader.GetStringValue("DB_PORT");
            this._usuario = reader.GetStringValue("DB_USER");
            this._clave = reader.GetStringValue("DB_PASS");
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new();
            try
            {
                var connectionString = $"Server={_servidor};Port={_puerto};Database={_baseDatos};User={_usuario};Password={_clave};";
                conexion.ConnectionString = connectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                throw;
            }
            return conexion;
        }

        public static Conexion GetInstancia()
        {
            return _con ??= new Conexion();
        }
    }
}
