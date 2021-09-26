using System;
using System.Linq;

namespace Switch
{
    public class Program
    {
        public static string FizzBuzz(int n) =>
             (n % 3, n % 5) switch
             {
                 (0, 0) => "FizzBuzz",
                 (0, _) => "Fizz",
                 (_, 0) => "Buzz",
                 (_, _) => $"{n}"
             };

        static void Main(string[] args)
        {
            foreach (int n in Enumerable.Range(0, 100))
            {
                Console.WriteLine(FizzBuzz(n));
            }
        }
    }
}
