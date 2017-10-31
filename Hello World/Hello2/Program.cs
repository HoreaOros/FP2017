using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instructiunea if
            int an = 2016;
            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine("{0} este bisect", an);
            }
            else
            {
                Console.WriteLine("{0} nu este bisect", an);
            }


            // instructiunea while
            int suma = 0;
            int n = 258964;
            int backup;
            int c;
            backup = n;
            while (n > 0)
            {
                c = n % 10; // obtin ultima cifra a lui n
                suma = suma + c;
                n = n / 10; // elimin ultima cifra a lui n
            }
            Console.WriteLine("Suma cifrelor numarului {0} este {1}", backup, suma);


            // instructiunea do ... while
            n = 10;
            do
            {
                Console.WriteLine(n);
                n--;
                Thread.Sleep(1000);
            } while (n > 0);
            Console.Beep(1000, 500);

            // instructiunea for
            suma = 0;
            for (int i = 0; i < 10; i += 2)
            {
                suma += i; // <==> suma = suma + i; a[x+y*z[j]][j%2 + n << 5] += 1;
            }

            // instructiunea switch
            int zi = 3;

            switch (zi)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("MidWeek");
                    break;
                case 5:
                    Console.WriteLine("Finally Friday!");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("<error/>");
                    break;
            }




        }
    }
}
