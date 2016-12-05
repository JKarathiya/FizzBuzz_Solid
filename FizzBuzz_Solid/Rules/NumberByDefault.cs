namespace FizzBuzz_Solid
{
    public class NumberByDefault:IKataRule
    {
        public string Process(string value, int number)
        {
            return (value.Length == 0) ? number.ToString() : "";
        }
    }
}