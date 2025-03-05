using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Escreva um número:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
