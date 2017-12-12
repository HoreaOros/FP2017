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



            //  // S2 = 1*2-2*3+3*4-.. +/- n*(n+1)
            S2(n);


            //  // * 
            //  // **
            //  // ***
            //  // ****
            S3(n);

            //  // S = 1 + 2*3 + 3*4*5 + 4*5*6*7 + 5*6*7*8*9 + ... + n*(n+1)*....*(2n-1)
            S4(n);

            S4_2(n);
            //  // i * (i + 1) * .... * (2i-1)
            //  // (i+1)*(i+2) *....(2i-1)*(2i)*(2i+1)


            //  //1
            //  //2 3
            //  //3 4 5
            //  //4 5 6 7
            //  //...
            S5(n);


            //  // ******
            //  // **  **
            //  // *    *
            //  // *    *
            //  // **  **
            //  // ******
            //  S6(6);

            //  // *****
            //  // ** **
            //  // *   *
            //  // ** **
            //  // *****
            //  S6(5);
            //  int a = int.Parse(Console.ReadLine());
            S6(n);




            S7(n);
            //      1
            //    2 3
            //  3 4 5
            //4 5 6 7


            Console.ReadKey();
        }
        static void S7(int n)
        {
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j <= 2 * (n - i); j++)
                    Console.Write(" ");
                for (j = 0; j < i; j++)
                {
                    Console.Write("{0} ", i + j);
                }
                Console.Write("\n");
            }
        }
        static void S6(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("**");
            for (int i = 0; i < n - 4; i++)
            {
                Console.Write(" ");
            }
            Console.Write("**");
            Console.Write("\n");
            for (int i = 0; i < n - 4; i++)
            {
                Console.Write("*");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("**");
            for (int i = 0; i < n - 4; i++)
            {
                Console.Write(" ");
            }
            Console.Write("**");
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        private static void S5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ", i + j);
                }
                Console.WriteLine();
            }
        }

        private static void S4_2(int n)
        {
            int suma = 1;
            int produs = 1;
            for (int i = 1; i < n; i++)
            {
                produs = produs / i * (2 * i) * (2 * i + 1);
                suma += produs;
            }
            Console.WriteLine("1 + 2*3 + 3*4*5 + ... + n*(n+1)*....*(2n-1) = {0}", suma);
        }

        private static void S4(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                // (i + 0) * (i + 1) * ... (i + (i - 1))
                int produs = 1;
                for (int j = 0; j < i; j++)
                {
                    produs = produs * (i + j);
                }

                suma += produs; // suma = suma + produs
            }
            Console.WriteLine("1 + 2*3 + 3*4*5 + ... + n*(n+1)*....*(2n-1) = {0}", suma);
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
