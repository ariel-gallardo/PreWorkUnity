using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Antiguedad
    {
        static Double sueldo = 0.0;
        static int anios = 0;
        static void Main(string[] args)
        {
            Console.Write("Sueldo: "); sueldo = Double.Parse(Console.ReadLine());
            Console.Write("   Años:"); anios = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Total: "+ (
                sueldo < 500 && anios >= 10 ? sueldo * 1.20:
                sueldo < 500 && anios < 10 ? sueldo * 1.05 :
                sueldo > 500 ? sueldo : 0.0
            ));
            Console.ReadKey();
        }
    }
}
