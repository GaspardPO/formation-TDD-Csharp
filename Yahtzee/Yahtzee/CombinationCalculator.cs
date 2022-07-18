using System;
using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class CombinationCalculator
    {
        private const int One = 1;
        public int ComputeOnes(int[] dices) => dices.Count(i => i == One);

        public int ComputeTwo(int[] dices)
        {
            return dices.Where(i => i==2).Sum();
        }
    }
}