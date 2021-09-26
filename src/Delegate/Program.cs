using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (int n in Enumerable.Range(0, 100))
            {
                Console.WriteLine(FizzBuzzer.FizzBuzz(n));
            }
        }
    }

    public class FizzBuzzer
    {
        delegate string Buzzer(int value);
        static List<Buzzer> _functions = new List<Buzzer>();

        static FizzBuzzer()
        {
            _functions.Add(x => x % 3 == 0 ? "Fizz" : "");
            _functions.Add(x => x % 5 == 0 ? "Buzz" : "");
        }

        public static string FizzBuzz(int value)
        {
            var result = _functions
                .Aggregate(string.Empty, (current, function) => current + function.Invoke(value));

            return string.IsNullOrEmpty(result) ? value.ToString(CultureInfo.InvariantCulture) : result;
        }
    }
}
