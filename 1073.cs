using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Escreva um número inteiro:");
            x = int.Parse(Console.ReadLine());

            for (int i = 2; i <= x; i += 2)
            {
                int quadrado = i * i;

                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }
}