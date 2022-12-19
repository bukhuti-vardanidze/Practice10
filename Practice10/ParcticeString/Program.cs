using System.Linq;

namespace PracticeString
{
    public class StringMethods
    {
        public static void ReverseString()
        {
            string str = "w3resource.com";
            int l = 0;
            Console.Write("");
            while (l <= str.Length - 1)
            {
                Console.WriteLine(str[l]);
                l++;
            }
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine();
        }


    }

    class Program
    {
       public static void Main()
        {
            StringMethods.ReverseString();

          
        }
    }
}
