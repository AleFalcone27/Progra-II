namespace Entidades
{
    public class Validacion
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"> dato a validar </param>
        /// <param name="min"> rango mínimo en el cual debe estar la variable valor </param>
        /// <param name="max"> rango máximo en el cual debe estar la variable valor </param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            else return false; 
        }
        public static int GetMin(int num,int min)
        {
            if (num < min)
            {
                return num;
            }
            else return min;
            
        }
        public static int GetMax(int num, int max) {
        
            if (num > max)
            {
                return num;
            }
            else return max;
        }

    }
}