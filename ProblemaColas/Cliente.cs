using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaColas
{
	class Cliente
	{
		public int Id { get; set; }
		public int HoraLlegada { get; set; }
		public int TiempoAtencion { get; set; }

		public Cliente(int id, int horaLlegada, int tiempoAtencion)
		{
			Id = id;
			HoraLlegada = horaLlegada;
			TiempoAtencion = tiempoAtencion;
		}
		public override string ToString()
		{
			return $"{Id}";
		}
	}
}
