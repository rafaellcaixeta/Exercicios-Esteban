using System;

class Program
{
    static void Main()
    {
        int x, y;
        double D;

        Console.WriteLine("Escreva um número inteiro:");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Escreva outro número inteiro:");
        y = int.Parse(Console.ReadLine());

        if (y == 0)
        {
            Console.WriteLine("Não é possível dividir um número por 0");
        }
        else if (x > y)
        {
            D = x / y;
            Console.WriteLine("O valor da divisão é:" + D);
        }
        else
        {
            Console.WriteLine("valor de Y é maior que o valor de X -- DIVISÃO IMPOSSÍVEL --");
        }
    }
}