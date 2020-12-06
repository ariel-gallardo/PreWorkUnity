using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParciales
{
	partial class Rectangulo : Figura
	{
		public Rectangulo(double @base, double altura)
		{
			Base = @base;
			Altura = altura;
		}
		public Rectangulo()
		{
		}

		public override string ToString()
		{
			return $"Forma de {this.GetType().Name}\nBase: {Base:n}\nAltura: {Altura:n}\nArea: {Area():n}\nPerimetro: {Perimetro()}";
		}
	}
}
