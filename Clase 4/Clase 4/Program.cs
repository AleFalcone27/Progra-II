using Entidades;
namespace Clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*

            Console.WriteLine("ingrese el primer número");
            string operadorUno = Console.ReadLine();

            Console.WriteLine("ingrese el segundo número");
            string operadorDos = Console.ReadLine();

            int.TryParse(operadorUno, out int operadorUnoInt);
            int.TryParse(operadorDos, out int operadorDosInt);


            int resultado = Calculadora.Sumar(operadorUnoInt, operadorDosInt);
            Console.WriteLine($"El resultado es: {resultado}");   
        */

            //Persona persona = new Persona(43803738,"Falcone","Alejo");
            //Console.WriteLine(persona.MostrarDatos());


        }

    }
}


/*

SOBRECARGA DE METODOS
(Crear mimso metodo pero con diferentes parametros)
- 2 o mas metodos si pueden compartir el mismo nombre
- Sobrecargas validas : Cantidad, orden o tipo de parametros

SOBRECARGA DE CONSTRUCTORES 
Crear objetos de diferentes formas
- Se puede ir creando solo con algunos datos y los demas quedan vacios
- Dar la posibilidad de construir un objeto de distinta manera y con distintos 
- Basicamente construi como quieras

SOBRECARGA DE OPERADORES
Le damos la posibilidad a nuestra clase de que pueda realizar algo con un operador
Redifinimos lo que hace el operador
Si sobrecargo operadores de comparacion tengo que comparar por las 2 posibilidades
    en cambio sobrecargo el + esto no es necesario
public static bool operator == (Persona p1, Persona p2) {

            return p1.dni == p2.dni;
        }
public static bool operator != (Persona p1, Persona p2) {

            return !(p1.dni == p2.dni);
        }
SOBRECARGA DE CONVERSION
- Este relamente no lo entendi y tampoco entendi para que sirve 

*/