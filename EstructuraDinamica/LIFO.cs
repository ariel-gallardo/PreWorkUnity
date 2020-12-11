using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	public class LIFO<T> : Lista<T>
	{

		public override Nodo<T> Extraer()
		{	
			if(Raiz != null)
			{
				Nodo<T> tempNodo = Raiz;
				Raiz = Raiz._Nodo;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(tempNodo.Dato.ToString() + " <- ");
				Console.ForegroundColor = ConsoleColor.White;
				return tempNodo;
			}
			
			return null;
		}
	}
}

