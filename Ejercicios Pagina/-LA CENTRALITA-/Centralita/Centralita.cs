using System.Data.Common;
using System.Text;

namespace CentralitA
{
    public class Centralita
    {
        public List<Llamada> listaDeLlamadas;
        protected string razonSocial;



        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();

        }
        public Centralita(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;

        }

        public float GanaciasPorLocal
        {
            get
            {
                return CalcularGanacia(ETipoLlamada.Local);
            }
        }

        public float GanaciasPorProvincia
        {
            get
            {

                return CalcularGanacia(ETipoLlamada.Provincial);
            }
        }

        public float GanaciasPorTotal
        {
            get
            {
                return CalcularGanacia(ETipoLlamada.Todas);
            }
        }


        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }


        private float CalcularGanacia(ETipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == ETipoLlamada.Local && llamada is Local)
                {
                    // Conversion explicita de llamada a local para poedr acceder al Costo de la llamada
                    ganancia += ((Local)llamada).CostoLlamada;
                }
                else if (tipo == ETipoLlamada.Provincial && llamada is Provincial)
                {
                    // Conversion explicita de llamada a provincial para poder acceder al Costro de la llamada
                    ganancia += ((Provincial)llamada).CostoLlamada;
                }
                else if (tipo == ETipoLlamada.Todas)
                {
                    if (llamada is Provincial)
                    {
                        ganancia += ((Provincial)llamada).CostoLlamada;
                    }
                    else
                    {
                        ganancia += ((Local)llamada).CostoLlamada;
                    }
                }
            }
            return ganancia;
        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }


        public override string ToString()
        {
            return Mostrar(); 
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("================");
            sb.AppendLine($"{this.razonSocial}");
            sb.AppendLine("================");
            sb.AppendLine($"Ganancia por provincia: {this.GanaciasPorProvincia}");
            sb.AppendLine($"Ganancia por local: {this.GanaciasPorLocal}");
            sb.AppendLine($"Ganancia total: {this.GanaciasPorTotal}");
            return sb.ToString();
        }


        public static bool operator ==(Centralita c, Llamada llamada)
        {

        }


    }

}