using System;

namespace Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            29. Faça um programa que verifique e mostre os números entre 1.000 e 2.000 (inclusive) que, quando divididos por 11 produzam resto igual a 5. 
            
            */

            for (int i = 1000; i <= 2000; i++)
            {
                if (i % 11 == 5)
                    Console.WriteLine(string.Format("o número {0} produz um resto 5 se dividido por 11", i));
            }
        }
    }
}
