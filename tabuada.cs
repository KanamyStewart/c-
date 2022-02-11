using System;
					
namespace Number
{
	class Program
	{

		public static void Main(string[] args)
		{
			tabuad(5);
			Console.ReadKey(true);
		}
		
		public static void tabuad(int numero)
		{
			for (int x = 1; x <= 10; x++)
			{
				Console.WriteLine(numero + " * " + x + " = " + numero * x);
			}
		}
	}
}