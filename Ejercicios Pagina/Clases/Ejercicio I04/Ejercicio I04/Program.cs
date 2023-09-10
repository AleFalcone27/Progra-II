using Entidades;
namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dibujo;

            Boligrafo b1 = new Boligrafo(ConsoleColor.Blue, 70);
            Console.ForegroundColor = b1.GetColor();
            Console.WriteLine($"Tinta: {b1.GetTinta()}");
            b1.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta: {b1.GetTinta()}");


            //b1.Pintar(10,out dibujo);
            //Console.WriteLine(dibujo);
            //b1.Pintar(-10, out dibujo);
            //Console.WriteLine(dibujo);
            //Console.WriteLine($"Tinta: {b1.GetTinta()}");
            //b1.Recargar();
            //Console.WriteLine($"Tinta: {b1.GetTinta()}");
            //b1.Pintar(-40, out dibujo);




        }
    }
}