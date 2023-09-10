using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El titular es {this.titular} y el dinero en cuenta {this.cantidad}");
            return sb.ToString();
        }

        public void ingresar (double suma) {

            if (suma > 0)
            {
                this.cantidad += suma;
            }
        }

        public void retirar(double suma)
        {

            this.cantidad = this.cantidad - suma;
        }
    }
}