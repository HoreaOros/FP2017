using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            // tip de date, variabile, operatori

            int a = 1, b = 2;


            string line;

            try
            {
                Console.WriteLine("Introduceti un numar: ");
                line = Console.ReadLine();
                a = int.Parse(line);


                Console.WriteLine("Introduceti inca un numar: ");
                line = Console.ReadLine();
                b = int.Parse(line);
            }
            catch (FormatException)
            {
                Console.WriteLine("Nu ati introdus un numar.");

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something went wrong.");
            }

            // aritmetice

            int c;

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;
            c = a % b;

            //sbyte, byte, short, ushort, int, uint, long, ulong


            // float, double, decimal. 

            // Probleme care opereaza asupra cifrelor unui numar;
            int n = 123;
            Console.WriteLine("Suma cifre: {0}", SumaCifre(n));

            if (AscendingDigits(n))
            {
                Console.WriteLine("Cifrele sunt in ordine  strict crescatoare.");
            }
            else
            {
                Console.WriteLine("Cifrele nu sunt in ordine strict crescatoare");
            }


            // Probleme care verifica anumite proprietati ale unui numar
            // teste de primalitate
            // verificam daca doua numere sunt prime intre ele
            // cmmdc, cmmmc


            a = 18; b = 60;
            Console.WriteLine("cmmmdc({0}, {1}) = {2}", a, b, cmmmdc(a, b));


            // sa se verifice daca un an este bisect

            a = 1984;
            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
            {
                Console.WriteLine("An bisect.");
            }
            else
            {
                Console.WriteLine("Nu e an bisect.");
            }

            int[] v;
            v = new int[100];

            Random rnd = new Random();

            int max = 1000;
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(max);
            }

            Print(v);


            // cautare, sortare, stergere, inserare. 

            //BubbleSort(v);

            CountingSort(v, max);
            Print(v);

            // matrici
            int[,] matrice;
            matrice = new int[5, 5];

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = rnd.Next(max);
                }
            }

            // suma elementelor de pe diagonala principala, 
            // secundara, deasupra, sub, N, S, E, V
            // rotatie cu 90grd. spre stanga, dreata

        }

        private static void CountingSort(int[] v, int max)
        {
            //ex. v = {3, 4, 5, 2, 3, 9, 1, 3}
            //    f = {0, 1, 1, 3, 1, 1, 0, 0, 0, 1}
            int[] f = new int[max];

            for (int i = 0; i < v.Length; i++)
            {
                f[v[i]]++;
            }
            int k = 0;
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i]; j++)
                {
                    v[k] = i;
                    k++;  
                }
            }
        }

        private static void BubbleSort(int[] v)
        {
            bool sortat;
            do
            {
                sortat = true;
                for (int i = 0; i < v.Length - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int aux;
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        sortat = false;
                    }
                }
            } while (!sortat);
        }

        private static void Print(int[] v)
        {
            foreach (var item in v)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        private static int cmmmdc(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        private static bool AscendingDigits(int n)
        {
            
            int c1, c2;
            c2 = n % 10;
            n = n / 10;
            while (n > 0)
            {
                c1 = n % 10;
                if (c1 >= c2)
                {
                    return false;
                }
                c2 = c1;
                n = n / 10;
            }

            return true;
        }

        private static int SumaCifre(int n)
        {
            int suma = 0;
            int c;
            while (n > 0)
            {
                c = n % 10;
                n = n / 10;

                suma += c; // suma = suma + c;
            }
            return suma;
        }
    }
}
