using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	class LIFO : Pila
	{

		public Nodo Extraer()
		{	
			if(Raiz != null)
			{
				Nodo tempNodo = Raiz;
				Raiz = Raiz._Nodo;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(tempNodo.Dato + " <- ");
				Console.ForegroundColor = ConsoleColor.White;
				return tempNodo;
			}
			
			return null;
		}
	}
}

