using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


namespace Guia___Conceptos_basicos
{
    internal class Ejercicio_01
    {
        static void Main(string[] args)
        {

            static void EJ1()
            {
                Console.Title = "Ejercicio Nro 1";
                Console.WriteLine("Calculo el mínimo, máximo y el promedio de 5 números\n" +
                  "-----------------------");

                int cont;
                string numStr;
                int numInt;
                int max;
                int min;
                float promedio;
                int acum;
                bool flag;

                cont = 0;
                acum = 0;
                max = 0;
                min = 0;
                promedio = 0.0f;
                numInt = 0;

                flag = false;

                while (cont < 5)
                {
                    cont++;
                    Console.WriteLine($"Ingrese un número:");
                    numStr = Console.ReadLine();

                    //Casteamos el str leido por consola a entero
                    numInt = int.Parse(numStr);


                    if (flag == false)
                    {
                        min = numInt;
                        max = numInt;
                        flag = true;
                    }
                    else
                    {
                        if (numInt > max)
                        {
                            max = numInt;
                        }
                        if (numInt < min)
                        {
                            min = numInt;
                        }
                    }

                    acum = numInt + acum;

                }

                promedio = acum / cont;

                Console.WriteLine("-----------------------");
                Console.WriteLine($"El número mínimo ingresado fue {min}");
                Console.WriteLine($"El número máximo ingresado fue {max}");
                Console.WriteLine($"El promedio fue de {promedio}");
                Console.WriteLine("-----------------------");
            }

            EJ1();

        }
    }

    internal class Ejercicio_02
    {

        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            Console.WriteLine("Calculo potencias del número ingresado\n" +
                  "-----------------------");

            string numString;
            int num;
            bool result;

            numString = GetInput("Ingrese un número mayor a 0:");
            num = IsNumber(numString, "Error, vuelva a ingresar un número!!");
            result = IsGreaterThanZero(num);
            if (result)
            {
                Console.WriteLine("-----------------------");
                GetAndPrintPow(num, 2);
                GetAndPrintPow(num, 3);
                Console.WriteLine("-----------------------");
            }
            else
            {
                Console.WriteLine("El número ingresado no es mayor a 0");
                Main(args);
            }


        }

