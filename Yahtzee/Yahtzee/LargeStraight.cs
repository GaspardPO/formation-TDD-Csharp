using System.Collections.Generic;

namespace Yahtzee
{
    public class LargeStraight : Straight
    {
        public LargeStraight(int[] round) : base(round)
        {
            Threshold = 5;
            Points = 40;
        }

        protected override IEnumerable<IEnumerable<int>> GetPossibleStraight()
        {
            return new[] {
                new[] { 1, 2, 3, 4, 5 },
                new[] { 2, 3, 4, 5, 6 }
            };
        }
    }
}