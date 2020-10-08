using System;
using System.IO;
using System.Linq;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            23. Efetuar a leitura de cinco números inteiros diferentes e identificar o maior e o menor valor. 
            
            */

            int[] listaDeNumeros = new int[5];

            byte indiceDoArray = 0;

            Console.WriteLine("Digite os valores:");
            while (indiceDoArray < 5)
            {
                listaDeNumeros[indiceDoArray] = int.Parse(Console.ReadLine());
                indiceDoArray++;
                Console.WriteLine("Digite o próximo valor:");
            }

            if (listaDeNumeros.All(i => i == listaDeNumeros[0]))
                Console.WriteLine("Os números são identicos");
            else
            {
                // elego o primeiro valor informado como sendo o maior, para realizar as comparações
                int maiorValor = listaDeNumeros.Max();
                Console.WriteLine(string.Format("O maior número digitado foi: {0}", maiorValor));

                int menorValor = listaDeNumeros.Min();
                Console.WriteLine(string.Format("O menor número digitado foi: {0}", menorValor));
            }
        }
    }
}
