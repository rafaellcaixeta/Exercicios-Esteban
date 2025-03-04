using System;
using System.Numerics;
internal class Program
{
    private static void Main(string[] args)
    {
        int n, n1, n2, n3;

        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {

            i = i++;

            n1 = (int)MathF.Pow(i, 1);
            n2 = (int)MathF.Pow(i, 2);
            n3 = (int)MathF.Pow(i, 3);

            Console.WriteLine($"{n1} {n2} {n3}");

            Console.WriteLine($"{n1} {n2 + 1} {n3 + 1}");
        }
    }
}