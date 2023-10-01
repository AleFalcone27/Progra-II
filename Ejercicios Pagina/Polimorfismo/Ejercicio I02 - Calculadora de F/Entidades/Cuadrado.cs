using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cuadrado : Rectangulo
    {
        double altura;

        public override string Dibujar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dibujando Cuadrado...");
            return sb.ToString();
        }

        public Cuadrado(double altura, double vase)  : base(altura,vase)
        {
        }

        public override double CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }

        public override double CalcularSuperficie()
        {
            return base.CalcularSuperficie();
        }


        public override string Perimetro
        {
            get { return this.CalcularPerimetro().ToString("N2"); }
        }


        public override string Superficie
        {
            get { return this.CalcularSuperficie().ToString("N2"); }
        }

    }
}
