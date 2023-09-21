using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        string nombre;
        int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.Nombre = value; }   
        }


        public static bool operator ==(Cliente c1, Cliente c2)
        { 
            return c1.numero == c2.numero ? true : false;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return c1.numero != c2.numero ? true : false;
        }

    }

}