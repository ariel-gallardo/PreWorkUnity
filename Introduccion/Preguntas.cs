using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Pregunta
    {
        public Boolean Correcta { get; set; }
        public Pregunta(Boolean correcta)
        {
            Correcta = correcta;
        }
    }

    class Persona
    {
        List<Pregunta> Preguntas { get; set; }

        public Persona()
        {
        }
        public Persona(List<Pregunta> preguntas)
        {
            Preguntas = preguntas;
        }

        public override string ToString()
        {
            Double nivel = Preguntas.Sum(pregunta => pregunta.Correcta ? 1.0 / Preguntas.Count() : 0.0);

            return $"Porcentaje {nivel:p}  -> " +  (nivel >= 0.9 ? "Nivel Maximo" : nivel >= 0.75 ? "Nivel Medio" : nivel >= 0.5 ? "Nivel Regular" : "Fuera de Nivel");
        }
    }

    class Preguntas
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona(
                    new List<Pregunta>(){
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(false),
                        new Pregunta(false),
                        new Pregunta(false),
                        new Pregunta(false),
                        new Pregunta(false)
                    }
                    ),
                new Persona(
                    new List<Pregunta>()
                    {
                        new Pregunta(false),
                        new Pregunta(false),
                        new Pregunta(false),
                        new Pregunta(false)
                    }
                    ),
                new Persona(
                        new List<Pregunta>(){
                            new Pregunta(true),
                            new Pregunta(true)
                        }
                    ),
                new Persona(
                    new List<Pregunta>(){
                        new Pregunta(false),
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(true),
                        new Pregunta(false)
                    }
                    )
            };
            personas.ForEach(delegate (Persona persona) {
                Console.WriteLine(persona);
            });
            Console.ReadKey();
        }
    }
}
