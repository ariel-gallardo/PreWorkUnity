using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	public class Lista<T>
	{
		public Nodo<T> Raiz { get; set; }

		public Lista()
		{
		}

		public Lista(Nodo<T> raiz)
		{
			Raiz = raiz;
		}
		public void Insertar(Nodo<T> nodo)
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

		public virtual Nodo<T> Extraer() {
			return null;
		}

		public override string ToString()
		{
			Nodo<T> tempRaiz = Raiz;
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
