using Entidades;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio C01";

            Console.WriteLine(Conversor.ConvertirBinarioADecimal(1010) + 20);
        }
    }
}