using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProblemaPilas
{
	static class Program
	{
		public static EstructuraDinamica.FIFO<Char> Simbolos { get; set; }
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Simbolos = new EstructuraDinamica.FIFO<char>();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new F_Pilas());
		}
	}
}
