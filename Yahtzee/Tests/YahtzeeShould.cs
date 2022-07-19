using Xunit;
using Yahtzee;

namespace Tests
{
    public class YahtzeeShould
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 1, 1, 4, 5 })]
        public void Return_0_if_different_values(int[] round)
        {
            var yahtzeeKo = new YahtzeeCombination(round);
            var value = yahtzeeKo.GetValue();
            Assert.Equal(0,value);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 })]
        [InlineData(new[] { 5, 5, 5, 5, 5 })]
        public void Return_50_if_same_values(int[] round)
        {
            var yahtzeeKo = new YahtzeeCombination(round);
            var value = yahtzeeKo.GetValue();
            Assert.Equal(50, value);
        }
    }
}
