using Xunit;
using Yahtzee;

namespace Tests
{

    public class CombinationCalculatorShould
    {
        private readonly CombinationCalculator _combinationCalculator = new();

        [Theory]
        [InlineData(new[] { 2, 3, 4, 5, 1 }, new[] { 1, 2, 3, 4, 5, 0 })]
        [InlineData(new[] { 1, 3, 5, 5, 1 }, new[] { 2, 0, 3, 0, 10, 0 })]
        [InlineData(new[] { 3, 3, 3, 3, 3 }, new[] { 0, 0, 15, 0, 0, 0 })]
        public void return_many_x_sums_as_possible(int[] dices, int[] expected)
        {
            int[] actual = new int[6];

            actual[0] = _combinationCalculator.Compute(dices, 1);
            actual[1] = _combinationCalculator.Compute(dices, 2);
            actual[2] = _combinationCalculator.Compute(dices, 3);
            actual[3] = _combinationCalculator.Compute(dices, 4);
            actual[4] = _combinationCalculator.Compute(dices, 5);
            actual[5] = _combinationCalculator.Compute(dices, 6);

            Assert.Equal(expected, actual);


        }
    }
}