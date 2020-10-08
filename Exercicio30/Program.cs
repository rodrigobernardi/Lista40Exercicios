using System;

namespace Exercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            30. Faça um programa que leia um valor n. inteiro e positivo, calcule e mostre a seguinte soma: 
                S  =  1  +  1/2  + 1/3  +   1/4  +  ...   + 1/n 

            */

            Console.WriteLine("Digite um valor inteiro");
            float numeroDigitado = float.Parse(Console.ReadLine());
            float soma = 1;

            if (numeroDigitado > 1)
            {
                
                do
                {
                    soma = soma + (1 / numeroDigitado); // sem o parse nao funcionou
                    numeroDigitado--;
                } while (numeroDigitado > 1);
            }

            Console.WriteLine(string.Format("Total da soma: {0}", soma));

        }
    }
}
