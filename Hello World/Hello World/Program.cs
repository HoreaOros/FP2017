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


            /* varianta scrisa la curs

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
            
    */
            // varianta propusa ptr citire si verificare

            int input1TransfNr;
            string input1;
            do
            {
                Console.Write("Introduceti un numar: ");
                input1 = Console.ReadLine();

                if (int.TryParse(input1, out input1TransfNr) == true)
                    Console.WriteLine("Valoare acceptata: {0}", input1TransfNr);
                else
                    Console.WriteLine("Eroare: Valoarea introdusa inacceptabila pentru exercitiul curent. Va rog sa incercati din nou!");

            } while (int.TryParse(input1, out input1TransfNr) == false);

            // end varianta propusa

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
