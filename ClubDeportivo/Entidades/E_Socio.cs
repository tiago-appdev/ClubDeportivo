using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class E_Socio : E_Cliente
    {
        public Cuota Cuota { get; set; }
        public int NumeroDeSocio { get; set; }


        public E_Socio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, int numeroDeSocio)
              : base(nombre, apellido, direccion, telefono, tipoCliente: "Socio")
        {
            this.Cuota = cuota;
            this.NumeroDeSocio = numeroDeSocio;
        }


    }
}
