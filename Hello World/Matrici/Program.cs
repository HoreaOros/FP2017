using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1;

            m1 = new int[3, 4];
            InitMatrice(m1);
            AfisareMatrice(m1);


            int[,] m2 = new int[4, 5];
            InitMatrice(m2);
            AfisareMatrice(m2);

            int[,] m3 = InmultireMatrici(m1, m2);

            // Parcurgere in spirala
            // 1  2  3  4 
            //10 11 12  5
            // 9  8  7  6
            // Va rezulta 1 2 3 4 5 6 7 8 9 10 11 12
            int[,] m4 = { { 1, 2, 3, 4}, 
                          { 10, 11, 12, 5}, 
                          {9, 8, 7, 6 } };
            ParcurgereSpirala(m4);

        }

        private static void ParcurgereSpirala(int[,] m4)
        {
            int i1, i2, j1, j2;

            i1 = 0; j1 = 0;
            i2 = m4.GetLength(0) - 1;
            j2 = m4.GetLength(1) - 1;


            int k = 0; // cate elemente am afisat
            while (true)
            {
                for (int j = j1; j <= j2; j++)
                {
                    Console.Write("{0} ", m4[i1, j]);
                    k++;
                }
                i1++;
                if (k == m4.Length)
                {
                    break;
                }

                for (int i = i1; i <= i2; i++)
                {
                    Console.Write("{0} ", m4[i, j2]);
                    k++;
                }
                j2--;
                if (k == m4.Length)
                {
                    break;
                }
                for (int j = j2;  j >= j1; j--)
                {
                    Console.Write("{0} ", m4[i2, j]);
                    k++;
                }
                i2--;
                if (k == m4.Length)
                {
                    break;
                }
                for (int i = i2; i >= i1; i--)
                {
                    Console.Write("{0} ", m4[i, j1]);
                    k++;
                }
                j1++;
                if (k == m4.Length)
                {
                    break;
                }
            }
        }

        private static int[,] InmultireMatrici(int[,] m1, int[,] m2)
        {
            int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];
            // m3 este variabila locala - alocata pe stiva -- dispare cand metoda se incheie
            // elementele matricii se aloca intr-o zona de memorie numita HEAP

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    int suma = 0;
                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        suma += m1[i, k] * m2[k, j];
                    }
                    m3[i, j] = suma;
                }
            }

            return m3;
        }

        private static void InitMatrice(int[,] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(-1000, 1000);
                }
            }
        }

        private static void AfisareMatrice(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", m[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
