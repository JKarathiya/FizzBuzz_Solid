using System;
using System.Linq;

namespace FizzBuzz_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzBuilder builder = new FizzBuzzBuilder(new KataRules());
            var oneToOneHundred = Enumerable.Range(1, 101).ToList();
            oneToOneHundred.ForEach(x =>Console.WriteLine(builder.build(x)));
            Console.ReadKey();
        }
    }
}
