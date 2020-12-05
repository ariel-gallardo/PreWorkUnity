using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Serie25
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"{num+=11}");
            }
            Console.ReadKey();
        }
    }
}
