using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class TresValores
    {
        static void Main(string[] args)
        {
            Int32 numA = Int32.Parse(Console.ReadLine()),
                numB = Int32.Parse(Console.ReadLine()),
                numC = Int32.Parse(Console.ReadLine());
            if(numA == numB && numB == numC)
            {
                Console.WriteLine($"({numA}+{numB})*{numC} = {(numA+numB)*numC}");
            }
            Console.ReadKey();
        }
    }
}
