using System.ComponentModel;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita(List<Llamada> listaDeLlamadas, string razonSocial)

        {
            this.listaDeLlamadas = listaDeLlamadas;
            this.razonSocial = razonSocial;
        }
    


        float GanaciasPorLocal
        {
            get
            {
                return float.NaN;
            }
        }

        float GanaciasPorProvincia 
        {
            get
            {
                return float.NaN;
            }
        }

        float GanaciasPorTotal
        {
            get
            {
                return float.NaN;
            }
        }


        List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        
        private float CalcularGanacia(ETipoLlamada tipo)
        {
            //Switch
            return float.NaN;
        }


    }
}