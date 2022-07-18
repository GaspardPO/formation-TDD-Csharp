using System;
using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class CombinationCalculator
    {
        private const int One = 1;
        private const int Two = 2;
        private const int Three = 3;

        public int ComputeOnes(int[] dices) => Compute(dices, One);
        
        public int ComputeTwo(int[] dices) => Compute(dices, Two);

        public int ComputeThree(int[] dices) => Compute(dices, Three);
        private static int Compute(int[] dices, int value)
        {
            return dices.Where(i => i== value).Sum();
        }
    }
}