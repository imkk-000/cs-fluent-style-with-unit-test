namespace FizzBuzzTest
{
    using FizzBuzz;

    public static class Given
    {
        public static FizzBuzz AFizzBuzz => new FizzBuzz();
        public static FizzBuzz AFizzBuzzWithNewRule => new FizzBuzz(
            new int[] {2, 3},
            new System.Collections.Generic.Dictionary<int, string>() {
                {2, "Fizz"},
                {3, "Buzz"},
            }
        );
    }
}
