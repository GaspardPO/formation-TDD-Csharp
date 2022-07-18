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
        public int ComputeOnes(int[] dices) => dices.Where(i => i== One).Sum();

        public int ComputeTwo(int[] dices) => dices.Where(i => i== Two).Sum();

        public int ComputeThree(int[] dices) => dices.Where(i => i== Three).Sum();
    }
}