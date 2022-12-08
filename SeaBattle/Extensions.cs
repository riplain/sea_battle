﻿namespace SeaBattle
{
    internal static class IntExtensions
    {
        public static bool InRange(this int number, int bottom, int top)
        {
            return number >= bottom && number <= top;
        }

        public static int Length(this int number)
        {
            return (int)Math.Floor(Math.Log10(Math.Abs(number)) + 1);
        }
    }

    internal static class StringExtensions
    {
        public static bool ConsistsOfLetters(this string str)
        {
            return str.ToCharArray().All(x => char.IsLetter(x));
        }

        public static bool ConsistsOfDigits(this string str)
        {
            return str.ToCharArray().All(x => char.IsDigit(x));
        }
    }
}
