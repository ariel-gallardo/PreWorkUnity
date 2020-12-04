using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Cifras
    {
        private static Int32 Numero { get; set; }
        static String Determinar() {
            Int32 longitud = Numero.ToString().Length;
            switch (longitud)
            {
                case 1: case 2: case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return $"{longitud} cifras.";
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "El numero de cifras es Mayor";
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresar Numero: ");
            Numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Determinar());
            Console.ReadKey();
        }
    }
}
