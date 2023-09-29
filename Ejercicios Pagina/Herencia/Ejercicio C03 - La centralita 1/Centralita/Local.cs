using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {

        protected float costo;

        public Local(Llamada llamada,float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                //Hay que ahacer una operacion aca
                return CalcularCosto();
            }
        }
        

        private float CalcularCosto()
        {
            return float.NaN;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"{this.costo}");
            return sb.ToString();

        }




    }
}
