using System;

namespace Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            24. Entrar com a idade de uma pessoa e informar: 
            • Se é maior de idade 
            • Se é menor de idade 
            • Se é maior de 65 anos 
            
            */

            Console.WriteLine("Informe a sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());

            if (idade < 18)
                Console.WriteLine("Você é menor de idade.");
            else if (idade >= 18 && idade <= 65)
                Console.WriteLine("Você é maior de idade.");
            else // maior que 65...
                Console.WriteLine("Você tem mais de 65 anos de idade.");


        }
    }
}
