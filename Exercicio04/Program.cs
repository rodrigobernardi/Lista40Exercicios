using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            4. Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10% para o garçom. 
            Fazer um algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o 
            valor total com gorjeta. 

            */


            Console.WriteLine("Digite o valor total do consumo:");
            decimal valorDoConsumo = decimal.Parse(Console.ReadLine());

            Console.WriteLine(String.Format("O novo valor do produto sem gorjeta de 10% é de R$ {0}", string.Format("{0:C}", valorDoConsumo)));


            decimal valorDoConsumoComGorjeta = valorDoConsumo * 1.10M;
            Console.WriteLine(String.Format("O novo valor do produto com gorjeta de 10% é de R$ {0}", string.Format("{0:C}", valorDoConsumoComGorjeta)));

            Console.ReadLine();
        }
    }
}
