using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero = 1;

            Console.WriteLine("Escreva a quantidade de linhas de saída que você deseja:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"{numero} {numero + 1} {numero + 2} PUM");

                numero += 4;
            }
        }
    }
}