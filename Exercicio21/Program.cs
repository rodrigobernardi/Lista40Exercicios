using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            21. Entrar com três números e imprimi-los em ordem decrescente (suponha números diferentes). 
            
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
                Array.Reverse(listaDeNumeros);

                Console.WriteLine("Ordem decrescente: ");
                foreach (var item in listaDeNumeros)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
