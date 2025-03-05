using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ntestes;
            int cobaias = 0;
            int sapos = 0;
            int ratos = 0;
            int coelhos = 0;

            Console.WriteLine("Escreva o número de testes (n):");
            ntestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < ntestes; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int qtd = int.Parse(valores[0]);
                string tipo = valores[1];
                if (tipo == "C")
                {
                    coelhos += qtd;
                }
                else if (tipo == "R")
                {
                    ratos += qtd;
                }
                else if (tipo == "S")
                {
                    sapos += qtd;
                }
                cobaias += qtd;
            }

            Console.WriteLine($"Total: {cobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {((double)coelhos / cobaias * 100).ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {((double)ratos / cobaias * 100).ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {((double)sapos / cobaias * 100).ToString("F2")} %");

        }
    }
}