using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes
{
    internal class Osszegzes
    {
        public static void Main(string[] args)
        {
            Console.Write("Adja meg az elemek számát: ");
            int n;

            n = (int)inputValue();
            int[] tomb = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("\nAdja meg a tömb " + (i + 1) + ". elemét!");
                tomb[i] = (int)inputValue();
            }
            int osszeg;

            osszeg = 0;
            for (i = 0; i <= n - 1; i++)
            {
                osszeg = osszeg + tomb[i];
            }
            Console.WriteLine("\n\tAz elemek összege: " + osszeg);
            Console.ReadKey();
        }

        // .NET can only read single characters or entire lines from the
        // console. The following function safely reads a double value.
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}
