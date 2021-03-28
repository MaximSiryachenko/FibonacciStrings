using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciStrings.BL.Extensions
{
    public static class FibonacciExtension
    {
        public static bool IsFibonacci(this int n)
        {
            return (Math.Sqrt(5 * Math.Pow(n, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(n, 2) + 4) % 1 == 0);
        }
    }
}
