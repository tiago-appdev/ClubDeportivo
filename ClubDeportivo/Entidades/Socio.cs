using ClubDeportivo.Data;

namespace ClubDeportivo
{
    internal class Socio : Cliente
    {
        public Socio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, string dni)
              : base(nombre, apellido, direccion, telefono, tipo: "Socio", dni)
        {
            this.Cuota = cuota;
        }

        // Si bien es igual al metodo de NoSocio, en el futuro pueden variar
        public override int? RegistrarCliente(Cliente cliente)
        {
            try
            {
                Clientes clientesDb = new();
                var id = clientesDb.RegistrarCliente(cliente);
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
