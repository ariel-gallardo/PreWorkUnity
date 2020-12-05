using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class IntercalarMatriz
	{
		static void Main(string[] args)
		{
			int[,] matriz;
			Console.Write("Fila: ");
			int n = Int32.Parse(Console.ReadLine()) ;
			Console.Write("Columna: ");
			int m = Int32.Parse(Console.ReadLine());

			matriz = new int[n, m];
			Console.WriteLine();

			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.Length / matriz.GetLength(0); j++)
				{
					Console.Write($"[{i}, {j}]: ");
					matriz[i, j] = Int32.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine();

			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.Length / matriz.GetLength(0); j++)
				{
					Console.Write($"{matriz[i, j]}  ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.Length / matriz.GetLength(0); j++)
				{
					if (i != matriz.GetLength(0) - 1)
					{
						Int32 temp = matriz[i, j];
						matriz[i, j] = matriz[i + 1, j];
						matriz[i + 1, j] = temp;
					}
				}
			}
			Console.ForegroundColor = ConsoleColor.Cyan;
			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.Length / matriz.GetLength(0); j++)
				{
					Console.Write($"{matriz[i,j]}  ");
				}
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}
