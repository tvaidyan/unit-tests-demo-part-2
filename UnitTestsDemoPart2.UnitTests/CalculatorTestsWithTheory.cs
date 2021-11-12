using Xunit;

namespace UnitTestsDemoPart2.UnitTests
{
    public class CalculatorTestsWithTheory
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(0, 1, 1)]
        public void GetTheSumOfTwoNumbers_WhenCalledWithTwoNumbers_ReturnsTheSum(int a, int b, int expectedResult)
        {
            var sut = new Calculator();
            var result = sut.GetTheSumOfTwoNumbers(a, b);
            Assert.Equal(expectedResult, result);
        }
    }
}
