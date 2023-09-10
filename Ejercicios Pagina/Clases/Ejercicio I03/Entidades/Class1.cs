using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string fechaDeNacimiento;
        private long dni;

        public Persona(string nombre, string fechaDeNacimiento, long dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        // Nombre.
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nombre);
            return sb.ToString();

        }

        // Fecha de nacimiento.
        public void SetFechaDeNacimiento(string fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        // Geteo un DateTime porque setteo 
        public string GetFechaDeNacimiento()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.fechaDeNacimiento);
            return sb.ToString();
        }

        // DNI.

        public void SetDni(long dni)
        {
            this.dni = dni;
        }

        public string GetDni()
        {
            StringBuilder stringBuilder  = new StringBuilder();
            stringBuilder.Append(dni);  
            return stringBuilder.ToString();
        }


        private int CalcularEdad()
        {
            string fechaDeNacimientoString;
            DateTime añoDeNacimientoDateTime;
            int edad;

            fechaDeNacimientoString = this.GetFechaDeNacimiento();
            DateTime.TryParse(fechaDeNacimientoString, out añoDeNacimientoDateTime);

            //añoDeNacimientoDateTime = DateTime.Parse(fechaDeNacimientoString);
            edad = (DateTime.Now.Year) - añoDeNacimientoDateTime.Year;
 
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaDeNacimiento} ");
            sb.AppendLine($"Edad: {this.CalcularEdad()} ");
            sb.AppendLine($"DNI: {this.dni} ");
            sb.AppendLine(EsMayorDeEdad());
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            StringBuilder sb = new StringBuilder();

            if (CalcularEdad() >= 18)
            {
                sb.AppendLine("Es mayor de edad");
            }
            else sb.AppendLine("es menor");

            return sb.ToString();
        }

    }
}