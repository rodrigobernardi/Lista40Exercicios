using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

             19. Entrar com três números e imprimir o maior numero (suponha números diferentes). 

             */

            Console.WriteLine("Digite o primeiro valor: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int terceiroNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero == segundoNumero && segundoNumero == terceiroNumero)
                Console.WriteLine("Os números são identicos");
            else
            {
                // elego o primeiro valor informado como sendo o maior, para realizar as comparações
                int maiorValor = primeiroNumero;

                if (maiorValor < segundoNumero)
                    maiorValor = segundoNumero;

                if (maiorValor < terceiroNumero)
                  maiorValor = terceiroNumero;

                Console.WriteLine(string.Format("O maior número digitado foi: {0}", maiorValor));
            }
        }
    }
}
