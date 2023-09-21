using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ 
    public class Operacion
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
        public Numeracion Operar(char operador)
        {
            // Utulizamos la sobrecarga del == para verificar si los sistemas son iguales para poder operar
            if (primerOperando == segundoOperando)
            {
                switch (operador)
                {
                    case '/':
                        return new Numeracion((this.primerOperando / this.segundoOperando), ESistema.Decimal);
                    case '*':
                        return new Numeracion((this.primerOperando * this.segundoOperando), ESistema.Decimal);
                    case '-':
                        return new Numeracion((this.primerOperando - this.segundoOperando), ESistema.Decimal);
                    default:
                        return new Numeracion((this.primerOperando + this.segundoOperando), ESistema.Decimal);
                }
            }
            else return new Numeracion(double.MinValue, ESistema.Decimal);
        }
    }
}

