using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int fatorial = 1;

            Console.WriteLine("insira um valor:");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 12)
                return;

            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"O fatorial de {n} é {fatorial}");
        }
    }
}