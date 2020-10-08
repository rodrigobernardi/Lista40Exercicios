using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio33
{
    class Program
    {
        public class cliente
        {
            public string nome { get; set; }
            public decimal valorCompra { get; set; }
        }

        static void Main(string[] args)
        {
            /*
            
            33. Uma loja tem 15 clientes cadastrados e deseja enviar uma 
                correspondência a cada um deles anunciando um bônus especial. 
                Faça um programa que leia o nome do cliente e o valor das 
                suas compras no ano passado. Calcule e mostre um bônus de 10% 
                se o valor das compras for menor que R$1.000,00 e de 15% 
                caso seja maior do que R$ 1.000,00. 
            
            */

            cliente[] clientes = new cliente[15];

            /* para gerar valores aleatorios
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
              stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            
            // p/ numeros:

            Random rnd = new Random();

            Console.WriteLine("Generating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
               Console.WriteLine($"{rnd.Next(),15:N0}");

            // The example displays output like the following:
            //
            //     Generating 10 random numbers:
            //         1,733,189,596
            //           566,518,090
            //         1,166,108,546
            //         1,931,426,514
            //         1,532,939,448
            //           762,207,767
            //           815,074,920
            //         1,521,208,785
            //         1,950,436,671
            //         1,266,596,666

            */


            for (int i = 0; i < 15; i++)
            {
                clientes[i] = new cliente();

                Console.WriteLine("Informe o nome do cliente:");
                clientes[i].nome = Console.ReadLine();

                Console.WriteLine("Informe o valor total das compras realizadas no ano passado:");
                clientes[i].valorCompra = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Calcular o bônus:");

            // calcular bonus
            byte valorBonus;
            foreach (cliente c in clientes)            
            {
                if (c.valorCompra < 1000)
                    valorBonus = 10;
                else
                    valorBonus = 15;

                Console.WriteLine(string.Format("Cliente {0} ganhou um bônus no valor de {1}%.", c.nome, valorBonus));
            }



        }
    }
}
