using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        public enum EFranja { Franja_1 = 099, Franja_2 = 125, Franja_3 = 066 }

        protected EFranja franjaHoraria;


        public Provincial(EFranja franjaHoraria, Llamada llamada)
             : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen) 
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string nroOrigen, EFranja miFranja, float duracion, string destino)
            : base(duracion,destino,nroOrigen)
        {
            this.franjaHoraria = miFranja;
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
            return Duracion * (int)this.franjaHoraria;
        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo: {this.CostoLlamada:C2}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");
            sb.AppendLine($"========================");
            return sb.ToString();
        }


    }
}
