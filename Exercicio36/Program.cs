using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            36. Faça um programa que receba idade de 15 pessoas e que calcule e mostre: 
            - a quantidade de pessoas em cada faixa etária  
            - a percentagem de pessoas na primeira e na última faixa etária, com relação ao total de pessoas. 
 
           Faixa etária Idade 
            1           Até 15 anos 
            2           De 16 a 30 anos 
            3           De 31 a 45 anos 
            4           De 46 a 60 anos 
            5           Acima de 61 anos  
 
            
            */


            const byte totalPessoas = 15;

            byte[] idade = new byte[totalPessoas];

            for (int i = 0; i < totalPessoas; i++)
            {
                Console.WriteLine(string.Format("Informe a {0}ª idade:", i + 1));
                idade[i] = byte.Parse(Console.ReadLine());
            }

            byte faixa1 = 0;
            byte faixa2 = 0;
            byte faixa3 = 0;
            byte faixa4 = 0;
            byte faixa5 = 0;

            foreach (var item in idade)
            {
                if (item <= 15)
                    faixa1++;
                else
                if (item >= 16 && item <= 30)
                    faixa2++;
                else
                if (item >= 31 && item <= 45)
                    faixa3++;
                else
                if (item >= 46 && item <= 60)
                    faixa4++;
                else
                if (item >= 61)
                    faixa5++;
            }

            Console.WriteLine("");
            Console.WriteLine(string.Format("O total de pessoas na Faixa 1 com Até 15 anos é {0} e correspondente a um percentual geral de {1}%", faixa1, (100 * faixa1) / 15));
            Console.WriteLine(string.Format("O total de pessoas na Faixa 2 De 16 a 30 anos é {0} e correspondente a um percentual geral de {1}%", faixa2, (100 * faixa2) / 15));
            Console.WriteLine(string.Format("O total de pessoas na Faixa 3 De 31 a 45 anos é {0} e correspondente a um percentual geral de {1}%", faixa3, (100 * faixa3) / 15));
            Console.WriteLine(string.Format("O total de pessoas na Faixa 4 De 46 a 60 anos é {0} e correspondente a um percentual geral de {1}%", faixa4, (100 * faixa4) / 15));
            Console.WriteLine(string.Format("O total de pessoas na Faixa 5 Acima de 61 anos é {0} e correspondente a um percentual geral de {1}%", faixa5, (100 * faixa5) / 15));
        }
    }
}

