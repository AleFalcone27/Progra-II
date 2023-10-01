using Centralita;

namespace Ejercicio_C03___La_centralita_Episodio_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CentralitA c = new CentralitA("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 20, "Rosario", 2.65f);
            Local l2 = new Local("Lanus", 40, "Benito Juarez", 2.340f);

            Llamada miCall = new Llamada(20, "2281305392", "1126420654");

            Provincial p1 = new Provincial(Provincial.EFranja.Franja_3, l2);

            Provincial p2 = new Provincial("Morón", Provincial.EFranja.Franja_1, 21, "Bernal");

            

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            c.Llamadas.Add(l1);
            Console.WriteLine(l1.Mostrar());

            c.Llamadas.Add(l2);
            Console.WriteLine(l2.Mostrar());

            c.Llamadas.Add(p1);
            Console.WriteLine(p1.Mostrar());

            c.Llamadas.Add(p2);
            Console.WriteLine(p2.Mostrar());


            Console.WriteLine(c.Mostrar());




        }
    }
}