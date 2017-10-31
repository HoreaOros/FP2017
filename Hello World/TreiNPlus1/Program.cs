using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreiNPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;

            
            Console.WriteLine("Pentru a = {0} lungimea sirului este: {1}", a, Lungime(a));

            for (int i = 1; i <= 10000; i++)
            {
                Lungime(i);
            }
        }

        private static int Lungime(int a)
        {
            int contor = 0;
            Console.WriteLine("{0} - ", a);
            while (a != 1)
            {
                contor++;
                if (a % 2 == 0) // testam paritatea numarului
                {
                    a = a / 2;
                }
                else
                {
                    a = 3 * a + 1;
                }

                Console.Write("{0} ", a);
            }
            Console.WriteLine("\n");
            return contor;
        }
    }
}
