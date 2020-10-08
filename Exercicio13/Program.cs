using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            13. Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens: 
            • Carioca 
            • Paulista 
            • Mineiro 
            • Outros estados
            
            */

            Console.WriteLine("Informe a sigla do seu estado:");
            string estado = Console.ReadLine().ToUpper();

            switch (estado)
            {
                case "RJ": 
                    Console.WriteLine("Nascidos no estado do Rio de Janeiro são Cariocas");
                    break;

                case "SP": 
                    Console.WriteLine("Nascidos no estado de São Paulo são Paulistas");
                    break;

                case "MG": 
                    Console.WriteLine("Nascidos no estado de Minas Gerais são Mineiros");
                    break;

                default:
                    Console.WriteLine("Outro estado");
                    break;
            }
        }
    }
}
