using Xunit;

namespace Tests
{
    public class CombinationShould
    {

        [Theory]
        [InlineData(new[] { 2, 3, 4, 5, 1 }, new[] { 1, 2, 3, 4, 5, 0 })]
        [InlineData(new[] { 1, 3, 5, 5, 1 }, new[] { 2, 0, 3, 0, 10, 0 })]
        [InlineData(new[] { 3, 3, 3, 3, 3 }, new[] { 0, 0, 15, 0, 0, 0 })]
        public void return_combination_dice(int[] dices, int[] expected)
        {
            int[] actual = new int[6];

            actual[0] = new Combination(dices, 1).GetValue();
            actual[1] = new Combination(dices, 2).GetValue();
            actual[2] = new Combination(dices, 3).GetValue();
            actual[3] = new Combination(dices, 4).GetValue();
            actual[4] = new Combination(dices, 5).GetValue();
            actual[5] = new Combination(dices, 6).GetValue();

            Assert.Equal(expected, actual);
        }

    }
}