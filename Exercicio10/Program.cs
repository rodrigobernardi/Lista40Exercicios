using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            10. Construir um algoritmo que indique se o número digitado esta compreendido entre 20 e 90 ou não
            
            */
            const byte valorMinimo = 20;
            const byte valorMaximo = 90;

            Console.WriteLine("Informe um numero qualquer:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado >= valorMinimo && numeroDigitado <= valorMaximo)
                Console.WriteLine(String.Format("o número digitado \"{0}\" está dentro da faixa permitida ", numeroDigitado));
            else
                Console.WriteLine(String.Format("o número digitado \"{0}\" está fora da faixa permitida entre {1} e {2}", numeroDigitado, valorMinimo, valorMaximo));
        }
    }
}
