using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] arr = new int[n];
            int maior = 0;
            int posicao = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > maior)
                {
                    maior = arr[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao + 1);
        }
    }
}