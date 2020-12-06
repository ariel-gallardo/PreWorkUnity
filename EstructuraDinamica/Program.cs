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
		static void Main(string[] args)
		{
			InstanciarFIFO();
			Console.WriteLine("Presionar una tecla para salir");
			Console.ReadKey();
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
			Console.WriteLine("\nPresionar una tecla para continuar.");
			Console.ReadKey();
			Console.Clear();
		}

		public static void VisualizacionFIFO() {
			if(FIFO != null)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine(FIFO);
				Console.ForegroundColor = ConsoleColor.White;
			}
		}
	}
}
