using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colaboracion1
{
	class Cliente
	{
		public String Nombre { get; set; }
		public Double Monto { get; set; }

		public Cliente()
		{
		}
		public Cliente(string nombre, double monto)
		{
			Nombre = nombre;
			Monto = monto;
		}
		public void Depositar(Double Monto) {
			this.Monto += Monto;
		}
		public Double Extraer(Double Monto) {
			Double calculo = Monto - this.Monto;
			return Monto >= 0.0 ? calculo : 0.0;
		}

		public override string ToString()
		{
			return $"Monto total: {Monto}";
		}
	}
}
