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
    }
}