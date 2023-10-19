using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class NoSocio : Cliente

    {
        public int NumeroDeNoSocio { get; set; }
        public NoSocio(string nombre, string apellido, string direccion, string telefono, int numeroDeNoSocio) : base(nombre, apellido, direccion, telefono, tipoCliente: "NoSocio")
        {
            this.NumeroDeNoSocio = numeroDeNoSocio;
        }

        public void PagarActividad(double costoActividad)
        {
            Console.WriteLine($"El no socio {Nombre} {Apellido} ha pagado ${costoActividad} por la actividad.");
        }

        //public void RegistrarCliente(double costoActividad)
        //{
        //    if (!Activo)
        //    {
        //        PagarActividad(costoActividad);
        //        // Cobrar la actividad preferida al registrar al cliente
        //        Activo = true;
        //        Console.WriteLine($"El no socio {Nombre} {Apellido} fue registrado");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El no socio ya está registrado.");
        //    }
        //}
    }
}
