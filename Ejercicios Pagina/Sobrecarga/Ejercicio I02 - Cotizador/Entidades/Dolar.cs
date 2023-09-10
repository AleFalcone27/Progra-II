using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Billetes
{
    public class Dolar
    {
        //Campos
        private double cantidad;
        static double cotzRespectoDolar; 

        //Constructores
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1/1.18;
        }

        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
        {
            Dolar.cotzRespectoDolar = cotizacion;
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

        // Sobrecarga Implicita para double
        public static implicit operator double(Dolar d)
        { 
            return new Dolar(d);
        }


        // Sobrecarga explicita para Euro y Peso
        public static explicit operator Euro(Dolar d)
        {
            double cantidadEnEuros = d.cantidad * Euro.GetCotizacion();
            return new Euro(cantidadEnEuros);
        }

        public static explicit operator Peso(Dolar d)
        {
            double cantidadEnPesos = d.cantidad * Peso.GetCotizacion();
            return new Peso(cantidadEnPesos);
        }


        //Sobrecarga de operadores


        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }


        // +


        public static double operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + e.GetCantidad();
        }
        public static double operator +(Dolar d, Peso p)
        {
            return d.GetCantidad() + p.GetCantidad();
        }




        public static double operator -(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() - d2.GetCantidad();
        }


        public static double operator /(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() / d2.GetCantidad();
        }

        public static double operator *(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() * d2.GetCantidad();
        }


    }



}