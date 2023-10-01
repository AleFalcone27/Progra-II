using System.Text;

namespace Entidades
{
    public abstract class Figura
    { 

        public virtual string Dibujar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dibujando forma...");
            return sb.ToString();
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}