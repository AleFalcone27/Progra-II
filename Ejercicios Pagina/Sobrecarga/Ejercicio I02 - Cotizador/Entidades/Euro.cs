using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {

        //Campos
        private double cantidad;
        static double cotzRespectoDolar;

        //Constructores
        private Euro()
        {
            Euro.cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {

            Euro.cotzRespectoDolar = cotizacion;
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


        //Sobrecarga explicita de Dolar y Peso

        public static explicit operator Dolar(Euro e)
        {
            double cantidadEnDolares = e.cantidad / Euro.GetCotizacion();
            return new Dolar(cantidadEnDolares);
        }

        public static explicit operator Peso(Euro e)
        {
            double cantidadEnPesos = e.cantidad / Euro.GetCotizacion();
            return new Peso(cantidadEnPesos);
        }



        // Sobrecarga Implicita para double
        public static implicit operator double(Euro e)
        {
            return new Euro(e);

        }



        //Sobrecarga de operadores

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad() == p.GetCantidad();
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == d.GetCantidad();
        }


        // !=
        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.GetCantidad() != e2.GetCantidad();
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return e.GetCantidad() != p.GetCantidad();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return e.GetCantidad() != d.GetCantidad();
        }


        // +
        public static double operator +(Euro e, Peso p)
        {
            return e.GetCantidad() + p.GetCantidad();
        }
        public static double operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + d.GetCantidad();
        }


        // -
        public static double operator -(Euro e, Peso p)
        {
            return e.GetCantidad() - p.GetCantidad();
        }
        public static double operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - d.GetCantidad();
        }
    }
}