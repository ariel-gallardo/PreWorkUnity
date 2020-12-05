using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Multiplo8
    {
        static void Main(string[] args)
        {
            Int32 num = 0;
            while (true)
            {
                num += 8;
                if (num > 500) {
                    break;
                }
                else
                {
                    Console.Write($"{num} - ");
                }
            }
            Console.ReadKey();
        }
    }
}
