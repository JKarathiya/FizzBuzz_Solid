using System;

namespace FizzBuzz_Solid
{
    public interface IKataRule
    {
        String Process(String value, int number);
    }
}