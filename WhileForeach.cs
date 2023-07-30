int sayi , toplam=0;
Console.Write("Bir Sayi Giriniz");
sayi=Convert.ToInt32(Console.ReadLine());
while (sayi != 0) 
{
	Console.WriteLine(sayi);
	sayi--;
}
int[] grup = { 3,1,5,7,8,12};
foreach (int i in grup) 
{
	toplam = +i;
// .NET7 Konsol ile yazıldığı için using yoktur
