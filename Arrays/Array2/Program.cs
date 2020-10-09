using System;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //------exercicio 1

            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vetTemp = new int[10];
            Random ran = new Random();

            for(int i = 0;i < vet1.Length;i++){
                vet1[i] = ran.Next(1,50);
                vet2[i] = ran.Next(51,100);
            }
            Console.WriteLine("Vetor 1");
            foreach(var x in vet1){
                Console.WriteLine(x);
            }
            Console.WriteLine("Vetor 2");
            foreach(var x in vet2){
                Console.WriteLine(x);
            }
            for(int i = 0;i < vet1.Length;i++){
                vetTemp[i] = vet1[i];
                vet1[i] = vet2[i];
                vet2[i] = vetTemp[i];
            }
            Console.WriteLine("Vetor 1");
            foreach(var x in vet1){
                Console.WriteLine(x);
            }
            Console.WriteLine("Vetor 2");
            foreach(var x in vet2){
                Console.WriteLine(x);
            }
            
            //------exercicio 2

            // int[] vet1 = {4,8,6,9,6,2,1,4};
            // int numRep = 0;
            
            // for(int i = 0;i < vet1.Length;i++){
            //     for(int j = i + 1;j < vet1.Length;j++){
            //         if(vet1[j] == vet1[i] && j != i){
            //             numRep++;    
            //         }
            //     }
            // }
            // if (numRep != 0){
            //     Console.WriteLine("Sim " + numRep);
            // }
            // else{
            //     Console.WriteLine("Não");
            // }

            //------exercicio 3

            // const int qttPeop = 10;
            // string[,] matriz = new string[qttPeop,2];
            // int posX = 0;
            // int posY = 0;
            // int count = 0;
            // int manNot = 0;
            // int womYes = 0;
            // int yesTot = 0;
            // int notTot = 0;
            // int man = 0;
            // int wom = 0;
            

            // while(count < qttPeop){
            //     Console.WriteLine("Digite o sexo da pessoa, sendo M ou F");
            //     string sexo = Console.ReadLine();
            //     if(sexo == "M"){
            //         man++;
            //     }
            //     else if(sexo == "F"){
            //         wom++;
            //     }
            //     matriz[posX,posY] = sexo;
            //     posY++;
            //     Console.WriteLine("Digite a opinião sendo S ou N");
            //     string opi = Console.ReadLine();
            //     matriz[posX,posY] = opi;
            //     posX++;
            //     posY--;
            //     count++;
            // }
            // for(int i = 0;i < qttPeop;i++){
            //     if(matriz[i,0] == "M"){
            //         if(matriz[i,1] == "S"){
            //             yesTot++;
            //         }
            //         else if(matriz[i,1] == "N"){
            //             notTot++;
            //             manNot++;
            //         }
            //     }
            //     if(matriz[i,0] == "F"){
            //         if(matriz[i,1] == "S"){
            //             yesTot++;
            //             womYes++;
            //         }
            //         else if(matriz[i,1] == "N"){
            //             notTot++;
            //         }
            //     }
            // }
            // Console.WriteLine($"Total de pessoas que responderam sim: {yesTot}");
            // Console.WriteLine($"Total de pessoas que responderam não: {notTot}");
            // double percWomYes = (womYes * 100) / wom;
            // double percManNot = (manNot * 100) / man;
            // Console.WriteLine($"Percentagem de mulheres que responderam sim: {percWomYes}");
            // Console.WriteLine($"Percentagem de homens que responderam não: {percManNot}");

            // for(int i = 0;i < qttPeop;i++){
            //     Console.WriteLine($" sexo {matriz[i,0]} opinião {matriz[i,1]}");
            // }

            //------exercicio 4

            // byte[] vetA = {7,14,22,35,56};
            // byte soma = 0;

            // for(byte i = 0;i < vetA.Length;i++){
            //     if(vetA[i] % 2 != 0){
            //         soma += vetA[i];
            //     }
            // }
            // Console.WriteLine(soma);

            //------exercicio 5

            // int[] vetA = {-7,14,22,-35,56,-11,87,92,-74,54};
            // byte valPos = 0;

            // for(byte i = 0;i < vetA.Length;i++){
            //     if(vetA[i] >= 0){
            //         valPos++;
            //     }
            // }
            // Console.WriteLine(valPos);

            //------exercicio 6

            // int[] vetQ = new int [10];
            // int maxVal = 0;
            // int posMaxVal = 0;
            // int count = 0;

            // for(int i = 0;count < vetQ.Length;i++){
            //     Console.WriteLine("Digite um valor");
            //     int val = int.Parse(Console.ReadLine());
            //     if(val >= 0){
            //         vetQ[i] = val;
            //         count++;
            //     }
            //     else{
            //         Console.WriteLine("Digite novamente");
            //         i--;
            //     }  
            // }
            // for(int g = 0;g < vetQ.Length;g++){
            //     for(int h = g + 1;h < vetQ.Length;h++){
            //         if(vetQ[g] > vetQ[h]){
            //             maxVal = vetQ[g];
            //             posMaxVal = g;
            //         }
            //         else if(vetQ[h] > vetQ[g]){
            //             maxVal = vetQ[h];
            //             posMaxVal = h;
            //         }
            //     }
            // }
            // Console.WriteLine($"O maior valor é {maxVal}");
            // Console.WriteLine($"A posição dele é {posMaxVal}");

            //------exercicio 7

            // int[] vetA = {7,14,2,35,56,5,41,36,8,75};
            // int count = 0;

            // for(int i = 0;i < vetA.Length;i++){
            //     if(vetA[i] == i){
            //         count++;
            //     }
            // }
            // Console.WriteLine(count); 

            //------exercicio 8

            // string[] vetA = {"a","b","c","d","e","f","g","h","i","j"};
            // int count = 0;

            // for(int i = 0;i < vetA.Length;i++){
            //     if(vetA[i] == "a" || vetA[i] == "e" || vetA[i] == "i" || vetA[i] == "o" || vetA[i] == "u"){
            //         count++;
            //     }
            // }
            // Console.WriteLine(count);

            //------exercicio 9

            // string[] vetA = {"a","b","c","d","e","f","g","h","i","j"};
            // string result = "";
            
            // for(int i = 0;i < vetA.Length;i++){
            //     if(i % 2 == 0 ){
            //         result += vetA[i];
            //     }
            // }
            // Console.WriteLine(result);
        }
    }
}
