using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class ThreeOfAKindCombination
    {

        private readonly List<int> _round; 

        public ThreeOfAKindCombination(int[] round)
        {
            _round = round.ToList();
        }

        public int GetValue()
        {
            return _round
                .GroupBy(diceValue => diceValue)
                .Any(group => group.Count() >= 3)
                ? _round.Sum() 
                : 0;
        }

        
    }
}