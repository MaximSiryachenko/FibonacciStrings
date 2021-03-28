using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciStrings.BL.Helpers
{
    public static class TextHelper
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
    }
}
