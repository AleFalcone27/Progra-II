using Libro;
using System.Runtime.CompilerServices;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 myBook = new Class1();

            myBook[1] = "Primer Pagina";

            Console.WriteLine(myBook[1]);
        }
    }
}