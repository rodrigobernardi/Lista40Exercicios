using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            12. Entrar com nome, sexo e idade de uma pessoa. 
            Se a pessoa for do sexo feminino e tiver menos que 25 anos, imprimir nome e a mensagem: ACEITA. Caso contrário, imprimir nome e a mensagem: NÃO ACEITA. 
            
            */

            Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();

            char sexo = ' ';

            while (sexo != 'F' && sexo != 'M') {
                Console.WriteLine("Informe M para Masculino ou F para Feminino:");
                string valorDigitado = Console.ReadLine();
                sexo = valorDigitado != "" ? valorDigitado[0] : ' ';
            }

            Console.WriteLine("Informe a sua idade:");
            byte idade = byte.Parse(Console.ReadLine());

            if (sexo == 'F' && idade < 25)
                Console.WriteLine(String.Format("{0}, seu cadastro está aprovado (ACEITA).", nome));
            else
                Console.WriteLine(String.Format("Desculpe {0}, seu cadastro foi regeitado (NÃO ACEITA).", nome));

        }
    }
}
