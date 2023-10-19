using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class E_NoSocio : E_Cliente
    {
        public Cuota Cuota { get; set; }
        public int NumeroDeNoSocio { get; set; }


        public E_NoSocio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, int numeroDeNoSocio)
              : base(nombre, apellido, direccion, telefono, tipoCliente: "NoSocio")
        {
            this.Cuota = cuota;
            this.NumeroDeNoSocio = numeroDeNoSocio;
        }


    }
}
