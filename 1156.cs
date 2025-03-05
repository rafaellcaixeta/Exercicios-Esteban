using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            int numerador = 1;
            int denominador = 1;

            for (int i = 0; numerador <= 39; i++)
            {
                s += (double)numerador / denominador;
                numerador += 2;
                denominador *= 2;
            }
            Console.WriteLine($"O valor de S é: {s:F2}");
        }
    }
}