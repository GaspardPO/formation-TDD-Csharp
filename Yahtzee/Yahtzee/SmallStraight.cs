using System.Collections.Generic;
using System.Linq;

namespace Yahtzee
{
    
    public class SmallStraight
    {
        private const int Four = 4;
        private readonly int[] _round;
        private readonly List<int> _possibleSmallStraight = new List<int>( new []{ 1, 2, 3, 4 });
        private readonly List<int> _possibleSmallStraight2 = new List<int>( new []{ 2, 3, 4, 5 });
        private readonly List<int> _possibleSmallStraight3 = new List<int>( new []{ 3, 4, 5, 6 });

        public SmallStraight(int[] round)
        {
            _round = round;
        }

        public int GetValue()
        {
            return  
                _round.Intersect(_possibleSmallStraight).Count() == Four ||
                _round.Intersect(_possibleSmallStraight2).Count() == Four ||
                _round.Intersect(_possibleSmallStraight3).Count() == Four
                ? 30:0 ;
        }
    }
}