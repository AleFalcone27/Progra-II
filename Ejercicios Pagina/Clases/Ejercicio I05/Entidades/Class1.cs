using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Geometria
{
    public class Punto
    {

        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

    }

    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto Vertice1;
        private Punto Vertice2;
        private Punto Vertice3;
        private Punto Vertice4;

        public Rectangulo(Punto vertice1,Punto vertice3)
        {
            Vertice1 = vertice1;
            Vertice3 = vertice3;
            Vertice2 = (new Punto(vertice1.getX() * vertice3.getX() / 2, vertice1.getY() * 2 )); //No puedo sacar esta cuenta
     
        }

        public int GetVertice2()
        {
            return Vertice2.getY(); 
        }

        public float Area()
        {
            
            return GetArea();
        }

        public float Perimetro()
        {
            return perimetro;
        }

        private float GetArea()
        {
            
           return (Vertice1.getX() * Vertice3.getY());
        }

        private float GetPerimetro()
        {
            return (Vertice1.getY() * Vertice3.getX()) / 2;
        }
    }

}

