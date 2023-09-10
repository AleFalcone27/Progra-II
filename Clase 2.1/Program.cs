using System.Text;

namespace Clase_2._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string PlatoElegido;
            string BebidaElegida;

            int cantPlatos;
            int cantBebidas;


           // PlatoElegido = Validadora.ValidarIngreso("Ingresa un plato elegido, (Pizza,Hamburgeusa,Ensalada,)", "Pizza", "Hamburguesa", "Ensalada");
           // BebidaElegida = Validadora.ValidarIngreso("Ingresa un bebida elegido, (Refresco,Agua,Jugo,)", "Refresco", "Agua", "Jugo");

           // Console.WriteLine($"PLato: {PlatoElegido}");
           // Console.WriteLine($"Bebida: {BebidaElegida}");

        }
    }



    /*
    En c# no podemos tirar funciones sino que estas deben estar denttro de clases

    # Crear biblioteca de clases:
        - Click de la solucion agregar
        - Agregar nuevo proyecto
        - Blibioteca de clases

        Luego debemos vincular: 
        - Dependenecias en el archivo principal
        - Agregar referencia del proyecto
        - Elegimos el proyecto al cual queremos referenciar

    # Clases y metodos estaticos:
        - Dont repeat Yourself (no expresar lo mismo de 2 maneras diferentes)
        - No escribir instrucciones duplicadas
        - Keep it simple 

    # Modificador de acceso: 
    # Desde donde posiblemnte es accesible al codigo
    Por defecto se ponen en privado
    - Public : Es accesible de todos lados
    - Internal: Desde dentro el mismo ensamblado osea el archivo
    - Private: Solo se puede acceder desde la misma clase  



    public static double harmonic (int n){

    }

    # Clase de instancia vs clase statica
        - Una clase estatica solo va a poder tener metodos estaticos y atributos estaticos no vamos a poder instanciarla 
            y de las clases de instancias si 

    # Palabra reservada params 
        - Debe ser el ultimo parametro de la lista de parametro
        - params string[] args
        - ES RE UTIL ESTO!! 

        while (!args.Contains(Datoingresado)){

            Aca adentro iterar la lista de los parametros y hacer lo que nos pinte;

        }

    # Buenas practicas métodos
        - Nombres de metodos y funciones descriptivos, deben ser verbos PascalCase
        - Deben hacer solo una Cosa 
        - Tamaño reducido 


    # Dentro de las calses estaticas podemos tener contantes osea atributos estaticos:
        Es una constante:
            public inst const VALOR = 21.00
        Es una variable:
             public estatic int const = 32.00


    # Documnetación XML ponemos 3 barras arriba del metodo que creemos

    # NAMESPACE: Toma el nombre del nombre del proyecto
        - Declara un ambito que contiene clases relacionadas entre si 
        - Es una agrupacion logica de lcases y otros elementos 
        - La funcion principal es para ordenar el codigo
        - Podemos llegar a tener 

    # DIRECTIVAS
    # USING es como el import de python
    - Primero debemos referenciar con las dependencias al archivo y despues utilizamos el USING "nombre de nuestro archivo"
    - Entidades.ValidarDAtos
    - ValdiarDatos

    # ALIAS
    - Nos permite utilizar un nombre distinto de un namespace (no es muy recomendable)


    # STRINGS
    - Se almcaena como una cadena secuencial de char 
    - Los objetos de cadenas Son inmutables, es decir no pueden transformarse una vez creados
    - Ls podemos recorer con un foreach como si fueran un vector 
    - Cada vez que se realiza una operacion en una cadena se destruye y se crea una nueva en memoria 
    - HAY QUE TENER CUIDADO CON LA UTILIZACION DE CADENAS!!! puede afectar mucho el rendimiento de nuestro codigo
    - Cuando operamos MUUUCHO con strings combiene utilziar string builder
    - STRING BUILDER:  
            - StringBuilder sb = new StringBuilder("Hola Mundo");
            - sb.Appenline concatena con salto de linea
            - Append concatena sin largo de linea
            - Length Nos devulve el largo
        
  
    
        StringBuilder sb = new StringBuilder("Hola Mundo");
        sb.Appenline concatena con salto de linea
        Append concatena sin largo de linea
        Length Nos devulve el largo


    #MATH
    Clase estatica particular
    Math.PI() Devuelve el numero de pi
    Math.Round()
    Math.Pow()
    cosntantes Math.E() Devuelve la constante de euler


    #DateTime 
    La clase DateTime representa una fecha y hora 
    DateTime.Now
    DateTime.Year
    DateTime.Hour

  */

}