using System;

namespace Exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            32. Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e mostre-os na ordem lida. Em seguida, mostre-os em ordem crescente e decrescente.  
            
            */

            int[,] grupos = new int[5, 4];

            Console.WriteLine("Digite cinco grupos com 4 valores cada (total de 20 valores)");
            for (int coluna = 0; coluna < 5; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {
                    grupos[coluna, linha] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Os 20 valores informados em ordem lida foram: ");
            // exibição em ordem lida
            for (int coluna = 0; coluna < 5; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {
                    Console.WriteLine(grupos[coluna, linha]);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Os 20 valores informados em ordem crescente: ");
            int[] arrayCrescente = new int[20];
            int posicao = 0;

            // exibição em ordem crescente
            for (int coluna = 0; coluna < 5; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {
                    arrayCrescente[posicao] = grupos[coluna, linha];
                    posicao++;
                }
            }

            Array.Sort(arrayCrescente);
            for (int coluna = 0; coluna < 20; coluna++)
            {
                Console.WriteLine(arrayCrescente[coluna]);
            }

            Console.WriteLine("");
            Console.WriteLine("Os 20 valores informados em ordem decrescente: ");
            int[] arrayDecrescente = new int[20];
            posicao = 0;

            // exibição em ordem decrescente
            for (int coluna = 0; coluna < 5; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {
                    arrayDecrescente[posicao] = grupos[coluna, linha];
                    posicao++;
                }
            }

            Array.Sort(arrayDecrescente);
            Array.Reverse(arrayDecrescente);
            for (int coluna = 0; coluna < 20; coluna++)
            {
                Console.WriteLine(arrayDecrescente[coluna]);
            }
        }
    }
}
