using Divisible_by_2_or_3;

namespace Divisible_by_2_or_3_testing
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(15, 30, 450)] // 15 * 30 = 450
        [InlineData(7, 12, 19)]   // 7 + 12 = 19
        [InlineData(2, 3, 6)]     // 2 * 3 = 6
        public void DivisibleBy2Or3_ShouldReturnCorrectResult(int number1, int number2, int expectedResult)
        {
            Assert.Equal(expectedResult, Program.DivisibleBy2Or3(number1, number2));
        }

 
    }
}
