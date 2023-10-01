using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitA
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

        public override float CostoLlamada
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


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo Llamada: {this.CostoLlamada:C2}");
            sb.AppendLine($"========================");
            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
