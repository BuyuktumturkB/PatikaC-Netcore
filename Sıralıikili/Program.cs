using System;

namespace Sıralıikili
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter number pair");
			int d = Convert.ToInt32(Console.ReadLine());

			int[] pair = new int[d];
			int i = 0;
			int control = d;

			while (d != 1)
			{
				Console.WriteLine("please enter a number");
				int n = Convert.ToInt32(Console.ReadLine());
				pair[i] = n;
				i++; d--;
			}
			Console.WriteLine(pair);
			int a = 0;
			int[] group = new int[control ];

			while (control != 0)
			{
				if (pair[a] != pair[a + 1])
				{
					group[a] = (pair[a] + pair[a + 1]);
					a = a + 2;
					control--;

				}
				else
				{
					group[a] = (pair[a] + pair[a + 1]) * (pair[a] + pair[a + 1]);
					a = a + 2;
					control--;
				}

			}
			Console.WriteLine(group);

		}
	}
}
