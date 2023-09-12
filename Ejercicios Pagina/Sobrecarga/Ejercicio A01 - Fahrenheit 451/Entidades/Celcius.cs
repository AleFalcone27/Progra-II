namespace Entidades
{
    public class Celcius
    {
        double grados;

        public Celcius(double grados)
        {
            this.grados = grados;
        }

        public double KelvinACelcius()
        {

        }

        public static explicit operator Celcius(Kelvin k)
        {
            return new Celcius(k.Grados -32 * 5/9);
        }

    }

}




//F = C * (9/5) + 32

//C = (F-32) * 5/9

//F = K * 9/5 – 459.67

//K = (F + 459.67) * 5/9