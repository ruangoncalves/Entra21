using System;
using System.Globalization;
using System.Linq;
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

        // Questão 5
        // Solicite ao usuário que informe 5 números e armazene em um array. Toda vez que o usuário digitar um valor inválido,
        // a aplicação deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.
        static void Questao5()
        {
            double?[] array = new double?[5];

            for(int i = 0;i < array.Length;i++)
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    array[i] = double.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    array[i] = null;
                }
            }
            foreach(double a in array)
            {
                if(a is double valueOfA)
                {
                    Console.WriteLine(a);
                }
            }    
        }

        // Questão 6
        // Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. A aplicação será encerrada quando o usuário
        // digitar a palavra "calcular". Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente. 
        static void Questao6()
        {
            int func = 0;
            string sal = "";
            double sum = 0.0;
            double mid = 0.0;

            while(true)
            {
                Console.WriteLine("Digite seu salario R$ ");
                sal = Console.ReadLine();
                if(sal == "calcular")
                {
                    break;
                }                
                double conv = double.Parse(sal);
                if(conv >= 0.0)
                {
                    sum += conv;
                    func++;
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                }
            }
            mid = sum / func;
            Console.WriteLine("A média salaria é R$ " + mid.ToString("f2", CultureInfo.InvariantCulture));

        }

        //Questão 7
        //Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. A aplicação deverá mostrar uma lista com todas as opções para o usuário,
        // e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. Ao final a aplicação deverá mostrar a
        //porcentagem de usuários que nasceram em Santa Catarina.
        static void Questao7()
        {
            const int users = 5;
            string[] repUser = new string [users];
            double percent = 0.0;
            int sum = 0;
            string[,] UF = new string[27,2] {{"11", "RO"},
                                            {"12", "AC"},
                                            {"13", "AM"},
                                            {"14", "RR"},
                                            {"15", "PA"},
                                            {"16", "AP"},
                                            {"17", "TO"},
                                            {"21", "MA"},
                                            {"22", "PI"},
                                            {"23", "CE"},
                                            {"24", "RN"},
                                            {"25", "PB"},
                                            {"26", "PE"},
                                            {"27", "AL"},
                                            {"28", "SE"},
                                            {"29", "BA"},
                                            {"31", "MG"},
                                            {"32", "ES"},
                                            {"33", "RJ"},
                                            {"35", "SP"},
                                            {"41", "PR"},
                                            {"43", "RS"},
                                            {"42", "SC"},
                                            {"50", "MS"},
                                            {"51", "MT"},
                                            {"52", "GO"},
                                            {"53", "DF"}};

            for(int i = 0;i < users;i++){
                Console.WriteLine("Qual dos estados abaixo representa o seu estado de nascimento \nID - UF");
                for(int j = 0;j < 27;j++){
                    Console.WriteLine($"{UF[j,0]} - {UF[j,1]}");
                }
                Console.Write("Digite a ID: ");
                repUser[i] = Console.ReadLine();
            }
            for(int u = 0;u < repUser.Length;u++){
                if(repUser[u] == "42"){
                    sum++;
                }
            }
            percent = (sum * 100) / users;
            Console.WriteLine($"{percent.ToString("f2",CultureInfo.InvariantCulture)}% das pessoas consultadas são de SC");
        }

        // Questão 8
        // Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. Cada turma possui 5 alunos.
        // Armazene os nomes em dois arrays distintos de forma alternada, ou seja, o primeiro nome deve ser armazenado no array da Matutino,
        // o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante. Ao final imprima apenas os nomes dos alunos que 
        // estão estudando em período integral. Caso nenhum aluno esteja cadastrado em ambas as turmas, imprimir a mensagem “todos os alunos estudam em meio período”.
        static void Questao8()
        {
            string[] tm = new string[5];
            string[] tv = new string[5];
            int cont1 = 0;
            int cont2 = 0;
            string name = "";
            
            for(int i = 0;i < 10;i++){
                Console.WriteLine("Digite o seu nome");
                name = Console.ReadLine();

                if(i % 2 == 0){
                    tm[cont1] = name;
                    cont1++;
                }
                else if(i % 2 != 0){
                    tv[cont2] = name;
                    cont2++;
                }
            }
            string[] diff = tm.Except(tv).ToArray();
            if(diff != null)
            {
                Console.Write("Alunos em período integral: ");
                foreach(var a in diff)
                {
                    Console.Write($"{a}, ");
                }
            }
            else
            {
                Console.WriteLine($"Todos os alunos estudam em meio período");
            }                       
        }
    }
}
