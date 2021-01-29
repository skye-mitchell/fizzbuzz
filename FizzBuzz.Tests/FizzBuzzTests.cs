using System;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        [Fact]
        public void Get_Returns_Fizz_for_10()
        {
            var fizzBuzz = new FizzBuzz();

            var result = fizzBuzz.Get(10);

            Assert.Equal("Buzz", result);
        }
    }
}
