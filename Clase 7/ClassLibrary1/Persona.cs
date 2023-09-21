using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class Persona
    {
        public enum ETipos { Alumno, Profesor, Admin, Usuario }
        private string nombre;
        private string apellido;
        private DateTime fechaNacimineto;
        private int dni;
        private string telefono;
        private ETipos tipo;

        public Persona(string nombre, string apellido, DateTime fechaNacimineto, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimineto = fechaNacimineto;
            this.dni = dni;
        }
        public string MostrarDatos()
        {
            return $"Mi nombre es {this.nombre}, {this.apellido}, Mi DNI es {this.dni}";
        }


        // Propiedades con metodos privados de validacion
        public int Dni
        {
            get { return this.dni; }

            private set
            {
                if (ValidarDni(value))
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = int.MinValue;
                }
            }
        }

        // Se puede tambier crear propiedades que generan calculos sin tenerla como atributos
        // es decir que no tengan ningun tipo de relacion con nuestros atributos, es productor de una operacion

        public int Edad
        {
            get
            {
                //return fechaDeNacimiento.year - DateTime.Now.Year
                return 0;
            }
        }



        // Como acceder a los numeros de los enum
        new ETipos p = (Persona.ETipos)1;



        private bool ValidarDni(int value)
        {
            // aca adentro hacemos nuestra logica para validarlo
            return true;
        }


        public string this[string value]
        {
            get
            {
                switch (value)
                {
                    case "nombre":
                        return this.nombre;
                    case "apellido":
                        return this.apellido;
                    default:
                        return "no valido";
                }
            }
        }





        /*
        DEFINICION:
        Consiste en agrupar los datos del objeto con los metodos que operan sobre estos.
        Nos permite ocultar los detalles de la implementacion y proteger el estado del objeto


        Exponemos solo lo que nosotros queremos exponer

        - No debemos trabajar con atributos ni metodos publicos hacia afuera
                getters y setters 
            - Solamente vamos a settear el dni al momento de crear el objeto : 
                hacemos que el atributo y su setter sean privados pero su getter publico 

        - Propiedades
            Miembro flexible se llaman miembros de acceso

        - Enumardos 
         Tipo de valor que define un conjunt de constantes con nombre 
            Se utiliza para darle semantica a la programacion

        - Indexadores
            Nos permiten acceder a la instancia de una clase a traves de un indice, como si fuera n array

        */


    }
}