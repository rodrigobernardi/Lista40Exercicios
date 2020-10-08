using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            3. Criar um algoritmo que efetue o cálculo do salário líquido de um professor. 
            Os dados fornecidos serão: valor da hora aula, numero de aulas dadas no mês 
            e percentual de desconto do INSS. 

            */

            Console.WriteLine("Informe o valor da hora/aula:");
            decimal valorHoraAula = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de aulas dadas nesse mês:");
            ushort quantidadeDeAulasNoMes = ushort.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de desconto do INSS:");
            decimal percentualDeDescontoINSS = decimal.Parse(Console.ReadLine());

            decimal salarioLiquido = (valorHoraAula * quantidadeDeAulasNoMes) * ((100 - percentualDeDescontoINSS)/100);

            Console.WriteLine(String.Format("O salário liquido calculado com desconto de {0} % de INSS é de R$ {1}", percentualDeDescontoINSS, string.Format("{0:C}", salarioLiquido)));

            Console.ReadLine();


        }
    }
}
