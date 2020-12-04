using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class FechaNavidad
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = new DateTime(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            Console.WriteLine(fechaActual.ToString("yyyy-MM-dd") + (fechaActual.Day == 25 && fechaActual.Month == 12 ? " es una fecha navideña" : " no es una fecha navideña"));
            Console.ReadKey();
        }
    }
}
