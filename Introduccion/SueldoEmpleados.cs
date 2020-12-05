using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class SueldoEmpleados
    {
        private static List<double> sueldos;
        static void Main(string[] args)
        {
            sueldos = new List<double>();
            while (true) {
                double sueldo = Double.Parse(Console.ReadLine());
                if (sueldo == 0.0) { break; }
                if(sueldo >= 100 && sueldo <= 500)
                {
                    sueldos.Add(sueldo);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El sueldo no corresponde a los valores de la empresa. Presione una tecla para seguir agregando");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
            Console.WriteLine($"{sueldos.Count(sueldo => sueldo >= 100.0 && sueldo <= 300.0)} empleados cobran entre 100$ y 300$" +
                $"\n{sueldos.Count(sueldo => sueldo > 300.0)} empleados cobran mas de 300$");
            Console.ReadKey();
        }
    }
}
