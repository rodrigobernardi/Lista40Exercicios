using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            14. Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se são iguais ou diferentes.
            
            */

            Console.WriteLine("Digite o primeiro valor: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero == segundoNumero)
                Console.WriteLine( string.Format("Os números informados são identicos: {0} e {1} ", primeiroNumero, segundoNumero));
            else
                Console.WriteLine(string.Format("Os números informados não são identicos: {0} e {1} ", primeiroNumero, segundoNumero));

        }
    }
}
