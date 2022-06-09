using FibonacciKata;
using FluentAssertions;

namespace FibonacciKataTest
{
    public class FibinacciTest
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(10, 55)]
        public void return_fibonacci_for_number(int number, int expectedResult)
        {
            int result = Fibonacci.GetNumber(number);
            result.Should().Be(expectedResult);
        }
    }
}