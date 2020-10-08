using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            2. Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo desconto. 
            Faça um algoritmo que possa entrar com o valor de um produto e imprima o novo valor tendo em vista que 
            o desconto foi de 9%.
            
            */

            Console.WriteLine("Digite o valor do produto:");
            decimal valorDoProduto = decimal.Parse(Console.ReadLine());

            
            decimal valorDoProdutoComDesconto = valorDoProduto * 0.91M;
            Console.WriteLine(String.Format("O novo valor do produto com desconto de 9% é de R$ {0}", string.Format("{0:C}", valorDoProdutoComDesconto)));

            Console.ReadLine();
        }
    }
}
