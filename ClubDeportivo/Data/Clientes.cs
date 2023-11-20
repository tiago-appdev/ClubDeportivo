using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Data
{
    internal class Clientes
    {
        public int? RegistrarCliente(Cliente cliente)
        {
            int? salida;
            MySqlConnection sqlCon = new();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new("RegistrarCliente", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = cliente.Telefono;
                comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = cliente.Dni;
                comando.Parameters.Add("Dir", MySqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Mon", MySqlDbType.Decimal).Value = cliente.Cuota?.Monto;
                comando.Parameters.Add("Tip", MySqlDbType.Enum).Value = cliente.Tipo;
                MySqlParameter parCodigo = new()
                {
                    ParameterName = "id",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(parCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToInt32(parCodigo.Value);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
            return salida;
        }

        public bool? PagarCuota(Cliente cliente)
        {
            bool? salida;
            MySqlConnection sqlCon = new();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new("PagarCuota", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = cliente.Dni;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = cliente.Tipo;
                MySqlParameter parCodigo = new()
                {
                    ParameterName = "paid",
                    MySqlDbType = MySqlDbType.Bit,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(parCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToBoolean(parCodigo.Value);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
            }
            return salida;
        }
    }
}