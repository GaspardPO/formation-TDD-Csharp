using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    
    public class Straight
    {
        private const int Four = 4;
        private const int Five = 5;
        private readonly int[] _round;
        private readonly bool _isSmall;
        private static readonly IEnumerable<IEnumerable<int>> _possibleSmallStraights = 
            new[] { 
                new[] { 1, 2, 3, 4 }, 
                new[] { 2, 3, 4, 5 }, 
                new[] { 3, 4, 5, 6 } 
            };

        private static readonly IEnumerable<IEnumerable<int>> _possibleLargeStraights = 
            new[] { 
                new[] { 1, 2, 3, 4, 5 }, 
                new[] { 2, 3, 4, 5, 6 } 
            };

        public Straight(int[] round, bool isSmall)
        {
            _round = round;
            _isSmall = isSmall;
        }

        public int GetValue()
        {
            if (!_isSmall)
            {
                return
                    _possibleLargeStraights.Any(l => l.Intersect(_round).Count() == Five)
                    ? 40 : 0;
            }
            else
            {
                return
                    _possibleSmallStraights.Any(l => l.Intersect(_round).Count() == Four)
                    ? 30 : 0;
            }
        }
    }
}