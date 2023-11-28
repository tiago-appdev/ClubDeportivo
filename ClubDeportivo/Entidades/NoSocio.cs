using ClubDeportivo.Data;

namespace ClubDeportivo
{
    internal class NoSocio : Cliente
    {
        public NoSocio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, string dni)
              : base(nombre, apellido, direccion, telefono, tipo: "No Socio", dni)
        {
            this.Cuota = cuota;
        }

    }
}
