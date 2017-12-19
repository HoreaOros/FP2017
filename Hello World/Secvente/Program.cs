using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dau doua numere naturale a si b, a < b
            // se cere sa se afiseze toate numerele din intervalul [a, b]
            // care au cifrele identice
            // Ex. [2, 256] -> 2,3,4,5,6,7,8,9,11,22,33,44,55,66,77,88,99,111, 222
            // Ex. [2, 12345679123] ->

            int a = 2, b = 256000000;
            T1(a, b);
        }

        private static void T1(int a, int b)
        {
            for (int nr = a; nr <= b; nr++)
            {
                if (CheckEqDigits(nr))
                {
                    Console.WriteLine(nr);
                }
            }
        }

        private static bool CheckEqDigits(int nr)
        {
            int x = nr;
            
            int c1, c2;
            c1 = x % 10; x = x / 10;
          
            while (x>0)
            {
                c2 = x % 10; x /= 10;
                if (c1 != c2)
                    return false;
                c1 = c2;
            }
            return true;
        }
    }
}
