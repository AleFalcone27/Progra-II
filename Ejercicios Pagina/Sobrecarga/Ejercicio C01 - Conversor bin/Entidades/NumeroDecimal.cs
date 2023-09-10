using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class NumeroDecimal
    {
        double numero;

        private NumeroDecimal(double num) 
        {
            this.numero = num;
        }

        /*
        double + (NumeroDecimal, NumeroBinario)
        double - (NumeroDecimal, NumeroBinario)
        bool == (NumeroDecimal, NumeroBinario)
        bool != (NumeroDecimal, NumeroBinario)
        */



        //Puedo usar los constructores aca por algo son privados no?

        public static double operator +(NumeroDecimal numDec, NumeroBinario numBin)
        {
            return numDec + numBin;
        }


    }
}
