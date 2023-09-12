using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        Producto[] productos;
        int capacidad;
        int ubicacionEstante;

        // Constructor

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }


        // Getter
        public Producto[] GetPrductos()
        {
            return productos;
        }

        // Metodos
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var producto in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }

        // Sobrecarga de operadores

        /// <summary>
        /// Verificamos si un producto (p) se encuentra en el estante (e)
        /// </summary>
        /// <param name="e">Estante</param>
        /// <param name="p">Product</param>
        /// <returns>true si se encuentra, de lo contrario false</returns>
        public static bool operator ==(Producto p, Estante e)
        {

            foreach (var producto in e.productos)
            {
                if (p == producto)
                {
                    return true;
                }

            }
            return false;

        }

        public static bool operator !=(Producto p, Estante e)
        {

            foreach (var producto in e.productos)
            {
                if (p != producto)
                {
                    return false;
                }

            }
            return true;

        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if (producto != estante)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i].GetType() == null) // Si no inicializamos el objeto Producto es un null
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Array operator -(Estante estante, Producto producto)
        {
            if (producto == estante)
            {
                int indiceAEliminar = Array.IndexOf(estante.productos, producto);

                if (indiceAEliminar >= 0)
                {
                    // Crea un nuevo arreglo sin el elemento a eliminar
                    Producto[] nuevoArreglo = new Producto[estante.productos.Length - 1];
                    for (int i = 0, j = 0; i < estante.productos.Length; i++)
                    {
                        if (i != indiceAEliminar)
                        {
                            nuevoArreglo[j] = estante.productos[i];
                            j++;
                        }
                    }

                    // Asigna el nuevo arreglo al arreglo original
                    estante.productos = nuevoArreglo;
                }
                
            }
            return estante.productos;
        }

    }
}