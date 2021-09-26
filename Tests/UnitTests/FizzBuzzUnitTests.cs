using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        static IEnumerable<Func<int, string>> TestCaseSources()
        {
            yield return Classic.Program.FizzBuzz;

            yield return Delegate.FizzBuzzer.FizzBuzz;

            yield return Linq.Program.FizzBuzz;

            yield return Switch.Program.FizzBuzz;

            yield return Tuple.Program.FizzBuzz;
        }

        [Test]
        [TestCaseSource(nameof(TestCaseSources))]
        public void Returns_Fizz_When_Three(Func<int, string> action)
        {
            var numbers = new[] { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 96, 99 };

            foreach (var number in numbers)
            {
                Assert.AreEqual("Fizz", action(number));
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCaseSources))]
        public void Returns_Buzz_When_Five(Func<int, string> action)
        {
            var numbers = new[] { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 95 };

            foreach (var number in numbers)
            {
                Assert.AreEqual("Buzz", action(number));
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCaseSources))]
        public void Returns_FizzBuzz_When_Fiveteen(Func<int, string> action)
        {
            var numbers = new[] { 15, 30, 45, 60, 75, 90 };

            foreach (var number in numbers)
            {
                Assert.AreEqual("FizzBuzz", action(number));
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCaseSources))]
        public void Returns_Number_WhenNot_ThreeAndFive(Func<int, string> action)
        {
            var numbers = new[] { 1, 2, 11, 22, 98 };

            foreach (var number in numbers)
            {
                Assert.AreEqual(number.ToString(), action(number));
                Assert.AreEqual(number.ToString(), action(number));
            }
        }
    }
}
