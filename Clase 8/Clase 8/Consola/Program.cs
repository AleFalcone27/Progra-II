using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            
        }

        public virtual override 

        public override bool Equals(object? obj)
        {

            if(obj == )
            return base.Equals(obj);
        }
    }
}


/* Polimorfismo
Capacidad de los objetos de responder al mismo mensaje de diferentes formas
Los tipos derivados van a poder redefinir una operacion de su clase padre
El polimorfismo en herencia se resuelve dinamicamente en tiempo de ejecucion
Se va a ejecutar el metodo mas especifico 

HERENCIA NO POLIMORFICA
- Nos permite redefinir una operacion pero sin aplicar polimorfismo

El modificador virtual se pone en el metodo de la clase 
padre para hacerle saber al compilador de que los hijos pueden sobre escribirlo
y en el metodo de la clase heredada se escribe el override

VIRTUAL palabra reservada para reservada para declarar un metodo que pueda
ser invalidado / redefinido / sobrescrito por una clase derivada

Overrido palabra reservada para invalidado / redefinido / sobrescrito 
un metodo virtual de la clase base

Un metodo puede tener los modificadores override y virtual al mismo tiempo? 
No se si tiene mucho sentido la pregunta 

CLASES ABSTRACTAS 
- Crean una jerarquia de herencias no pueden ser instancias 
La regla seria que si heredamos de una clase abstracta, base en una clase abstracta hija, 
estamos obligados a implementar lo heredado en la 
clase nieta a no ser que ya haya sido implementado en la clase hija 
*/

