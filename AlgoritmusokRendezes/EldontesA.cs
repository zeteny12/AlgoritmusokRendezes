using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmusokRendezes
{
    internal class EldontesA
    {
        public static void Main(string[] args)
        {
            // Eldöntés "A"
            // Eldöntés az összes elem vizsgálatával
            Console.Write("Hány elemű legyen a tömb? Írd be: ");
            int n;

            n = (int)inputValue();
            int[] tomb = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("\nKérem a(z) " + (i + 1) + ". elemet:");
                tomb[i] = (int)inputValue();
            }
            int szam;

            Console.Write("\nEgy utolsót is: ");
            szam = (int)inputValue();
            int k;

            k = 0;
            for (i = 0; i <= n - 1; i++)
            {
                if (tomb[i] == szam)
                {
                    k = k + 1;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Nincs benne");
            }
            else
            {
                Console.WriteLine("Benne van");
            }

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
