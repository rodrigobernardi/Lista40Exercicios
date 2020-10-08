using System;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            22. Entrar com três números e armazená-los em três variáveis com seguintes nomes: maior, intermediário e menor (suponha números diferentes). 

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
                int[] listaDeNumeros = new int[3];

                listaDeNumeros[0] = primeiroNumero;
                listaDeNumeros[1] = segundoNumero;
                listaDeNumeros[2] = terceiroNumero;

                Array.Sort(listaDeNumeros);

                int menor = listaDeNumeros[0];
                int intermediario = listaDeNumeros[1];
                int maior = listaDeNumeros[2];

                Console.WriteLine(string.Format("{0} é o maior número digitado", maior));
                Console.WriteLine(string.Format("{0} é o menor número digitado", menor));
                Console.WriteLine(string.Format("{0} é o número intermediário entre {1} e {2}", intermediario, menor, maior));


            }



        }
    }
}
