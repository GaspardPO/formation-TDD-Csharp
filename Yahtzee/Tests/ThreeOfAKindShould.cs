using Xunit;
using Yahtzee;

namespace Tests
{
    public class ThreeOfAKindShould
    {
        
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 2, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 6, 5 })]
        [InlineData(new[] { 1, 1, 2, 2, 5 })]
        public void Return_0_when_we_are_no_three_of_a_kind(int[] round)
        {
            var sumOfNoneThreeOfKind = new ThreeOfAKindCombination(round);

            var actual = sumOfNoneThreeOfKind.GetValue();

            Assert.Equal(0, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 2, 3 }, 8)]
        [InlineData(new[] { 1, 1, 1, 2, 4 }, 9)]
        [InlineData(new[] { 1, 1, 1, 1, 4 }, 8)]
        [InlineData(new[] { 2, 2, 2, 1, 4 }, 11)]
        [InlineData(new[] { 3, 3, 3, 1, 4 }, 14)]
        [InlineData(new[] { 3, 5, 1, 5, 5 }, 19)]
        public void Return_sum_when_have_three_identical_dices(int[] round, int expected)
        {
            var sumOfThreeOfAKind = new ThreeOfAKindCombination(round);

            var actual = sumOfThreeOfAKind.GetValue();

            Assert.Equal(expected, actual);
        }
    }


}
