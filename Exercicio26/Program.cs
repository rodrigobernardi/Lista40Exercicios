using System;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            26. Um comerciante comprou um produto e quer vende-lo com um lucro de 45% 
                se o valor da compra for menor que R$ 20,00; caso contrario, 
                o lucro será de 30%. Entrar com o valor do produto e imprimir o valor da venda. 
            
            */

            Console.WriteLine("Informe o valor do produto:");
            decimal valorDoProduto = decimal.Parse(Console.ReadLine());

            int valorDoLucro = valorDoProduto < 20 ? 45 : 30;
            decimal valorDeVenda = valorDoProduto < 20 ? (valorDoProduto * 1.45M) : (valorDoProduto * 1.30M);

            Console.WriteLine(string.Format("Valor de venda do produto com lucro de {0}%: R$ {1}", valorDoLucro, valorDeVenda));
        }
    }
}
