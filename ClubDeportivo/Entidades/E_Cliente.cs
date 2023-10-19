
using System;

namespace ClubDeportivo
{
    public class E_Cliente
    {
        // Variables para datos personales
        public int ClienteId {get; set;}
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public string TipoCliente { get; set; }
        
        public E_Cliente(string nombre, string apellido, string direccion, string telefono, string tipoCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Activo = false; // Por defecto, el cliente se crea inactivo
            TipoCliente = tipoCliente;
        }

    }
}
