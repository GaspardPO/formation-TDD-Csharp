using Xunit;
using Yahtzee;

namespace Tests
{
    public sealed class UpperSectionShould
    {
        [Fact]
        public void Return_0_when_all_combinations_have_no_points()
        {
            var combinaison1 = new Combination(new[] { 2, 3, 4, 5, 2 }, 1);
            var combinaison2 = new Combination(new[] { 1, 3, 4, 5, 1 }, 2);
            var combinaison3 = new Combination(new[] { 1, 2, 4, 5, 1 }, 3);
            var combinaison4 = new Combination(new[] { 1, 2, 1, 5, 1 }, 4);
            var combinaison5 = new Combination(new[] { 1, 2, 4, 1, 1 }, 5);
            var combinaison6 = new Combination(new[] { 1, 2, 4, 1, 1 }, 6);

            var upperSection = new UpperSection(
                combinaison1,
                combinaison2,
                combinaison3,
                combinaison4,
                combinaison5,
                combinaison6);

            var actual = upperSection.GetTotal();

            //On a les 6 combinaisons à 0
            Assert.Equal(0, actual);
        }
    }
}
