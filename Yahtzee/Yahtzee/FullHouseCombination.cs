using System.Linq;

namespace Yahtzee
{
    public class FullHouseCombination
    {
        private int[] round;

        public FullHouseCombination(int[] round)
        {
            this.round = round;

        }

        public int GetValue()
        {
            var groups = round.ToList()
                            .GroupBy(diceValue => diceValue);
            return
               groups.Any(group => group.Count() == 3)
               &&
               groups.Any(group => group.Count() == 2)
                ? 25
                : 0;
        }
    }
}