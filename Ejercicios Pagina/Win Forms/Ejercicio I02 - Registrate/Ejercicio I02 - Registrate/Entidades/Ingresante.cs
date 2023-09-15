using System.Text;

namespace Ejercicio_I02___Registrate
{
    public class Ingresante
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
            sb.Append($"Nombre: {this.nombre}");
            sb.Append($"Dirección: {this.direccion}");
            sb.Append($"Edad: {this.edad}");
            sb.Append($"Género: {this.genero}");
            sb.Append($"País: {this.pais}");
            sb.Append($"Curso/s {this.cursos}");
            return sb.ToString();
        }
    }
}