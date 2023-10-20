using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        public DataTable Log_Usu(string lUsu, string pUsu)
        {
            DataTable tabla = new();
            MySqlConnection sqlCon = new();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso el nombre
                // del procedimiento almacenado y la referencia a la conexion

                MySqlCommand comando = new("Login", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = lUsu;

                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = pUsu;

                // abrimos la conexion
                sqlCon.Open();
                MySqlDataReader? resultado = comando.ExecuteReader(); // variable de tipo datareader

                tabla.Load(resultado); // cargamos la tabla con el resultado.

                return tabla;
                // de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL
            }
            catch (Exception)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
        }
    }
}
