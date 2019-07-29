namespace FizzBuzz
{
    public static class FizzBuzzExtension
    {
        public static bool IsDivisibleBy(this int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
