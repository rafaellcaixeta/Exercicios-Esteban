using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Escreva um número inteiro:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número inteiro:");
            y = int.Parse(Console.ReadLine());

            for (int i = x; i < y; i++)
            {
                if (i % 5 == 2)
                {
                    Console.WriteLine(i);
                }
                else if (i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
