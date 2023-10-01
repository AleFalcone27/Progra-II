using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Circulo : Figura
    {

        private double radio;

        public Circulo(double radio) 
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dibujando Círculo...");
            return sb.ToString();
        }

        public override double CalcularPerimetro()
        {
            return (this.radio * 2) * Math.PI;
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(2 , this.radio * Math.PI);
        }

        public string Perimetro
        {
            get { return this.CalcularPerimetro().ToString("N2"); }
        }


        public string Superficie
        {
            get { return this.CalcularSuperficie().ToString("N2"); }
        }

    }
}
