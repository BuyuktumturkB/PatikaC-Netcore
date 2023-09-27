using System.Collections;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

ArrayList liste=new ArrayList();
liste.Add("Burak");
liste.Add("Btt");
liste.Add(22);
liste.Add('M');
int i=0;

ArrayList kronoloji=new ArrayList();
kronoloji.Add(1922);
kronoloji.Add(1453);
kronoloji.Add(2023);

Console.WriteLine("****Kronoloji******");
kronoloji.Sort();
for (int j=0; j<kronoloji.Count; j++)
	Console.WriteLine(kronoloji[j]);
   

while (i < liste.Count) 
{
	Console.WriteLine(liste[i]);
	i++;
}
Console.WriteLine("**********Reverse*****");
int a=0, b = liste.Count;
while (a <= b) 
{
	
	liste.Reverse();
	a++;
	b--;
	Console.WriteLine(liste[a]);

}
