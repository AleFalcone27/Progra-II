using Entidades;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            Alumno alejo = new Alumno("123","Alejo","'Falcone",12345,22);
            Console.WriteLine(alejo.MostrarDatos());
        }
    }
}

// modificador de acceso sealed