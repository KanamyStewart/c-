using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Informe o volume: ");
		double volume = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Informe a altura: ");
		double altura = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Informe a profundidade: ");
		double profundidade = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("O volume informado é: " + (volume * altura * profundidade));
	}
}