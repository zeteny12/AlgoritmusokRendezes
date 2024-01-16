using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megszamolas
{
    internal class Megszamolas
    {
        public static void Main(string[] args)
        {
            // Megszámolás
            // 
            // Adott egy N elemű T számsorozat. Határozzuk meg az adott tulajdonsággal rendelkező elemek számát!
            // A végeredményt az 'szamlalo' tartalmazza.
            int szamlalo;

            szamlalo = 0;
            Console.WriteLine("Hány elemű legyen a tömb? Írd be: ");
            int n;

            n = (int)inputValue();
            int i;
            int[] t = new int[n];

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("\nKérem a(z) " + (i + 1) + ". elemet:");
                t[i] = (int)inputValue();
            }
            for (i = 0; i <= n - 1; i++)
            {
                if (t[i] < 0)
                {
                    szamlalo = szamlalo + 1;
                }
            }
            Console.WriteLine(szamlalo);
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
