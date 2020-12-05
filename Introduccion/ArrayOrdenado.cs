using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class ArrayOrdenado
	{
		static void Main(string[] args)
		{
			List<Int32> Arreglo = new List<int>() {
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10
			};
			Int32 Anterior = Arreglo[0], i = 0;
			Boolean s = true;
			s = Arreglo.TrueForAll(elem => {
				if(i > 0)
				{
					return Arreglo[i] == Arreglo[i - 1]+ 1 && s;
					i++;
				}
				i++;
				return true;
			});

			Console.WriteLine ((s ? " ordenado" : " desordenado"));
			Console.ReadKey();
		}
	}
}
