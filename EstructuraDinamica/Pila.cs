using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class Pila
	{
		public Nodo Raiz { get; set; }

		public Pila()
		{
		}

		public Pila(Nodo raiz)
		{
			Raiz = raiz;
		}
		public void Insertar(Nodo nodo)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write((Raiz != null ? " - " : String.Empty) + nodo.Dato);
			if (Raiz == null)
			{
				Raiz = nodo;
			}
			else
			{
				nodo._Nodo = Raiz;
				Raiz = nodo;
			}
			Console.ForegroundColor = ConsoleColor.White;
		}

		public virtual Nodo Extraer() {
			return null;
		}

		public override string ToString()
		{
			Nodo tempRaiz = Raiz;
			String Valores = String.Empty;
			while (tempRaiz != null)
			{
				Valores += tempRaiz.Dato + (tempRaiz._Nodo != null ? " - " : String.Empty);
				tempRaiz = tempRaiz._Nodo;
			}
			return Valores;
		}
	}
}
