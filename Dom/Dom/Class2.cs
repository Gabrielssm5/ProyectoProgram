using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom
{
    internal class Reservacion
    {
        static double Reserva {  get; set; }
        public static double CalcularReserva (int opc)
        {
            do
            {
                switch (opc) { 
                
                case 1:
                        Reserva = 650; break;
                case 2:
                        Reserva = 1200; break;
                case 3:
                        Reserva = 1520; break; 
                case 4:
                        Reserva = 2000; break;

                }return Reserva;
            } while (opc > 4 || opc < 0);
        } 
        public static void MostrarReserva (double Precio) {
            Console.WriteLine($"La Reserva final es de: {Reserva}\n  La reserva aplicada con el precio es de: {Reserva + Precio}");
        }
    }
}
