using System;

namespace Exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            27. Um restaurante esta fazendo uma promoção semanal de descontos para clientes 
                de acordo com as iniciar do nome da pessoa. Criar um algoritmo que leia o 
                primeiro nome do cliente, o valor de sua conta e se o nome iniciar com as 
                letras A, D, M ou S, dar um desconto de 30%. Para o cliente cujo nome não se 
                inicia por nenhuma dessas letras, exibir a mensagem 
                “Que pena. Nesta semana o desconto não é para seu nome; mas continue nos prestigiando que sua vez chegara”. 
            
            */

            Console.WriteLine("Informe o seu primeiro nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o valor de sua conta:");
            decimal valorDaConta = decimal.Parse(Console.ReadLine());

            decimal valorAPagar = 0;

            if (nome.StartsWith('A') || nome.StartsWith('D') || nome.StartsWith('M') || nome.StartsWith('S'))
                valorAPagar = valorDaConta * 0.70M;
                
            if (valorAPagar != 0)
                Console.WriteLine("Parabéns {0}. O seu nome está na lista de privilegiados com um desconto de 30% e o valor total da sua conta ficou em: R$ {1}", nome, valorAPagar);
            else
                Console.WriteLine("Que pena. Nesta semana o desconto não é para seu nome, mas continue nos prestigiando que sua vez chegara.");

        }
    }
}
