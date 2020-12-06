using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class LIFO
	{
		public Nodo Raiz { get; set; }

		public LIFO()
		{
		}

		public LIFO(Nodo raiz)
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

		public Nodo Extraer()
		{
			Nodo tempNodo = null;
			if (Raiz._Nodo == null)
			{
				tempNodo = Raiz;
				Raiz._Nodo = null;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(Raiz.Dato + " <- ");
				Console.ForegroundColor = ConsoleColor.White;
				return tempNodo;
			}
			else
			{
				tempNodo = new Nodo(Raiz);
				Raiz = Raiz._Nodo;
			}
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(" No hay mas elementos ");
			Console.ForegroundColor = ConsoleColor.White;
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
