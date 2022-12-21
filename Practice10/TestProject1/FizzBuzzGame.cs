using System.Linq;
namespace TestProject1
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {

            if (!number.IsDivisibleBy(3))
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}