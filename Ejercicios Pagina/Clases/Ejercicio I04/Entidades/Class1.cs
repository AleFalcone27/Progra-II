using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMAxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }


        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        //Tengo el atributo tinta y el parametro tinta, por eso le puse tintaInput
        private void SetTinta(short tintaInput)
        {
            if (tintaInput > 0)
            {
                //Si es positivo
                if (this.tinta + tintaInput<= cantidadTintaMAxima)
                {

                    this.tinta += tintaInput;
                }
            }
            else
            {
                if ((tinta - tintaInput) >= 0)
                {
                    this.tinta = tintaInput;
                }
            }
        }

        public void Recargar(short tintaInput)
        {
            this.SetTinta(100);
        }


        public void Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            //No estoy seguro de que este if sea necesario 
            if (gasto > 0)
            {
                SetTinta();

                StringBuilder sb = new StringBuilder();
                while (gasto <= tinta)
                {
                    sb.Append("*");
                    this.tinta--;
                    dibujo = sb.ToString();
                }
            }

        }

    }

}
