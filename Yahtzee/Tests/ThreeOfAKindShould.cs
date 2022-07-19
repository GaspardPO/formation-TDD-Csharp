using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ThreeOfAKindShould
    {
        // 1 + 1 + 1 + 2 + 3 = 8  
        // 1 + 1 + 1 + 1 + 3 = 7
        // 2 + 2 + 2 + 1 + 3 = 10
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 2, 2, 3, 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 6, 5 })]
        public void Return_0_when_we_are_no_kind_of_a_kind(int[] round)
        {
            var sumOfNoneThreeOfKind = new ThreeOfAKindCombination(round);

            var actual = sumOfNoneThreeOfKind.GetValue();

            Assert.Equal(0, actual);
        }
    }


}
