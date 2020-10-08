using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Exercicio38
{
    class Program
    {
        public class transacao
        {
            public char codigo { get; set; }
            public decimal valorCompra { get; set; }
        }

        static void Main(string[] args)
        {
            /*
            
            38. Uma loja utiliza um código V para transações à vista e P para transações à prazo. 
                Faça um programa que receba o código e o valor de 15 transações. 
                
                Calcule e mostre: 
                - valor total das compras à vista 
                - valor total das compras à prazo 
                - valor total das compras efetuadas 
                - valor da primeira prestação das compras à prazo, sabendo-se que essa serão pagas em três vezes. 
            
            */

            transacao[] transacoes = new transacao[15];

            for (int i = 0; i < 15; i++)
            {
                transacoes[i] = new transacao();

                Console.WriteLine("Informe o código da transação V (para á vista) ou P (para a prazo):");
                transacoes[i].codigo = Console.ReadLine()[0];

                Console.WriteLine("Informe o valor total da compra:");
                transacoes[i].valorCompra = decimal.Parse(Console.ReadLine());
            }

            transacao[] transacoesAVista = Array.FindAll(transacoes, t => t.codigo == 'V');
            decimal totalAVista = 0M;
            foreach (var item in transacoesAVista)
            {
                totalAVista += item.valorCompra;
            }
            Console.WriteLine(string.Format("Valor total de compras a vista: R$ {0}", string.Format("{0:C}", totalAVista)));


            transacao[] transacoesAPrazo = Array.FindAll(transacoes, t => t.codigo == 'P');
            decimal totalAPrazo = 0M;
            foreach (var item in transacoesAPrazo)
            {
                totalAPrazo += item.valorCompra;
            }
            Console.WriteLine(string.Format("Valor total de compras a prazo: R$ {0}", string.Format("{0:C}", totalAPrazo)));

            Console.WriteLine(string.Format("Valor total de compras efetuadas: R$ {0}", string.Format("{0:C}", totalAVista + totalAPrazo)));

            Console.WriteLine("Para compras a prazo: ");
            decimal[] primeiraParcelaAPrazo = new decimal[transacoesAPrazo.Count()];
            for (int i = 0; i < transacoesAPrazo.Count(); i++)
            {
                primeiraParcelaAPrazo[i] = transacoesAPrazo[i].valorCompra / 3;
            }

            foreach (var item in primeiraParcelaAPrazo)
            {
                Console.WriteLine(string.Format("Valor da primeira parcela: R$ {0}", string.Format("{0:C}", item)));
            }
        }
    }
}
