using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, q, c;

            Console.WriteLine("Escreva um número inteiro:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                q = i * i;
                c = i * i * i;

                Console.WriteLine($"{i} {q} {c}");
            }
        }
    }
}