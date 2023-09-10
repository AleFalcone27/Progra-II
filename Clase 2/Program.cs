namespace Clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 2";

            string Nombre;
            string primerNota;
            string segundaNota;

            int primerNotaNumero;
            int segundaNotaNumero;


            bool resultado;
            double promedio;


            Console.WriteLine("Ingrese su primer Nota");

            primerNota = Console.ReadLine();

            resultado = int.TryParse(primerNota,out primerNotaNumero);

            Console.WriteLine(resultado.ToString() + primerNotaNumero);


            //Nos permite ejecutarl le programa desde el .exe
            Console.ReadKey();
            // .GetType() método que nos permite saber el tipo de dato 

            /* int.TryParse(cadena de caracteres, out y la varaible en la cual queremos que se guarde) 
                 Si lo puede convertir devuelve true y nos guarda en la varibale si no lo puede convertir devuelva false, y en la variable de salida nos va a guardar 0
                 Cuando pasamos por referencia apuntamos directamente 
            */ 

            
        }
    }
}

