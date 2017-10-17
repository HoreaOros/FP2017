using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rnd = new Random();

            int r1 = 0;

            // Console.WriteLine(rnd.Next(42));

            


            Console.WriteLine("Introduceti un numar: ");

            string line;

            line = Console.ReadLine();



            try
            {
                r1 = int.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            

            



            int r2;
            r2 = rnd.Next(1, 7);
            Console.WriteLine("r1 = {0}, r2 = {1}", r1, r2);

            Console.WriteLine("r1 + r2 = {0}", r1 + r2);
            Console.WriteLine("r1 - r2 = {0}", r1 - r2);
            Console.WriteLine("r1 * r2 = {0}", r1 * r2);
            Console.WriteLine("r1 / r2 = {0}", r1 / r2);
            Console.WriteLine("r1 % r2 = {0}", r1 % r2);
        }
    }
}
