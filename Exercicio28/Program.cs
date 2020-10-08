using System;
using System.Linq;

namespace Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            28. A policia rodoviária resolveu fazer cumprir a lei e cobrar dos motoristas a DUT. 
                Sabendo-se que o mês em que o emplacamento do carro deve ser renovado é determinado 
                pelo último número da placa do mesmo, criar um algoritmo que, a partir da leitura da placa do carro, 
                informe o mês em que o emplacamento deve ser renovado. 

            fonte: https://autopapo.uol.com.br/noticia/taxa-de-licenciamento-2020-valor/
            
            */
            Console.WriteLine("Digite o número da sua placa:");
            string placaDoVeiculo = Console.ReadLine();

            char numeroFinalPlacaCarro = placaDoVeiculo[placaDoVeiculo.Length - 1];

            string mesEmplacamento = "";

            switch (numeroFinalPlacaCarro)
            {
                case '1':
                    mesEmplacamento = "Abril";
                    break;

                case '2':
                    mesEmplacamento = "Maio";
                    break;

                case '3':
                    mesEmplacamento = "Junho";
                    break;

                case '4':
                    mesEmplacamento = "Julho";
                    break;

                case '5': case '6':
                    mesEmplacamento = "Agosto";
                    break;

                case '7':
                    mesEmplacamento = "Setembro";
                    break;

                case '8':
                    mesEmplacamento = "Outubro";
                    break;

                case '9':
                    mesEmplacamento = "Novembro";
                    break;

                case '0':
                    mesEmplacamento = "Dezembro";
                    break;

                default:
                    Console.WriteLine("Não foi possível identificar o último digito numérico da placa informada.");
                    break;
            }

            if (mesEmplacamento != "")
                Console.WriteLine(string.Format("O mês em que o emplacamento deve ser renovado é: {0}", mesEmplacamento));
        }
    }
}
