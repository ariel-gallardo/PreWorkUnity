using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class InformeAlumno
    {
        private static List<double> Notas { get; set; }
        static void Main(string[] args)
        {
            Notas = new List<double>();
            while(Notas.Count < 10)
            {
                Notas.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(
                $"\n{Notas.Count(nota => nota >= 7)} Alumnos tienen notas >= 7\n" +
                $"{Notas.Count(nota =>nota < 7)} Alumnos tienen notas menores a 7"
            );
            Console.ReadKey();
        }
    }
}
