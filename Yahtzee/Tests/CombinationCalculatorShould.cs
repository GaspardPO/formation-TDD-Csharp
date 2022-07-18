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
            Assert.Equal(0, CombinationCalculator.Compute(dicesWithoutOnes, CombinationCalculator.One));
        }

        [Theory]
        [InlineData(new[] {1, 3, 4, 5, 6}, 1)]
        [InlineData(new[] {2, 3, 4, 5, 1}, 1)]
        [InlineData(new[] {1, 3, 1, 5, 6}, 2)]
        [InlineData(new[] {1, 3, 4, 5, 1}, 2)]
        [InlineData(new[] {1, 1, 1, 1, 1}, 5)]
        public void return_sum_of_as_many_ones_as_possible(int[] dices, int expected)
        {
            Assert.Equal(expected, CombinationCalculator.Compute(dices, CombinationCalculator.One));
        }

        [Theory]
        [InlineData(new[] { 1, 3, 4, 5, 6 })]
        [InlineData(new[] { 1, 1, 1, 1, 1 })]
        [InlineData(new[] { 4, 3, 6, 5, 6 })]
        public void return_0_when_no_dices_equals_2_for_combination_for_two(int[] dicesWithoutTwo)
        {
            Assert.Equal(0, CombinationCalculator.Compute(dicesWithoutTwo, CombinationCalculator.Two));
        }

        [Theory]
        [InlineData(new[] {2, 3, 4, 5, 1}, new[] {1,2,3,4,5,0})]
        public void return_sum_of_as_many_twos_as_possible(int[] dices, int[] expected)
        {
            
           // Assert.Equal(expected, CombinationCalculator.Compute(dices, CombinationCalculator.Two));
            
        }
        
        [Theory]
        [InlineData(new[] { 1, 2, 4, 5, 6 })]
        [InlineData(new[] { 1, 1, 1, 1, 1 })]
        [InlineData(new[] { 4, 2, 6, 5, 6 })]
        public void return_0_when_no_dices_equals_3_for_combination_for_three(int[] dicesWithoutThree)
        {
            Assert.Equal(0, CombinationCalculator.Compute(dicesWithoutThree, CombinationCalculator.Three));
        }
        
        [Theory]
        [InlineData(new[] {2, 3, 4, 5, 1}, 3)]
        [InlineData(new[] {3, 3, 4, 2, 1}, 6)]
        [InlineData(new[] {3, 3, 3, 3, 3}, 15)]
        public void return_sum_of_as_many_threes_as_possible(int[] dices, int expected)
        {
            Assert.Equal(expected, CombinationCalculator.Compute(dices, CombinationCalculator.Three));
        }
    }
}   