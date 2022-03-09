using System;
namespace UnitTests
{
    public class PrimeNumbers
    {
        public bool IsPrime(int num)
        {
            if (num == 1) return false;
            if (num == 2) return true;

            int divisors = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    divisors++;
            }

            return divisors == 2;
        }
    }
}
