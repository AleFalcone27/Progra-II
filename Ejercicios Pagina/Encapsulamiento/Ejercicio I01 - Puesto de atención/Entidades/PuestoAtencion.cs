using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public enum Puesto {Caja1,Caja2}

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get{ return PuestoAtencion.numeroActual++;  }
        }


        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2);
            return true;
        }






    }

}
