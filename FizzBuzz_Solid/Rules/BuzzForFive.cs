using System;

namespace FizzBuzz_Solid
{
    public class BuzzForFive: IKataRule
    {
        public string Process(string value, int number)
        {
            return (divisibleByFive(number)) ? FizzBuzzContract.BUZZ : "";
        }

        private bool divisibleByFive(int number)
        {
            return (number % 5 == 0);
        }
    }
}