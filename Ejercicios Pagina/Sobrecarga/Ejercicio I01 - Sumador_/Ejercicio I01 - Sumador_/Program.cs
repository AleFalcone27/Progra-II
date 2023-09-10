using Entidades;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();
            Console.WriteLine($"Sumador 1: {sumador1.Sumar(1, 2)}");
            Console.WriteLine($"Sumador 2: {sumador2.Sumar(5,7)}");
            Console.WriteLine($"Sumador 2: {sumador2.Sumar(5,7)}");
            Console.WriteLine($"Resultado: {sumador1 + sumador2}");
            Console.WriteLine($" Tienen los sumadores la misma cantidad de sumas ? {sumador1 | sumador2}");
        }
    }
}