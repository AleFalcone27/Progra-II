using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        //Propiedades Set y Get
        public Numeracion PrimerOperando
        { 
            get 
            { 
                return this.primerOperando; 
            } 
            set
            {
                this.primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }

        // Metodos

        //public Numeracion Operar(char operador)
        //{
        //    //Switch que deterimna la operacion a relizar por defecto se realiza una suma

        //    switch (operador)
        //    {
                
                    

        //    }

        //}

    }
}

