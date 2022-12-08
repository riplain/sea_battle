﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
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
}
