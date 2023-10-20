using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    internal class Socio : Cliente
    {
        public int NumeroDeSocio { get; set; }


        public Socio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, int numeroDeSocio)
              : base(nombre, apellido, direccion, telefono, tipo: "Socio")
        {
            this.Cuota = cuota;
            this.NumeroDeSocio = numeroDeSocio;
        }

        // Si bien es igual al metodo de NoSocio, en el futuro pueden variar
        public override int? RegistrarCliente(Cliente cliente)
        {
            try
            {
                Clientes clientesDb = new();
                int? id = clientesDb.RegistrarCliente(cliente);
                if (id == 0) throw new Exception("No se pudo registrar el cliente");
                bool? pagada = clientesDb.PagarCuota(cliente);
                if (pagada != true) throw new Exception("No se pudo pagar la cuota");
                return id;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
