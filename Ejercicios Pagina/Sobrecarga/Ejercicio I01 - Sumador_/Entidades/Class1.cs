using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Sumador
    {

        int cantidadSumas;


        // Sobrecargamos constructores para poder construir objetos de varias formas
        public Sumador(int num)
        {
            this.cantidadSumas = num;
        }

        public Sumador()
            : this(0)
        {

        }

        //Sobrecargamos metodos para que puedan tomar diferentes parametros
        public long Sumar(long a, long b)
        {
            cantidadSumas += 1;
            return (a + b);
        }

        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        // Realizamos una conversion explicita
        public static explicit operator int (Sumador cant)
        {
            return cant.cantidadSumas;
        }

        // La sobrecarga de operadores la hacemos para poder realizar operaciones entre instancias de nuestra clase
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }

        // Sobrecargamos el metodo | para ver si ambos sumadores realizaron la misma cantidad de sumas
        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas ? true : false;
        }


    }
}