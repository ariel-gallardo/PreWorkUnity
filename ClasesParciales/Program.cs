using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
	class Program
	{
		static void Main(string[] args)
		{
			Figura figura = new Rectangulo(10.5, 20.5);
			Console.WriteLine(figura);
			Console.ReadKey();
		}
	}
}
