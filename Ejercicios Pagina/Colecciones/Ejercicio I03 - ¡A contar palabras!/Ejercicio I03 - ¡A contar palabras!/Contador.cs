using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ejercicio_I03____A_contar_palabras_
{

    public class Contador
    {
        public string str;

        public Contador (string str)
        {
            this.str = str;
        }


        public static Dictionary<string,int> getPalabras(string palabras)
        {
            // Spliteamos el str pasado por parametros en los espacios y lowereamos todas las palabras
            string[] arrayPlabras = palabras.ToLower().Split(' '); 

            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (var palabra in arrayPlabras)
            {

                // Validamos que no sea un str vacio
                if (!string.IsNullOrEmpty(palabra))
                {
                    if (diccionario.ContainsKey(palabra) == false)
                    {
                        diccionario.Add(palabra, 1);
                    }
                    else
                    {
                        diccionario[palabra]++;
                    }
                }
            }
            return diccionario;
        }



    }





}
