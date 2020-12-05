using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class CursoNota
	{
		private static List<Int32> CursoA = new List<int>() {
			1,
			7,
			10,
			 3,
			 8
		},
			CursoB = new List<int>() {
				 6,
				 4,
				 2,
				 9,
				 5
			};
		static void Main(string[] args)
		{
			Double promA = CursoA.Average(), promB = CursoB.Average();
			Console.WriteLine($"Curso {(promA > promB ? " A " + promA : " B " + promB)}");
			Console.ReadKey();
		}
	}
}
