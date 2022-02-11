using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Informe a primeira nota: ");
		double notaUm = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Informe a segunda nota: ");
		double notaDois = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Informe a terceira nota: ");
		double notaTres = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("A média das notas informadas é: " + (notaUm + notaDois + notaTres)/3);
	}
}