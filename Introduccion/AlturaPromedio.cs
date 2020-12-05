using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class AlturaPromedio
    {
        private static List<Double> Alturas { get; set; }
        static void Main(string[] args)
        {
            Alturas = new List<Double>();
            Console.WriteLine("Ingresar numero con formato de , no con . ");
            while (true)
            {
                Console.Write($"Altura n° {Alturas.Count+1}: ");
                double altura = double.Parse(Console.ReadLine());
                if (altura <= 0.0) { break; }
                Alturas.Add(altura);
            }
            Console.WriteLine($"Total de personas {Alturas.Count} con un promedio: {(Alturas.Sum()/Alturas.Count):n}");
            Console.ReadKey();
        }
    }
}
