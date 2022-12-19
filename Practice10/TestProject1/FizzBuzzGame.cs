namespace TestProject1
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {

            if(number ==5)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}