using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           
            1. Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos incorporaram essa palavra em seu vocabulário. Sabendo-se que 100 quilowatts de energia custa um sétimo do salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta por uma residência e calcule. Imprima: 
            • O valor em reais de cada quilowatt 
            • O valor em reais a ser pago 
            • O novo valor a ser pago por essa residência com um desconto de 10% 

            */


            // fazer um algoritmo que receba o valor do salário mínimo 
            Console.WriteLine("Digite o valor atual do salário mínimo:");
            decimal valoSalarioMinimo = decimal.Parse(Console.ReadLine());

            // e a quantidade de quilowatts gasta por uma residência e calcule
            Console.WriteLine("Digite o valor total consumido de Quillowatts:");
            decimal valorTotalConsumidoQuillowatt = decimal.Parse(Console.ReadLine());


            // Sabendo-se que 100 quilowatts de energia custa um sétimo do salário mínimo (1/7 equivale a 0,1428571428571429)
            // entao 1 quilowatts equivale a 0,0014285714285714
            const decimal fracaoUmQuillowattsBaseSalarioMinimo = 0.0014M;
            // calcular:

            // O valor em reais de cada quilowatt
            decimal valorDeCadaQuillowatt = valoSalarioMinimo * fracaoUmQuillowattsBaseSalarioMinimo;
            Console.WriteLine(String.Format("O custo de 1 Quillowatt é R$ {0}", string.Format("{0:C}", valorDeCadaQuillowatt)));

            // O valor em reais a ser pago 
            decimal valorTotalPagoConsumoQuillowatts = valorDeCadaQuillowatt * valorTotalConsumidoQuillowatt;
            Console.WriteLine(String.Format("O total do consumo de quillowatts a pagar é de R$ {0}", string.Format("{0:C}", valorTotalPagoConsumoQuillowatts)));

            // O novo valor a ser pago por essa residência com um desconto de 10 %
            decimal valorTotalPagoComDesconto = valorTotalPagoConsumoQuillowatts * 0.90M;
            Console.WriteLine(String.Format("O total do consumo de quillowatts a pagar com desconto de 10% é de R$ {0}", string.Format("{0:C}", valorTotalPagoComDesconto)));

            Console.ReadLine();
        }
    }
}
