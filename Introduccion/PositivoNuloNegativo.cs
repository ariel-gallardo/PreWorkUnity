using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class PositivoNuloNegativo
    {
        static void Main(string[] args)
        {
            Double numero = Double.MinValue;
            try
            {
                numero = Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                numero = Double.MinValue;
            }
            finally
            {
                Console.WriteLine(numero == Double.MinValue || numero == 0.0 ? "El valor es nulo" : (numero < 0 ? "Numero Negativo" : "Numero Positivo" ));
            }
            Console.ReadKey();
        }
    }
}
