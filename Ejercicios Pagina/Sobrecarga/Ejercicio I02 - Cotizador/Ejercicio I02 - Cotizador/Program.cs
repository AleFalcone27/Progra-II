using Billetes;

namespace Ejercicio_I02___Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new Peso(902) - new Dolar(100)) ;
            Console.WriteLine(new Euro(1) + new Dolar(1)) ;


            Euro billeteEuro = new Euro(100);
            Peso p = (Peso)billeteEuro;
            Console.WriteLine((Dolar)billeteEuro);



            //Dolar dolar = new Dolar(200);
            //Peso p = (Peso)dolar;
            //Console.WriteLine(p.GetCantidad());

        }
    }
}