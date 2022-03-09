using System;

namespace UnitTests
{
    public class Calculator
    {
        public int Sum(int num1, int num2) => num1 + num2;

        public int Substract(int num1, int num2) => num1 - num2;

        public int Multiply(int num1, int num2) => num1 * num2;

        public int Divide(int num1, int num2) => num2 != 0 ? num1 / num2 : throw new DivideByZeroException();
    }
}
