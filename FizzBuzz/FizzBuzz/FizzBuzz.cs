namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Say(int number)
        {
            int[] modNumbers = new int[] { 15, 3, 5 };
            var fizzBuzzTable = new System.Collections.Generic.Dictionary<int, string>{
                {15, "FizzBuzz"},
                {3, "Fizz"},
                {5, "Buzz"},
            };
            foreach (int modNumber in modNumbers)
            {
                if (number % modNumber == 0)
                    return fizzBuzzTable[modNumber];
            }
            return number.ToString();
        }
    }
}
