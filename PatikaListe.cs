using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

List<int> PassportID = new List<int>();
PassportID.Add(003214712);
PassportID.Add(002937711);
PassportID.Add(001441765);
PassportID.Add(002746214);
PassportID.Add(003746214);


List<string>Name=new List<string>();
Name.Add("Fenasi");
Name.Add("Ali");
Name.Add("Veli");
Name.Add("Kerim");
PassportID.ForEach(PassportID=> Console.WriteLine(PassportID));
int input;
Console.WriteLine("Sayı Giriniz");
input=Convert.ToInt32(Console.ReadLine());
if (input==0)
	PassportID.Clear();
List<DateTime>tarih=new List<DateTime>();
tarih.Add(DateTime.Now);
Console.WriteLine(tarih);

