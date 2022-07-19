using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    
    public abstract class Straight
    {
        protected int Threshold { get; set; }
        protected int Points { get; set; }

        private readonly int[] _round;

        protected Straight(int[] round)
        {
            _round = round;
        }

        public int GetValue() => GetPossibleStraight().Any(l => l.Intersect(_round).Count() == Threshold)
                    ? Points 
                    : 0;

        protected abstract IEnumerable<IEnumerable<int>> GetPossibleStraight();
    }
}