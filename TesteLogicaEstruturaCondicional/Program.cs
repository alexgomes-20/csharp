using System;
using System.Globalization;

namespace TesteLogicaEstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double dog = 4.00;
            double xsalada = 4.50;
            double xbacon = 5.00;
            double torrada = 2.00;
            double refri = 1.50;
            int cod1 = 1;
            int cod2 = 2;
            int cod3 = 3;
            int cod4 = 4;
            int cod5 = 5;
            
            
            Console.WriteLine("qual o seu pedido ?" );
            int c = int.Parse(Console.ReadLine());

            if (c == cod1)
                {

                Console.WriteLine("cachorro quente");
                Console.WriteLine("Quantos vc vai querer?");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("valor do pedido");
                Console.WriteLine("R$" + y * dog);
                
                 }
             
            else if (c == cod2) 
                {
                 Console.WriteLine("X-Salada");
                Console.WriteLine("Quantos vc vai querer?");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("valor do pedido");
                Console.WriteLine("R$" + y * xsalada);
                }

            else if (c == cod3)
            {
                Console.WriteLine("X-Bacon");
                Console.WriteLine("Quantos vc vai querer?");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("valor do pedido");
                Console.WriteLine("R$" + y * xbacon);
            }

            else if (c == cod4)
            {
                Console.WriteLine("Torrada Simples");
                Console.WriteLine("Quantos vc vai querer?");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("valor do pedido");
                Console.WriteLine("R$" + y * torrada);
            }

            else if (c == cod5)
            {
                Console.WriteLine("Refrigerante");
                Console.WriteLine("Quantos vc vai querer?");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("valor do pedido");
                Console.WriteLine("R$" + y * refri);
            }


            else
            { Console.WriteLine("Codigo errado"); 
                
                }

            Console.ReadLine();






        }

            }
}
