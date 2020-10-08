using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            9. A prefeitura do Rio de Janeiro abriu uma linha de crédito para os funcionários estatutários. 
            O valor Máximo da prestação não poderá ultrapassar 30% do salário bruto. 
            Fazer um programa que permita entrar com o salário bruto e o valor da prestação e informa se o empréstimo pode ou não ser concedido. 
            
            */

            Console.WriteLine("Informe o seu salário bruto:");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da parcela:");
            decimal valorDaParcela = decimal.Parse(Console.ReadLine());

            decimal valorMaximo = salarioBruto * 0.30M;

            if (valorDaParcela <= valorMaximo)
                Console.WriteLine(String.Format("Valor da parcela aprovada R$ {0}", valorDaParcela));
            else
                Console.WriteLine(String.Format("O Valor da parcela ultrapassa o limite máximo de R$ {0}", valorMaximo));
        }
    }
}
