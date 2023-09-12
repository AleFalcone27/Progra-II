using Entidades;
using System;

namespace Ejercicio_C02___La_estantería
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);

            // Agrego los productos al estante

            Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            Console.WriteLine("¡Agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());


            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}