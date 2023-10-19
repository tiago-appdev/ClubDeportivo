
using System;

namespace ClubDeportivo
{
    public class Cliente
    {
        // Variables para datos personales
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public string TipoCliente { get; set; }

        // Constructor para crear un nuevo cliente
        public Cliente(string nombre, string apellido, string direccion, string telefono, string tipoCliente)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Activo = false; // Por defecto, el cliente se crea inactivo
            TipoCliente = tipoCliente;
        }

        // Método para dar de baja al cliente
        public void DarDeBaja()
        {
            if (Activo)
            {
                Activo = false;
                Console.WriteLine("El cliente ha sido dado de baja.");
            }
            else
            {
                Console.WriteLine("El cliente ya está dado de baja.");
            }
        }

        public void RegistrarCliente()
        {
            Console.WriteLine("");
        }

    }
}
