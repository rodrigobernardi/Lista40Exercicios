using System;

namespace Exercicio39
{
    class Program
    {
        public class pessoa
        {
            public byte idade { get; set; }
            public float altura { get; set; }
            public float peso { get; set; }
        }


        static void Main(string[] args)
        {
            /*
            
            39. Faça um programa que receba a idade, altura e peso de 25 pessoas e calcule e mostre: 
            - quantidade de pessoas com idade superior a 50 anos 
            - média das alturas das pessoas com idade entre 10 e 20 anos 
            - percentagem de pessoas com peso inferior a 40 quilos entre todas as pessoas analisadas 
            
            */
            const byte totalPessoasLidas = 15;

            pessoa[] pessoas = new pessoa[totalPessoasLidas];

            byte idadeMaior50Anos = 0;

            byte totalPessoasEntre10e20anos = 0;
            float mediaAlturaPessoasEntre10e20anos = 0;

            byte totalPessoaspesoInferior40Quilos = 0;


            for (int i = 0; i < pessoas.Length; i++)
            {
                pessoas[i] = new pessoa();

                Console.WriteLine(string.Format("Para a {0}º pessoa: ", i+1));

                Console.WriteLine("Informe a idade: ");
                pessoas[i].idade = byte.Parse(Console.ReadLine());

                if (pessoas[i].idade > 50)
                    idadeMaior50Anos++;

                Console.WriteLine("Informe a altura: ");
                pessoas[i].altura = float.Parse(Console.ReadLine());

                if (pessoas[i].idade >= 10 && pessoas[i].idade <= 20)
                {
                    mediaAlturaPessoasEntre10e20anos += pessoas[i].altura;
                    totalPessoasEntre10e20anos++;
                }

                Console.WriteLine("Informe o peso: ");
                pessoas[i].peso = float.Parse(Console.ReadLine());

                if (pessoas[i].peso < 40)
                    totalPessoaspesoInferior40Quilos++;

                Console.WriteLine("");
            }

            Console.WriteLine(string.Format("O total de pessoas com idade superior a 50 anos é: {0}", idadeMaior50Anos));

            Console.WriteLine(string.Format("A média das alturas das pessoas com idade entre 10 e 20 anos é: {0}", mediaAlturaPessoasEntre10e20anos / totalPessoasEntre10e20anos));

            Console.WriteLine(string.Format("O total de pessoas com percentagem de pessoas com peso inferior a 40 quilos é: {0}%", (totalPessoaspesoInferior40Quilos * 100) / totalPessoasLidas));
        }
    }
}
