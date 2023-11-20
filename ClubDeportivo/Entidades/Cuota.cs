namespace ClubDeportivo
{
    public class Cuota
    {
        public decimal Monto { get; set; }
        private bool Pagada { get; set; }
        public DateTime FechaDeVencimiento { get; set; }

        public Cuota(decimal monto)
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
                var montoTotal = Monto;
                if (cuotas > 1)
                {
                    montoTotal = Monto * (decimal)1.1;
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
