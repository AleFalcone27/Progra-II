using Geometria;
namespace Ejercicio_I05
{
    internal class Program
    {

        public static void mostrar(Rectangulo rect)
        {
            Console.WriteLine($"Area: {rect.Area()}");
            Console.WriteLine($"Vertice 2: {rect.GetVertice2()}");

        }


        static void Main(string[] args)
        {
            Rectangulo rect = new Rectangulo(new Punto(2,2),new Punto(6,6));
            mostrar(rect);


        }
    }
}
