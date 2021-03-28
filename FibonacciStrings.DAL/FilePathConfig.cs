using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FibonacciStrings.DAL
{
    public static class FilePathConfig
    {
        public static string GetPathFile()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\DataSet.txt");
        }
    }
}
