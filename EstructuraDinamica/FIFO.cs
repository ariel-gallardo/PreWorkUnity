﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
	public class FIFO<T> : Lista<T>
	{

		public override Nodo<T> Extraer()
		{
			Nodo<T> tempNodo = null;
			if(Raiz != null)
			{
				if(Raiz._Nodo == null)
				{
					tempNodo = Raiz;
					Raiz = null;
					//Console.ForegroundColor = ConsoleColor.Red;
					//Console.Write(tempNodo.Dato.ToString() + " <- ");
					//Console.ForegroundColor = ConsoleColor.White;
					return tempNodo;
				}
				else
				{
					tempNodo = Raiz._Nodo;
					Nodo<T> tempRaiz = Raiz;
					while (tempNodo != null)
					{
						if (tempNodo._Nodo == null)
						{
							//Console.ForegroundColor = ConsoleColor.Red;
							//Console.Write(tempNodo.Dato.ToString() + " <- ");
							//Console.ForegroundColor = ConsoleColor.White;
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
	}
}
