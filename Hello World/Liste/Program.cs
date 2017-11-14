using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se citesc numere pana cand se introduce zero. 
            // se cere sa se determine cea mai mare diferenta (in valoare absoluta)
            // dintre doua numere consecutive.
            // Lista contine cel putin 2 numere si zeroul de la sfarsit 
            // nu se ia in calcul.

            //Diff1();

            // Se citesc numere pana cand se introduce zero. 
            // se cere sa se determine cea mai mare diferenta (in valoare absoluta)
            // dintre doua numere consecutive si sa se afiseze acele numere.
            // Daca sunt mai multe perechi cu aceasi diferenta maxim o afisam pe prima
            // Lista contine cel putin 2 numere si zeroul de la sfarsit 
            // nu se ia in calcul.

            Diff2();


            

        }

        private static void Diff2()
        {
            int a, b;
            int maxim = -1;
            int amax = 0, bmax = 0;

            a = int.Parse(Console.ReadLine());
            do
            {
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                int dif;
                dif = Math.Abs(a - b);
                if (dif > maxim)
                {
                    maxim = dif;
                    amax = a;
                    bmax = b;
                }
                a = b;
            } while (true);
            Console.WriteLine("Cea mai mare diferenta dintre 2 valori consecutive este: {0}", maxim);
            Console.WriteLine("Numerele sunt: ({0}, {1})", amax, bmax);
        }

        private static void Diff1()
        {
            int a, b;
            int maxim = 0;

            a = int.Parse(Console.ReadLine());
            do
            {
                b = int.Parse(Console.ReadLine());
                if (b == 0)
                {
                    break;
                }
                int dif;
                dif = Math.Abs(a - b);
                if (dif > maxim)
                {
                    maxim = dif;
                }
                a = b;
            } while (true);
            Console.WriteLine("Cea mai mare diferenta dintre 2 valori consecutive este: {0}", maxim);
        }
    }
}
