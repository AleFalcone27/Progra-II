using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Clase_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // MATRICES UNIDIMENSIONALES

            int[] edades = { 5 ,8 ,14 ,2, 53};
            //Ambas son validas
            //int[] edades = new int[5] { 5 ,8 ,14 ,2, 53};

            //Console.WriteLine(edades[0]);
            edades[0] = 12;

            //Console.WriteLine(edades);


            //MATRICES MULTIDIMENSIONALES
            const int filas = 3;
            const int columnas = 2;
            // Son 3 filas de 2 valores cada una
            string[,] enteros = new string[filas, columnas]{{"Lucas","Ferrini"},
                                                         {"Ale", "Bongioanni"},
                                                         {"Pepe", "Falcone"}};

            //Console.WriteLine(enteros[1,1]);  

            //using System.Collections.Generic; 

            // Listas
            // son objetos y las vamaos a tener que instanciar

            List<int> listaNumeros = new List<int>(); 
            //Apend
            listaNumeros.Add(1);
            //Insertamos un elemento 
            listaNumeros.Insert(0,3);
            // Elimina un elemento
            listaNumeros.Remove(3);
            // Elimina el enlemento en un indice
            // Agregammos al final de la lisa
            listaNumeros.Add(3);

           
            foreach (int i in listaNumeros)
            {
                //Console.WriteLine(i);
               // Console.WriteLine(listaNumeros.Count);

            }

            // Diccionarios
            // Las clvaes son unicas 
            Dictionary<string,string> diccionario = new Dictionary<string,string>();
            // El diccionario tiene objetos de este tipo KeyValuePair

            diccionario.Add("Alejo", "Falcone1");
            diccionario.Add("1", "Falcone2");

            //Esta bueno el try add
            diccionario.TryAdd("Alejo","Falcone");

            foreach ( KeyValuePair<string,string> i in diccionario)
            {
               // Console.WriteLine(i.Key);
            }
            // Tenemos casi los mismos  metodos que en las listas

            //Colas
            // FIFO - First in, first out
            Queue<int> colaEnteros = new Queue<int>();

            colaEnteros.Enqueue(1);
            colaEnteros.Enqueue(2);
            colaEnteros.Enqueue(3);
            // Agrega cosas a la cola
            colaEnteros.Enqueue(4);

            //Elimina y deveulve el primer valor de la cola
            colaEnteros.Dequeue();

            //Nos deveulve el siguiente en salir 
            //Console.WriteLine(colaEnteros.Peek());

            foreach (int q in colaEnteros)
            {
               // Console.WriteLine(q);
            }

            // Pilas o stack
            // Lifo - Last in, first out
            Stack<int> stack = new Stack<int>();   
            
            //Agragmos a la pila
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //Nos retonrna el ultimo item y lo elimina de la pila
            stack.Pop();

            // Nos devuelve el ultimo item
            stack.Peek();

            foreach (int s in stack)
            {
                Console.WriteLine(s);
            }


        }
    }
}



/*
COLECCIONES

Matrices
Tamaño fijo

int[] edades = new int[5] { 5 ,8 ,14 ,2, 53};

edades[0] = 3;

*/