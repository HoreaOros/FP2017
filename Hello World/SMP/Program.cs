using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP
{
    class Program
    {
        static void Main(string[] args)
        {
            // S1 = 1*2+2*3+3*4+..+n*(n+1)
            Console.WriteLine("Introduceti un numar natural nenul: ");
            string line;
            line = Console.ReadLine();
            int n;

            n = int.Parse(line);

            S1(n);



            // S2 = 1*2-2*3+3*4-.. +/- n*(n+1)
            S2(n);


            // * 
            // **
            // ***
            // ****
            S3(n); 

        }

        private static void S3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void S2(int n)
        {
            int suma = 0;


            int k = 1;

            while (k <= n)
            {
                if (k % 2 == 1)
                {
                    suma = suma + k * (k + 1);
                }
                else
                {
                    suma = suma - k * (k + 1);
                }
                k++;

                // suma = suma + k * (k + 1) * ((k % 2 == 1) ? 1 : -1);
                // (cond)?(exp1):(exp2)
            }
            Console.WriteLine("Suma este: {0}", suma);
        }

        private static void S1(int n)
        {
            int suma = 0;


            int k = 1;

            while (k <= n)
            {
                suma = suma + k * (k + 1);
                k++;
            }
            Console.WriteLine("Suma este: {0}", suma);
        }
    }
}
