using System;
					
namespace print_string_array
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = new double[] { 2, 2.5, 15.9, 10.3, 2.6, 1, 3, 18, 19, 54, 874, 154.6 };
            Console.WriteLine(String.Join("\n", arr));
        }
    }
}