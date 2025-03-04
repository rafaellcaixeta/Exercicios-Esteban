using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int soma;

            Console.WriteLine("Escreva um número inteiro:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número inteiro:");
            y = int.Parse(Console.ReadLine());

            soma = 0;

            for (int i = x; i <= y; i++)
            { 
              if (i % 13 != 0)
                {
                    soma += i;
                }   
            }

            Console.WriteLine("A soma dos números que não são divisíveis por 13 é: " + soma);
        }
    }
}
