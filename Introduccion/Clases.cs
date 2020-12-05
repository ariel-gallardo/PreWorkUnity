using System;
using System.Collections.Generic;

namespace Introduccion
{
	class Clases
	{
		class Empleado
		{
			String Nombre { get; set; }
			Double Sueldo { get; set; }

			public Empleado(string nombre, double sueldo)
			{
				Nombre = nombre;
				Sueldo = sueldo;
			}

			public override string ToString()
			{
				return $"{Nombre,12:s} {Sueldo,18:c} {(Sueldo > 3000 ? "si" : "no")} paga impuestos";
			}
		}
		static void Main(string[] args)
		{
			List<Empleado> empleados = new List<Empleado>()
			{
                new Empleado("Cierra",  1591),
                new Empleado("Hershel",  4830),
                new Empleado("Rodrick",  284),
                new Empleado("Isabella",  3390),
                new Empleado("Shonna",  535),
                new Empleado("Delois",  4713),
                new Empleado("Lorita",  4905),
                new Empleado("Evalyn",  3969),
                new Empleado("Dolores",  2059),
                new Empleado("Dulce",  1485),
                new Empleado("Freeda",  2344),
                new Empleado("Ramiro",  2021),
                new Empleado("Yadira",  2568),
                new Empleado("Katheleen",  4904),
                new Empleado("Emilie",  4939),
                new Empleado("Lashanda",  958),
                new Empleado("Rolanda	",  2464),
                new Empleado("Sal",  4701),
                new Empleado("Pearl",  416),
                new Empleado("Providencia", 2985),
                new Empleado("Delta",  3612),
                new Empleado("Frida",  3097),
                new Empleado("Deborah",  1134),
                new Empleado("Cecile	",  2535),
                new Empleado("Julian",  4541),
                new Empleado("Bev	",  2061),
                new Empleado("Tosha",  4582),
                new Empleado("Rosana",  4182),
                new Empleado("Hope",  1870),
                new Empleado("Pamela",  363)
			};
			empleados.ForEach(e => Console.WriteLine(e));;
			Console.ReadKey();
		}
	}
}
