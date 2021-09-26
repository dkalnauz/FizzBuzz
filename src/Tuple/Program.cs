using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; ++i)
            {
                FizzBuzz(i);
            }
        }

        public static string FizzBuzz(int number)
        {
            var fizzTuple = new Tuple<int, string>(3, "Fizz");
            var buzzTuple = new Tuple<int, string>(5, "Buzz");
            var fizzBuzzTuple = new Tuple<int, string>(15, "FizzBuzz");

            if (number % fizzBuzzTuple.Item1 == 0)
            {
                return fizzBuzzTuple.Item2;
            }
            else if (number % buzzTuple.Item1 == 0)
            {
                return buzzTuple.Item2;
            }
            else if (number % fizzTuple.Item1 == 0)
            {
                return fizzTuple.Item2;
            }

            return number.ToString();
        }
    }
}