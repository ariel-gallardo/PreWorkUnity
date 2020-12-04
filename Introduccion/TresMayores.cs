using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class TresMayores
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine()),
                b = Double.Parse(Console.ReadLine()),
                c = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n"+(a>=b && a>=c ? a : b > a && b > c ? b : c));
            Console.ReadKey();
        }
    }
}
