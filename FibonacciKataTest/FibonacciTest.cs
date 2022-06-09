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

        [Test]
        public void when_number_is_zero_then_return_zero()
        {
            int result = Fibonacci.GetNumber(0);
            result.Should().Be(0);
        }

        [Test]
        public void when_number_is_one_then_return_one()
        {
            int result = Fibonacci.GetNumber(1);
            result.Should().Be(1);
        }

        [Test]
        public void when_number_is_two_then_return_one()
        {
            int result = Fibonacci.GetNumber(2);
            result.Should().Be(1);
        }
    }
}