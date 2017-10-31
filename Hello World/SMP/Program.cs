using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMP
{
	class Program
	{
		static void Main(string[] args)
		{
			// S1 = 1*2+2*3+3*4+..+n*(n+1)
			Console.WriteLine("Introduceti un numar natural nenul: ");
			string line;
			line = Console.ReadLine();
			int n;

			n = int.Parse(line);

			S1(n);



			// S2 = 1*2-2*3+3*4-.. +/- n*(n+1)
			S2(n);


			// * 
			// **
			// ***
			// ****
			S3(n);

			//S4=1+2*3+3*4*5+4*5*6*7+....+n*(n+1)*(n+2)*...*(2*n-1)
			S4(n);

			//******
			//**  **
			//*    *
			//*    *
			//**  **
			//******
			//S5(6);

			//*****
			//** **
			//*   *
			//** **
			//*****
			//S5(5);
			S6(n);
			
			// Cred ca asa erau problemele astea
			//1
			//2 3
			//3 4 5
			//4 5 6 7
			S5(n);

			//      1
			//    3 2
			//  5 4 3
			//7 6 5 4 
			S7_i(n);

			//      1
			//    2 3
			//  3 4 5
			//4 5 6 7
			S7_ii(n);
			Console.ReadKey();

		}

		private static void S7_ii(int n)
		{
			int k = 1;
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					if (i <= n - j)
						Console.Write("  ");
					else Console.Write("{0} ",k++);
				}
				k = k - i + 1;
				Console.WriteLine();
			}
		}

		private static void S7_i(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					if (i<=n-j)
						Console.Write("  ");
					else Console.Write("{0} ",i+n-j);
				}
				Console.WriteLine();
			}
		}

		private static void S5(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ",i+j-1);
				}
				Console.WriteLine();
			}
		}

		private static void S6(int n)
		{
			int k = 0;
			if (n % 2 == 1)
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (j > n / 2 - k && j < n / 2 + k)
							Console.Write(" ");
						else Console.Write("*");
					}
					if (i < n / 2)
						k++;
					else k--;
					Console.WriteLine();
				}
			}
			else
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (j > n / 2 - 1 - k && j < n / 2 + k)
							Console.Write(" ");
						else Console.Write("*");
					}
					if (i < n / 2 - 1)
						k++;
					else if (i > n / 2 - 1)
						k--;
					Console.WriteLine();
				}
			}
		}

		private static void S4(int n)
		{
			int prod = 1, suma = 1;

			for (int i = 1; i < n; i++)
			{
				prod = prod / i * (2 * i) * (2 * i + 1);
				suma += prod;
			}
			Console.WriteLine("Suma este: {0}", suma);
		}

		private static void S3(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}

		private static void S2(int n)
		{
			int suma = 0;


			int k = 1;

			while (k <= n)
			{
				if (k % 2 == 1)
				{
					suma = suma + k * (k + 1);
				}
				else
				{
					suma = suma - k * (k + 1);
				}
				k++;

				// suma = suma + k * (k + 1) * ((k % 2 == 1) ? 1 : -1);
				// (cond)?(exp1):(exp2)
			}
			Console.WriteLine("Suma este: {0}", suma);
		}

		private static void S1(int n)
		{
			int suma = 0;


			int k = 1;

			while (k <= n)
			{
				suma = suma + k * (k + 1);
				k++;
			}
			Console.WriteLine("Suma este: {0}", suma);
		}
	}
}
