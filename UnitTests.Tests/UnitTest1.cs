using System;
using Xunit;

namespace UnitTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            //Arrange - инициализация
            Calculator calculator = new Calculator();

            //Act - исполнение
            int result = calculator.Sum(2, 5);

            //Assert - результат теста
            Assert.Equal(result, 2 + 5);
        }

        //[Fact]
        //public void TestSort()
        //{
        //    //Arrange
        //    int[] arr = new int[] { 2, 1, 3, 5, 0, 4 };
        //    int[] arr2 = new int[] { 2, 1, 3, 5, 0, 4 };

        //    //Act
        //    SortAlgo.SortArray(arr);
        //    Array.Sort(arr2);

        //    //Assert
        //    Assert.Equal(arr, arr2);

        //    //Ссылки
        //    //Assert.Same(sortedArr, arr);
        //}

        //[Theory]
        //[InlineData(6, 3)]
        //[InlineData(7, 6)]
        //public void TestDivision(int num1, int num2)
        //{
        //    //Arrange
        //    Calculator calculator = new Calculator();

        //    //Act
        //    int result = calculator.Divide(num1, num2);

        //    //Assert
        //    Assert.Equal(result, num1 / num2);
        //}

        //[Theory]
        //[InlineData(2, 0)]
        //[InlineData(15, 0)]
        //public void TestDivide(int num1, int num2)
        //{
        //    //Arrange
        //    Calculator calculator = new Calculator();

        //    //Assert
        //    Assert.ThrowsAny<DivideByZeroException>(() => calculator.Divide(num1, num2));
        //}
    }
}
