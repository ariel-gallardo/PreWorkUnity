using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class FIFO
	{
		public Nodo Raiz { get; set; }

		public FIFO()
		{
		}

		public FIFO(Nodo raiz)
		{
			Raiz = raiz;
		}
		public void Insertar(Nodo nodo)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write((Raiz != null ? " - " : String.Empty) + nodo.Dato);
			if (Raiz == null) {
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
			if(Raiz != null)
			{
				if(Raiz._Nodo == null)
				{
					tempNodo = Raiz;
					Raiz = null;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write(tempNodo.Dato + " <- ");
					Console.ForegroundColor = ConsoleColor.White;
					return tempNodo;
				}
				else
				{
					tempNodo = Raiz._Nodo;
					Nodo tempRaiz = Raiz;
					while (tempNodo != null)
					{
						if (tempNodo._Nodo == null)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write(tempNodo.Dato + " <- ");
							Console.ForegroundColor = ConsoleColor.White;
							tempRaiz._Nodo = null;
							return tempNodo;
						}
						else
						{
							tempRaiz = tempNodo;
							tempNodo = tempRaiz._Nodo;
						}
					}
				}
			}
			return null;
		}

		public override string ToString()
		{
			Nodo tempRaiz = Raiz;
			String Valores = String.Empty;
			while(tempRaiz != null)
			{
				Valores += tempRaiz.Dato+(tempRaiz._Nodo != null ? " - " : String.Empty);
				tempRaiz = tempRaiz._Nodo;
			}
			return Valores;
		}
	}
}
