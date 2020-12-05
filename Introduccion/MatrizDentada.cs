using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class MatrizDentada
	{
		private static Int32[][] Matriz { get; set; }
		static void Main(string[] args)
		{
			Console.Out.NewLine = "\n\n";
			Console.Write("Numero de Filas: ");
			Int32 numFilas = Int32.Parse(Console.ReadLine());
			Matriz = new int[numFilas][];
			for (int i = 0; i < numFilas; i++)
			{
				Console.Write($"Fila N°{i+1} -> Cantidad de columnas: ");
				Matriz[i] = new int[Int32.Parse(Console.ReadLine())];
			}

			foreach (Int32[] Fila in Matriz)
			{
				Array.ForEach(Fila, Columna => {
					Fila.SetValue(Int32.Parse(Console.ReadLine()), Fila.Count(Valor => Valor != 0));
				});
			}
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Cyan;
			foreach (Int32[] fila in Matriz)
			{
				foreach (Int32 col in fila)
				{
					Console.Write($"{col} ");
				}
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}
