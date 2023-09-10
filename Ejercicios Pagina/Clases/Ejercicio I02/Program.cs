using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Alejo","11/27/2005",43803738);
            p1.SetNombre("Alejo");
            p1.SetDni(43803738);
            p1.SetFechaDeNacimiento("11/27/2001");
            Console.WriteLine(p1.Mostrar());
        }
    }
}