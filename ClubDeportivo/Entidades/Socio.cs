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

    }
}
