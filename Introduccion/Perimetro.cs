using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Perimetro
    {
        public static double Lado { get; set; }
        static void Main(string[] args)
        {
            Lado = Double.Parse(Console.ReadLine());
            Lado *= 4;
            Console.WriteLine("Perimetro: " + Lado);
            Console.Read();
        }
    }
}
