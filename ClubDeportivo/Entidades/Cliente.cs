namespace ClubDeportivo
{
    public abstract class Cliente
    {
        // Variables para datos personales
        public int ClienteId { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public string Dni { get; set; }
        public bool Activo { get; set; }
        public Cuota? Cuota { get; set; }


        protected Cliente(string nombre, string apellido, string direccion, string telefono, string tipo, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Tipo = tipo;
            Dni = dni;
            Activo = false; // Por defecto, el cliente se crea inactivo
        }

        public virtual int? RegistrarCliente(Cliente cliente)
        {
            return null;
        }


    }
}
