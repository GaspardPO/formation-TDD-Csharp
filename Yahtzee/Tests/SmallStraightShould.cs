using Xunit;
using Yahtzee;

namespace Tests
{
    public sealed class SmallStraightShould
    {
        
        [Theory]
        [InlineData(new[] { 2, 1, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 1 })]
        [InlineData(new[] { 1, 3, 4, 5, 6 })]
        [InlineData(new[] { 5, 2, 3, 4, 5 })]
        public void Return_30_if_small_straight_exits(int[] round)
        {
            var smallStraight = new SmallStraight(round);
            var value = smallStraight.GetValue();
            Assert.Equal(30,value);
        }
        
        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 })]
        [InlineData(new[] { 1, 2, 1, 2, 1 })]
        [InlineData(new[] { 1, 2, 1, 4, 5 })]
        public void Return_0_if_small_straight_doesnt_exits(int[] round)
        {
            var smallStraight = new SmallStraight(round);
            var value = smallStraight.GetValue();
            Assert.Equal(0,value);
        }

    }
}
