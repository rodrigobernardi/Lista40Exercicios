using System;

namespace Exercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            25. Entrar com nome, nota da PR1 e nota da PR2 de um aluno, imprimir nome, nota da PR1, nota da PR2, 
                média e uma das mensagens: APROVADO, REPROVADO ou EXAME 
                ( a média é 7 para aprovação, menor que 3 para reprovação e as demais em exame). 
            
            */

            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o valor da nota da primeira prova: ");
            float pr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da nota da segunda prova: ");
            float pr2 = float.Parse(Console.ReadLine());

            float media = (pr1 + pr2) / 2;

            Console.WriteLine(string.Format("{0} a nota da primeira prova foi {1} e a nota da segunda prova foi {2} e a média foi {3}.", nome, pr1, pr2, media));

            if (media >= 7)
                Console.WriteLine("Aluno aprovado");
            else if (media < 3)
                Console.WriteLine("Aluno reprovado");
            else
                Console.WriteLine("Aluno em recuperação (exame)");
        }
    }
}
