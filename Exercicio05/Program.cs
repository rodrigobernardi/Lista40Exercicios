using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            5. Uma pessoa resolveu fazer uma aplicação em uma poupança programada. 
            Para calcular seu rendimento, ela devera fornecer o valor constante da aplicação mensal, a taxa e o número de meses. Sabendo-se que a formula usada para este calculo é: 

            Valor acumulado = P * ((1+i)n -1)/i 
            i = taxa 
            P = aplicação mensal 
            n = número de meses (obs. (1+i) elevado a n) 

            */

            Console.WriteLine("Informe o valor constante da aplicação mensal (valor do depósito):");
            double P = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a taxa de rendimento:");
            double i = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de meses:");
            ushort n = ushort.Parse(Console.ReadLine());

            double valorAcumulado = P * (( Math.Pow(1 + i, n) - 1)/ i);

            Console.WriteLine(String.Format("O valor estimado acumulado com taxa de rendimento de {0}% é de R$ {1}", i, string.Format("{0:C}", valorAcumulado)));

            Console.ReadLine();
        }
    }
}
