using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaPilas
{
	public partial class F_Pilas : Form
	{
		public F_Pilas()
		{
			InitializeComponent();
		}

		private void BTN_Analisis_Click(object sender, EventArgs e)
		{
			var simbolos =
			TB_Formula.Text.Where<char>(
				simbolo => simbolo == '(' || simbolo == ')' || simbolo == '{' || simbolo == '}'
			);

				foreach (char simbolo in simbolos)
				{
					Program.Simbolos.Insertar(new EstructuraDinamica.Nodo<char>(simbolo));
				}
				EstructuraDinamica.Nodo<char> nodoActual = Program.Simbolos.Extraer();
				if(nodoActual != null)
				{
					int cA = 0, cC = 0, pA = 0, pC = 0;
					String Mensaje = String.Empty;
					while (nodoActual != null)
					{
						switch (nodoActual.Dato)
						{
							case '(': pA++;
							break;
							case ')': pC++;
							break;
							case '{': cA++;
							break;
							case '}': cC++;
							break;
						}
						nodoActual = Program.Simbolos.Extraer();
					}
					
					if(cA != cC)
					{
						if (Mensaje.Equals(String.Empty)) { Mensaje += "Error"; }
						Mensaje += " - Corchetes";
					}
					if(pA != pC)
					{
						if (Mensaje.Equals(String.Empty)) { Mensaje += "Error"; }
						Mensaje += " - Parentesis";
					}
					if (!Mensaje.Equals(String.Empty))
					{
						L_Analisis.Text = Mensaje;
					}
					else { L_Analisis.Text = "Correctamente formulada."; }
				}
				else
				{
					L_Analisis.Text = "Completar";
				}
		}
	}
}
