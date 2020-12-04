using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Coordenada
    {
        public Int32 X{ get; set; }
        public Int32 Y { get; set; }

        public Coordenada()
        {
        }

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Cuadrante
    {
        static Int32 NumCuadrante(ref Coordenada c) {
            return c.X > 0 && c.Y > 0 ? 1 :
                c.X < 0 && c.Y > 0 ? 2 :
                c.X < 0 && c.Y < 0 ? 3 :
                4;
        }
        static void Main(string[] args) {
            Coordenada c = new Coordenada(Int32.Parse(Console.ReadLine()),Int32.Parse(Console.ReadLine()));
            Console.WriteLine($"La coordenada ingresada pertenece al cuadrante -> {NumCuadrante(ref c)}");
            Console.ReadKey();
        }
    }
}
