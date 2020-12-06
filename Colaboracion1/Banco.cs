using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboracion1
{
	class Banco
	{
		private static Cliente[] clientes = new Cliente[3];
		private static Int32 empleadoActual = 0;
		static void Main(string[] args)
		{
			
			for (int i = 0; i < clientes.Length; i++)
			{
				Console.WriteLine("Cargar clientes:\n");
				clientes[i] = new Cliente();
				Console.Write("Nombre: ");
				clientes[i].Nombre = Console.ReadLine();
				Console.Write("Monto: ");
				clientes[i].Monto = Double.Parse(Console.ReadLine());
				Console.Clear();
			}
			Boolean operar = true;
			while (operar) {
				Console.Write(
					$"Empleado actual {empleadoActual}\n"+
					"1 - 2 - 3  Cambiar de empleado\n" +
					"Extraccion\n" +
					"Deposito\n" +
					"Opcion: "
				);
				String seleccion = Console.ReadLine().ToLower();
				switch (seleccion)
				{
					case "1": case "2": case "3:":
						empleadoActual = Int32.Parse(seleccion)-1;
					break;
					case "extraccion":
						Console.Write("Monto a extraer: ");
						Console.WriteLine($"Se ha extraido {clientes[empleadoActual].Extraer(Double.Parse(Console.ReadLine())):c}");
						Console.WriteLine($"{clientes[empleadoActual]}:c");
					Console.Write("Presione una tecla para continuar");
					Console.ReadKey();
					break;
					case "deposito":
						Console.Write("Monto a depositar: ");
						clientes[empleadoActual].Depositar(Double.Parse(Console.ReadLine()));
						Console.WriteLine(clientes[empleadoActual]);
					Console.Write("Presione una tecla para continuar");
					Console.ReadKey();
					break;
					default:
						operar = false;
					break;
				}
				Console.Clear();
			}
			Console.WriteLine($"Monto total del banco: {clientes.ToList().Sum(cliente => cliente.Monto):c}");
			Console.Write("Presione una tecla para salir");
			Console.ReadKey();
		}
	}
}
