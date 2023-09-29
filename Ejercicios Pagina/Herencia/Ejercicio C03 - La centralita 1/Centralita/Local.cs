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

        public Local(string origen,float duracion,string destino,float costo)
            : base(duracion, destino ,origen)
        {
               this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        

        private float CalcularCosto()
        {
            return this.duracion * this.costo;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"{this.CostoLlamada}");
            return sb.ToString();
        }
    }
}
