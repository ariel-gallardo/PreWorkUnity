using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class PromedioAlumno
    {
        public static void Main(string[] args)
        {
            double n1 = Double.Parse(Console.ReadLine()), n2 = Double.Parse(Console.ReadLine()), n3 = Double.Parse(Console.ReadLine());
            double promedio = (n1 + n2 + n3) / 3;
            if(promedio >= 7)
            {
                Console.WriteLine("Aprobado");
            }
            Console.ReadKey();
        }
    }
}
