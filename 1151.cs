using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int numero1, numero2;
            Console.WriteLine("Escreva um número:");
            n = int.Parse(Console.ReadLine());

            if (n <= 0 || n >= 46)
                return;

            numero1 = 0;
            numero2 = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numero1);
                int aux = numero1;
                numero1 = numero2;
                numero2 = aux + numero2;
            }
        }
    }
}