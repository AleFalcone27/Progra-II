using Entidades;
using System.Security.Cryptography;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circulo miCirculo = new Circulo(2.5);
            Cuadrado miCuadrado = new Cuadrado(2,2);
            Rectangulo miRectangulo = new Rectangulo(2,4);


            Console.WriteLine("========== FIGURA 1 ==========");
            Console.WriteLine($"Tipo: {miCirculo.GetType()}");
            Console.Write(miCirculo.Dibujar());
            Console.WriteLine($"Área: {miCirculo.Superficie}");
            Console.WriteLine($"Perímetro: {miCirculo.Superficie}");
            Console.WriteLine("==============================");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("========== FIGURA 2 ==========");
            Console.WriteLine($"Tipo: {miCuadrado.GetType()}");
            Console.Write(miCuadrado.Dibujar());
            Console.WriteLine($"Área: {miCuadrado.Superficie}");
            Console.WriteLine($"Perímetro: {miCuadrado.Superficie}");
            Console.WriteLine("==============================");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("========== FIGURA 3 ==========");
            Console.WriteLine($"Tipo: {miRectangulo.GetType()}");
            Console.Write(miRectangulo.Dibujar());
            Console.WriteLine($"Área: {miRectangulo.Superficie}");
            Console.WriteLine($"Perímetro: {miRectangulo.Perimetro}");
            Console.WriteLine("==============================");
        }
    }
}