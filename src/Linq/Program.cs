using System;
using System.Linq;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(1, 100)
              .Select(n =>
              {
                  return FizzBuzz(n);
              });

            foreach (string item in list)
                Console.WriteLine(item);
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
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}
