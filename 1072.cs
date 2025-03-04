using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[4];
            int dentro = 0;
            int fora = 0;

            Console.WriteLine("Escreva 4 números:");
            
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());  
            }

            for (int i = 0; i < n.Length; i++)
            {

                if (n[i] >= 10 && n[i] <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
