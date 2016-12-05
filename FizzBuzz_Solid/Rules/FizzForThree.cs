using System;

namespace FizzBuzz_Solid
{
    public class FizzForThree: IKataRule
    {
        public string Process(string value, int number)
        {
            return (divisibleByThree(number)) ? FizzBuzzContract.FIZZ : "";
        }

        private bool divisibleByThree(int number)
        {
            return (number % 3 == 0);
        }
    }
}