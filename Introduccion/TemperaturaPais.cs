using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class TemperaturaPais
	{
		private static Object[,] PaisTemperatura = new object[4, 4];		
		private static Double TempTrimMedia(int i, ref String Pais, ref Double Temperatura) {
			Double tempTMedia = 0.0;
			for (int j = 1; j < 4; j++)
			{
				tempTMedia += Double.Parse(PaisTemperatura[i, j].ToString());
			}
			if (Pais.Equals(String.Empty) || tempTMedia > Temperatura)
			{
				Pais = PaisTemperatura[i, 0].ToString();
				Temperatura = tempTMedia / 3;
			}
			return tempTMedia / 3;
		}
		static void Main(string[] args) {
			String Pais = ""; Double Temperatura = 0.0;
			Console.WriteLine("Pais | Temperatura");
			for (int i = 0; i < PaisTemperatura.GetLength(0); i++)
			{
				Console.Write("\nPais: ");
				PaisTemperatura[i, 0] = Console.ReadLine();
				for (int j = 1; j < PaisTemperatura.GetLength(1); j++)
				{
					Console.Write($"Temperatura media mensual n°{j+1}: ");
					PaisTemperatura[i, j] = double.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine();

			for (int i = 0; i < PaisTemperatura.GetLength(0); i++)
			{
				Console.Write("Pais: "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(PaisTemperatura[i, 0]);
				Console.ForegroundColor = ConsoleColor.White;
				for (int j = 1; j < PaisTemperatura.GetLength(1); j++)
				{
					Console.Write($"Temperatura n°{j + 1}: "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"{PaisTemperatura[i, j]}°C");
					Console.ForegroundColor = ConsoleColor.White;
				}
				Console.Write($"Temperatura Trimestral Media: ");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine($"{TempTrimMedia(i,ref Pais, ref Temperatura):n}°C");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("\n");
			}

			Console.WriteLine($"{Pais} tiene la mayor temperatura trimestral de {Temperatura}°C");

			Console.ReadKey();
		}
	}
}
