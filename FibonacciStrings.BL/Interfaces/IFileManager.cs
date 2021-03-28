using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciStrings.BL.Interfaces
{
    public interface IFileManager
    {
        public string[] ReadFile(string path);
        public void WriteFile(string reverseS);
    }
}
