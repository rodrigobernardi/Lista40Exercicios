using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            16. Entrar com dois números e imprimir o menor numero (suponha números diferentes). 
            
            */

            Console.WriteLine("Digite o primeiro valor: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int segundoNumero = int.Parse(Console.ReadLine());
        
            if (primeiroNumero == segundoNumero)
                Console.WriteLine("Os números são identicos");
            else
            {
                // elego o primeiro valor informado como sendo o maior, para realizar as comparações
                int menorValor = primeiroNumero;

                if (segundoNumero < menorValor)
                    menorValor = segundoNumero;

                //                sem usar lista, a lógica que uso para encontrar o maior número é essa...
                //                if (terceiroNumero < menorValor)
                //                    menorValor = terceiroNumero;

                //                if (quartoNumero < menorValor)
                //                    menorValor = quartoNumero;

                Console.WriteLine(string.Format("O menor número digitado foi: {0}", menorValor));
            }
        }
    }
}
