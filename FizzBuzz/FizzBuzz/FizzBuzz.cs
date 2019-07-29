using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int[] modNumbers = new int[] { 15, 3, 5 };
        private Dictionary<int, string> modNumberTable = new Dictionary<int, string>() {
            {15, "FizzBuzz"},
            {3, "Fizz"},
            {5, "Buzz"},
        };

        public string Say(int number)
        {
            foreach (int modNumber in modNumbers)
            {
                if (number.IsDivisibleBy(modNumber))
                    return modNumberTable[modNumber];
            }
            return number.ToString();
        }
    }
}
