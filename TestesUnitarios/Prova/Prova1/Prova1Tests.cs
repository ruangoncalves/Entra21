using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace TesteProva1
{
    public class Prova1Tests
    {
        
        // [Theory]
        // [InlineData(6, new int[10]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60})]
        // [InlineData(5, new int[10]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50})]
        // public void should_return_the_input_multiplied_by_1_to_10(int number, int[] expectedResult)
        // {
        //     // Dado / Setup
        //     var exercises = new Prova1();
            
        //     // Quando / Ação
        //     var result = exercises.Exercise17(number);

        //     // Deve / Asserções
        //     Assert.Equal(result, expectedResult);
        // }

        
        // questao1 - solicite ao usuario que informe quantas horas e minutos ele trabalha por dia, e qual valor da hora do serviço.
        // imprima quanto dinheiro ele ganha ao longo de um dia trabalhado, a mensagem impressa deve ter no maximo duas casa após a virgula.

        // [Theory]
        // [InlineData(8.48, 10.35, "87.77")]
        // [InlineData(5.42, 25.47, "138.05")]
        // public void Q1(double htd, double vh, string result)
        // {
        
        // var prova1 = new Prova1();
        
        // var expected = prova1.Q1(htd,vh);
                
        // Assert.Equal(result,expected);
        // }

        // solicite ao usuario que informe uma palavra, porem deve ser digitado uma letra por vez,
        // quando o usuario digitar a palavra "Finalizar", a aplicação deve apresentar a palavra inteira.

        // [Theory]
        // [InlineData(new string[]{"p","a","i"}, "pai")]
        // [InlineData(new string[]{"m","a","e"}, "mae")]
        // public void Q2(string[] letters, string wordResult)
        // {
        //     var prova1 = new Prova1();

        //     var result = prova1.Q2(letters);

        //     Assert.Equal(wordResult,result);

        // }

        // solicite a 5 usuarios seus nomes e se são solteiros,
        // apresente os nomes dos solteiros.
        
        // public static TheoryData<(List<(string name, string esCivil)>, List<string>)> testQ3()
        // {
        //     return new TheoryData<(List<(string name, string esCivil)>, List<string>)>
        //     {
        //         // primeira lista = pessoas que serão enviadas / segunda lista = resultado esperado
        //         (new List<(string name, string esCivil)>{("Fernando","Solteir@"),("Alberto","Casado"),("Renato","Solteir@")}, new List<string>{"Fernando","Renato"}),
        //         (new List<(string name, string esCivil)>{("Amanda","Casad@"),("Rafaela","Solteir@"),("Mayara","Solteir@")}, new List<string>{"Rafaela","Mayara"})
        //     };
            
        // }
        // [Theory]
        // [MemberData(nameof(testQ3))]
        // public void Q3((List<(string name, string esCivil)> , List<string>) peopleGeneral)
        // {
        //     //var peopleS = new List<(string name, string esCivil)>{("Fernando","Solteiro"),("Alberto","Casado"),("Renato","Solteiro")};
            
        //     var prova1 = new Prova1();

        //     var result = prova1.Q3(peopleGeneral.Item1);
            
        //     Assert.Equal(peopleGeneral.Item2, result);
        // }

        [Fact]
        public void Q4()
        {
            var prova1 = new Prova1();
        
            var result1 = prova1.Q4(2002);
            var result2 = prova1.Q4(2005);

            Assert.True(result1);
            Assert.False(result2);  
        }

        [Theory]
        [InlineData(5,8,"j",3,"a", new int[]{5,8,3})]
        public void Q5(int a,int b, string c, int d, string e, int[] expected)
        {
            var prova1 = new Prova1();

            var result = prova1.Q5(a,b,c,d,e);
            
        
        //When
        
        //Then
        }

        
    }
}
