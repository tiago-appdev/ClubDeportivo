using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Clientes
    {
        public int? RegistrarCliente(E_Cliente cliente)
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
                comando.Parameters.Add("Dir", MySqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Tip", MySqlDbType.Enum).Value = cliente.TipoCliente;
                MySqlParameter ParCodigo = new()
                {
                    ParameterName = "id",
                    MySqlDbType = MySqlDbType.Int32,
                    Direction = ParameterDirection.Output
                };
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToInt32(ParCodigo.Value);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}