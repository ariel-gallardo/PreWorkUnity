using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class EnterosParesImpares
    {
        private static List<Int32>Numeros { get; set; }
        static void Main(string[] args)
        {
            Numeros = new List<Int32>();
            while (true) {
                Int32 tempNum = Int32.Parse(Console.ReadLine());
                if (tempNum == 0) break;
                Numeros.Add(tempNum);
            }
            Console.WriteLine($"Cantidad -> Pares({Numeros.Count(n => n % 2 == 0)}) | Impares({Numeros.Count(n => n%2 == 1)})");
            Console.ReadKey();
        }
    }
}
