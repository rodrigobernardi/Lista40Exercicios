using System;

namespace Exercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            
            37.  faça um programa que mostre a tabuada dos números de 1 a 10. 
            
            */
            for (int tabuada = 1; tabuada <= 10; tabuada++)
            {
                for (int valores = 0; valores <= 10; valores++)
                {
                    Console.WriteLine(string.Format("{0} x {1} = {2}", tabuada, valores, tabuada * valores));
                }
                Console.WriteLine("");
            }
        }
    }
}
