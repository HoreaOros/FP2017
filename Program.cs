using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertire
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int bazax = 0, bazay = 0, r;
            double nr10 = 0;
            string s;
            string sy = "";
            string resturi = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int n10 = (int)nr10;

            Console.Write("Dati baza x:");
            bazax = int.Parse(Console.ReadLine());
            Console.Write("Introduce un numar din baza x:");
            s = Console.ReadLine();
            char[] t;
            t = new char[36];
            for (i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                    nr10 += (Convert.ToInt32(char.ToUpper(s[i])) - 55) * Math.Pow(bazax, s.Length - i - 1);
                if (char.IsDigit(s[i]))
                    nr10 += (Convert.ToInt32(s[i]) - 48) * Math.Pow(bazax, s.Length - i - 1);

            }
            Console.WriteLine("numarul in baza 10 este: {0}", nr10);

            Console.Write("Dati baza y in care sa transform numarul(intre 2 si 36):");
            bazay = int.Parse(Console.ReadLine());

            n10 = (int)nr10;
            while (n10 > 0)

            {
                r = n10 % bazay;
                sy = resturi[r] + sy;
                n10 /= bazay;
            }
            Console.WriteLine("Numarul in baza y este:{0}", sy);
            Console.ReadKey();
        }
    }
}
