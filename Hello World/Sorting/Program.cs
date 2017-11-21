using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            v = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(100);
            }

            // Selection Sort
            Console.WriteLine("Selection Sort:");
            Shuffle.Program.DisplayArray(v);
            SelectionSort(v);
            Shuffle.Program.DisplayArray(v);


            // Insertion Sort
            Console.WriteLine("Insertion Sort:");
            Shuffle.Program.ShuffleDeck(v);
            Shuffle.Program.DisplayArray(v);
            InsertionSort(v);
            Shuffle.Program.DisplayArray(v);

        }

        private static void InsertionSort(int[] v)
        {
            
            int aux;
            for (int i = 1; i < v.Length; i++)
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
                }
            }
        }

        private static void SelectionSort(int[] v)
        {
            int k, aux;
            for (int i = 0; i < v.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[k] > v[j])
                        k = j;
                }
                aux = v[i];
                v[i] = v[k];
                v[k] = aux;
            }
        }
    }
}
