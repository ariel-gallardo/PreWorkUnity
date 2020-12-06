using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class Program
	{
		public static FIFO FIFO { get; set; }
		public static LIFO LIFO { get; set; }
		static void Main(string[] args)
		{
			InstanciarFIFO();
			InstanciarLIFO();
			Console.WriteLine("Presionar una tecla para salir");
			Console.ReadKey();
		}

		public static void InstanciarLIFO() {
			LIFO = new LIFO();
			Console.WriteLine("Estructura de una Pila LIFO");
			Console.Write("Insercion de valores: ");
			LIFO.Insertar(new Nodo(10));
			LIFO.Insertar(new Nodo(20));
			LIFO.Insertar(new Nodo(30));
			LIFO.Insertar(new Nodo(40));
			LIFO.Insertar(new Nodo(50));
			Console.WriteLine();
			Console.Write("Visualizacion de valores: "); VisualizacionLIFO();
			Console.WriteLine("Extracciones:\n");
			LIFO.Extraer(); VisualizacionLIFO();
			LIFO.Extraer(); VisualizacionLIFO();
			LIFO.Extraer(); VisualizacionLIFO();
			LIFO.Extraer(); VisualizacionLIFO();
			LIFO.Extraer(); VisualizacionLIFO();
			LIFO.Extraer(); VisualizacionLIFO();
			Console.WriteLine("\nPresionar una tecla para continuar.");
			Console.ReadKey();
			Console.Clear();
		}

		public static void InstanciarFIFO() {
			FIFO = new FIFO();
			Console.WriteLine("Estructura de una Pila FIFO");
			Console.Write("Insercion de valores: ");
			FIFO.Insertar(new Nodo(10));
			FIFO.Insertar(new Nodo(20));
			FIFO.Insertar(new Nodo(30));
			FIFO.Insertar(new Nodo(40));
			FIFO.Insertar(new Nodo(50));
			Console.WriteLine();
			Console.Write("Visualizacion de valores: "); VisualizacionFIFO();
			Console.WriteLine("Extracciones:\n");
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
			FIFO.Extraer(); VisualizacionFIFO();
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
				Console.WriteLine(LIFO);
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	}
}
