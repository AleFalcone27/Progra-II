using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        double grados;

        public double Grados
        {
            get { return grados; }
        }


        public Kelvin(double num)
        {
            this.grados = num;
        }

    }
}