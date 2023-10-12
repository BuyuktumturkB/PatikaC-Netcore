using System;
using System.IO;

double yarıcap;

Console.WriteLine("Bir Yarıçap Değeri Giriniz");
yarıcap = Convert.ToDouble(Console.ReadLine());
for (int y = -(int)yarıcap; y <= (int)yarıcap; y++)
{
	for (int x = -(int)yarıcap; x <= (int)yarıcap; x++)
	{
		if (x * x + y * y <= yarıcap * yarıcap)
		{
			Console.Write("*");
		}
		else
		{
			Console.Write(" ");
		}
	}
	Console.WriteLine();
}
