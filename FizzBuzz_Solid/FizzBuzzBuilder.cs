using System;

namespace FizzBuzz_Solid
{
    public class FizzBuzzBuilder
    {
        private  KataRules _rules;

        public String build(int number)
        {
            String value = string.Empty;

            _rules.ForEach(x=> value += x.Process(value, number));

            return value;
        }
        public FizzBuzzBuilder(KataRules rules)
        {
            if (rules == null)
            {
                throw new ArgumentException("rules cannot be null");
            }

            this._rules = rules;
        }
    }
}