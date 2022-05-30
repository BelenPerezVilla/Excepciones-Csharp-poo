using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepcionejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];

            Random R = new Random();

            try
            {
                for (int x = 0; x < arreglo.Length; x++)
                {
                    arreglo[x] = R.Next(10, 99);
                }
                Array.Sort(arreglo);

                Console.WriteLine("\n\nARREGLO ORDENADO");
                for (int x = 0; x < arreglo.Length; x++)
                {
                    Console.Write("\t{0}.-{1}", x + 1, arreglo[x]);
                }
                Console.Write("\nprecione <enter> para continuar.....");
                Console.ReadKey();

                arreglo[15] = 12345;

            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("\n\nMensaje del Error: " + i.Message);
                Console.WriteLine("\nFRuta del Error> " + i.StackTrace);
                Console.Write("\nprecione <enter> para continuar.....");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("\nprecione <enter> para continuar.....");
                Console.ReadKey();
            }


         }
    }
}
