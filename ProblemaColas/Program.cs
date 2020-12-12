using EstructuraDinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemaColas
{
	class Program
	{
		public static int Tiempo { get; set; }
		public static int TiempoAnterior { get; set; }
		public static int NumAtendido { get; set; }
		public static int NumTotal { get; set; }
		public static Thread Ingreso { get; set; }
		public static Thread Atencion { get; set; }
		public static Thread Mensaje { get; set; }
		public static FIFO<Cliente> Clientes { get; set; }
		static void Main(string[] args)
		{
			Clientes = new FIFO<Cliente>();
			Tiempo = 0;
			TiempoAnterior = -1;
			NumAtendido = NumTotal = 0;
			Ingreso = new Thread(new ThreadStart(NuevoCliente)); Ingreso.Start();
			Atencion = new Thread(new ThreadStart(AtenderClientes)); Atencion.Start();
			Mensaje = new Thread(new ThreadStart(MostrarMensaje)); Mensaje.Start();
		}

		public static void MostrarMensaje()
		{
			while (true)
			{
				if (!Ingreso.IsAlive && !Atencion.IsAlive)
				{
					Console.WriteLine(new Program().ToString());
					Console.ReadKey();
					break;
				}
				Thread.Sleep(1);
			}
		}
		public static void NuevoCliente(){
			while (Tiempo <= 600)
			{
				if(Tiempo != TiempoAnterior)
				{
					if (Tiempo % 2 == 0 && Tiempo % 3 != 0 && Tiempo > 0)
					{
						Clientes.Insertar(new Nodo<Cliente>(new Cliente(NumTotal,Tiempo, new Random().Next(2, 4))));
						NumTotal++;
					}
					else if (Tiempo % 2 != 0 && Tiempo % 3 == 0 && Tiempo > 0)
					{
						Clientes.Insertar(new Nodo<Cliente>(new Cliente(NumTotal, Tiempo, new Random().Next(2, 4))));
						NumTotal++;
					}
				}
				TiempoAnterior = Tiempo;
				Thread.Sleep(1);
			}
		}

		public static void AtenderClientes()
		{
			for (Tiempo = 0; Tiempo <= 600; Tiempo++)
			{
				if(Clientes.Raiz != null)
				{
					if ((Clientes.Raiz.Dato.HoraLlegada + Clientes.Raiz.Dato.TiempoAtencion) == Tiempo)
					{
						Clientes.Extraer();
						NumAtendido++;
					}
				}
				Thread.Sleep(1);
			}
		}

		public override string ToString()
		{
			return $"\nCantidad de clientes que se atienden en 10 horas -> {NumAtendido}\n" +
				$"Cantidad de clientes que hay en cola después de 10 horas -> {NumTotal-NumAtendido}\n" +
				$"Hora de llegada del primer cliente que no es atendido luego de 10 horas -> { (Clientes.Raiz != null ? Clientes.Raiz.Dato.HoraLlegada.ToString()+" Minuto" : "Se atendieron a todos") }";
		}
	}
}
