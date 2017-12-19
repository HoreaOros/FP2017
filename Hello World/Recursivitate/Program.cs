using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            
            try
            {
                Console.WriteLine("{0}! = {1}", n, FactorialNR(n));
                Console.WriteLine("{0}! = {1}", n, Factorial(n));
            }

            catch (OverflowException)
            {
                Console.WriteLine("Valori prea mari pe care nu le pot reprezenta");
            }

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", FibRec(i));
            }
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0} ", FibNR(i));
            }
            Console.WriteLine();


            Random rnd = GetRndGenerator();

            // Suma cifrelor 
            n = 1254879;
            int sc = SC(n);
            Console.WriteLine("SumaCifre({0}) = {1}", n, sc);

            sc = SumaCifreRec(n);
            Console.WriteLine("SumaCifreRec({0}) = {1}", n, sc);

            // maximul dintr-un vector

            int[] v = { 5, 6, -9, 3, 1, 0 };

            Console.WriteLine("Cel mai mare numar din lista este: {0}", MaxRec(v));
        }

        private static int MaxRec(int[] v)
        {
            return MaxRecHelper(v, v.Length);
        }

        private static int MaxRecHelper(int[] v, int n)
        {
            if (n == 1)
            {
                return v[0];
            }
            else
                return Math.Max(v[n - 1], MaxRecHelper(v, n - 1));
        }

        private static int FibNR(int i)
        {
            int f1 = 1, f2 = 1, f3;

            while (i > 1)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                i--;
            }
            return f1;

        }

        private static int SumaCifreRec(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
                return n % 10 + SumaCifreRec(n / 10);
        }

        private static int SC(int n)
        {
            int suma = 0;
            int c;
            while (n > 0)
            {
                c = n % 10;
                suma += c;
                n = n / 10;
            }
            return suma;
        }

        private static Random GetRndGenerator()
        {
            return new Random();
        }

        private static int FibRec(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return FibRec(n - 1) + FibRec(n - 2);
            }
        }

        private static int FactorialNR(int n)
        {

            int p = 1;
            for (int i = 2; i <= n; i++)
            {
                p *= i;
            }
            return p;
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * Factorial(n - 1);
        }

    }
}
