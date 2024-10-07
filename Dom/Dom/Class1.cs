using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dom
{
    internal class Vehiculo
    {
        public string Modelo{ get; set; }
        public double Precio { get; set; }
        public class Descuento { 
            public double DescAplicacion { get; set; }
            public double CalcDescuento ( double Precio, int opc)
            {
                switch (opc)
                {
                    case 1:
                        DescAplicacion = (Precio * 0.10); break;
                    case 2:
                        DescAplicacion = (Precio * 0.25); break;
                    case 3:
                        DescAplicacion = (Precio * 0.60); break;
                    case 4:
                        DescAplicacion = (Precio * 0.85); break;
                }
                return DescAplicacion;
            }
            public void MostrarInfDesc(double Precio)
            {
                Console.WriteLine($"El total aplicando el descuento es de: {Precio - DescAplicacion}");
            }
        } public void MostrarInfVehiculo()
        {
            Console.WriteLine($"El modelo del vehiculo es: {Modelo}, El valor es de: {Precio} ");
        }
       
    }
}
