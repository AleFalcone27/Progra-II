using ClassLibrary1;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion miCamion = new Camion(12,2,Colores.Blanco,4,500,2);
            
            Console.WriteLine(miCamion.MostrarDatos());
        }
    }
}