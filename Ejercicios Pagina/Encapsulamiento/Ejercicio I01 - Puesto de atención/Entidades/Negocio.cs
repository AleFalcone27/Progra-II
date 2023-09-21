using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>(); 
        }

        public Negocio(string nombre): this() 
        {
            this.nombre = nombre;
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count;}
        }


        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }

            set 
            { 
                //Con el this accedemos directamente la intancia 
                if (!(this == value))
                {
                    bool res;
                    res = this + value;
                }
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            n.clientes.Enqueue(c);
            return true;
        }

        public static bool operator == (Negocio n, Cliente c)
        {
            foreach (var cliente in n.clientes)
            {
                return cliente.Equals(c);
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            foreach (var cliente in n.clientes)
            {
                return cliente.Equals(c);
            }
            return false;
        }


        public static bool operator ~(Negocio n)
        {
            if (n.caja.Atender(n.Cliente))
            {
                n.clientes.Dequeue();
                return true;
            }
            return false;
        }

    }
}
