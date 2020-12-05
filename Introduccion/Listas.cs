using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Listas
    {
        static Int32[][] Lista = {
            new Int32[15],
            new Int32[15] 
        };

        static void Main(string[] args)
        {
            foreach (int[] lista in Lista)
            {
                for (int i = 0; i < lista.Count(); i++)
                {
                    lista[i] = Int32.Parse(Console.ReadLine());
                }
            }

            foreach (int[] list in Lista)
            {
                foreach (int value in list)
                {
                    Console.Write($"{value} - ");
                }
            }

            Console.Clear();

            Console.WriteLine(
                Lista[0].Max() > Lista[1].Max() ? "Lista 1 Mayor" : Lista[1].Max() == Lista[0].Max() ? "Listas Iguales" : "Lista 2 Mayor"
            );

            Console.ReadKey();
        }
    }
}
