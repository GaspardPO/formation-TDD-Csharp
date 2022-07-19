using System.Linq;

namespace Yahtzee
{
    public class YahtzeeCombination
    {
        private readonly int[] _round;

        public YahtzeeCombination(int[] round)
        {
            _round = round;
        }
        public int GetValue()
        {
            return _round
                .GroupBy(diceValue => diceValue)
                .Count() == 1
                ? 50
                : 0;
        }
    }
}