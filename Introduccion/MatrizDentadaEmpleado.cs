using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
	class MatrizDentadaEmpleado
	{
		private static Object[][] Matriz;
		static void Main(string[] args)
		{
			int i = 0, j = 1;
			while (true)
			{
				Console.Write("Nombre: ");
				String Nombre = Console.ReadLine();
				if (Nombre == String.Empty) break;
				Array.Resize(ref Matriz, i + 1);
				Matriz[i] = new Object[1];
				Matriz[0][i] = Nombre;	
				j = 1;
				while (true) {
					Console.Write($"\tTardanza n°{j}: ");
					Int32 Dia = Int32.Parse(Console.ReadLine());
					if (Dia == 0) break;
					Array.Resize(ref Matriz[i], j + 1);
					Matriz[i][j] = Dia;
					j++;
				}
				i++;
			}
			Console.Clear();
			Boolean nombre;
			foreach (Object[] o in Matriz)
			{
				nombre = true;
				foreach (Object element in o)
				{
					if (nombre)
					{
						Console.WriteLine($"Empleado {element}");
						nombre = false;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
						Console.WriteLine($"\tDia {element}");
						Console.ForegroundColor = ConsoleColor.White;
					}
				}
			}
			Console.ReadKey();
		}
	}
}
