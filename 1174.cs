using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int [5];

            Console.WriteLine("Escreva 5 números:");

            for (int i = 0; i < 5; i++)
            {
                n[i] = int.Parse(Console.ReadLine());

                if (n[i] == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (n[i] % 2 == 0)
                {
                    Console.WriteLine("EVEN");
                }
                else
                {
                    Console.WriteLine("ODD");
                }
            }
        }
    }
}