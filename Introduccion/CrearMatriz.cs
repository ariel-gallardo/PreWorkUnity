using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class CrearMatriz
	{
		static void Main(string[] args)
		{

			int[,] Matriz = new int[2, 5];
			for (int i = 0; i < Matriz.Rank; i++)
			{
				for (int j = 0; j < Matriz.Length/Matriz.Rank; j++)
				{
					Matriz[i, j] = Int32.Parse(Console.ReadLine());
				}
			}

			foreach (var item in Matriz)
			{
				Console.Write($"{item} ");
			}

			Console.ReadKey();
		}
	}
}
