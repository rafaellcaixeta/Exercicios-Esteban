using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("escreva o valor 1:");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("escreva o valor 2:");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("escreva o valor 3:");
            z = double.Parse(Console.ReadLine());

            double media = (x * 2 + y * 3 + z * 5) / 10;

            Console.WriteLine($"{media:F1}");
        }
    }
}