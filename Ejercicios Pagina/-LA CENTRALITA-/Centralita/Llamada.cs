using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitA
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        // Para las propiedaes abstracteas debemos determinar si sera set o get o ambas 

        public abstract float CostoLlamada
        {
            get;
        }



        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"========================");
            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Número Destino: {this.nroDestino}");
            sb.AppendLine($"Número Origen: {this.nroOrigen}");
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            // desarrollar 
            return 1;
        }


        //public static bool operator ==(Llamada l1, Llamada l2)
        //{
        //    // Voy a tener que volver aca
        //    return true;
        //}



    }

    enum ETipoLlamada { Local, Provincial, Todas }

}
