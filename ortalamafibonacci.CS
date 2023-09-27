 int deger ,count=2,a=0,b=1,c=0; 
void opsiyonelfibonacci() 
{
	Console.WriteLine(" Lütfen değer giriniz");
	deger=Convert.ToInt32(Console.ReadLine());
	Console.Write("{0} {1}", a, b);
	while ( count<deger)
	{
		c = a + b;
		Console.Write(" {0}", c);
		a = b;
		b=c;
		count++;
	
	}

}
opsiyonelfibonacci();

