using NUnit.Framework;
using Shouldly;

namespace FizzBuzzTest
{
    public class Test
    {
        [Test]
        public void GivenFizzBuzzSay30ShouldBeFizzBuzz()
        {
            Given.AFizzBuzz.Say(30).ShouldBe("FizzBuzz");
        }

        [Test]
        public void GivenFizzBuzzSay15ShouldBeFizzBuzz()
        {
            Given.AFizzBuzz.Say(15).ShouldBe("FizzBuzz");
        }

        [Test]
        public void GivenFizzBuzzSay10ShouldBeBuzz()
        {
            Given.AFizzBuzz.Say(10).ShouldBe("Buzz");
        }

        [Test]
        public void GivenFizzBuzzSay6ShouldBeFizz()
        {
            Given.AFizzBuzz.Say(6).ShouldBe("Fizz");
        }

        [Test]
        public void GivenFizzBuzzSay5ShouldBeBuzz()
        {
            Given.AFizzBuzz.Say(5).ShouldBe("Buzz");
        }

        [Test]
        public void GivenFizzBuzzSay3ShouldBeFizz()
        {
            Given.AFizzBuzz.Say(3).ShouldBe("Fizz");
        }

        [Test]
        public void GivenFizzBuzzSay2ShouldBe2()
        {
            Given.AFizzBuzz.Say(2).ShouldBe("2");
        }

        [Test]
        public void GivenFizzBuzzSay1ShouldBe1()
        {
            Given.AFizzBuzz.Say(1).ShouldBe("1");
        }
    }
}
