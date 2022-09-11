using System;

namespace HarckerRank1
{
	class Program
	{
		static void Main(string[] args)
		{
		
			Console.WriteLine("Please Enter Your Nationality: ");
			string Nationality;
			Nationality = Console.ReadLine();
			switch (Nationality)
			{
				case "EU Nation":
					Console.WriteLine("No Need Visa");
					break;
				case "Japan Citizien":
					Console.WriteLine("No Need Visa");
					break;
				case "Balkan Countries":
					Console.WriteLine(" Visa Required");
					break;
				case "African Countries":
					Console.WriteLine("Visa Required");
					break;


			}

			}

		}
	}
}
