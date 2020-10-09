using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExercicioTestes
{
    class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
				numbers[i] = i + 1;
            }

            return numbers;
        }
        
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int i = 10; i > 0; i--)
            {
                numbers[numbers.Length - i] = i;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }

        public int Exercise2()
        {
            int sum = 0;

            for(int i = 0;i < 101;i++)
            {
                sum+=i;
            }

            return sum;
        }

        public int[] Exercise3()
        {
            int[] num = new int[5];
            int count = 0;
                for(int i = 1;i <= 10;i += 2)
                {
                    num[count] = i;
                    count++;
                }
                return num;
        }

        public double Exercise4(List<int> ages)
        {
            double sum = 0.0;
            var answers = ages.Count;

            foreach(var item in ages)
            {
                sum += item;
            }

            var average = (sum / answers);

            return average;
        }

        public int Exercise5(int[] ages)
        {
            int sum = 0;
            int count = 0;

            foreach (var a in ages)
            {
                if(a >= 18 && a <= 35)
                sum++;
                count++;
            }
            int perc = ((sum * 100) / ages.Length);
            
            return perc;
        }

        
        public string Exercise6_cand2(string[] names, List<int> wishes)
        {
            int sumCand1 = 0;
            int sumCand2 = 0;

            foreach(var c in wishes)
            {
                if(c == 1)
                {
                    sumCand1++;
                }
                if(c == 2)
                {
                    sumCand2++;
                }
            }

            if(sumCand1 > sumCand2)
            {
                return names[0];
            }
            if(sumCand1 < sumCand2)
            {
                return names[1];
            }
            else
            {
                return "Empate";
            }
        }

        public string Exercise6_cand1(string[] names, List<int> wishes)
        {
            int sumCand1 = 0;
            int sumCand2 = 0;

            foreach(var c in wishes)
            {
                if(c == 1)
                {
                    sumCand1++;
                }
                if(c == 2)
                {
                    sumCand2++;
                }
            }

            if(sumCand1 > sumCand2)
            {
                return names[0];
            }
            if(sumCand1 < sumCand2)
            {
                return names[1];
            }
            else
            {
                return "Empate";
            }
        }
        
        public string Exercise6_emp(string[] names, List<int> wishes)
        {
            int sumCand1 = 0;
            int sumCand2 = 0;

            foreach(var c in wishes)
            {
                if(c == 1)
                {
                    sumCand1++;
                }
                if(c == 2)
                {
                    sumCand2++;
                }
            }

            if(sumCand1 > sumCand2)
            {
                return names[0];
            }
            if(sumCand1 < sumCand2)
            {
                return names[1];
            }
            else
            {
                return "Empate";
            }
        }

        public double Exercise7(int years, int smkDay, double walPrice)
        {
            
            int a = years * 365;
            int b = a * smkDay;
            double c = b / 20;
            double d = c * walPrice;

            return d;
        }

        public string Exercise8(int x, int y)
        {
            if(x % y == 0)
            {
                return "Is multiple";
            }
            else
            {
                return "Is not multiple";
            }
        }

        public int[] Exercise14(int[] num)
        {
                        
            int[] num2 = num.OrderBy(x => x).ToArray();
            
            return num2;
        }        
    }
}