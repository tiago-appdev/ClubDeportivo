using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    internal class NoSocio : Cliente
    {
        public int NumeroDeNoSocio { get; set; }


        public NoSocio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, int numeroDeNoSocio, string dni)
              : base(nombre, apellido, direccion, telefono, tipo: "No Socio", dni)
        {
            this.Cuota = cuota;
            this.NumeroDeNoSocio = numeroDeNoSocio;
        }

        // Si bien es igual al metodo de Socio, en el futuro pueden variar
        public override int? RegistrarCliente(Cliente cliente)
        {
            try
            {
                Clientes clientesDb = new();
                int? id = clientesDb.RegistrarCliente(cliente);
                if (id == 0) throw new Exception("No se pudo registrar el cliente");
                return id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
