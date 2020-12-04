using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class SubTotal
    {
        static void Main(string[] args)
        {
            Console.Write("Precio: ");
            double precio = Double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            double cantidad = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Precio({precio})  Cantidad({cantidad}) = {precio*cantidad}");
            Console.ReadKey();
        }
    }
}
