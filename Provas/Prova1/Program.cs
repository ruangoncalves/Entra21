using System;
using System.Globalization;
using System.Text;

namespace Prova1_parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao4();
        }

        static void Questao1()
        {
            Console.WriteLine("Quantas horas você trabalha por dia (Ex: 8 = 8 / 8:15 = 8,25 / 8:30 = 8,50 / 8:45 = 8,75)");
            double horaTrabalho = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor da sua hora/trabalho (Ex: R$ 10,00)");
            double valorHora = double.Parse(Console.ReadLine());
            double valorDia = horaTrabalho * valorHora;
            Console.WriteLine("Você ganha em um dia de trabalho R$ " +valorDia.ToString("f2", CultureInfo.InvariantCulture));
        }

        static void Questao2()
        {
            string verify = "";
            StringBuilder msg = new StringBuilder();

            while(true)
            {
                Console.WriteLine("Digite uma letra para formar a palavra");
                string letra = Console.ReadLine();
                if(letra == "Finalizar")
                {
                    break;
                }
                verify = letra;
                msg.Append(verify);
            }
            Console.Write(msg);
        }

        static void Questao2Alt()
        {
            string world = "";
            
            while(true)
            {
                Console.WriteLine("Digite uma letra para formar a palavra");
                string letter = Console.ReadLine();
                if(letter == "Finalizar")
                {
                    break;
                }
                world += letter;
            }
            Console.Write(world);
        }

        static void Questao3()
        {
            string[] name = new string [5];
            string[] sit = new string [5];

            for(int i = 0;i < name.Length;i++)
            {
                Console.WriteLine("Qual seu nome");
                name[i] = Console.ReadLine();
                Console.WriteLine("Solteiro (sim / nao)");
                sit[i] = Console.ReadLine();
            }
            for(int i = 0;i < name.Length;i++)
            {
                if(sit[i] == "sim"){
                    Console.WriteLine(name[i]);
                }
            }
        }

        static void Question3Prof()
        {
            var singleMen = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu nome");
                var name = Console.ReadLine();
                Console.WriteLine("Você é solteiro?");
                var isSingle = Console.ReadLine();
                if (isSingle == "sim")
                {
                    singleMen.Append($"{name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);
            Console.WriteLine($"Todos os solteiros: {singleMen}");
        }
       static void Questao4()
          {
            int input = 0;
            Console.WriteLine("Qual seu ano de nascimento?");

            while(true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    break;
                }
                catch(SystemException)
                {
                    Console.WriteLine("Valor inválido, tente novamente");
                }
            }
            if(input < 2002)
            {
                Console.WriteLine("você é maior de idade");
            }
            else
            {
                Console.WriteLine("você é menor de idade");
            }
        }
    }
}
