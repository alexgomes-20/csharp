using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = " Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produto:");
            Console.Write(produto1);
            Console.Write(", cujo preço é R$ ");
            Console.WriteLine(preco1.ToString("F2"));
            Console.Write(produto2);
            Console.Write(", cujo preço é R$");
            Console.WriteLine(preco2.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Registro:");
            Console.Write(idade);
            Console.Write(" anos de idade, código ");
            Console.Write(codigo);
            Console.Write(" e genero:");
            Console.WriteLine(genero);
            Console.WriteLine();
            Console.Write("Medida com oito casa decimais:");
            Console.WriteLine(media.ToString("F6"));
            Console.Write("Arredondado (três casas decimais):");
            Console.WriteLine(media.ToString("F3"));
            Console.Write("Separador decimal invariant culture:");
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
