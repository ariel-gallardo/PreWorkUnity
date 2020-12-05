using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Triangulo
    {
        public Int32 Base { get; set; }
        public Int32 Altura { get; set; }

        public Triangulo(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }

        static void Main(string[] args)
        {
            Console.Out.NewLine = "\n\n";
            List<Triangulo> triangulos = new List<Triangulo>();
            for(; ; )
            {
                Triangulo t = new Triangulo(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                if (t.Base == 0 || t.Altura == 0) { break; }
                triangulos.Add(t);
            }
            Console.Clear();
            triangulos.ForEach(t => Console.WriteLine($"Base({t.Base}) - Altura ({t.Altura}) - Superficie({t.Base*t.Altura})"));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Triangulos cuya superficie es mayor a 12 -> ({triangulos.Count(t => t.Base*t.Altura > 12)})");
            Console.ReadKey();
        }
    }
}
