using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class NOfAKindCombination
    {

        private readonly List<int> _round;
        private readonly int _iteration;

        public NOfAKindCombination(int[] round, int iteration)
        {
            _round = round.ToList();
            _iteration = iteration;
        }

        public int GetValue()
        {
            return _round
                .GroupBy(diceValue => diceValue)
                .Any(group => group.Count() >= _iteration)
                ? _round.Sum() 
                : 0;
        }

        
    }
}