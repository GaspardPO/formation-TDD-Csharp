﻿using Xunit;
using Yahtzee;

namespace Tests
{
    public sealed class UpperSectionShould
    {
        [Fact]
        public void Return_0_when_all_combinations_have_no_points()
        {
            var sumOfOnesIsZero = new Combination(new[] { 2, 3, 4, 5, 2 }, 1);
            var sumOfTwosIsZero = new Combination(new[] { 1, 3, 4, 5, 1 }, 2);
            var sumOfThreesIsZero = new Combination(new[] { 1, 2, 4, 5, 1 }, 3);
            var sumOfFoursIsZero = new Combination(new[] { 1, 2, 1, 5, 1 }, 4);
            var sumOfFivesIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 5);
            var sumOfSixIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 6);


            var upperSection = new UpperSection(
                sumOfOnesIsZero,
                sumOfTwosIsZero,
                sumOfThreesIsZero,
                sumOfFoursIsZero,
                sumOfFivesIsZero,
                sumOfSixIsZero);

            var actual = upperSection.GetTotal();

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Return_X_when_ones_combination_has_points()
        {
            var sumOfOnesIsTwo = new Combination(new[] { 1, 3, 1, 5, 2 }, 1);
            var sumOfTwosIsZero = new Combination(new[] { 1, 3, 4, 5, 1 }, 2);
            var sumOfThreesIsZero = new Combination(new[] { 1, 2, 4, 5, 1 }, 3);
            var sumOfFoursIsZero = new Combination(new[] { 1, 2, 1, 5, 1 }, 4);
            var sumOfFivesIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 5);
            var sumOfSixIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 6);


            var upperSection = new UpperSection(
                sumOfOnesIsTwo,
                sumOfTwosIsZero,
                sumOfThreesIsZero,
                sumOfFoursIsZero,
                sumOfFivesIsZero,
                sumOfSixIsZero);

            var actual = upperSection.GetTotal();

            Assert.Equal(2, actual);
        }

        [Fact]
        public void Return_X_when_two_combinations_have_points()
        {
            var sumOfOnesIsTwo = new Combination(new[] { 1, 3, 1, 5, 2 }, 1);
            var sumOfTwosIsTwo = new Combination(new[] { 2, 3, 4, 5, 1 }, 2);
            var sumOfThreesIsZero = new Combination(new[] { 1, 2, 4, 5, 1 }, 3);
            var sumOfFoursIsZero = new Combination(new[] { 1, 2, 1, 5, 1 }, 4);
            var sumOfFivesIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 5);
            var sumOfSixIsZero = new Combination(new[] { 1, 2, 4, 1, 1 }, 6);


            var upperSection = new UpperSection(
                sumOfOnesIsTwo,
                sumOfTwosIsTwo,
                sumOfThreesIsZero,
                sumOfFoursIsZero,
                sumOfFivesIsZero,
                sumOfSixIsZero);

            var actual = upperSection.GetTotal();

            Assert.Equal(4, actual);
        }

        [Fact]
        public void Return_X_when_all_combinations_have_points()
        {
            var sumOfOnesIsTwo = new Combination(new[] { 1, 3, 1, 5, 2 }, 1);
            var sumOfTwosIsTwo = new Combination(new[] { 2, 3, 4, 5, 1 }, 2);
            var sumOfThreesIsSix = new Combination(new[] { 1, 2, 3, 3, 1 }, 3);
            var sumOfFoursIsFour = new Combination(new[] { 1, 2, 1, 4, 1 }, 4);
            var sumOfFivesIsFive = new Combination(new[] { 1, 2, 4, 1, 5 }, 5);
            var sumOfSixIsSix = new Combination(new[] { 6, 2, 4, 1, 1 }, 6);

            var upperSection = new UpperSection(
                sumOfOnesIsTwo,
                sumOfTwosIsTwo,
                sumOfThreesIsSix,
                sumOfFoursIsFour,
                sumOfFivesIsFive,
                sumOfSixIsSix);

            var actual = upperSection.GetTotal();

            Assert.Equal(25, actual);
        }

        [Fact]
        public void Has_no_bonus_when_score_is_lower_than_63()
        {
            var sumOfOnesIsTwo = new Combination(new[] { 1, 1, 2, 5, 2 }, 1);
            var sumOfTwosIsSix = new Combination(new[] { 2, 2, 2, 5, 1 }, 2);
            var sumOfThreesIsNine = new Combination(new[] { 3, 2, 3, 3, 1 }, 3);
            var sumOfFoursIsTwelve = new Combination(new[] { 4, 4, 1, 4, 1 }, 4);
            var sumOfFivesIsFifteen = new Combination(new[] { 5, 5, 4, 1, 5 }, 5);
            var sumOfSixIsEighteen = new Combination(new[] { 6, 6, 6, 1, 1 }, 6);

            var upperSectionWithTotalOf62 = new UpperSection(
                sumOfOnesIsTwo,
                sumOfTwosIsSix,
                sumOfThreesIsNine,
                sumOfFoursIsTwelve,
                sumOfFivesIsFifteen,
                sumOfSixIsEighteen
                );

            Assert.False(upperSectionWithTotalOf62.HasABonus());
        }

        [Fact]
        public void Has_a_bonus_when_score_is_higher_or_equal_than_63()
        {
            var sumOfOnesIsThree = new Combination(new[] { 1, 1, 1, 5, 2 }, 1);
            var sumOfTwosIsSix = new Combination(new[] { 2, 2, 2, 5, 1 }, 2);
            var sumOfThreesIsNine = new Combination(new[] { 3, 2, 3, 3, 1 }, 3);
            var sumOfFoursIsTwelve = new Combination(new[] { 4, 4, 1, 4, 1 }, 4);
            var sumOfFivesIsFifteen = new Combination(new[] { 5, 5, 4, 1, 5 }, 5);
            var sumOfSixIsEighteen = new Combination(new[] { 6, 6, 6, 1, 1 }, 6);

            var upperSectionWithTotalOf63 = new UpperSection(
                sumOfOnesIsThree,
                sumOfTwosIsSix,
                sumOfThreesIsNine,
                sumOfFoursIsTwelve,
                sumOfFivesIsFifteen,
                sumOfSixIsEighteen
                );

            Assert.True(upperSectionWithTotalOf63.HasABonus());
        }
        
        
        [Fact]
        public void Return_total_of_upper_section_with_bonus()
        {
            var sumOfOnesIsThree = new Combination(new[] { 1, 1, 1, 5, 2 }, 1);
            var sumOfTwosIsSix = new Combination(new[] { 2, 2, 2, 5, 1 }, 2);
            var sumOfThreesIsNine = new Combination(new[] { 3, 2, 3, 3, 1 }, 3);
            var sumOfFoursIsTwelve = new Combination(new[] { 4, 4, 1, 4, 1 }, 4);
            var sumOfFivesIsFifteen = new Combination(new[] { 5, 5, 4, 1, 5 }, 5);
            var sumOfSixIsEighteen = new Combination(new[] { 6, 6, 6, 1, 1 }, 6);

            var upperSectionWithTotalOf63 = new UpperSection(
                sumOfOnesIsThree,
                sumOfTwosIsSix,
                sumOfThreesIsNine,
                sumOfFoursIsTwelve,
                sumOfFivesIsFifteen,
                sumOfSixIsEighteen
            );

            Assert.Equal(63 + 35,upperSectionWithTotalOf63.GetTotalOfUpperSection());
        }

        [Fact]
        public void Return_total_of_upper_section_without_bonus()
        {
            var sumOfOnesIsTwo = new Combination(new[] { 1, 3, 1, 5, 2 }, 1);
            var sumOfTwosIsTwo = new Combination(new[] { 2, 3, 4, 5, 1 }, 2);
            var sumOfThreesIsSix = new Combination(new[] { 1, 2, 3, 3, 1 }, 3);
            var sumOfFoursIsFour = new Combination(new[] { 1, 2, 1, 4, 1 }, 4);
            var sumOfFivesIsFive = new Combination(new[] { 1, 2, 4, 1, 5 }, 5);
            var sumOfSixIsSix = new Combination(new[] { 6, 2, 4, 1, 1 }, 6);

            var upperSectionWithTotalOf25 = new UpperSection(
                sumOfOnesIsTwo,
                sumOfTwosIsTwo,
                sumOfThreesIsSix,
                sumOfFoursIsFour,
                sumOfFivesIsFive,
                sumOfSixIsSix
            );

            Assert.Equal(25 ,upperSectionWithTotalOf25.GetTotalOfUpperSection());
        }

    }
}
