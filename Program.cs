using System;

namespace Aula_22___Static
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Conversão de Valores em Dolar:");


            Console.ForegroundColor = ConsoleColor.Yellow;

            Conversor.CotacaoDolar = 5.29f;
            Console.WriteLine( Conversor.DolarParaReal(52) );
            Console.WriteLine( Conversor.RealParaDolar(52) );

            Console.ResetColor();

            //
            System.Console.WriteLine("Conversão de Valores em Euro:");

            Console.ForegroundColor = ConsoleColor.Green;

            Conversor.CotacaoEuro = 5.90f;
            Console.WriteLine( Conversor.EuroParaReal(52) );
            Console.WriteLine( Conversor.RealParaEuro(52) );

            Console.ResetColor();
        }
    }
}
