using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            7. Construir um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo

            */

            Console.WriteLine("Digite o primeiro valor inteiro:");
            int primeiroNumeroDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int segundoNumeroDigitado = int.Parse(Console.ReadLine());

            int somar = primeiroNumeroDigitado + segundoNumeroDigitado;

            if (somar > 10)
                Console.WriteLine(String.Format("O soma dos números digitados ({0} e {1}) é {2}", primeiroNumeroDigitado, segundoNumeroDigitado, somar));

        }
    }
}
