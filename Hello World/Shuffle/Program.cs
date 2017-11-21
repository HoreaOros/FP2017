using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] deck;

            deck = new int[24];

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i;
            }

            DisplayArray(deck);

            ShuffleDeck(deck);

            DisplayArray(deck);



        }

        public static void ShuffleDeck(int[] deck)
        {
            int j;
            Random rnd = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                j = rnd.Next(0, i + 1);
                int aux;
                aux = deck[i];
                deck[i] = deck[j];
                deck[j] = aux;
            }
        }

        public static void DisplayArray(int[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                Console.Write("{0} ", deck[i]);
            }

            Console.WriteLine();
        }
    }
}
