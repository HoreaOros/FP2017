using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divizibilitate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculam suma divizorilor unui numar;

            ulong n;
            n = ulong.Parse(Console.ReadLine());
            //Console.WriteLine("Suma divizorilor lui {0} este {1}", n, SumaDivizori(n));
            //Console.WriteLine("Numarul divizorilor lui {0} este {1}", n, NumarDivizori(n));


            Console.WriteLine("Suma divizorilor lui {0} este {1}", n, SumaDivizoriFast(n));
            Console.WriteLine("Numarul divizorilor lui {0} este {1}", n, NumarDivizoriFast(n));
        }

        private static uint NumarDivizoriFast(ulong n)
        {
            uint d = 2;
            uint nd = 1;
            while (n > 1)
            {
                uint a = 0;
                while (n % d == 0)
                {
                    a++;
                    n = n / d;
                }
                nd = nd * (a + 1);
                d++;
            }
            return nd;
        }

        private static ulong SumaDivizoriFast(ulong n)
        {
            uint d = 2;
            ulong suma = 1;
            while (n > 1)
            {
                uint a = 0;
                while (n % d == 0)
                {
                    a++;
                    n = n / d;
                }
                suma = suma * ((ExponentiereFast(d, a + 1) - 1) / (d - 1));
                d++;
            }
            return suma;
        }

        private static uint ExponentiereFast(uint d, uint v)
        {
            if (v == 0)
            {
                return 1;
            }
            else if (v % 2 == 0)
            {
                uint e;
                e = ExponentiereFast(d, v / 2);
                return e * e;
            }
            else
            {
                uint e;
                e = d * ExponentiereFast(d, v - 1);
                return e;
            }
        }

        private static ulong NumarDivizori(ulong n)
        {
            ulong contor = 0;
            for (ulong d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    contor++;
                }
            }
            return contor;
        }

        /// <summary>
        /// Calculeaza suma divizorilor
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Suma Divizori</returns>
        /// <example>
        /// n = 12, Suma divizorilor este: 28
        /// </example>
        private static ulong SumaDivizori(ulong n)
        {
            ulong suma = 0;
            for (ulong d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    suma += d;
                }
            }
            return suma;
        }
    }
}
