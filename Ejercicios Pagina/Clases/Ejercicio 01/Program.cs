using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta n1 = new Cuenta("Alejo",10000);
            Console.WriteLine(n1.Mostrar());
            n1.retirar(50);
            Console.WriteLine(n1.Mostrar());
            n1.ingresar(10000);
            Console.WriteLine(n1.Mostrar());

        }  

    }
}