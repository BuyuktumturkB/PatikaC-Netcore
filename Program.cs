using System;

namespace HarckerRank1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a;
			int b;
			 a = Convert.ToInt32(Console.ReadLine());
			 b = Convert.ToInt32(Console.ReadLine());
			int sum = a + b;
			int difference = a - b;
			Console.WriteLine(sum);
			Console.WriteLine(difference);
			string password;
			bool passwordcontrol;
			Console.WriteLine("Please Enter Password: ");
			password = Console.ReadLine();
			
			if (password == "WE LOVE KEBAB") 
			{
				passwordcontrol = true;
				Console.WriteLine("Password Correct");
			}
			else
			{
				passwordcontrol = false;
				Console.WriteLine("Wrong Password");
			}

			double c;
			c = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"{c - 2.27}");
			byte a=10;
			short b=3;
			int suma=a+b;
			Console.WriteLine(suma);
			

		}
	}
}
