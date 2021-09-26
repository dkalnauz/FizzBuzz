using System;

namespace Classic
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
        }

        public static string FizzBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
