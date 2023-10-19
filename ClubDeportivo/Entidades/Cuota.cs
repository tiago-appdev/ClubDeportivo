using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    internal class Cuota
    {
        public double Monto { get; set; }
        public bool Pagada { get; set; }
        public DateTime FechaDeVencimiento { get; set; }

        public Cuota(double monto)
        {
            Monto = monto;
            Pagada = false;
        }

        public void PagarEfectivo()
        {
            if (!Pagada)
            {
                Pagada = true;
                Console.WriteLine($"La cuota de ${Monto} ha sido pagada en efectivo.");
            }
            else
            {
                Console.WriteLine("La cuota ya ha sido pagada.");
            }
        }

        public void PagarTarjetaCredito(int cuotas)
        {
            if (!Pagada)
            {
                double montoTotal = Monto;

                if (cuotas == 3)
                {
                    montoTotal *= 1.05; // 5% de recargo para 3 cuotas
                }
                else if (cuotas == 6)
                {
                    montoTotal *= 1.1; // 10% de recargo para 6 cuotas
                }

                Console.WriteLine($"La cuota de ${Monto} se ha pagado en {cuotas} cuotas de ${montoTotal / cuotas} cada una.");
                Pagada = true;
            }
            else
            {
                Console.WriteLine("La cuota ya ha sido pagada.");
            }
        }

    }
}
