using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        double cantidad;
        static double cotzRespectoDolar;

        public Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad) : this()
        // Llamamos al constructor anterior para darle un valor a cotzRespoectoDeDolar si no se ingreso al instanciralo
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }


        //Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }


        //Sobrecarga explicita de Dolar y Euro

        public static explicit operator Dolar(Peso p)
        {
            double cantidadEnDolares = p.GetCantidad() / Peso.GetCotizacion();
            return new Dolar(cantidadEnDolares);
        }

        public static explicit operator Euro(Peso p)
        {
            double cantidadEnEuros = p.GetCantidad()  / Peso.GetCotizacion();
            return new Euro(cantidadEnEuros);
        }

        // Sobrecarga implicita de double

        public static implicit operator double(Peso e)
        {
            return new Peso(e);

        }


        //Sobrecarga de operadores 

        // == 
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }

        // !=
        public static bool operator !=(Peso p, Peso p2)
        {
            return p.GetCantidad() != p2.GetCantidad();
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return p.GetCantidad() != d.GetCantidad();
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return p.GetCantidad() != e.GetCantidad();
        }


        // +
        public static double operator +(Peso p, Dolar d)
        {
            return p.GetCantidad() + d.GetCantidad();
        }
        public static double operator +(Peso p, Euro e)
        {
            return p.GetCantidad() + e.GetCantidad();
        }


        // -
        public static double operator -(Peso p, Dolar d)
        {
            return p.GetCantidad() - d.GetCantidad();
        }
        public static double operator -(Peso p, Euro e)
        {
            return p.GetCantidad() - e.GetCantidad();
        }


    }
}
