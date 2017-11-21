using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuponColector
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 10000;
            int count, sum = 0;
            for (int i = 0; i < times; i++)
            {
                count = CuponTest();
                sum += count;
            }
            Console.WriteLine("Average: {0}", 1.0*sum / times);

        }

        private static int CuponTest()
        {
            int[] v;
            int cuponNo = 10;

            v = new int[cuponNo];
            int cupon;
            Random rnd = new Random();
            int count = 0;
            while (!CheckFullCollection(v))
            {
                cupon = rnd.Next(cuponNo);
                v[cupon]++;
                count++;
            }
            return count;
        }

        private static bool CheckFullCollection(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
