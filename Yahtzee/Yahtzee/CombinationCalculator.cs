using System.Linq;

namespace Yahtzee
{
    public class CombinationCalculator
    {
        private const int One = 1;
        public int ComputeOnes(int[] dices) => dices.Count(i => i == One);
    }
}