﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborekos
{
    internal class BuborekosRendezes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kérem az elemek számát");
            int n;

            n = (int)inputValue();
            int[] t = new int[n];
            int i;

            for (i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("Kérem a " + (i + 1) + ". elemet: ");
                t[i] = (int)inputValue();
            }
            Console.WriteLine("Rendezetlen adatok:");
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
            }
            int k;

            for (k = 0; k <= n - 2; k++)
            {
                for (i = 0; i <= n - 2 - k; i++)
                {
                    if (t[i] > t[i + 1])
                    {
                        int tmp;

                        tmp = t[i];
                        t[i] = t[i + 1];
                        t[i + 1] = tmp;
                    }
                }
            }
            Console.WriteLine("\nRendezett adatok:");
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
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
