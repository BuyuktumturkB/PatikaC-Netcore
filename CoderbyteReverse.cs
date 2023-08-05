using System;

class MainClass {

  public static string FirstReverse(string str) {

    // code goes here  
    
     char[] Carray= str.ToCharArray();
     int i=Carray.Length-1;
    
    string reverse = " ";
    while ( i>-1)
    {
      reverse+=Carray[i];
      i--;

    }
   

    return reverse;   

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(FirstReverse(Console.ReadLine()));
    
  } 

}
