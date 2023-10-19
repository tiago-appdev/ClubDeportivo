using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Socio : Cliente
    {
        public Cuota Cuota { get; set; }
        public int NumeroDeSocio { get; set; }


        public Socio(string nombre, string apellido, string direccion, string telefono, Cuota cuota, int numeroDeSocio)
              : base(nombre, apellido, direccion, telefono, tipoCliente: "Socio")
        {
            this.Cuota = cuota;
            this.NumeroDeSocio = numeroDeSocio;
        }

        public void PagarCuotaMensual()
        {
            Console.WriteLine($"El socio {Nombre} {Apellido} ha pagado la cuota mensual de ${Cuota}");
        }

        public void PuedeRealizarActividades()
        {
            DateTime fechaActual = DateTime.Now;
            Activo = Cuota.FechaDeVencimiento < fechaActual && Cuota.Pagada;
        }

        public void RegistrarCliente(E_Socio socio)
        {

            try
            {
                if (socio.Activo)
                {
                    throw new System.Exception("El socio ya se encuentra registrado");
                }
                Cuota.PagarEfectivo();
                // Cobrar la actividad preferida al registrar al cliente
                Activo = true;
                Console.WriteLine($"El socio {Nombre} {Apellido} fue registrado");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void EntregarCarnet()
        {
            Console.WriteLine("El carnet ha sido entregado");
        }


        public static void ListarSociosConVencimiento()
        {
            Console.WriteLine("Lista de socios con vencimiento al dia de hoy");
        }


    }
}
