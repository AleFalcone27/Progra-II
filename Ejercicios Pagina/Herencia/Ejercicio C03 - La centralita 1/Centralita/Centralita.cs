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
                return CalcularGanacia(ETipoLlamada.Local);
            }
        }

        float GanaciasPorProvincia 
        {
            get
            {

                return CalcularGanacia(ETipoLlamada.Provincial);
            }
        }

        float GanaciasPorTotal
        {
            get
            {
                return CalcularGanacia(ETipoLlamada.Todas);
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
            switch (tipo)
            {
                case ETipoLlamada.Local:
                    return 1;

                case ETipoLlamada.Provincial:
                    return 1;

                case ETipoLlamada.Todas:
                    return 1;

                default:
                    return 0;
            }

        }

    }
}