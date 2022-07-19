using Xunit;
using Yahtzee;

namespace Tests
{
    public class FullHouseShould
    {

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 2, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 6, 5 })]
        [InlineData(new[] { 1, 1, 2, 2, 5 })]
        [InlineData(new[] { 1, 1, 1, 1, 2 })]
        public void Return_0_when_Numbers_AreDifferentThenTwoAndThree(int[] round)
        {
            var fullHouseKo = new FullHouseCombination(round);

            var actual = fullHouseKo.GetValue();

            Assert.Equal(0, actual);
        }


        [Theory]
        [InlineData(new[] { 1, 1, 1, 2, 2 })]
      
        public void Return_sum_when_have_threeAndTwo_identical_dices(int[] round)
        {
            var fullHouseOK = new FullHouseCombination(round);

            var actual = fullHouseOK.GetValue();

            Assert.Equal(25, actual);
        }
       
            
    }


}
