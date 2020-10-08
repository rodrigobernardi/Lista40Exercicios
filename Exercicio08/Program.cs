using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            8. Construir um algoritmo que leia dois números e efetue a adição. 
               Caso o valor somado seja maior que 20, este devera ser apresentado somando-se a ele mais 8; 
               caso o valor somado seja menor ou igual a 20, este devera ser apresentado subtraindo-se 5. 
            
            */

            Console.WriteLine("Digite o primeiro valor inteiro:");
            int primeiroNumeroDigitado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int segundoNumeroDigitado = int.Parse(Console.ReadLine());

            int resultadoSoma = primeiroNumeroDigitado + segundoNumeroDigitado;

            if (resultadoSoma > 20)
                resultadoSoma += 8;
            else
                resultadoSoma -= 5;

            Console.WriteLine(String.Format("O número somado (e calculado) é {0}", resultadoSoma));

        }
    }
}
