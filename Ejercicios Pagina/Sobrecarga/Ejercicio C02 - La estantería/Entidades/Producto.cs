using System.Data.Common;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        // Espacios
        private string codigoDeBarra;
        private string marca;
        private float precio;

        // Constructor
        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }


        // Getters
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        // Metodos
        public static string MostrarProducto(Producto p)
        {
            if (p.GetType() != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Marca : {p.marca}");
                sb.Append($"Precio: {p.precio}");
                sb.Append($"Codigo de barra: {(string)p}");
                return sb.ToString();
            }
            return "";
        }

        //Sobrecarga de operadores ed conversion
        public static explicit operator string(Producto p)
        {
    
         
                return p.codigoDeBarra;
    
        }

        // Sobrecarga de operadores de comparacion
        public static bool operator !=(Producto p,string marca)
        {
            bool res;
            res = (string)p!= marca ? false : true;
            return res;
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool res;
            res = (string)p == marca ? true : false;
            return res;
        }


        public static bool operator !=(Producto p1, Producto p2)
        {
            if ((string)p1 != (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                return false;
            }
            else return true;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                return true;
            }
            else return false;
        }


    }
}