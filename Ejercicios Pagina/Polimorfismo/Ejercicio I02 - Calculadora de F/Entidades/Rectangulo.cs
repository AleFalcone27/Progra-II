using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo : Figura
    {
        private double vase;
        private double altura;

        public Rectangulo(double vase, double altura)
        {
            this.vase = vase;
            this.altura = altura;
        }


        public override string Dibujar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dibujando Rectángulo...");
            return sb.ToString();
        }


        public override double CalcularPerimetro()
        {
            return (this.altura + this.vase) * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.vase * this.altura;
        }



        public virtual string Perimetro
        {
            get { return this.CalcularPerimetro().ToString("N2"); }
        }


        public virtual string Superficie
        {
            get { return this.CalcularSuperficie().ToString("N2"); }
        }


    }
}
