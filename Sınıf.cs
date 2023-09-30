using System;
using static System.Console;
using System.Linq;

class Passport
{
    public int Passportid;
    public string FirstName;
    public string LastName;
    public string Gender;
    public int age;
    public int validateuntil;

    public void Getir()
    {
        Console.WriteLine("İim" + FirstName);
    } 
}
Passport yolcu1=new Passport();
yolcu1.Passportid=12314227; yolcu1.FirstName = "Kenan ";  yolcu1.LastName = "Ökler";yolcu1.Gender = "Erkek"; yolcu1.age = 22; yolcu1.validateuntil = 2029;
Passport yolcu2 = new Passport();
yolcu2.FirstName = 2314151;yolcu2.FirstName"Anna"; yolcu2.LastName = "Markova";yolcu2.Gender = "Kadın";yolcu2.age = 25; yolcu2.validateuntil = 2037;

Passport.Getir();
