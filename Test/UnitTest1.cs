using Xunit;
using ByndyusoftTestTask;
namespace Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {-1, 20, 30, 11 }, 10)]
        [InlineData(new int[] { -20, 50, 45}, 25)]
        [InlineData(new int[] { 4, 0, 3, 19, 492, -10, 1 }, -10)]
        public void ValueTest(int[] arr, int expectedResult)
        {
            int? result = Logic.SumOfTwoMinimum(arr);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[1] { 10 })]
        public void ExceptionTest(int[] arr)
        {
            int? result = Logic.SumOfTwoMinimum(arr);
            Assert.Null(result);
        }
    }
}