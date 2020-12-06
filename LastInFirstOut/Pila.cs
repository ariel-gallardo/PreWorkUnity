using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastInFirstOut
{
	class Pila
	{
		public Int32 Valor { get; set; }
		public Pila Nodo { get; set; }

		public Pila(int valor)
		{
			Valor = valor;
		}

		public void Add(Int32 Valor)
		{
			if(Nodo == null)
			{
				Nodo = new Pila(this.Valor);
			}
			else
			{
				Nodo = Nodo.Nodo;
				Nodo.Add(this.Valor);
			}
			this.Valor = Valor;
		}
	}
}
