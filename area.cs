using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Informe a area 1: ");
		double areaUm = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Informe a segunda nota: ");
		double areaDois = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("A area informada é: " + (areaUm * areaDois));
	}
}