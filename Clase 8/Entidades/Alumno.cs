using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        private string legajo;
        private List<string> materias;

        public Alumno(string legajo, string nombre, string apellido, int dni, int edad)
            : base(nombre, apellido, dni)
        {
            this.legajo = legajo;
            this.apellido = legajo;
        }

    }
}
