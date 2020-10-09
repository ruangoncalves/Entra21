using Xunit;
using System.Collections.Generic;
using System.Linq;
using System;


namespace ExercicioTestes
{
    public class ExercisesTests
    {
        [Fact]
        public void TestExercise1A()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            int[] expectedOutput = {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

         [Fact]
        public void TestExercise1B()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void TestExercise1C()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void TestExercise2()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
            // então a aplicação deverá retornar a soma dos números de 1 a 100

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int returnSum = exercises.Exercise2();

            // Deve / Asserções           
            Assert.Equal(5050, returnSum);
        }

        [Fact]
        public void TestExercise3()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
            // então a aplicação deverá retornar os numeros impares de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnNum = exercises.Exercise3();

            // Deve / Asserções
            int[] expectedOutput = {1,3,5,7,9};
            
            Assert.Equal(expectedOutput, returnNum);
        }

        [Fact]
        public void TestExercise4()
        {
            var exercises = new Exercises();

            var myList = new List<int>(){5,9};
            
            //para adicionar atraves do add
            //myList.Add(5,9);

            var retSum = exercises.Exercise4(myList);

            Assert.Equal(7,retSum);
        }

        [Fact]
        public void TestExercise5()
        {
        var exercises = new Exercises();
        
        int[] ageWom = {27,15,31,25,48};

        var returned = exercises.Exercise5(ageWom);

        Assert.Equal(60,returned);
        }

        [Fact]
        public void TestExercise6_winer_cand2()
        {
        //Given
        var exercises = new Exercises();
        string[] candidates = {"Alberto","Carlos"};
        var listWishes = new List<int>();
        listWishes.Add(1);
        listWishes.Add(2);
        listWishes.Add(2);

        //When
        var returned = exercises.Exercise6_cand2(candidates, listWishes);
        
        //Then
        Assert.Equal("Carlos", returned);
        }

        [Fact]
        public void TestExercise6_winer_cand1()
        {
        //Given
        var exercises = new Exercises();
        string[] candidates = {"Alberto","Carlos"};
        var listWishes = new List<int>();
        listWishes.Add(1);
        listWishes.Add(1);
        listWishes.Add(2);

        //When
        var returned = exercises.Exercise6_cand1(candidates, listWishes);
        
        //Then
        Assert.Equal("Alberto", returned);
        }

        [Fact]
        public void TestExercise6_emp()
        {
        //Given
        var exercises = new Exercises();
        string[] candidates = {"Alberto","Carlos"};
        var listWishes = new List<int>();
        listWishes.Add(1);
        listWishes.Add(0);
        listWishes.Add(2);

        //When
        var returned = exercises.Exercise6_cand1(candidates, listWishes);
        
        //Then
        Assert.Equal("Empate", returned);
        }

        [Fact]
        public void TestExercise7()
        {
        //Given
        var exercises = new Exercises();
        //When
        int years = 10;
        int smkDay = 12;
        double walPrice = 4.20;

        var returned = exercises.Exercise7(years,smkDay,walPrice); 
        
        //Then
        Assert.Equal(9198.00,returned);

        }

        [Theory]
        [InlineData(9,3, "Is multiple")]
        [InlineData(10,3, "Is not multiple")]
        public void TestExercise8(int x, int y, string expected)
        {

        var exercises = new Exercises();
        
        var returned = exercises.Exercise8(x,y);

        Assert.Equal(expected, returned);
        }
        
        [Theory]
        [InlineData(new int[]{5,9,2},new int[]{2,5,9})]
        public void TestExercise14(int[] num, int[] expected)
        {
            var exercises = new Exercises();

            int[] returned = exercises.Exercise14(num);
            
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], returned[i]);
            }
                    
        }

    }
}
