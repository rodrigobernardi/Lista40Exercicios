using System;
using System.Net;

namespace Exercicio34
{
    class Program
    {

        public class GlobalVariables
        {
            public static decimal valorIngresso { get; set; }
            public static ushort totalDeIngressosVendidos { get; set; }
            public static decimal totalDespesas { get; set; }
            public static decimal lucro { get; set; }
            public static decimal custoDe1Despesa { get; set; }

        }


        static void Main(string[] args)
        {
            /*
            
            34. Uma companhia de teatro deseja dar uma série de espetáculos. 
                A direção calcula que a R45,00 o ingresso serão vendidos 120 ingressos, 
                e que as despesas serão de R$200,00. Diminuindo-se R$0,50  o preço dos 
                ingressos espera-se que as vendas aumentem em 26 ingressos. 

                Faça um programa que escreva uma tabela de valores de lucros esperados em função do preço do ingresso, 
                fazendo-se variar esse preço de R$ 5,00 a R$ 1,00 de R$0,50 em R$0,50. 
                Escreva ainda o lucro máximo esperado, o preço do ingresso e a quantidade de ingressos vendidos para a obtenção desse lucro. 
            
            */

            // cenario 1:
            Console.WriteLine("Cenário 1 da Direção");

            GlobalVariables.valorIngresso = 45.00M;
            GlobalVariables.totalDeIngressosVendidos = 120;
            GlobalVariables.totalDespesas = 200.00M;
            GlobalVariables.lucro = (GlobalVariables.totalDeIngressosVendidos * GlobalVariables.valorIngresso) - GlobalVariables.totalDespesas;
            GlobalVariables.custoDe1Despesa = GlobalVariables.totalDespesas / GlobalVariables.totalDeIngressosVendidos;

            ExibirValores();


            // cenario 2:
            
            ushort aumentoIngressos = 26;
            GlobalVariables.valorIngresso = 44.50M;
            GlobalVariables.totalDeIngressosVendidos += aumentoIngressos;

            // calcular a nova total de despesas: 
            // entende-se que 120 ingressos vendidos geram uma despesa de R$ 200,00 (coresponde a R$ 1,66 por ingresso vendido)


            GlobalVariables.totalDespesas = GlobalVariables.custoDe1Despesa * GlobalVariables.totalDeIngressosVendidos;

            GlobalVariables.lucro = (GlobalVariables.totalDeIngressosVendidos * GlobalVariables.valorIngresso) - GlobalVariables.totalDespesas;
            
            Console.WriteLine("");
            Console.WriteLine("Cenário 2 da Direção");
            ExibirValores();


            // cenário calculado

            decimal variacao = 5.00M;
            decimal intervalo = 0.50M;
            

            do
            {

                GlobalVariables.valorIngresso -= intervalo;
                GlobalVariables.totalDeIngressosVendidos += aumentoIngressos;
                GlobalVariables.totalDespesas = GlobalVariables.custoDe1Despesa * GlobalVariables.totalDeIngressosVendidos;
                GlobalVariables.lucro = (GlobalVariables.totalDeIngressosVendidos * GlobalVariables.valorIngresso) - GlobalVariables.totalDespesas;

                // cenario 2:
                Console.WriteLine("");
                Console.WriteLine("Cenário calculado");
                ExibirValores();

                variacao -= intervalo;

            } while (variacao > 1);




        }

        private static void ExibirValores()
        {
            Console.WriteLine(string.Format("Valor do Ingresso R$ {0}", string.Format("{0:C}", GlobalVariables.valorIngresso)));
            Console.WriteLine(string.Format("Total de Ingressos vendidos: {0}", GlobalVariables.totalDeIngressosVendidos));
            Console.WriteLine(string.Format("Total de Despesas R$ {0}", string.Format("{0:C}", GlobalVariables.totalDespesas)));
            Console.WriteLine(string.Format("Lucro R$ {0}", string.Format("{0:C}", GlobalVariables.lucro)));
        }
    }
}
