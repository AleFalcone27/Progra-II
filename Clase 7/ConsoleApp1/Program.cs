using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Persona persona = new Persona("Alejo", "Falcone", DateTime.Now, 43803738);

            Console.WriteLine(persona["apellido"]);

        }
    }
}