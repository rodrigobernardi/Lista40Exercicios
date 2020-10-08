using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            11. Entrar com um número e imprimir uma das mensagens: maior do que 20, igual a 20 ou menor do que 20.
            
            */

            const byte valorLimite = 20;

            Console.WriteLine("Informe um numero qualquer:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado < valorLimite)
              Console.WriteLine(String.Format("o número digitado \"{0}\" é menor que {1}.", numeroDigitado, valorLimite)); 
            else if (numeroDigitado == valorLimite)
              Console.WriteLine(String.Format("o número digitado \"{0}\" é igual a {1}.", numeroDigitado, valorLimite));
            else // if (numeroDigitado > valorLimite)
                Console.WriteLine(String.Format("o número digitado \"{0}\" é maior que {1}.", numeroDigitado, valorLimite));

        }
    }
}
