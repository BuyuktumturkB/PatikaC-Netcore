using System;
using System.IO;

Console.WriteLine(sehirler.Eskişehir);
Console.WriteLine((int)sehirler.Istanbul);
int girdi;
Console.WriteLine("Bir sayi giriniz");
girdi=Convert.ToInt32(Console.ReadLine());
if (girdi == (int)CografiBolge.Marmara) 
{
	Console.WriteLine(sehirler.Istanbul);
}
else if (girdi == (int)CografiBolge.Ege)
{
	Console.Write(sehirler.Denizli);
	Console.Write(sehirler.Manisa);
}
else if (girdi == (int)CografiBolge.İçAnadolu)
{
	Console.Write( sehirler.Eskişehir);
	Console.Write(sehirler.Ankara);
}
else if (girdi == (int)CografiBolge.DAnadolu)
{
	Console.Write(sehirler.Erzurum);
	Console.Write(sehirler.Kars);
}
else if (girdi == (int)CografiBolge.GDAnadolu)
{
	Console.Write(sehirler.Gaziantep);
	Console.Write(sehirler.Diyarbakır);
}
else if (girdi == (int)CografiBolge.Akdeniz)
{
	Console.Write(sehirler.Adana);
	Console.Write(sehirler.Mersin);
}
else if (girdi == (int)CografiBolge.Karadeniz)
{
	Console.Write(sehirler.Samsun);
	Console.Write(sehirler.Trabzon);
}





enum sehirler
{
	Istanbul,
	Mersin,
	Adana,
	Ankara,
	Eskişehir,
	Manisa,
	Denizli,
	Erzurum,
	Kars,
	Diyarbakır,
	Gaziantep,
	Samsun,
	Trabzon
}
enum CografiBolge 
{
	Marmara=1,
	Ege,
	İçAnadolu,
	DAnadolu,
	GDAnadolu,
	Karadeniz,
	Akdeniz

}
