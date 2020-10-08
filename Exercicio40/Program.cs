using System;

namespace Exercicio40
{
    class Program
    {
        public class pessoa
        {
            public byte idade { get; set; }
            public float peso { get; set; }
        }

        static void Main(string[] args)
        {
            /*
            
            40. Faça um programa que receba a idade e o peso de sete pessoas. Calcule e mostre: 
            - a quantidade de pessoas com mais de 90 quilos 
            - a média das idades das sete pessoas 
            
            */

            const byte totalPessoasLidas = 7;

            pessoa[] pessoas = new pessoa[totalPessoasLidas];

            byte totalPessoasComMaisDe90Quilos = 0;

            float mediaDasIdades = 0;

            for (int i = 0; i < pessoas.Length; i++)
            {
                pessoas[i] = new pessoa();

                Console.WriteLine(string.Format("Para a {0}º pessoa: ", i + 1));

                Console.WriteLine("Informe a idade: ");
                pessoas[i].idade = byte.Parse(Console.ReadLine());

                mediaDasIdades += pessoas[i].idade;

                Console.WriteLine("Informe o peso: ");
                pessoas[i].peso = float.Parse(Console.ReadLine());

                if (pessoas[i].peso > 90)
                    totalPessoasComMaisDe90Quilos++;

                Console.WriteLine("");
            }

            Console.WriteLine(string.Format("O total de pessoas com mais de 90 Quilos é: {0}", totalPessoasComMaisDe90Quilos));

            Console.WriteLine(string.Format("A média das idades das pessoas lidas são: {0}", mediaDasIdades / totalPessoasLidas));            
        }
    }
}
