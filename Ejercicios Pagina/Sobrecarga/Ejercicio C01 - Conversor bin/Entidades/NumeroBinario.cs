using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class NumeroBinario
    {
        string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }


        public string Numero
        {
            get { return this.numero; }
        }


        public double ConvertirBinarioADecimal(double numeroEntero)
        {
            string numStr = numeroEntero.ToString();
            double acumDecimal = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                // Verificamos que el caracter sea 0 o 1
                if (numStr[i] == '0' || numStr[i] == '1')
                {
                    // Guardamos el caracter
                    int bit = int.Parse(numStr[i].ToString());
                    // Calculamos la posicion del bit y le restamos uno porque debemos arrancar desde 0
                    int posicion = numStr.Length - i - 1;
                    // multiplicamos el bit por 2 y lo elevamos a su posicion dentro del numero
                    acumDecimal += bit * (int)Math.Pow(2, posicion);
                }
                else continue;

            }
            return acumDecimal;
        }


        // Sobrecarga operador de conversion

        public static explicit operator NumeroBinario (string numero)
        {
            return new NumeroBinario(numero);
        }


        /*
        string + (NumeroBinario, NumeroDecimal)
        string - (NumeroBinario, NumeroDecimal)
        bool == (NumeroBinario, NumeroDecimal)
        bool != (NumeroBinario, NumeroDecimal)
        */


        //public static string operator +(NumeroBinario numBin, NumeroDecimal numDec)
        //{
        

        //}




    }
}
