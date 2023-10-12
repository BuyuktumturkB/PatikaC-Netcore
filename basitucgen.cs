using System;
using System.IO;

giris:
int boyut,a,b,c;
Console.WriteLine(" Üçgen için boyut giriniz");
boyut=int.Parse(Console.ReadLine());
for (a = 1; a <= boyut; a++) 
{
	for (b = 1; b <= boyut-a; b++) 
	{
		
	}
	for (c = 1; c <= a; c++) 
	{
		Console.Write("+");
	}
	Console.WriteLine("");
}
