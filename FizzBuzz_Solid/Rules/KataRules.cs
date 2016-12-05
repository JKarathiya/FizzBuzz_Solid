using System.Collections.Generic;

namespace FizzBuzz_Solid
{
    public class KataRules: List<IKataRule>
    {
        public KataRules()
        {
            this.Add(new FizzForThree());
            this.Add(new BuzzForFive());
            this.Add(new NumberByDefault());
        }
    }
}