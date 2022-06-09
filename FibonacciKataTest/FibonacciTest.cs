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

        [Test]
        public void when_number_is_three_then_return_two()
        {
            int result = Fibonacci.GetNumber(3);
            result.Should().Be(2);
        }

        [Test]
        public void when_number_is_four_then_return_three()
        {
            int result = Fibonacci.GetNumber(4);
            result.Should().Be(3);
        }
    }
}