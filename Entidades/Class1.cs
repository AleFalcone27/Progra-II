namespace Entidades
{
    public class Validadora
    {
 
            /// <summary>
            /// Valida el ingreso del usuario en base a una lista de argumentos
            /// </summary>
            /// <param name="mensaje"> Mesaje que le sale al usuario </param>
            /// <param name="argumentos"> Lista de argumentos </param>
            /// <returns> El ingreso validado</returns>
            public static string ValidarIngreso(string mensaje, params string[] argumentos)
            {

                Console.WriteLine(mensaje);

                string datoIngresado = Console.ReadLine();

                //while (datoIngresado != pArg && datoIngresado != sArg && datoIngresado != tArg)
                //{
                //    Console.WriteLine($"ERROR re {mensaje}");
                //    datoIngresado = Console.ReadLine();
                //}

                return datoIngresado;
            }

    }