        /// <summary>
        /// Abre una consola, muestra un mensaje y toma un input
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Input del usuario</returns>
        public static string GetInput(string message)
        {
            string input;
            Console.Write(message);
            input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Intenta parsear un numero a entero e imprime en caso de error un mensaje por consola.
        /// </summary>
        /// <param name="numString">String a parsear</param>
        /// <param name="errorMessage">Mensaje de error, en caso de que no se pueda convertir</param>
        /// <returns>El entero convertido y en caso de error -1 </returns>
        public static int IsNumber(string numString, string errorMessage)
        {
            int numInt;

            if (int.TryParse(numString, out numInt))
            {
                return numInt;
            }
            else
            {
                Console.WriteLine(errorMessage);
                return -1;
            }
        }

        /// <summary>
        /// erifica si el número que recibe como parametro es mayor que cero.
        /// </summary>
        /// <param name="num">Entero</param>
        /// <returns>false si el número pasado como parametro no es mayor a 0, de lo contrario true</returns>
        public static bool IsGreaterThanZero(int num)
        {
            if (num <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Calcula la potencia de un número y la printea por consola 
        /// </summary>
        /// <param name="num">Base: número del cual queremos calcular la potencia</param>
        /// <param name="pow">Exponente: número de veces que se multiplica por la base</param>
        /// <returns></returns>
        public static int GetAndPrintPow(int num, int pow)
        {
            double result;

            result = Math.Pow(num, pow);

            Console.WriteLine($" {num} a la {pow} es {result}");

            return num;

        }


    }

    internal class Ejercicio_03
    {
        public static void Main(string[] args)
        {
            string numString;
            int num;

            Console.Title = "Ejercicio Nro 03";

            Console.WriteLine("Muestra todos los números primos hasta el ingresado\n" +
                  "-----------------------");

            numString = Ejercicio_02.GetInput("Ingresa un número:");

            Console.WriteLine("-----------------------");

            num = Ejercicio_02.IsNumber(numString, "Error! Ingrese un número");

            Iterator(num);

            Console.WriteLine("-----------------------");
        }


        /// <summary>
        /// Itera desde el 1 hasta el número que pasamos por parametro y le aplica a cada uno 
        /// la función isPrime().
        /// </summary>
        /// <param name="num"></param>
        public static void Iterator(int num)
        {

            for (int i = 0; i < num; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        /// <summary>
        /// Verifica si es un número primo o no -
        /// Los números primos son aquellos que SOLO son divisibles por ellos mismos y por uno.
        /// </summary>
        /// <param name="num"></param>
        /// <returns> true si el número es primo, de lo contrario falso </returns>
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num <= 3)
            {
                return true;
            }
            else if (num % 3 == 0 || num % 2 == 0)
            {
                return false;
            }
            else
            {
                //Esto no lo entiendo 
                for (int i = 5; i * i <= num; i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }

    }

    internal class Ejercicio_04
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            Console.WriteLine("Calculo números perfectos\n" +
                              "-----------------------");
            Iterator();
            Console.WriteLine("-----------------------");
            Console.WriteLine("El quinto es 33.550.336 lol");

        }

        /// <summary>
        /// Verifica si un número es perfecto o no - Los números 
        /// perfectos son aquellos iguales a la suma de sus divisores
        /// </summary>
        /// <param name="num"></param>
        /// <returns>true si es un número perfecto, de lo contrario falso</returns>
        public static bool IsPerfect(int num)
        {
            int divisorSum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    divisorSum += i;
                }
            }
            if (divisorSum == num)
            {
                return true;
            }
            else return false;

        }

        /// <summary>
        /// Itera por todos los números entre 1-10.000 incluidos y les pasa la funcion IsPerfect(),
        /// si el número es perfecto lo imprime 
        /// </summary>
        public static void Iterator()
        {
            for (int i = 1; i <= 10000; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i);
                }
            }

        }


    }

    internal class Ejercicio_05
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 05";
            Console.WriteLine("Calculo centro numerico\n" +
                              "-----------------------");
            double aumento = 1;
            double num;
            double i;
            double j;
            double sumaAtras;
            double sumaAdelante;

            Console.Write("Ingrese un número: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            while (aumento < num)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;


                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }

                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }


                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.WriteLine("-----------------------");
        }

    }

    internal class Ejercicio_06
    {
        public static void Main(string[] args)
        {
            string firstYearString;
            string secondYearString;
            int firstYearInt;
            int secondYearInt;

            Console.Title = "Ejercicio Nro 06";
            Console.WriteLine("Calculo cuantos años biciestos\n" +
                "-----------------------");

            firstYearString = Ejercicio_02.GetInput("Ingrese el primer año");
            secondYearString = Ejercicio_02.GetInput("Ignrese el segundo año");

            firstYearInt = Ejercicio_02.IsNumber(firstYearString, "Error");
            secondYearInt = Ejercicio_02.IsNumber(secondYearString, "Error");

            Console.WriteLine("-----------------------");
            Iterator(firstYearInt, secondYearInt);
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Itera sobre el rango de nuestros numeros que representan años, recibidos por parametros
        /// </summary>
        /// <param name="firstYear">int de 4 dígitos</param>
        /// <param name="secondYear">int de 4 dígitos</param>
        public static void Iterator(int firstYear, int secondYear)
        {
            Console.WriteLine(firstYear);
            for (int i = firstYear; i <= secondYear; i++)
            {

                if (IsLeapYear(i))
                {
                    Console.WriteLine(i);
                }

            }

        }

        /// <summary>
        /// Verifica si un año es biciesto o no 
        /// </summary>
        /// <param name="year">int de 4 numeros</param>
        /// <returns>true si el año es biciesto,de lo contrario false </returns>
        public static bool IsLeapYear(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                return true;
            }
            return false;
        }



    }

    internal class Ejercicio_07
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            string input;

            Console.WriteLine("Calculo la cantidad de dias vividos \n" + "-----------------------");
            input = Ejercicio_02.GetInput("Escribí tu fecha de nacimiento con el siguiente formato (año,mes,dia) ####,##,## .");
            Console.WriteLine("-----------------------");

            // Nos aseguramos de que el input tenga 10 caracteres de longitud
            if (CheckFormat(input))
            {
                // Convertimos el input en un objeto DateTime
                DateTime inputDate = DateTime.Parse(input);

                int LeapYearCount = Iterator(inputDate.Year);

                int dayCount = GetDayDiff(input);

                Messages(LeapYearCount, dayCount);

            }
            else Main(args);

        }

        /// <summary>
        /// Validamos que el string que recibe por parametros tenga una longitud de 10
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Verdadero si su longitud es de 10, de lo contrario falso</returns>
        public static bool CheckFormat(string input)
        {
            if (input.Length == 10)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Itera sobre el rango de años que existe entre el año ingresado por el usuario y el año actual y 
        /// verifica si existen años biciestos en el medio, para poder hacer la suma de dias mas exacta. Si encuentra un año biciesto se suma 1 dia 
        /// </summary>
        /// <param name="inputYear"></param>
        /// <returns> entero de 4 digitos que representa un año</returns>
        public static int Iterator(int inputYear)
        {
            int currentYearInt;
            int LeapYearCount;

            LeapYearCount = 0;

            currentYearInt = DateTime.Now.Year;


            for (int i = inputYear; i < currentYearInt; i++)
            {
                if (Ejercicio_06.IsLeapYear(i))
                {
                    LeapYearCount++;

                }
            }

            return LeapYearCount;
        }

        /// <summary>
        /// Se encarga de realizar todas las cuentas para calcular la cantidad de dias que pasaron entre el año ingresado por el usuario
        /// y el año actual 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Entero que representa la diferencia de días entre ambos años</returns>
        public static int GetDayDiff(string input)
        {
            DateTime inputDate = DateTime.Parse(input);

            DateTime InputDateTicks = new DateTime(inputDate.Ticks);

            TimeSpan dif = DateTime.Now - InputDateTicks;

            int daysDiff = dif.Days;

            return daysDiff;

        }

        /// <summary>
        /// Printea por consola varios mensajes indicando el final y de la ejecución de nuestra aplicación 
        /// </summary>
        /// <param name="LeapYearCount">Cantidad de añ{os biciestos que vivió la persona</param>
        /// <param name="dayCount">Cantida de días que vivió la persona</param>
        public static void Messages(int LeapYearCount, int dayCount)
        {
            int totalDays;

            totalDays = LeapYearCount + dayCount;

            Console.WriteLine($"Llevas {totalDays} días vividos");
            Console.WriteLine($"Viviste {LeapYearCount} años bicisestos");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" - Si sos hombre te quedan un aproximado de " + (26645 - totalDays) + " días de vida y " + ((26645 - totalDays) / 7) + " semanas.\n" +
                " - Si sos mujer te quedan un aproximado de " + (29200 - totalDays) + " días de vida y " + ((29200 - totalDays) / 7) + " semanas.");

        }


    }

    internal class Ejercicio_08
    {

        public static void GetData(out string name, out string ratePerHour, out string antiquity, out string totalHours) {

            name = Ejercicio_02.GetInput("Nombre: ");
            ratePerHour = Ejercicio_02.GetInput("Precio por hora: ");
            antiquity = Ejercicio_02.GetInput("Antiguedad en años: ");
            totalHours = Ejercicio_02.GetInput("Cantidad de horas trabajadas: ");

        }


        public static double GetSalary(string ratePerHour, string totalHours) {

            double ratePerHourInt;
            double totalHoursInt;

            if (double.TryParse(ratePerHour, out ratePerHourInt) && double.TryParse(totalHours, out totalHoursInt))
            {
                double netSalary = ratePerHourInt * totalHoursInt;
                return netSalary;
            }
            else return -1;

        }


        public static double GetAntiquity(string antiquity, int antiquityRate)
        {
            double antiquityInt = double.Parse(antiquity);
            return antiquityInt * antiquityRate;

        }


        public static void nicePrint(string message, int width)
        {


            Console.Write("|");
            Console.Write(message);

            for (int i = width; i > message.Length; i--)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }



        public static void GetPayCheck(string name, string ratePerHour, string antiquity, string totalHours, double netSalary, double discount, double GrossSalary)
        {
            // ESTO LO HAGO MAÑANA PARA QUE QUEDE BIEN FACHERO 
            // LIMPIAR LA CONSOLA Y HACER EL RECIBO (A CHEKEAR LO DE LIMPIAR PQ PIERDO EN ANTERIOR)
            // hACERLO FACHERO AL RECBIO

            ;

            Console.WriteLine("-------------------------------------");
            nicePrint($"RECIBO DE SUELDO DE {name.ToUpper()}", 35);
            Console.WriteLine("-------------------------------------");

            nicePrint($"Precio por hora: {int.Parse(ratePerHour):C}", 35);
            nicePrint($"Cant horas trabajadas: {totalHours}", 35);
            nicePrint($"Antiguedad: {antiquity}", 35);
            nicePrint($"Salario burto: {GrossSalary:C}", 35);
            nicePrint($"Descuento: {discount:C}", 35);
            nicePrint($"Salario neto {netSalary:C}", 35);
            Console.WriteLine("-------------------------------------");
        }

        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";

            string name;
            string ratePerHour;
            string antiquity;
            string totalHours;

            string addWorker;

            double salary;
            double netSalary;
            double discount;
            double GrossSalary;

            Console.WriteLine("Calculadora de sueldo");
            Console.WriteLine("-------------------------------");

            addWorker = "SI";

            while (addWorker == "SI") {

                GetData(out name, out ratePerHour, out antiquity, out totalHours);

                salary = GetSalary(ratePerHour, totalHours);

                if (salary != -1)
                {
                    // Bono por antiguedad
                    double antiquityBonus = GetAntiquity(antiquity, 150);

                    // Sumamos el bono por antiguedad al salario
                    GrossSalary = salary + antiquityBonus;

                    // Obtenemos el descuento
                    discount = GrossSalary * 0.13;

                    // Obtenemos el salario 
                    netSalary = GrossSalary - discount;

                    GetPayCheck(name, ratePerHour, antiquity, totalHours, netSalary, discount, GrossSalary);

                    addWorker = Ejercicio_02.GetInput("¿ Deseá calcular el sueldo de otro trabajdor ? (SI-NO): ");
                    addWorker = addWorker.ToUpper();
                }
                else
                {
                    Console.WriteLine("ERROR ingresá los valores en números");
                    GetData(out name, out ratePerHour, out antiquity, out totalHours);
                }

            }
            Console.WriteLine("GRACIAS POR USAR NUESTRA APP!");
        }
    }

    internal class Ejercicio_09
    {
        public static void BuildHalfPyramid(int numInt){

            string str;

            for (int i = 0; i < numInt; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }



        static void Main(string[] args)
        {
            string numString;
            int numInt;

            Console.Title = "Ejerciocio Nro 09";

            Console.WriteLine("Imprimo piramides por la mitad");
            Console.WriteLine("-------------------------------");

            numString= Ejercicio_02.GetInput("Ingrese un entero: ");
            if (int.TryParse(numString, out numInt)) {

                Console.WriteLine("Es num");

                BuildHalfPyramid(numInt);
            }
            else
            {
                Console.Clear();
                Main(args);
            }
        }

    }

    internal class Ejercicio_10
    {

        public static void BuildFullPyramid(double numDouble)
        {

            double peak;

            peak = numDouble / 2;

            peak = Math.Ceiling(peak);

            Console.WriteLine(peak);

            int cont = 0;

            for (int i = 1; i <= numDouble; i++)
            {
                // Imprimir espacios en blanco a la izquierda para centrar los asteriscos
                for (int j = 1; j <= numDouble - i; j++)
                {
                    Console.Write(" ");
                }

                // Imprimir asteriscos
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Cambiar de línea para la siguiente fila
            }

            Console.ReadLine(); // Esperar a que el usuario presione Enter
        }

        



        static void Main(string[] args)
        {
            
            string numString;
            double numDouble;

            Console.Title = "Ejerciocio Nro 10";

            Console.WriteLine("Imprimo piramides");
            Console.WriteLine("-------------------------------");

            numString = Ejercicio_02.GetInput("Ingrese un entero: ");
            if (double.TryParse(numString, out numDouble))
            {

                Console.WriteLine("Es num");

                BuildFullPyramid(numDouble);
            }
            else
            {
                Console.Clear();
                Main(args);
            }

        }
    }
}




