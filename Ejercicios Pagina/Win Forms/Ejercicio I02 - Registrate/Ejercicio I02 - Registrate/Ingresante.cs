using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Registrate
{
    internal class Ingresante
    {
       private string[] cursos;
       private string direccion;
       private int edad;
       private string genero;
       private string nombre;
       private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direcciób {this.direccion}");
            sb.AppendLine($"Edad {this.edad}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine($"Curso/s {this.cursos.ToString()}");
            return sb.ToString();   
        }

    }
}
