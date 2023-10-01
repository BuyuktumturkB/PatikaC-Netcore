using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



string[] girdi = new string[5];
girdi[0] = "a";
girdi[1] = "o";
girdi[2] = "c";
girdi[3] = "d";

Console.WriteLine(girdi.ToString());

for (int i = 0; i<girdi.Length; i++)
{
	

	if (girdi[i] == "a"  || girdi[i]=="e" || girdi[i] == "o" || girdi[i] == "u" || girdi[i] == "i" && girdi[i+1] == "e" && girdi[i] == "o" && girdi[i] == "u" && girdi[i+1]=="i")
		
	{
		Console.WriteLine("True");
	}
	i++;
	

}
if (girdi[girdi.Length - 1] != "a" || girdi[girdi.Length - 1] != "e" || girdi[girdi.Length - 1] != "u" || girdi[girdi.Length - 1] != "o" || (girdi[girdi.Length - 1] != "i" &&
	girdi[girdi.Length] != "a") && girdi[girdi.Length ] != "o" && girdi[girdi.Length ] != "e" || girdi[girdi.Length ] == "u") 
	{
		Console.WriteLine ("False");
	}
