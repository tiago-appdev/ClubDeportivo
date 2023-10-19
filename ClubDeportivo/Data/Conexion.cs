using MySql.Data.MySqlClient;
using System;
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
            this.baseDatos = "ClubDeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "root";
        }

        public MySqlConnection crearConexion()
        {
            MySqlConnection? conexion = new MySqlConnection();
            try
            {

                conexion.ConnectionString = "datasource=" + this.servidor +
                                            ";port=" + this.puerto +
                                            ";username=" + this.usuario +
                                            ";password=" + this.clave +
                                            ";Database=" + this.baseDatos; ;
            }
            catch (Exception)
            {
                conexion = null;
                throw;
            }
            return conexion;
        }

        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}
