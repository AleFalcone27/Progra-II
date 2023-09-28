using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VehiculoTerrestre
    {
        Colores color;
        short cantidadRuedas;
        short cantidadPuertas;
        short cantidadMarchas;
        int cantidadPasajeros;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"------------------");
            sb.AppendLine($" Color: {this.color}");
            sb.AppendLine($" Cantidad de Ruedas: {this.cantidadRuedas}");
            sb.AppendLine($" Cantidad de Puertas: {this.cantidadPuertas}");
            sb.AppendLine($" Cantidad de Marchas: {this.cantidadMarchas}");
            sb.AppendLine($" Cantidad de Pasajeros: {this.cantidadPasajeros}");
            sb.AppendLine($"------------------");
        }
    }
}
