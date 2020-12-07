using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class Program
	{
		public static FIFO<int> FIFO { get; set; }
		public static LIFO<int> LIFO { get; set; }
		static void Main(string[] args)
		{
			InstanciarFIFO();
			InstanciarLIFO();
			Console.WriteLine("Presionar una tecla para salir");
			Console.ReadKey();
		}

		public static void InstanciarLIFO() {
			int valLIFO = 10;
			LIFO = new LIFO<int>();
			Console.WriteLine("Estructura de una Pila LIFO");
			Console.Write("Insercion de valores: ");
			do
			{
				LIFO.Insertar(new Nodo<int>(valLIFO+=10));
			} while (valLIFO < 60);
			Console.WriteLine();
			Console.Write("Visualizacion de valores: "); VisualizacionLIFO();
			Console.WriteLine("Extracciones:\n");
			while(LIFO.Raiz != null)
			{
				LIFO.Extraer(); VisualizacionLIFO();
			}
			Console.WriteLine("\nPresionar una tecla para continuar.");
			Console.ReadKey();
			Console.Clear();
		}

		public static void InstanciarFIFO() {
			int valFIFO = 10;
			FIFO = new FIFO<int>();
			Console.WriteLine("Estructura de una Pila FIFO");
			Console.Write("Insercion de valores: ");
			do
			{
				FIFO.Insertar(new Nodo<int>(valFIFO+=10));
			} while (valFIFO < 60);
			Console.WriteLine();
			Console.Write("Visualizacion de valores: "); VisualizacionFIFO();
			Console.WriteLine("Extracciones:\n");
			while(FIFO.Raiz != null)
			{
				FIFO.Extraer(); VisualizacionFIFO();
			}
			Console.WriteLine("\nPresionar una tecla para continuar.");
			Console.ReadKey();
			Console.Clear();
		}

		public static void VisualizacionFIFO() {
			if(FIFO != null)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;		
				if(FIFO.Raiz == null)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine("No hay mas elementos ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.WriteLine(FIFO);
				}
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
		public static void VisualizacionLIFO()
		{
			if (LIFO != null)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				if (LIFO.Raiz == null)
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					Console.WriteLine("No hay mas elementos ");
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
				{
					Console.WriteLine(LIFO);
				}
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	}
}
