using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
	partial class Rectangulo
	{
		public Double Area() {
			return Base * Altura;
		}

		public Double Perimetro() {
			return Base * 2 + Altura * 2;
		}
	}
}
