using Entidades;


namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int min = 0, max = 0, prom = 0, inputInt= 0, cont = 0;
            bool flag = true;
            string inputString;

            Console.WriteLine("-- Ingrese un número para saber si es mayor o menor --");

            while (cont < 10) {

                inputString = Console.ReadLine();

                if (int.TryParse(inputString, out inputInt) && Validacion.Validar(inputInt, -100, 100)) {

                    if (flag)
                    {
                        max = inputInt;
                        min = inputInt;
                        flag = false;
                    }


                    max = Validacion.GetMin(inputInt, max);
                    min = Validacion.GetMin(inputInt, min);
                    cont++;

                }
                else {
                    Console.WriteLine("-- Error Ingrese un número --");
                    inputString = Console.ReadLine();

                }
            }
        }
    }
}