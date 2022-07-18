using System;
using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class CombinationCalculator
    {
        public const int One = 1;
        public const int Two = 2;
        public const int Three = 3;

        public static int Compute(int[] dices, int value)
        {
            return dices.Where(i => i== value).Sum();
        }
    }
}