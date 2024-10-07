using System;
namespace Dom
{
    public class Program
    {
        public static void Main(string[] args){
            int opc = 0;
            double Precio = 0;

            Console.WriteLine("Ingrese el precio del vehiculo: ");

            Precio = Convert.ToDouble(Console.ReadLine());

            Vehiculo jk = new Vehiculo { Modelo = "Audi R8", Precio = Precio };

            Vehiculo.Descuento descuento = new Vehiculo.Descuento();

            Console.WriteLine("Elija para aplicar descuento");

            Console.WriteLine("1. 10% 2. 25% 3. 60%. 4. 85%");

            opc = Convert.ToInt32(Console.ReadLine());
            descuento.CalcDescuento(Precio, opc);
            jk.MostrarInfVehiculo();
            descuento.MostrarInfDesc(Precio);

            Console.WriteLine($"Elija para aplicar el tiempo de la reserva");
            Console.WriteLine("1. 3 días 2. 12 días 3. 16 días 4. 20 días");
            opc = Convert.ToInt32(Console.ReadLine());

            double calc = Reservacion.CalcularReserva(opc);
            Reservacion.MostrarReserva(Precio);
        
        }
    }
}