using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            15. Entrar com dois números e imprimir o maior numero (suponha números diferentes). 
            
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
                int maiorValor = primeiroNumero;

                if (maiorValor < segundoNumero)
                    maiorValor = segundoNumero;

                //                sem usar lista, a lógica que uso para encontrar o maior número é essa...
                //                if (maiorValor < terceiroNumero)
                //                    maiorValor = terceiroNumero;

                //                if (maiorValor < quartoNumero)
                //                    maiorValor = quartoNumero;

                Console.WriteLine(string.Format("O maior número digitado foi: {0}", maiorValor));
            }

        }
    }
}
