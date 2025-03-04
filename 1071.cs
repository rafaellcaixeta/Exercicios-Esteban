using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int min, max;
            int soma;

            Console.WriteLine("Escreva um número inteiro:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número inteiro:");
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("O valor impar entre os números informados é: " + soma);
        }
    }
}