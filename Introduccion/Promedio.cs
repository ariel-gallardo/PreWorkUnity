using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Promedio
    {
        private static double A, B, C, D;
        static void Main(string[] args)
        {
            Console.Out.NewLine = "\n\n";
            A = Double.Parse(Console.ReadLine());
            B = Double.Parse(Console.ReadLine());
            C = Double.Parse(Console.ReadLine());
            D = Double.Parse(Console.ReadLine());
            Console.WriteLine($"\n{A}+{B}+{C}+{D} = {A + B + C + D}");
            Console.WriteLine($"Promedio = {(A + B + C + D) / 4}");
        }
    }
}
