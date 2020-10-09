using System;
using System.Globalization;
using System.Linq;

namespace Entra21_exercicios_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            exe6();            
        }

        //---------exercicio 1
        static void exe1(){

            var arrayA = new int[15];
            var arrayB = new int[15];
            var arrayC = new int[15];

            Random rNum = new Random();

            for (int i = 0;i < arrayA.Length;i++){
                arrayA[i] = rNum.Next(30,60);
                arrayB[i] = rNum.Next(1,25);
            }

            for(int x = 0;x < arrayC.Length;x++){
                arrayC[x] = arrayA[x] - arrayB[x];
                Console.WriteLine(arrayC[x]);
            }
        }

        //---------exercicio 2
        static void exe2(){

            int[] num = new int[10];

            for(int k = 0;k < 10;k++){
                Console.WriteLine("Digite um numero");
                num[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros na ordem de entrada");
            for(int a = 0;a < 10;a++){
                Console.WriteLine(num[a]);
            }
            Console.WriteLine("Numeros na ordem contrária");
            for(int b = 9;b > -1;b--){
                Console.WriteLine(num[b]);
            }
        }

        //---------exercicio 3
        static void exe3(){

            int[] num = {2,5,9,14,25,37,46,69,71,94};
            string msg = "";

            Console.WriteLine("Digite o numero a ser pesquisado");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0;i <= num.Length;i++){
                if(a == num[i]){
                    msg = "O número existe";
                }
                else{
                    msg = "O número não existe";
                }
            }
            Console.WriteLine(msg);
        }

        //---------exercicio 4
        static void exe4(){

            int[] tabA = {2,5,9,14,25,37,46,69,71,94};
            int[] tabB = {1,5,12,16,25,39,46,70,75,94};

            for(int x = 0;x < tabA.Length;x++){
                if(tabA[x] == tabB[x]){
                    Console.WriteLine("São iguais");
                }
                else{
                    Console.WriteLine("Não são iguais");
                }
            }
        }

        //---------exercicio 5
        static void exe5(){

            int[] notas = {5,8,10,6,2,4,1,3,7,9,4,7,9,2,8};
            int sum = 0;
            int upMed = 0;
            int downMed = 0;

            for(int i = 0;i < notas.Length;i++){
                sum += notas[i];
            }
            double med = sum / notas.Length;
            Console.WriteLine($"A média é {med.ToString("f2", CultureInfo.InvariantCulture)}");

            for(int i = 0;i < notas.Length;i++){
                if(notas[i] < med){
                    downMed++;
                }
                else{
                    upMed++;
                }
            }
            Console.WriteLine($"Notas acima da média {upMed}");
            Console.WriteLine($"Notas abaixo da média {downMed}");
        }

        //---------exercicio 6
        static void exe6(){

            int[] arrayA = {100,5,25,17,43,20,231,69,150,30,47,2};
            int[] ordArrayA = arrayA.OrderBy(x => x).ToArray();
            foreach(var a in ordArrayA){
                Console.WriteLine(a);
            }
            int[] arrayB = {21,54,2,33,7,91,44,75,15,31,127,3};
            int[] decArrayB = arrayB.OrderByDescending(h => h).ToArray();
            Console.WriteLine();
            foreach(var b in decArrayB){
                Console.WriteLine(b);
            }
            int[] arrayC = new int[12];
            for(int i = 0;i < arrayC.Length;i++){
                arrayC[i] = arrayA[i] + arrayB[i];
            }
            int[] ordArrayC = arrayC.OrderBy(s => s).ToArray();
            Console.WriteLine();
            foreach(var c in ordArrayC){
                Console.WriteLine(c);
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