using System.Linq;

namespace Tests
{
    public class Combination
    {
        private int[] dices;
        private int value;

        public Combination(int[] dices, int value)
        {
            this.dices = dices;
            this.value = value;
        }

        public int GetValue()
        {
            return dices.Where(i => i == value).Sum();
        }


    }
}