using Xunit;

namespace TestProject1
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]

        public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString(int number)
        {
            string result = FizzBuzzGame.Play(1);

            result.Contains(number.ToString());
            

        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        public void GivenANumberNotDivisibleBy5_ThenReturnsBuzz(int number)
        {
            var result =  FizzBuzzGame.Play(5);
            result.Contains("Buzz");
        }

    }
}