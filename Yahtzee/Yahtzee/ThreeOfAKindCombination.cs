using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    public class ThreeOfAKindCombination
    {

        private readonly List<int> Round; 

        public ThreeOfAKindCombination(int[] round)
        {
            Round = round.ToList();
        }

        public int GetValue()
        {
            if (Round.Count(r => r == 1) >= 3)
                return 8;

            return 0;
        }

        
    }
}