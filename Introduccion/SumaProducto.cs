using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class SumaProducto
    {
        private static double A { get; set; }
        private static double B { get; set; }
        private static double C { get; set; }
        private static double D { get; set; }
        static void Main(string[] args)
        {
            Console.Out.NewLine = "\n\n";
            A = Double.Parse(Console.ReadLine());
            B = Double.Parse(Console.ReadLine());
            C = Double.Parse(Console.ReadLine());
            D = Double.Parse(Console.ReadLine());

            Console.WriteLine($"\nSuma -> {A:n} + {B:n} = {A+B:n}");
            Console.WriteLine($"Producto -> {A:n} * {B:n} = {A*B:n}");
            Console.Read();
        }
    }
}
