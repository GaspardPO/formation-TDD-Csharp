using System.Linq;

namespace Yahtzee
{
    public class CombinationCalculator
    {
        public int Compute(int[] dices, int value)
        {
            return dices.Where(i => i == value).Sum();
        }
    }
}