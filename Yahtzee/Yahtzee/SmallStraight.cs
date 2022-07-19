using System.Collections.Generic;

namespace Yahtzee
{
    public class SmallStraight : Straight
    {
        public SmallStraight(int[] round) : base(round)
        {
            Threshold = 4;
            Points = 30;
        }
        protected override IEnumerable<IEnumerable<int>> GetPossibleStraight()
        {
            return new[] {
                new[] { 1, 2, 3, 4 },
                new[] { 2, 3, 4, 5 },
                new[] { 3, 4, 5, 6 }
            };
        }
    }
}