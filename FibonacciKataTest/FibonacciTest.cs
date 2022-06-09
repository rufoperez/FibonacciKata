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
        public void hwen_number_is_zero_then_return_zero()
        {
            int result = Fibonacci.GetNumber(0);
            result.Should().Be(0);
        }
    }
}