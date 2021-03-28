﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciStrings.BL.Helpers
{
    public static class TextHelper
    {
        public static string ReverseLinq(this string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }
    }
}
