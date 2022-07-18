using Xunit;
using Yahtzee;

namespace Tests
{
    
    public class CombinationCalculatorShould
    {
        private readonly CombinationCalculator _combinationCalculator = new();
        
        [Theory]
        [InlineData(new[] {2, 3, 4, 5, 6})]
        [InlineData(new[] {2, 2, 2, 2, 2})]
        [InlineData(new[] {4, 3, 6, 5, 6})]
        public void return_0_when_no_dices_equals_1_for_combination_for_ones(int[] dicesWithoutOnes)
        {
            Assert.Equal(0, _combinationCalculator.ComputeOnes(dicesWithoutOnes));
        }
        
        [Theory]
        [InlineData(new[] {1, 3, 4, 5, 6}, 1)]
        [InlineData(new[] {2, 3, 4, 5, 1}, 1)]
        [InlineData(new[] {1, 3, 1, 5, 6}, 2)]
        [InlineData(new[] {1, 3, 4, 5, 1}, 2)]
        [InlineData(new[] {1, 1, 1, 1, 1}, 5)]
        public void return_sum_of_as_many_ones_as_possible(int[] dices, int expected)
        {
            Assert.Equal(expected, _combinationCalculator.ComputeOnes(dices));
        }
        
    }
}   