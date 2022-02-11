using System;
					
public class fatoria
{
    public static void Main(String[] args) 
	{
       	Console.WriteLine("Digite um número para verificar seu fatorial:");
		int numero = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("O fatorial de " + numero + " é " + fatorial(numero));
    }
	
    private static int fatorial(int numero)
	{
        int fatorial = 1;
        for(int i=1; i<=numero; i++)
		{
            fatorial *=i;
        }
        return fatorial;
    }
}