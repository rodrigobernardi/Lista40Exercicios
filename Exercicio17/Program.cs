using System;

namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            17. Entrar com dois números e imprimi-los em ordem crescente (suponha números diferentes). 
            
            */

            Console.WriteLine("Digite o primeiro valor: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero == segundoNumero)
                Console.WriteLine("Os números são identicos");
            else
            {
                int[] listaDeNumeros = new int[2];

                listaDeNumeros[0] = primeiroNumero;
                listaDeNumeros[1] = segundoNumero;

                Array.Sort(listaDeNumeros);

                Console.WriteLine("Ordem crescente: ");
                foreach (var item in listaDeNumeros)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

}
