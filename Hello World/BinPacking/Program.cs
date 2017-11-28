using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinPacking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] w = {3, 6, 2, 1, 5, 7, 2, 4, 1, 9};
            int C = 10;

            int nf = NextFit(w, C);
            Console.WriteLine("Next Fit: {0} bins", nf);

            int ff = FirstFit(w, C);
            Console.WriteLine("First Fit: {0} bins", ff);

            int bf = BestFit(w, C);
            Console.WriteLine("Best Fit: {0} bins", bf);

        }

        private static int BestFit(int[] w, int c)
        {
            int[] bins = new int[w.Length];
            int bf = 1, j;
            int minim = c + 1, indexMin = 0;
            for (int i = 0; i < w.Length; i++)
            {
                minim = c + 1;
                for (j = 0; j < bf; j++)
                {
                    if (bins[j] + w[i] <= c)
                    {
                        if (c - (bins[j] + w[i]) < minim)
                        {
                            minim = c - (bins[j] + w[i]);
                            indexMin = j;
                        }
                    }
                }
                
                if (minim == c + 1)
                {
                    bins[bf] = w[i];
                    bf++;
                }
                else
                {
                    bins[indexMin] += w[i];
                }
            }
            return bf;
        }

        private static int FirstFit(int[] w, int c)
        {
            int[] bins = new int[w.Length];
            int ff = 1, j;

            for (int i = 0; i < w.Length; i++)
            {
                for (j = 0; j < ff; j++)
                {
                    if (bins[j] + w[i] <= c)
                    {
                        bins[j] += w[i];
                        break;
                    }
                }
                if (j == ff)
                {
                    bins[ff] = w[i];
                    ff++;
                }
            }
            return ff;
        }

        private static int NextFit(int[] w, int c)
        {
            int S = 0;
            int nf = 1;
            for (int i = 0; i < w.Length; i++)
            {
                if (S + w[i] <= c)
                {
                    S = S + w[i];
                }
                else
                {
                    nf++;
                    S = w[i];
                }
            }
            return nf;
        }
    }
}
