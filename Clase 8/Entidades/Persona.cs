using System.Text;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected int dni;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            return sb.ToString();   
        }

    }
}


// 

