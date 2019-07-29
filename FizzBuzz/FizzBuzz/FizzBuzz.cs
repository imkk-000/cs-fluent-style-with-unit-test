using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private int[] modNumbers;
        private Dictionary<int, string> modNumberTable;

        public FizzBuzz()
        {
            modNumbers = new int[] { 15, 3, 5 };
            modNumberTable = new Dictionary<int, string>() {
                {15, "FizzBuzz"},
                {3, "Fizz"},
                {5, "Buzz"},
            };
        }

        public FizzBuzz(int[] modNumbers, Dictionary<int, string> modNumberTable)
        {
            this.modNumbers = modNumbers;
            this.modNumberTable = modNumberTable;
        }
        public string Say(int sayNumber)
        {
            foreach (int number in modNumbers)
            {
                if (sayNumber.IsDivisibleBy(number))
                    return modNumberTable[number];
            }
            return sayNumber.ToString();
        }
    }
}
