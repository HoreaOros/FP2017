using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Numere
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste de primalitate

            int n;

            n = int.Parse(Console.ReadLine());

            if (Prim3(n) == true)
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            {
                Console.WriteLine("Numarul este compus");
            }


            // Probleme cu cifrele unui numar;

            // Se cere sa se afiseze suma cifrelor unui numar;
            Console.WriteLine("Suma cifrelor lui {0} este {1}", n, SumaCifre(n));

            // Verifica daca n este palindrom (numarul este egal cu oglinditul sau) de ex. 12521
            Console.WriteLine("Palindrom({0}) = {1}", n, Palindrom(n));

            // *****************************************
            // Suma cifre (numere divizibile cu 9)
            
            Div9();
        }

        private static void Div9()
        {

            //Console.WriteLine("Introduceti un numar n si apoi nu numere divizibile cu 9");
            //int n = int.Parse(Console.ReadLine());
            //int nr;
            //int suma = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    nr = int.Parse(Console.ReadLine());
            //    //suma += SumaCifre(nr);
            //}

            //while (suma > 9)
            //{
            //    suma = SumaCifre(suma);
            //}

            Console.WriteLine("Rezultatul este: {0}", 63);
        }

        private static bool Palindrom(int n)
        {
            //if (n == Oglindit(n))
            //{
            //    return true;
            //}
            //else
            //    return false;
            return n == Oglindit(n);
        }

        private static int Oglindit(int n)
        {
            int og = 0, c;
            while (n > 0)
            {
                c = n % 10;
                n = n / 10;
                og = og * 10 + c;
            }
            return og;
        }

        private static int SumaCifre(int n)
        {
            int suma = 0; // n = 12584
            int c;
            while (n > 0)
            {
                c = n % 10; // ultima cifra a lui n
                suma = suma + c;
                n = n / 10;
            }
            return suma;
        }

        /// <summary>
        /// Verifica primalitatea unui numar
        /// </summary>
        /// <param name="n">Numarul verificat</param>
        /// <returns>True daca numarul este prim, False in caz contrar</returns>
        private static bool Prim1(int n)
        {
            for (int d = 2; d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Verifica primalitatea unui numar
        /// </summary>
        /// <param name="n">Numarul verificat</param>
        /// <returns>True daca numarul este prim, False in caz contrar</returns>
        private static bool Prim2(int n)
        {
            bool ok = true; // tehnica fanionului (flag)
            for (int d = 2; ok && d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    ok = false;
                }
            }

            return ok;
        }



        /// <summary>
        /// Verifica primalitatea unui numar (varianta mai rapida)
        /// </summary>
        /// <param name="n">Numarul verificat</param>
        /// <returns>True daca numarul este prim, False in caz contrar</returns>
        private static bool Prim3(int n)
        {
            bool ok = true; // tehnica fanionului (flag)
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (int d = 3; ok && d * d <= n; d += 2)
            {
                if (n % d == 0)
                {
                    ok = false;
                }
            }

            return ok;
        }
    }
}
