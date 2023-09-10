using System.Security.Cryptography.X509Certificates;

namespace Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}






/*
PARADIGMAS DE LA PROGRAMACIÓN{

Estilo de desarrollo del prorgama
Define la forma o metodologia con el que se resolveá un problema utilizando un lenguaje de programación


Paradgimas imperativos: Describien como se debe relizar una tarea (programacione structurada)
Paradigmas no imperativos Definir que se debe hacer, sin especificar de como hacerlo (programación funcional, programación declarativa)

El POO
- Propone resolver problemas a traves de identificar objetos de la vida rela
- Debemos empezar a modelar lo que podria hacer el programa en objetos, tambien debemos tener en cuenta la rekacion de colaboracion entre ellos
- Posiblemente compartan atributos y metodos

PILARES DE LA POO
- Abstracción:
    Consiste en seleccionar datos de un conjunto mas grande para trabajr solo en los detalles releventes de un objeto
    Al momento de programar debemos tener en cuenta que datos realmente nos interesan y cuales no 
    Ignoracia selectiva : Que es importante y que no es, para nuestra clase
    EJEMPLO: incirpciones a la materia de la facu
    CLASE PERSONA: Los metodos y atributos pueden variar mucho segundo el contexto



- Encapsulación:
    Caractersitica que denota la capacidad del metodo de responder sin exponer necesariamente de como lo hace
    Necesita el usuario poder acceder a los atributos y modificarlos (metodos privados y uno public que ejecute todos los demas)

- Herencia
    Una clase va a poder heredar sus atributos y metodos de otras , a esta la vamos a llamar padre
    Nos ayuda a ahorrarnos codigo

- Polymorphism
    Define la capacidad que mas de un objeto puedan crearse usando la clase base para lograr 2 objetos diferentes
    Capacidad de nuestras clases a  reacionar de manera diferente a un mensaje en tiempo de ejecucion:
    Un telefono (clase base)
        - Un telefono fijo
        - Smartphone
    La deficinición del método redive en la clase padre o base
    La impementación del método recide en la clase hija
}

CLASE {
    - Una clase es una descripción de un conjunto de objetos que comparten los mismos
        atributos, métodos, relaciones y semántica en un determinado contexto.
        atributos = variables
        metodos = funciones


    MODIFICADORES DE CLASE:
    por fececto: se crean en internal

    NOMBRE:
    Sustenativos y solo la primer letra en Mayuscula

    MODIFICADORES DE ACCESO DE CLASE:
    internal: Accesible dentro de su mismo ensamblado/proyecto
    public: Accesible desde cualquier parte del proyecto
    private: Accesibles solo dentro de la clase 

    METODOS:
    modificador de acceso - tipo de retorno - Identificador - parametros de entrada


    OBJETO: 
    - Son instancias de una clase
    - La clase es el molde y a partir de ella se crean objetos
    - Son clases instanciadas, tiene comportamientos (metodos) y un estado (atributos)
    
}
*/


//Biblioteca de clases
public class Animal
{
    public int cantidadDePatas;
    string nombre;
    DateTime fechaNacimeinto;
    string raza;
    bool hambre;

    //El constructor es un metodo especial sin retorno
    // Tenemos cointructores estaticos  y publicos
    public Animal(string nombre, DateTime fechaNacimeinto,string raza, bool hambre) { 
        this.nombre = nombre;
        this.raza = raza;
        this.fechaNacimeinto = fechaNacimeinto;
        this.hambre = hambre;
        
    } 

    //Los contructores estaticos se invocan por el CLR una unica vez con la primera interaccion con la clase
    //yo no no puedo llamar 
    static Animal()
    {
        cantidadDePatas  = 4;
        //No tiene modificador de visibilidad ni parametros
        //Solo permiten trabajar con atributos estaticos
    }
        
    
    //Setter
    public void SetRaza(string raza)
    {
        if (!String.IsNullOrWhiteSpace(raza))
        {
            this.raza = raza;
        }
    }


    public string Saludar()
    {
        return $"Hola, mi nombre es {this.nombre} y mi raza es {this.raza}";
    }

    public static void Alimentar(Animal animal)
    {
        Animal.hambre = true;
    }
}


Animal animal = new Animal("Alejo",DateTime.Now,"Pepe");   

Animal.Saludar();

Animal.Alimentar(animal);




/*
}

- CLASES Y METODOS ESTATICOS {
Decribir metodos de tipo utilidades o metodos que no tienene una relacion directa 
con el objeto
Dentro de una clse estatica tambien pueden existir constante estaitcas (Math.P)
}




 */