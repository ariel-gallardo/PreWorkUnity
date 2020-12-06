using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class Nodo
	{
		public Nodo _Nodo { get; set; }
		public int Dato { get; set; }
		public Nodo(int dato)
		{
			Dato = dato;
		}

		public Nodo(Nodo nodo)
		{
			this.Dato = nodo.Dato;
		}
	}
}
