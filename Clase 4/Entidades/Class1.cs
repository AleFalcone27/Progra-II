using System.Text;

namespace Entidades
{
    /*
    SOBRECARGA DE METODOS
    public class Calculadora
    {

        public static int Sumar(int operadorUno, int operadorDos)
        {
            return operadorUno + operadorDos;
        }

        public static string Sumar(string operadorUno, string operadorDos)
        {
            int.TryParse(operadorUno, out int operadorUnoInt);
            int.TryParse(operadorDos, out int operadorDosInt);

            return operadorUno + operadorDos;
        }
    }
    */



    public class Persona
    {
    //    private string nombre;
    //    private string apellido;
    //    private int dni;
    //    private int edad;

        // Podemos instanciar nuestro objeto con 
        //public Persona(int dni)
        //{
        //    this.dni = dni;
        //}

    //    public Persona(int dni, string apellido)
    //        :this(dni)
    //    {
    //        this.apellido = apellido;

    //    }

    //    public Persona(int dni, string apellido, string nombre)
    //        : this(dni,apellido) // Nos permite ir a otro constructor dentro de nuestro ensamblado
    //    {
    //        this.nombre = nombre;
    //    }

    //    public string MostrarDatos()
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        //sb.AppendLine(this.dni);
    //        sb.AppendLine(this.nombre);
    //        sb.AppendLine(this.apellido);

    //        return sb.ToString();


        }

    //}

    class Persona1
    {

        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Persona1(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        //public static bool operator ==(Persona p1, Persona p2)
        //{

        //    return p1.dni == p2.dni;
        //}
        //public static bool operator !=(Persona p1, Persona p2)
        //{

        //    return !(p1.dni == p2.dni);
        //}

        public static implicit operator int (Persona1 p1)
        {
            return p1.edad;
        }

        public static explicit operator string (Persona1 p1)
        {
            return p1.nombre;
        }


    }


}
