using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Camion : VehiculoTerrestre
    {
        int cantidadPasajeros;
        int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short CantidadMarchas, int pesoCarga, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas,color,CantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.pesoCarga = pesoCarga; 

        }
    }
}
