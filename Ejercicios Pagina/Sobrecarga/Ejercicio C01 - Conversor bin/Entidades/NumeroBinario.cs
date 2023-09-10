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


        /*
        string + (NumeroBinario, NumeroDecimal)
        string - (NumeroBinario, NumeroDecimal)
        bool == (NumeroBinario, NumeroDecimal)
        bool != (NumeroBinario, NumeroDecimal)
        */


        //Puedo usar los constructores aca 

        public static string operator +(NumeroBinario numBin, int numDec)
        {
            return numBin + int.Parse(Conversor.ConvertirDecimalABinario(numDec));
        }

    }
}
