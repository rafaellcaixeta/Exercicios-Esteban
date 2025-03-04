using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite um número inteiro:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}