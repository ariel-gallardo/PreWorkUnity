using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class MayorMenor
    {
        public static void Main(string[] args)
        {
            double a = 0, b = 0;
            Console.Write("A: ");  a = Double.Parse(Console.ReadLine());
            Console.Write("B: ");  b = Double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? $"{a}+{b} = {a+b} | {a}-{b} = {a-b}" : $"{a}*{b} = {a*b} | {a}/{b}={a/b:n}");
            Console.ReadKey();
        }
    }
}
