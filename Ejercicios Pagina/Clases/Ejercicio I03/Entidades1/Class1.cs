using System.Text;

namespace Entidades1
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        static Estudiante()
        {

            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string name, string legajo)
        {
            this.apellido = apellido;
            this.nombre = name;
            this.legajo = legajo;
        }



        private float CalcularPromedio(){

            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            }

           
        public double CalcularNotafinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return Estudiante.random.Next(6, 11);
            }
            else return -1;
        }


        public string Mostrar()
        {
            double notaFinal = CalcularNotafinal();

            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota 1re parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nora 2do parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Nota final : {CalcularPromedio()}");
            if (notaFinal > 0)
            {
                sb.AppendLine("Alumno desaprobado");
            }
            else
            { 
                sb.AppendLine($"Nora final {notaFinal}"); 
            }
            return sb.ToString();
        }


        public void setterNotaPrimerParcial(int nota)
        {
            if (nota >0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }

        }


        public void setterNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }

        }
    }

}
        
        