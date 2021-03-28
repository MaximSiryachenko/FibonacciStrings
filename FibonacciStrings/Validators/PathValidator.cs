using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FibonacciStringsMain.Validators
{
    public static class PathValidator
    {
        public static bool PathIsValid(this string s)
        {
            return File.Exists(s);
        }
    }
}
