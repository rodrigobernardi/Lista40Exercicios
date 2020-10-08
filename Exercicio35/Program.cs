using System;

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            35. Faça um programa que receba a idade de dez pessoas e que calcule e mostre a quantidade de pessoas com idade maior ou igual a 18 anos.
            
            */

            const byte totalPessoas = 10;

            byte[] idade = new byte[totalPessoas];

            for (int i = 0; i < totalPessoas; i++)
            {
                Console.WriteLine(string.Format("Informe a {0}ª idade:", i+1));
                idade[i] = byte.Parse(Console.ReadLine());
            }

            byte quantidadeMaioridade = 0;
            foreach (var item in idade)
            {
                if (item >= 18)
                    quantidadeMaioridade++;
            }

            Console.WriteLine("");
            Console.WriteLine(string.Format("O total de pessoas com idade igual ou superior a 18 anos é : {0}", quantidadeMaioridade));

        }
    }
}
