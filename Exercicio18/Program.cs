using System;

namespace Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            18. Entrar com dois números e imprimi-los em ordem decrescente (suponha números diferentes).  
            
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


                // vi várias formas de fazer....
                // table = ints.OrderByDescending(x => x).ToArray();
                // Array.Sort(numbers, (a, b) => b - a);
                /*
                  
                 int[] array = new int[] { 3, 1, 4, 5, 2 };
                    Array.Sort<int>(array,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    )); 
                
                Array.Sort<int>( array,
                delegate(int a, int b)
                  {
                    return b - a; //Normal compare is a-b
                  }); 
                
                  
                */

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
