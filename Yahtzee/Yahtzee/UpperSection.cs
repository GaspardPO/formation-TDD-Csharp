using System;
using Tests;

namespace Yahtzee
{
    public sealed class UpperSection
    {
        private readonly Combination _combinaison1;
        private readonly Combination _combinaison2;
        private readonly Combination _combinaison3;
        private readonly Combination _combinaison4;
        private readonly Combination _combinaison5;
        private readonly Combination _combinaison6;

        public UpperSection(Combination combinaison1, Combination combinaison2, Combination combinaison3, Combination combinaison4, Combination combinaison5, Combination combinaison6)
        {
            _combinaison1 = combinaison1;
            _combinaison2 = combinaison2;
            _combinaison3 = combinaison3;
            _combinaison4 = combinaison4;
            _combinaison5 = combinaison5;
            _combinaison6 = combinaison6;
        }

        public int GetTotal()
        {
            return _combinaison1.GetValue() + _combinaison2.GetValue() + _combinaison3.GetValue() + _combinaison4.GetValue()
                + _combinaison5.GetValue() + _combinaison6.GetValue();
        }

        public bool HasABonus()
        {
            return GetTotal() >= 63;
        }
    }
}