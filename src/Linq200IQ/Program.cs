using System;
using System.Linq;

namespace Linq200IQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
            string.Join(
              Environment.NewLine,
              Enumerable.Range(1, 100)
                .Select(n => n % 15 == 0 ? "FizzBuzz"
                           : n % 3 == 0 ? "Fizz"
                           : n % 5 == 0 ? "Buzz"
                           : n.ToString())
            ));
        }
    }
}
