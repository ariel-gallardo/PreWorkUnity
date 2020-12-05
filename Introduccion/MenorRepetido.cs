using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class MenorRepetido
	{
		static void Main(string[] args)
		{
			List<Int32> Numeros = new List<int>() {
				1,
				1,
				3,
				5,
				6,
				3,
				8,
				3
			};
			Console.WriteLine($"Numero menor -> {Numeros.Min()} {(Numeros.Count(num => num == Numeros.Min()) > 1 ? "si" : "no")} se repite");
			Console.ReadKey();
		}
	}
}
