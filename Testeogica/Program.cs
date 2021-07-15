using System;

namespace Testeogica
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, soma;

            a = 5.30;
            b = 5.10;

            Console.Write("Valor a pagar : R$");
            soma = b * 2 + a;
            Console.WriteLine(soma.ToString("F2"));
            

            


        }
    }
}
