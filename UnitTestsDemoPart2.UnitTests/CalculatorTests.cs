using Xunit;

namespace UnitTestsDemoPart2.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void GetTheSumOfTwoNumbers_WhenCalledWithTwoNumbers_ReturnsTheSum()
        {
            var sut = new Calculator();
            var result = sut.GetTheSumOfTwoNumbers(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void GetTheSumOfTwoNumbers_WhenCalledWithTwoNegativeNumbers_ReturnsTheSum()
        {
            var sut = new Calculator();
            var result = sut.GetTheSumOfTwoNumbers(-1, -2);
            Assert.Equal(-3, result);
        }

        [Fact]
        public void GetTheSumOfTwoNumbers_WhenCalledWithZeroAndAnotherNumber_ReturnsTheSum()
        {
            var sut = new Calculator();
            var originalNumber = 1;
            var result = sut.GetTheSumOfTwoNumbers(0, originalNumber);
            Assert.Equal(originalNumber, result);
        }
    }
}
