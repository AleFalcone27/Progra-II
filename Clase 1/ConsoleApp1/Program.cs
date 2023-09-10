namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Consola de Alejo";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

           


            string input;

            //Console.WriteLine("Escribe algo:");
            input = Console.ReadLine(); // Lee una línea de entrada del usuario
            Console.WriteLine("Escribiste: " + input);

        }
    }
}