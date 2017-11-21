using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectori
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            v = new int[10];


            TestRandomness();
            

            int win = 0, loose = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (Gambler() == true)
                    win++;
                else
                    loose++;
            }
            Console.WriteLine("Win: {0}, Loose: {1}", win, loose);
        }

        private static void TestRandomness()
        {
            Random rnd = new Random();
            int v0 = 0, v1 = 0, bet;
            for (int i = 0; i < 1000; i++)
            {
                bet = rnd.Next(2);
                if (bet == 0)
                    v0++;
                else
                    v1++;
            }
            Console.WriteLine("v0 = {0}, v1 = {1}", v0, v1);
        }

        private static bool Gambler()
        {
            int stake = 50;
            int goal = 100;
            int cash;

            cash = stake;

            Random rnd = new Random();


            int bet;
            while (cash > 0 && cash < goal)
            {
                bet = rnd.Next(1000);
                if (bet < 500)
                    cash--;
                else
                    cash++;
            }
            if (cash == 0)
                return false;
            else
                return true;
        }
    }
}
