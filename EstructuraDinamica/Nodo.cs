using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	public class Nodo<T>
	{
		public Nodo<T> _Nodo { get; set; }
		public T Dato { get; set; }
		public Nodo(T dato)
		{
			Dato = dato;
		}
		public Nodo(Nodo<T> nodo)
		{
			this.Dato = nodo.Dato;
		}
	}
}
