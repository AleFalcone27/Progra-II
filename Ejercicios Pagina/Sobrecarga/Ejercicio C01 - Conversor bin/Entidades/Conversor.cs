namespace Entidades
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroDecimal)
        {
            if (numeroDecimal == 0)
            {
                return "0"; // Si el número es 0 su binario tambien es 0
            }

            string binario = "";

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % 2; // Calcula el residuo de dividir por 2.
                binario = residuo.ToString() + binario; // Agrega el residuo al principio de la cadena.
                numeroDecimal /= 2; // Divide el número decimal por 2
            }

            return binario;
        }


        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numStr = numeroEntero.ToString();
            int acumDecimal = 0;

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
    }
}