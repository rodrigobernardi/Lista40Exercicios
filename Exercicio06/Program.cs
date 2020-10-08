using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Entrar com um número e imprimi-lo caso seja maior que 20

            Console.WriteLine("Digite um número qualquer:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado > 20)
                Console.WriteLine(String.Format("O número digitado é {0}", numeroDigitado));

        }
    }
}
