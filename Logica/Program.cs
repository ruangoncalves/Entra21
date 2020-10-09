using System;
using System.Linq;

using System.Globalization;

namespace Entra21_exercicios_logica
{
    class Program
    {

        //-------exercicio 1
        static void exe1(){

            for(int i = 1;i < 11;i++){
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int i = 10;i > 0;i--){
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int i = 0;i < 11;i++){
                if(i % 2 == 0){
                    Console.WriteLine(i);
                } 
            }
        }
            
        //-------exercicio 2
        static void exe2(){

            int som = 0;

            for(int i = 0;i < 100;i++){
                som += i;
            }
            Console.WriteLine(som);
        }

        //-------exercicio 3
        static void exe3(){

            for(int i = 0;i < 201;i++){
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }  
            }
        }

        //-------exercicio 4
        static void exe4()
        {
            int sum = 0;
            int age = 1;
            int count = 0;

            while(age != 0 )
            {
                Console.WriteLine("Digite sua idade");
                age = int.Parse(Console.ReadLine());
                sum += age;
                if(age != 0){
                    count++;
                }
            }
            double mid = ((double)sum / count);
            Console.WriteLine(mid);
        }

        //-------exercicio 5
        static void exe5(){

            Console.WriteLine("Quantas pessoas serão verificadas");
            int qttWom = int.Parse(Console.ReadLine());
            string[] name = new string[qttWom];
            int[] age = new int[qttWom];

            for(int i = 0;i < qttWom;i++){
                Console.WriteLine("Name:");
                name[i] = Console.ReadLine();
                Console.WriteLine("Age:");
                age[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (var a in age)
            {
                if(a >= 18 && a <= 35)
                sum+= a;
            }
            double perc = (sum * 100) / qttWom;
            Console.WriteLine(perc);
        }
            
        //-------exercicio 6
        static void exe6(){

            int init = 0;
            string senha = "";
            string nomPriCand = "";
            string nomSegCand = "";
            int vot = 0;
            int votPriCand = 0;
            int votSegCand = 0;
        
            Console.WriteLine("URNA ELETRÔNICA");
            Console.WriteLine();

            while (init != 100)
            {
                Console.WriteLine();
                Console.WriteLine("PARA: \n CADASTRAR CANDIDATOS - DIGITE 10 \n VOTAR - DIGITE 20 \n APURAR VOTOS - DIGITE 30 \n FINALIZAR PROGRAMA - DIGITE 100");

                init = int.Parse(Console.ReadLine());

                if (init == 10)
                {
                    while (senha != "Pa$$w0rd")
                    {
                        Console.WriteLine("SENHA:");
                        senha = Console.ReadLine();
                        if(senha != "Pa$$w0rd")
                        {
                            Console.WriteLine("SENHA INCORRETA, TENTE NOVAMENTE");
                        }
                    }
                    Console.WriteLine("DIGITE O NOME DO PRIMEIRO CANDIDATO");
                    nomPriCand = Console.ReadLine();
                    Console.WriteLine("DIGITE O NOME DO SEGUNDO CANDIDATO");
                    nomSegCand = Console.ReadLine();
                    Console.WriteLine("CADASTRO REALIZADO");
                    Console.WriteLine();
                }
                else if ((init == 20) && (nomPriCand != "") && (nomSegCand != ""))
                {
                    while (vot != 99) {

                        Console.WriteLine();
                        Console.WriteLine($"DIGITE SEU VOTO DE ACORDO COM AS INFORMÇÕES ABAIXO \n {nomPriCand} DIGITE 1 \n {nomSegCand} DIGITE 2 \n PARA FINALIZAR A VOTAÇÃO DIGITE 99");
                        Console.WriteLine();
                        vot = int.Parse(Console.ReadLine());

                        if (vot == 1)
                        {
                            Console.WriteLine("OBRIGADO");
                            votPriCand++;
                        }
                        else if (vot == 2)
                        {
                            Console.WriteLine("OBRIGADO");
                            votSegCand++;
                        }
                        else if (vot == 99)
                        {
                            Console.WriteLine("ENCERRADO");
                        }
                        else
                        {
                            Console.WriteLine("ALGO DEU ERRADO, DIGITE NOVAMENTE");
                        }
                    }
                }
                else if ((init == 30) && (votPriCand != 0) && (votSegCand != 0))
                {
                    if(votPriCand == votSegCand)
                    {
                        Console.WriteLine();
                        Console.WriteLine("EMPATE, HAVERÁ SEGUNDO TURNO");
                        Console.WriteLine();
                        init = 100;
                    }
                    else if(votPriCand > votSegCand)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O VENCEDOR FOI " + nomPriCand);
                        Console.WriteLine();
                        init = 100;
                    }
                    else if (votPriCand < votSegCand)
                    {
                        Console.WriteLine();
                        Console.WriteLine("O VENCEDOR FOI " + nomSegCand);
                        Console.WriteLine();
                        init = 100;
                    }
                }
                else if ((init == 20) && ((nomPriCand == "") || (nomSegCand == "")))
                {
                    Console.WriteLine("O SISTEMA AINDA NÃO POSSUÍ CANDIDATOS CADASTRADOS");
                }
                else if ((init == 30) && ((votPriCand == 0) || (votSegCand == 0)))
                {
                    Console.WriteLine("O SISTEMA AINDA NÃO CONTABILIZOU NENHUM VOTO PARA APURAR");
                }
            }
        }

        //-------exercicio 7
        static void exe7(){

            Console.WriteLine("How many years of smoker?");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cigarettes a day?");
            int smkDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Price of Wallet");
            double walPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            int a = years * 365;
            int b = a * smkDay;
            double c = b / 20;
            double d = c * walPrice;

            Console.WriteLine(d.ToString("f2",CultureInfo.InvariantCulture));
        }

        //-------exercicio 8
        static void exe8(){

            Console.WriteLine("Write the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number");
            int y = int.Parse(Console.ReadLine());

            if(x % y == 0){
                Console.WriteLine("Is multiple");
            }
            else{
                Console.WriteLine("Is not multiple");
            }
        }
            
        //-------exercicio 9
        static void exe9(){

            Console.WriteLine("How many numbers will be verify ?");
            int num = int.Parse(Console.ReadLine());

            int[] vet = new int[num];
            int soma = 0;

            for(int i = 0;i < vet.Length;i++){
                Console.WriteLine("Write number");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 1;i < vet.Length;i++){
                soma += vet[i];
            }
            if(soma < vet[0]){
                Console.WriteLine("The first is bigger");
            }
            else if(soma == vet[0]){
                Console.WriteLine("They are equals");
            }
            else{
                Console.WriteLine("The first isn't bigger");
            }
        }

        //-------exercicio 9 usando classe
        // static void exe9c(){

        //     Console.WriteLine("How many numbers will be verify ?");
        //     int dimension = int.Parse(Console.ReadLine());

        //     Array1[] array1 = new Array1[dimension];
        //     int soma = 0;

        //     for(int i = 0;i < array1.Length;i++){
        //         Console.WriteLine("Write a number");
        //         int value = int.Parse(Console.ReadLine());
        //         array1[i] = new Array1(value);
        //     }
        //     for(int i = 1;i < array1.Length;i++){
        //         soma += array1[i].Value;
        //     }
        //     if(soma < array1[0].Value){
        //         Console.WriteLine("The first is bigger");
        //     }
        //     else if(soma == array1[0].Value){
        //         Console.WriteLine("They are equals");
        //     }
        //     else{
        //         Console.WriteLine("The first isn't bigger");
        //     }
        // }

        //-------exercicio 10
        static void exe10(){

            Console.WriteLine("How many numbers will be verify ?");
            int num = int.Parse(Console.ReadLine());

            int[] vet = new int[num];
            int big = 0;
            string iq = "";
            
            for(int i = 0;i < vet.Length;i++){
                Console.WriteLine("Write number");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < vet.Length;i++){
                for(int j = i + 1;j < vet.Length;j++){
                    if(vet[i] > vet[j]){
                        big = vet[i];
                    }
                    else if(vet[i] < vet[j]){
                        big = vet[j];
                    }
                    else if(vet[i] == vet[j]){
                        iq = $"{vet[i]} = {vet[j]}";
                    }
                }
            }
            if(iq != ""){
                Console.WriteLine(iq);
            }
            else{
                Console.WriteLine("O maior é: " + big);
            }
        }  

        //-------exercicio 14
        static void exe14(){

            const int qtd = 3;
            double[] num = new double[qtd];

            Console.WriteLine("Digite tres valores");

            for(int i = 0; i < qtd; i++)
            {
                num[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double[] num2 = num.OrderBy(x => x).ToArray();
            foreach(var nOrdenado in num2)
            {
                Console.WriteLine(nOrdenado.ToString("f2", CultureInfo.InvariantCulture));
            }
        }

        //-------exercicio 15
        static void exe15(){
            
            double number;
            int count = 1;
            double qtdMult3 = 0;
            double qtdMult5 = 0;
            
            while(count < 4)
            {
                Console.WriteLine("Digite um numero");
                number = double.Parse(Console.ReadLine());
                count++;

                double a = number % 3;
                double b = number % 5;
                if(a == 0)
                {
                    qtdMult3++;
                }
                if(b == 0)
                {
                    qtdMult5++;
                }
            }
            Console.WriteLine($"Multiplos de 3 {qtdMult3}");
            Console.WriteLine($"Multiplos de 5 {qtdMult5}");
        }            

        //-------exercicio 16
        static void exe16(){

            Console.WriteLine("Digite seu salário");
            double sal = double.Parse(Console.ReadLine());

            if(sal < 601)
            {
                Console.WriteLine("ISENTO");
            }
            else if(sal > 600 && sal < 1201)
            {
                double salLiq = sal - (sal * 0.2);
                Console.WriteLine($"Salário liquido: {salLiq}");
            }
            else if(sal > 1200 && sal < 2001)
            {
                double salLiq = sal - (sal * 0.25);
                Console.WriteLine($"Salário liquido: {salLiq}");
            }
            else
            {
                double salLiq = sal - (sal * 0.3);
                Console.WriteLine($"Salário liquido: {salLiq}");
            }
        }

        //-------exercicio 17
        static void exe17(){

            int n = 0;
            while(n != -1)
            {
                Console.WriteLine("Digite um numero");
                n = int.Parse(Console.ReadLine());
                int x = 1;
            
                while((x<11) && (n!=-1))
                {
                    Console.WriteLine(n * x);
                    x++;
                }
            }
        }

        //---------exercicio 18
        static void exe18(){

            Console.WriteLine("Diga quantas maças você quer comprar");
            int qtd = int.Parse(Console.ReadLine());
            
            if(qtd < 12)
            {
                Console.WriteLine($"Total a pagar R$ {qtd * 1.3}");
            }
            else
            {
                Console.WriteLine($"Total a pagar R$ {qtd * 1}");
            }
        }

        static void Main(string[] args)
        {
            exe4();
        }
        
    }
}