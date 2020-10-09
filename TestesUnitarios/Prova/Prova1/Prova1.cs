using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TesteProva1
{
    public class Prova1
    {
        // public IEnumerable<int> Exercise17(int number)
		// {
        //     // Imprimir a tabuada de qualquer número fornecido pelo usuário.
        //     // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
        //     // DEVE retornar a tabuada de 1 a 10

        //     var multiplicationTable = new List<int>()
        //     {
        //         1,2,3,4,5,6,7,8,9,10;
        //     };
            
        //     return multiplicationTable.Select(item => item * number);
            
		// }

        public string Q1(double qhd, double vh)
        {
            var dayWork = (qhd * vh).ToString("f2", CultureInfo.InvariantCulture);

            return dayWork;

        }
        
        //Se estivesse vindo como letras sem ser uma array,
        //poderia usar o (params string[] letters) para criae uma array com o que vem.
        public string Q2(string[] letters)
        {
            var word = "";
            for(int i = 0;i < letters.Length;i++)
            {
                word += letters[i];
            }
            return word;
        }

        public List<string> Q3(List<(string name, string esCivil)> people)
        {
            return people.Where(item => item.esCivil == "Solteir@")
                .Select(item => item.name)
                .ToList();
        }

        public bool Q4(int ano)
        {
            if(ano > 2002)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerable<int> Q5(int a,int b, string c, int d, string e)
        {
            var x = new List<int>{a,b,int.Parse(c),d,int.Parse(e)};

            return x.Select(item => item < 0 ? item : null);
        }
    }




}