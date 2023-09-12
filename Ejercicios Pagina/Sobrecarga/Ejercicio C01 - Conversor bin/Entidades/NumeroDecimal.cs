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

        public string ConvertirDecimalABinario(double numeroDecimal)
        {
            if (numeroDecimal == 0)
            {
                return "0"; // Si el número es 0 su binario tambien es 0
            }

            string binario = "";

            while (numeroDecimal > 0)
            {
                double residuo = numeroDecimal % 2; // Calcula el residuo de dividir por 2.
                binario = residuo.ToString() + binario; // Agrega el residuo al principio de la cadena.
                numeroDecimal /= 2; // Divide el número decimal por 2
            }

            return binario;
        }



        /*
        double + (NumeroDecimal, NumeroBinario)
        double - (NumeroDecimal, NumeroBinario)
        bool == (NumeroDecimal, NumeroBinario)
        bool != (NumeroDecimal, NumeroBinario)
        */



        //Puedo usar los constructores aca por algo son privados no?






    }
}
